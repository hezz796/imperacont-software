---
title: Plano de implementação MVP 1
type: implementation-plan
status: approved-with-conditions
scope: project
version: 1.1
project: imperacont-software
created: 2026-09-22
---

# Plano de Implementação — ImperaCont MVP 1

## 1. Contexto e entradas

Plano da **etapa 1 (Planejamento) do Workflow 05 (Development)**. Transforma o backlog aprovado em unidades incrementais de implementação, respeitando requisitos, arquitetura e critérios de qualidade.

Entradas utilizadas:

- **REQ-001 v1.4** (requisitos do MVP 1);
- **US-001 a US-005** (histórias do usuário);
- **ARC-001 v1.3** (arquitetura aprovada com condições; decisões ADR-001…010, DR-0012, §13/§17/§24);
- **BACKLOG-001** (BL-001…013);
- **dec-004** (decisão arquitetural consolidada);
- **PEN-ARC-003/004/005/010** e **PEN-PB-003** (pendências condicionantes);
- **Revisão independente do reviewer (2026-09-22): APROVADO COM CONDIÇÕES** — 2 achados ALTA e 9 MÉDIA/BAIXA incorporados nesta v1.1 (ver §12).

Decisões-chave já consolidadas que orientam o plano:

- **Stack: C#/.NET — ASP.NET Core + Razor Pages, versão .NET 10 LTS** (ADR-010; DR-0012; EVD-020: LTS atual até 14/11/2028; .NET 8/9 terminam em 10/11/2026 — não iniciar em versão em fim de suporte);
- **Banco: SQLite em modo WAL, centralizado no PC-base** (ADR-002/003), acesso via `Microsoft.Data.Sqlite` + ORM leve/Dapper (não EF pesado no início);
- **Transporte: HTTP em LAN interna própria protegida** (P-ARC-001/EVD-019);
- **Concorrência otimista (transversal a todo módulo de escrita)** (PEN-ARC-010): `version`/`updated_at`, `WHERE version = ?`, `BEGIN IMMEDIATE`, transação curta em lote — aplicável a **todas** as entidades editáveis (Cliente, Lançamento, Pendência, Obrigação-instância, Documento);
- **Monolítico**: aplicação única com módulos C1–C11 (sem microsserviços);
- **Backup**: diário no PC-base (VACUUM INTO/snapshot + anexos atômicos) para alvo independente; validação semanal com restauração de ≥1 anexo (ADR-004, P-ARC-004/008, PEN-ARC-005).

---

## 2. Objetivo do plano

Dividir o trabalho em **incrementos verificáveis**, com ordem orientada a:

1. **Fundação** (esqueleto + segurança base) — sem fundamento não há incremento seguro;
2. **Núcleo** (lançamento/validação/conferência) — dor 1, maior valor;
3. **Apoio** (clientes, usuários, obrigações/prazos, pendências, documentos) — dá contexto ao núcleo;
4. **Operação** (métricas, backup) — sustenta valor e reduz risco de perda.

A ordem segue valor + risco + dependência (BACKLOG-001 §14), conforme ARC-001 C5–C9.

---

## 3. Estrutura de solução proposta (bootstrap)

Estrutura mínima inicial do repositório .NET (a validar na preparação do IN-00):

```
imperacont/
├── ImperaCont.sln
├── src/
│   └── ImperaCont.Web/            # ASP.NET Core + Razor Pages
│       ├── Pages/                 # páginas Razor (módulos)
│       ├── Models/                # entidades (Cliente, Usuario, Lancamento, ...)
│       ├── Data/                  # acesso SQLite (Dapper), migrations/seed iniciais
│       ├── Services/              # C2 núcleo/API de negócio
│       │   ├── Lancamentos/
│       │   ├── Obrigacoes/
│       │   ├── Pendencias/
│       │   ├── Cadastros/
│       │   └── Documentos/
│       ├── Auth/                  # C3 autenticação/autorização/auditoria
│       ├── Backup/                # C11
│       ├── Metrics/               # C10
│       ├── Files/                 # repositório de anexos (C9)
│       └── Program.cs
└── tests/
    └── ImperaCont.Tests/          # testes unitários + integração
```

> Camada de dados isolada (Data/) para permitir evolução a PostgreSQL sem reescrever tudo (TD-001/RSK-ARC-001).

---

## 4. Incrementos de implementação

Cada incremento tem: escopo, artefatos de origem, critérios de saída (testes/verificação) e riscos observados. A implementação deve ser **vertical e mínima** (Workflow 05 etapa 3), sem expansão de escopo.

> **Otimista transversal (PEN-ARC-010):** todo incremento que altera entidade editável aplica `version`/`updated_at` + `WHERE version = ?` + `BEGIN IMMEDIATE` e testa o cenário de conflito (version mismatch → aviso + recarga). Isto vale explicitamente para IN-02/04/05/06/08/10/11.

### IN-00 — Bootstrap da solução

| Campo | Detalhe |
|---|---|
| Escopo | Solução .NET (sln), projeto `ImperaCont.Web` (Razor Pages), `ImperaCont.Tests`; conexão SQLite WAL (`PRAGMA journal_mode=WAL`, `busy_timeout`), camada Data mínima; página home/health-base; CI local básico (`dotnet build`, `dotnet test`) |
| Origem | ARC-001 ADR-001/002/003/010, dec-004 |
| Critérios de saída | `dotnet build` e `dotnet test` verdes; app sobe em `http://localhost:PORT`; teste unitário de exemplo |
| Riscos | Versão do SDK/ambiente do dev (verificar .NET instalado) — **usar .NET 10 LTS (EVD-020)**; WAL requer permissão de escrita no diretório |

### IN-01 — Autenticação, autorização, auditoria e seed inicial (BL-013, C3, UC-005)

| Campo | Detalhe |
|---|---|
| Escopo | Login usuário/senha com hash (lib madura), sessão cookie HttpOnly+SameSite (sem `Secure` — HTTP em LAN, EVD-019), perfis: auxiliar / contador / atendimento / sócio-gestor; matriz de permissão UC-005; trilha de auditoria append-only das ações críticas **incluindo estação origem** (ACH-07); política de lockout/timeout (P-ARC-005); CSRF (P-ARC-006). **Seed inicial do usuário contador titular** com troca de senha obrigatória no primeiro login (ACH-01) |
| Origem | REQ-001 RF-002/RNF-003/RNF-004; US-002/003; ARC-001 ADR-005, §13, UC-005; BACKLOG-001 BL-013 |
| Critérios de saída | Login/rejeição testados (unit + integração); sessão com HttpOnly/SameSite; teste de autorização por perfil (rota negada); auditoria grava ação/autor/data/**estação origem**; proteção CSRF ativa nos forms; **seed do contador inicial validado (primeiro login força troca de senha)** |
| Riscos | Segurança (RGPD) — **primeiro incremento de alto risco e extenso** (ACH-10): manter, mas garantir **revisão de segurança dedicada** ao final e critérios de saída por componente; se ao implementar o incremento ficar grande demais para revisar, dividir em IN-01a (login/hash/perfis/CSRF) + IN-01b (auditoria/lockout) com gate entre elas |

> PRÉ-REQUISITO de todos os demais incrementos (qualquer tela pressupõe identidade/perfil).

### IN-02 — Cadastro de clientes (BL-001, C8, RF-001)

| Campo | Detalhe |
|---|---|
| Escopo | CRUD de clientes (empresas): nome, CNPJ/CPF, regime fiscal, contato; lista com busca; versionamento otimista (version/updated_at); auditoria |
| Origem | REQ-001 RF-001; ARC-001 C8/§11 (entidade Cliente); BACKLOG-001 BL-001 |
| Critérios de saída | CRUD testado; duplicidade de CNPJ tratada; conflito otimista (version mismatch) gera aviso e recarga; auditoria |
| Riscos | Base de dados futura lançamentos/obrigações — validação de exclusão de cliente com vínculos |

### IN-03 — Cadastro de usuários/perfis (BL-002, C8, RF-002)

| Campo | Detalhe |
|---|---|
| Escopo | CRUD de usuários do sistema: nome, credencial, perfil; ativo; redefinição de senha; menor privilégio; auditoria. **Seed já criado em IN-01 permanece a única via de primeiro acesso** (não precisa de usuário autenticado para criar o contador titular) |
| Origem | REQ-001 RF-002; ARC-001 UC-005/§11 (entidade Usuário); BACKLOG-001 BL-002 |
| Critérios de saída | CRUD testado; permissões por perfil aplicadas; usuário não pode escalar próprio privilégio; primeiro acesso via seed validado |

### IN-04 — Lançamento de movimentação com validação (BL-003, C5, UC-001, US-001, RF-003/004)

| Campo | Detalhe |
|---|---|
| Escopo | Nova tela de lançamento: cliente, período (competência), data, valor, natureza (entrada/saída), descrição; validação de obrigatórios (RN-001); **política C de sinalização** (RN-003 duplicidade cliente+data+valor — Q6a; RN-004 data≠período — Q6b): aviso [Corrigir]/[Manter mesmo assim]; persistência ACID uma transação curta; status inicial "pendente de conferência" (RN-005); auditoria; golden cases Q6a/Q6b |
| Origem | REQ-001 RF-003/004, RN-001/003/004/005; US-001 CA-001…; ARC-001 Fluxo 1, C5, §17 (concorrência otimista, BEGIN IMMEDIATE); BACKLOG-001 BL-003; PEN-CONTADOR-001 §10-A (Q6a/Q6b) |
| Critérios de saída | Golden cases de duplicidade e período passam (3+3 casos); "Manter mesmo assim" grava com sinalização identificável; transação curta; auditoria; **smoke de desempenho RNF-001 (listagem <2s em LAN)** |
| Riscos | **Núcleo P0 (dor 1)**; validação incorreta gera erro contábil (RSK-PB-002) — testes de golden cases obrigatórios |

### IN-05 — Conferência em lote pelo contador (BL-004, C5, RF-005, US-001)

| Campo | Detalhe |
|---|---|
| Escopo | Fila de conferência (filtro pendente/sinalizado); o contador marca conferido / corrige / devolve (RN-005); estados "conferido"/"corrigido"/"devolvido"; auditoria; transação curta por item no lote (PEN-ARC-010) |
| Origem | REQ-001 RF-005; US-001 CA; ARC-001 Fluxo 2; BACKLOG-001 BL-004 |
| Critérios de saída | Conferência em lote com transação curta; estados corretos; auditoria por ação; **início dos testes de concorrência 2 sessões (PEN-ARC-004)** |

### IN-06 — Edição/exclusão de lançamentos com política (BL-010, RF-012)

| Campo | Detalhe |
|---|---|
| Escopo | **(a) Edição de lançamento não-conferido** — depende apenas de IN-04, permite corrigir erro antes da conferência (ACH-06); **(b) Edição/cancelamento de lançamento conferido** — depende de IN-05, **reabre conferência**; cancelamento com **motivo obrigatório**; **exclusão lógica universal (soft-state/cancelado), inclusive para não-conferido** (P-ARC-007/ACH-09); sem exclusão física; auditoria preserva snapshot |
| Origem | REQ-001 RF-012; RESUMO-001 C1-C3; ARC-001 Fluxo 2, P-ARC-007; BACKLOG-001 BL-010 |
| Critérios de saída | Regra de reabertura/cancelamento com motivo testada; exclusão lógica aplicada (sem exclusão física); conflito otimista de edição testado; auditoria |

### IN-07 — Catálogo e instâncias de obrigações (BL-005, C6, RF-006, US-003)

| Campo | Detalhe |
|---|---|
| Escopo | Catálogo configurável (Q8): DAS mensal (~dia 20), DCTF Web mensal (~dia 25), IRPJ/CSLL trimestrais, PIS/COFINS mensais (~dia 25); **seed inicial do catálogo Q8 com mapeamento padrão por regime** (ACH-01); padrão por regime ao cadastrar cliente (B5); ajuste por cliente; instância por cliente/competência; sem cálculo automático |
| Origem | REQ-001 RF-006/RN-006; US-003; ARC-001 Fluxo 3, C6; BACKLOG-001 BL-005; PEN-CONTADOR-001 §10-A (Q8) |
| Critérios de saída | Catálogo e instância por cliente criados; **padrão por regime aplicado a partir do seed**; ajuste por cliente funcional; exceção → pendência manual (obrigação sem vencimento) |

### IN-08 — Status automático de prazos + alertas (BL-006, C6, RF-007, US-003)

| Campo | Detalhe |
|---|---|
| Escopo | Cálculo de status (RN-006): em dia / a vencer / atrasado / **entregue**; parâmetro de alerta (padrão 7 dias); registro de entrega (data+autor obrigatórios; anexo opcional — B4); golden cases Q12; pendência manual para obrigação sem vencimento (exceção); **otimista em atualização de status/entrega** (ACH-04) |
| Origem | REQ-001 RF-007, RN-006; US-003; ARC-001 Fluxo 3; BACKLOG-001 BL-006; PEN-CONTADOR-001 §10-A (Q12) |
| Critérios de saída | 4 golden cases de status passam; entrega altera status com auditoria; alerta com parâmetro; conflito otimista de entrega testado |

### IN-09 — Visão de pendências por cliente (BL-007, C7, RF-008, US-002/US-004)

| Campo | Detalhe |
|---|---|
| Escopo | Visão agregada por cliente: pendências manuais + derivadas (atrasos/obrigações em aberto); filtros (cliente, status, período); ordenação; registro de cobrança (data, canal, resultado — CA-002 US-004). **Depende de IN-10 (pendências manuais) para lista ponta a ponta testável** (ACH-03) |
| Origem | REQ-001 RF-008; US-002/US-004; ARC-001 Fluxo 4; BACKLOG-001 BL-007 |
| Critérios de saída | Lista agregada correta (manual+derivada) **com CRUD de IN-10 já disponível**; filtros funcionam; registro de cobrança atualiza pendência; checklist básico de acessibilidade RNF-010 (labels, contraste, teclado) |

### IN-10 — Pendências manuais (BL-008, C7, RF-009, US-002/US-004)

| Campo | Detalhe |
|---|---|
| Escopo | CRUD de pendências: descrição, cliente, status (aberta/em andamento/resolvida — RN-007), responsável, autor/data; marca resolvida sai da lista com auditoria; **otimista em atualização de status** (ACH-04). **Executado ANTES de IN-09** para a visão ser agregada (ACH-03) |
| Origem | REQ-001 RF-009, RN-007; US-004; ARC-001 Fluxo 4; BACKLOG-001 BL-008 |
| Critérios de saída | CRUD testado; status/alteração registrados; conflito otimista testado |

### IN-11 — Registro mínimo de documentos (BL-009, C9, RF-010, US-005, UC-004)

| Campo | Detalhe |
|---|---|
| Escopo | Registro de documento na chegada: descrição e/ou arquivo, situação (recebido/pendente — RN-008); vínculo opcional a cliente/pendência/obrigação; criação de pendência a partir do documento (CA-002); armazenamento de anexo em pasta controlada. **Segurança de upload (ACH-02): limite de tamanho e extensões permitidas, nomes sanitizados/gerados pelo servidor, prevenção de path traversal, verificação de tipo real do conteúdo, ACL de leitura por perfil (RNF-004)**; gravação atômica (write-temp + rename — P-ARC-004); **otimista na situação do documento** (ACH-04); auditoria |
| Origem | REQ-001 RF-010, RN-008; US-005; ARC-001 Fluxo 5, C9, §13/§17 (anexos); BACKLOG-001 BL-009 |
| Critérios de saída | Registro/vínculo/situação testados; anexo gravado atômicamente (sem truncamento); **testes de segurança de upload (tamanho, tipo, nome malicioso, path traversal) e de ACL por perfil**; conflito otimista testado |

> Nota: se o threat model aceito (LAN interna + usuários autenticados) rebaixar a exigência de verificação de conteúdo, registrar explicitamente como decisão (não deixar implícito) (ACH-02).

### IN-12 — Logs para métricas (BL-011, C10, RF-011)

| Campo | Detalhe |
|---|---|
| Escopo | Logs estruturados das ações relevantes (lançamento, conferência, pendência, entrega) para métricas de produto (RF-011); **evento de login/sessão para métrica "usuários únicos ativos/semana" (ACH-07)**; checagem de backup; tabela de eventos |
| Origem | REQ-001 RF-011/RNF-007; ARC-001 C10/§11; BACKLOG-001 BL-011 |
| Critérios de saída | Evento registrado nas ações-chave (lançamento, conferência, pendência, entrega, **login**); consulta de agregação simples funciona |

### IN-13 — Backup automático e plano de recuperação (BL-012, C11, RNF-006)

| Campo | Detalhe |
|---|---|
| Escopo | Job diário: cópia consistente (banco via VACUUM INTO/snapshot + anexos atômicos) para **alvo independente do PC-base** (disco externo/outra máquina); validação semanal com script de restauração (banco + ≥1 anexo); documentação de recuperação; liga/desliga pelo contador titular |
| Origem | REQ-001 RNF-006; ARC-001 Fluxo 6, ADR-004, P-ARC-004/008, PEN-ARC-005; BACKLOG-001 BL-012 |
| Critérios de saída | Backup diário gerado; restauração validada manualmente (procedimento testado); registro de verificação; falha de backup visível |

---

## 5. Sequência e dependências

| Ordem | Incremento | Depende de | Prioridade |
|---|---|---|---|
| 1 | IN-00 Bootstrap | — | — |
| 2 | IN-01 Autenticação/Autorização/Auditoria/Seed (BL-013) | IN-00 | P1 (pré-requisito) |
| 3 | IN-02 Clientes (BL-001) | IN-01 | P1 |
| 4 | IN-03 Usuários (BL-002) | IN-01 | P1 |
| 5 | IN-04 Lançamento + validação (BL-003) | IN-01, IN-02 | **P0** |
| 6 | IN-05 Conferência em lote (BL-004) | IN-04 | **P0** |
| 7 | IN-06a Edição de não-conferido (BL-010) | IN-04 | P1 |
| 8 | IN-06b Edição/Cancelamento de conferido (BL-010) | IN-05 | P1 |
| 9 | IN-07 Obrigações/catálogo (BL-005) | IN-01, IN-02 | **P0** |
| 10 | IN-08 Status de prazos + alertas (BL-006) | IN-07 | **P0** |
| 11 | IN-10 Pendências manuais (BL-008) | IN-01 | P1 |
| 12 | IN-09 Visão de pendências (BL-007) | IN-10, IN-07, IN-08 | **P0** |
| 13 | IN-11 Documentos/anexos (BL-009) | IN-01, IN-10 | P1 |
| 14 | IN-12 Métricas/logs (BL-011) | IN-04/05/08/10 (eventos) | P2 |
| 15 | IN-13 Backup/recuperação (BL-012) | IN-00 | P0/P1 (Arquitetura) |

> IN-13 (backup) pode ser antecipado assim que houver dados minimamente estáveis (após IN-04) por se tratar de proteção contra perda (RSK-ARC-002); o plano oficial o mantém como item de operação, com preparação em paralelo (PEN-ARC-005).

---

## 6. Estratégia de testes por incremento

Em cada incremento (Workflow 05 etapa 4; a estratégia completa é do Workflow 06):

- **Unit:** regras de negócio puras (validações RN-003/004/006, cálculo de status, concorrência otimista) — maior valor por custo;
- **Integração:** camada Data ↔ SQLite, fluxos de serviço (usando banco SQLite de teste em memória/arquivo temporário);
- **Funcional/aceitação:** golden cases (Q6a/Q6b, Q12) e critérios de aceitação das US;
- **Segurança:** em IN-01/IN-02/IN-03/IN-06 (autorização, auditoria, CSRF, exclusão lógica) **e IN-11 (upload/anexos/ACL)** (ACH-02);
- **Concorrência multi-estação (PEN-ARC-004):** a partir de IN-04/IN-05, cenários com 2 sessões simultâneas (simuláveis com dois clientes HTTP na mesma estação em dev); **gate da release** exige teste de concorrência concluído antes da promoção (ACH-05);
- **Desempenho (RNF-001):** smoke de latência de listagem (<2s em LAN) a partir de IN-04 (ACH-08);
- **Acessibilidade (RNF-010):** checklist básico (labels, contraste, teclado) a partir de IN-09 (ACH-08);
- **Regressão:** antes de fechar cada incremento subjacente (Workflow 06).

---

## 7. Riscos observados neste plano

| Risco | Impacto | Mitigação |
|---|---|---|
| Ambiente .NET não instalado/versão diferente | Atraso | IN-00 verifica SDK logo no início (preparação) |
| Segurança de autenticação mal feita (RGPD) | Alto | IN-01 isolado e revisado; lib madura de hash; testes de autorização; revisão de segurança dedicada |
| Seed inicial ausente (sem primeiro contador/catálogo) | Alto | IN-01/IN-07 com seed controlado e troca de senha obrigatória no primeiro login (ACH-01) |
| Upload de anexos inseguro (vetor malicioso/LGPD) | Alto | IN-11: limites, sanitização, path traversal, verificação de conteúdo, ACL por perfil; testes de segurança (ACH-02) |
| Validação contábil incorreta | Alto (erro contábil) | Golden cases Q6a/Q6b/Q12 como testes obrigatórios |
| Concorrência multi-estação | Médio | PEN-ARC-010 transversal + teste 2 sessões PEN-ARC-004 (ACH-04/05) |
| Perda de dados | Alto | IN-13 backup; PEN-ARC-005; alvo independente |
| Escopo expansivo | Médio | Implementação vertical mínima; gate por incremento |

---

## 8. Rastreabilidade

| Incremento | Requisito | Us | Backlog | Componente | Teste-alvo |
|---|---|---|---|---|---|
| IN-01 | RF-002/RNF-003/004 | US-002/003 | BL-013 | C3 | Segurança/funcional |
| IN-02 | RF-001 | — | BL-001 | C8 | Funcional |
| IN-03 | RF-002 | — | BL-002 | C8 | Funcional/segurança |
| IN-04 | RF-003/004 | US-001 | BL-003 | C5 | Golden + funcional |
| IN-05 | RF-005 | US-001 | BL-004 | C5 | Funcional |
| IN-06 | RF-012 | US-001 | BL-010 | C5 | Funcional/segurança |
| IN-07 | RF-006 | US-003 | BL-005 | C6 | Funcional + golden |
| IN-08 | RF-007 | US-003 | BL-006 | C6 | Golden + funcional |
| IN-09 | RF-008 | US-002/004 | BL-007 | C7 | Funcional |
| IN-10 | RF-009 | US-004 | BL-008 | C7 | Funcional |
| IN-11 | RF-010 | US-005 | BL-009 | C9 | Funcional + integração + segurança |
| IN-12 | RF-011/RNF-007 | — | BL-011 | C10 | Logs |
| IN-13 | RNF-006 | — | BL-012 | C11 | Recuperação |

---

## 9. Pendências condicionantes (entrada de implementação)

- **PEN-PB-003** — validação de UX com auxiliares e 1 cliente: **não bloqueia** os incrementos IN-01…IN-06 (backend/fluxos já validados com solicitante); pode ajustar detalhes de UX de IN-09/IN-10 após validação. **Agendamento segue pendente.**
- **PEN-PB-007** — baseline manual de métricas (PEN-001/PB-001 §15): não bloqueia desenvolvimento; registrar medição de valor na release (INF-12).
- **PEN-ARC-003/005** — infra final + backup/recuperação padronizados: **produção** (não bloqueia desenvolvimento; preparação em paralelo p/ IN-13).
- **PEN-ARC-004** — ambiente de homologação com 2 estações para testes de concorrência: previsto em §6; **gate da release** (ACH-05).
- **PEN-ARC-010** — mecanismo otimista: **já especificado** (§17) — aplicar **transversalmente** em IN-02/04/05/06/08/10/11 (ACH-04).

---

## 10. Gate (Planejamento)

**Entrada:** requisitos aprovados, arquitetura aprovada, backlog priorizado, decisões de stack/banco/transporte consolidadas. ✅

**Saída esperada:** plano de implementação com incrementos verificáveis e ordem de execução.

### Veredito: **APROVADO COM CONDIÇÕES**

Condições para execução (incorporadas nesta v1.1):

1. Seed inicial definido (contador titular + catálogo Q8 com padrão por regime) — IN-01/IN-03/IN-07 (ACH-01);
2. Segurança de upload fechada em IN-11 + IN-11 nos testes de segurança (ACH-02);
3. Otimista transversal aplicado em todos os módulos de escrita (ACH-04);
4. PEN-ARC-004/2-estações previsto no teste e como gate da release (ACH-05);
5. PEN-PB-003 não bloqueia IN-01…IN-06; acompanhar para IN-09/IN-10;
6. PEN-ARC-003/005 tratadas antes da release (produção);
7. Cada incremento executa gate próprio (build verde, testes do incremento, revisão quando necessário) antes de avançar.

---

## 11. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação (etapa 1 workflow 05) — incrementos IN-00…IN-13, sequência, testes, riscos, gate | Squad Lead |
| 1.1 | 2026-09-22 | Incorpora revisão independente (APROVADO COM CONDIÇÕES): seed inicial (ACH-01), segurança de upload em IN-11 (ACH-02), reordenação IN-10/IN-09 (ACH-03), otimista transversal (ACH-04), PEN-ARC-004/teste 2 estações (ACH-05), IN-06 dividido em IN-06a/06b (ACH-06), estação origem no log + evento de login (ACH-07), RNF-001/RNF-010 (ACH-08), exclusão lógica universal (ACH-09), nota IN-01 extenso + revisão dedicada (ACH-10), dependência IN-12 (ACH-11), PEN-PB-007 (INF-12) | Squad Lead |

---

## 12. Decisão da revisão independente (resumo)

**Veredito do reviewer (2026-09-22): APROVADO COM CONDIÇÕES.** Plano substancialmente sólido: cobre BL-001…013 e RF-001…012, respeita C1–C11/ADR/PEN-ARC-010, transforma golden cases em critérios de saída verificáveis e trata pendências condicionantes corretamente.

- **Condições obrigatórias (ALTA):** ACH-01 (seed do primeiro usuário/catálogo) e ACH-02 (segurança de upload em IN-11) — incorporadas.
- **Melhorias MÉDIA:** ACH-03 (ordem IN-10/IN-09), ACH-04 (otimista transversal), ACH-05 (PEN-ARC-004/2 estações) — incorporadas.
- **BAIXA:** ACH-06…11 — incorporadas.
- **Informativo:** INF-12 (PEN-PB-007, cobertura implícita) — registrado em §9.

Nenhum achado invalidou a arquitetura; nenhum bloqueia o início da implementação.