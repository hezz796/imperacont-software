---
title: Architecture
description: Arquitetura da solução do MVP 1 do ImperaCont — contexto, domínio, componentes, dados, segurança, operação, decisões técnicas e gate arquitetural.
type: architecture
status: approved-with-conditions
scope: project
version: 1.1
project: imperacont-software
---

> **Nota de governança (Squad Lead):** este artefato foi produzido **pelo Squad Lead** em 2026-09-22 após tentativa de delegação ao `solution-architect` falhar por indisponibilidade do provedor (erro free tier — mesmo padrão registrado em `memoria/aprendizados/apd-002`). Trabalho executado com o máximo de rigor a partir dos artefatos de entrada (REQ-001 v1.3, UX-001 v1.1, PB-001 v1.1, RESUMO-001 v1.2, memória). A **revisão independente do `reviewer` foi realizada em 2026-09-22** (veredito **APROVADO COM CONDIÇÕES**; correções P-ARC-001…012 incorporadas na v1.1 — ver §27). A análise especializada de arquitetura complementar permanece pendente quando a ferramenta estiver disponível.

# Architecture — ARC-001 (MVP 1 ImperaCont)

## 1. Identificação

- **ID:** ARC-001
- **Produto:** ImperaCont (nome provisório) — ferramenta contábil interna
- **Projeto:** imperacont-software
- **Versão:** 1.1
- **Responsável:** Squad Lead (inicial; solução-architect pendente — ver header); confirmação final com solicitante/dev único (PEN-PB-006)
- **Data:** 2026-09-22
- **Status:** Aprovado com condições (revisão independente do reviewer: veredito em §27; correções P-ARC-001…012 incorporadas)

---

## 2. Contexto arquitetural

- **Sistema:** aplicação interna de gestão e validação contábil do escritório (não é sistema de escrituração formal no MVP 1).
- **Ambiente:** **on-premise** — servidor/PC-base no escritório + **rede local**; **2 estações** (PCs/notebooks), **uso simultâneo** (auxiliar lança enquanto contador consulta); dados centralizados no **PC-base**; consumidores acessam via **rede local** (RESUMO-001 D1/D1b/D2).
- **Usuários:** auxiliares (lançam), contador titular (confere + autoridade de domínio + config), atendimento (pendências/documentos), **sócio/gestor somente leitura** (RESUMO-001 E1/E2).
- **Fronteiras:** acesso **interno somente** no MVP; **acesso externo de clientes fora** (portal adiado, uso assistido; DEC-MVP-002, dec-002, RSK-001).
- **Dependências externas:** nenhuma obrigatória (sem nuvem, sem SaaS, sem integração com sistemas fiscais no MVP 1).
- **Capacidade:** dev único com programação básica (EVD-016/017); orçamento limitado; sem prazo rígido.

---

## 3. Problema arquitetural

Como entregar, com baixa complexidade de desenvolvimento e operação, uma aplicação:

1. **acessível de 2 estações simultaneamente** na rede local, com dados centralizados e sem corrupção (RNF-002, dec-002);
2. com **dados contábeis sensíveis protegidos** (autenticação por usuário, autorização por perfil, auditoria — RNF-003/004, LGPD/CRC);
3. **confiável nos alertas e prazos** (RNF-005) e **sem perda de dados** (backup automático + recuperação testada — RNF-006);
4. **simples de manter e evoluir** por 1 programador básico (RNF-008, RNF-009);
5. **sem custo/risco de nuvem** (on-premise), com **observabilidade mínima** para métricas de produto (RNF-007, RF-011).

Restrição transversal: a **stack não foi definida antes** (fica formalmente decidida aqui); a capacidade de dev limita fortemente a complexidade permitida.

---

## 4. Objetivos

- Definir uma arquitetura **monolítica simples** adequada a 2–3 estações em rede local, com banco centralizado no PC-base.
- Garantir que as decisões estruturais atendam aos RNF-001…011 (desempenho baixo volume, multi-estação, segurança, confiabilidade, disponibilidade, observabilidade, manutenibilidade, compatibilidade, acessibilidade).
- Resolver explicitamente a **concorrência de uso simultâneo** (2 estações) com risco controlado (RSK-UX-005).
- Definir **backup automático diário + validação semanal** (RESUMO-001 D3; RNF-006; BL-012) e **plano de recuperação**.
- Separar a arquitetura em **componentes por domínio** (lançamentos, obrigações/prazos, pendências, documentos, cadastros/usuários, auditoria, métricas/backup) sem criar serviços distribuídos sem necessidade.
- Registrar decisões tecnológicas **como consequência** das necessidades, com alternativas e trade-offs (não escolha por preferência).

---

## 5. Requisitos arquiteturalmente relevantes

| ID | Requisito | Impacto arquitetural |
|---|---|---|
| RF-001/002 | Cadastros de clientes e usuários com perfis | Modelo de identidade/autorização; CRUD simples |
| RF-003/004/005 | Lançamento unitário + validação na confirmação + conferência em lote (devolvido/corrigido) | Transações ACID; regras de validação perto do dado; modelo de status de lançamento |
| RF-006/007 | Obrigações/prazos: catálogo configurável, padrão por regime, status automático, alerta 7d/entregue (data+autor) | Modelo de dados configurável; cálculo de status por data (RN-006); regras testáveis (golden cases) |
| RF-008/009 | Visão de pendências por cliente + pendências manuais | Agregação por cliente; status com autor/data |
| RF-010 | Documento mínimo (descrição/arquivo, situação) | Armazenamento de anexos local; vínculo opcional |
| RF-011 | Métricas de uso (lançamentos/semana, usuários ativos, conferência por lote, pendências atualizadas) | Logs/auditoria estruturados para agregação |
| RF-012 | Edição/exclusão com política (autor até conferir; contador depois; reabre conferência; cancelamento com motivo) | Auditoria imutável; estados; sem exclusão física do conferido |
| RNF-001 | Desempenho < 2s em rede local, volume baixo | Banco local suficiente; sem cache distribuído |
| RNF-002 | Múltiplos PCs em rede local, sem corrupção | Banco centralizado multiusuário; concorrência tratada |
| RNF-003 | Autenticação, autorização menor privilégio, auditoria | Módulo de autenticação/autorização/auditoria central |
| RNF-004 | Privacidade/LGPD; sigilo CRC | Criptografia em repouso (recomendada); senhas com hash; controle por perfil |
| RNF-005 | Alertas confiáveis (golden cases) | Regras de status isoladas e testáveis; configuração versionada |
| RNF-006 | Disponibilidade + restauração testada | Backup automático diário + procedimento de recuperação documentado/testado |
| RNF-007 | Observabilidade/logs de produto | Trilha de auditoria + métricas derivadas |
| RNF-008 | Configuração sem alterar código | Tabelas de configuração (obrigações, parâmetros de alerta) |
| RNF-009 | Compatibilidade on-premise/rede local; Windows preferência em avaliação (não bloqueio) | Escolha de stack multi-plataforma ou Windows; implantação local |
| RNF-010 | Acessibilidade mínima (WCAG AA essencial) | Front-end com contraste/fonte/labels/navegação por teclado |
| RNF-011 | Escalabilidade não exigida | Evitar arquiteturas distribuídas |

---

## 6. Atributos de qualidade

| Atributo | Necessidade | Critério | Prioridade |
|---|---|---|---|
| Segurança | Acesso por usuário/perfil; auditoria; dados sensíveis | Autenticação por usuário; menor privilégio (UC-005); trilha de auditoria das ações críticas; senhas com hash; criptografia/caminho seguro p/ anexos | Alta |
| Desempenho | Volume baixo; rede local | Operações respondem < 2s (RNF-001) em 2 estações simultâneas | Alta |
| Disponibilidade | Disponível no expediente | Falha sem perda de dados; restauração testada a partir de backup (RNF-006) | Alta |
| Confiabilidade | Alertas e status de prazo corretos | Golden cases aprovados pelo contador antes do dev (RNF-005) | Alta |
| Escalabilidade | Não exigida (RNF-011) | Suportar 2–3 estações; sem desenho distribuído | Baixa |
| Manutenibilidade | Config sem código; dev único | Cadastro de obrigações/parâmetros via interface (RNF-008); código simples e modular | Alta |
| Observabilidade | Logs de uso + diagnóstico | Auditoria/log estruturado p/ métricas (RF-011) e diagnóstico | Média |
| Portabilidade | On-premise; Windows preferência em avaliação | Stack multi-plataforma; instalação simples local (RNF-009) | Média |
| Recuperabilidade | Restauração de dados | Backup automático diário + validação semanal + procedimento de recuperação testado (BL-012) | Alta |
| Custo operacional | Orçamento limitado | Sem nuvem paga; stack aberta; operação local | Alta |

---

## 7. Princípios arquiteturais

1. **Simplicidade sobre sofisticação** (viável por dev único; evita complexidade antecipada).
2. **Tecnologia como consequência** (requisitos/qualidade primeiro, depois stack).
3. **On-premise e dados no escritório** (sem dependência de nuvem no MVP).
4. **Mínimo de integrações** (nenhuma externa no MVP).
5. **Regras de domínio próximas dos dados** (validações e estados de status no núcleo/domínio, testáveis).
6. **Auditoria imutável e rastreável** para ações críticas (lançamento, conferência, edição/exclusão, pendência, entrega).
7. **Configuração dirigida a dados** (obrigações, alertas por interface — RNF-008).
8. **Fronteiras por domínio** mapeadas aos RFs, sem serviços distribuídos sem necessidade.
9. **Reversibilidade/evolução** (componentes com contratos simples para evoluir sem redesenho).
10. **Segurança por padrão** (menor privilégio, senhas com hash, auditoria, proteção de anexos).

---

## 8. Visão da solução

Uma **aplicação monolítica** executando no **PC-base do escritório**, com um **banco de dados relacional local** (persistência central) e **interface acessada pelas 2 estações via rede local**. O núcleo trata os domínios de valor (lançamentos/validação/conferência, obrigações/prazos, pendências, documentos), sobre uma base de cadastros, autenticação/autorização e auditoria.

- Os **dados ficam centralizados** no PC-base; as estações são clientes leves (browser ou app cliente fino), conforme decisão de tecnologia (§17).
- O **backup automático diário** roda no PC-base para dispositivo externo/pasta de rede com **validação semanal** pelo contador (liga/desliga pelo contador titular — P4/PEN-PB-006).
- A **concorrência** é resolvida pelo mecanismo de persistência (transações ACID) + estratégia de "dado obsoleto" (aviso/bloqueio otimista) no cliente (RSK-UX-005, PEN-UX-005).
- As **regras de status de obrigações e alertas** vivem em um módulo isolado, com entradas de parâmetros (alerta em dias — padrão 7) e critérios de aceite (golden cases).
- **Sem integrações externas** no MVP (obrigações são registradas, não enviadas; sem SPED/NF-e/portal).
- **Segurança local**: autenticação por usuário/banco, autorização por perfil (matriz UC-005), auditoria de ações críticas, proteção de anexos.

> Decisão de entrega técnica (desktop puro vs web local vs híbrido) é avaliada em §17–18; premissa em análise é **web local** (browser nas estações + servidor no PC-base), alinhada à multi-estação, mas ainda em avaliação com alternativas.

---

## 9. Contextos e componentes

### Componentes (fronteiras lógicas)

| Componente | Responsabilidade | Entradas | Saídas | Dependências |
|---|---|---|---|---|
| **C1 — Aplicação/Cliente** (interface) | Interação do usuário, validação de formulário, navegação por perfil | Ações do usuário | Requisições de negócio; apresentação | C2 |
| **C2 — Núcleo/API de negócio** | Orquestra casos de uso (UC-001…005), aplica RN, expõe dados | Requisições C1 | Respostas/dados validados | C4, C5, C6, C7, C9 |
| **C3 — Autenticação/Autorização/Auditoria** | Login por usuário/senha, perfil menor privilégio (UC-005), trilha de auditoria (RNF-003) | Credenciais, ações | Sessão/permissão, registros de auditoria | C4 |
| **C4 — Persistência relacional central** | Dados de clientes, usuários, lançamentos, obrigações, pendências, documentos, config, auditoria, métricas | Dados e consultas | Dados consistentes, transações ACID | — |
| **C5 — Domínio Lançamentos/Validação** (UC-001) | Lançar (UNIT), validar na confirmação (RN-001…005), conferência em lote, edição/exclusão (RF-012) | Dados de lançamento | Lançamento validado/status; sinalizações | C4, C3, C8 |
| **C6 — Domínio Obrigações/Prazos** (UC-002) | Catálogo configurável, padrão por regime, instâncias por cliente, status automático (RN-006), alerta, registro de entrega | Dados de obrigação/parâmetros | Status/alertas/entrega | C4, C8 |
| **C7 — Domínio Pendências** (UC-003) | Pendências por cliente, status (RN-007), visão agregada | Dados de pendência | Visão por cliente/status | C4, C8 |
| **C8 — Domínio Cadastros/Configuração** | Clientes, usuários/perfis, catálogo de obrigações, parâmetros de alerta/backup | Dados de cadastro | Cadastros consistentes | C4, C3 |
| **C9 — Domínio Documentos** (UC-004) | Registro mínimo de documentos (título/descrição/arquivo), situação, vínculo opcional | Dados de documento + arquivo | Documento rastreado | C4, C8 |
| **C10 — Métricas/Observabilidade** | Logs estruturados (RF-011), agregações de uso, checagem de backup | Ações do sistema | Métricas de produto; diagnóstico | C3, C4 |
| **C11 — Backup/Recuperação** | Backup automático diário, validação semanal, restauração | Job agendado | Cópia consistente; procedimento de restauração | C4, C8 |

> Fronteiras C5–C9 correspondem aos módulos do backlog (C5→BL-003/004/010; C6→BL-005/006; C7→BL-007/008; C8→BL-001/002; C9→BL-009); C3→BL-013, C10→BL-011, C11→BL-012 (infraestrutura transversal). Não há serviço/microsserviço — arquitetura monolítica (aplicação única com módulos).

---

## 10. Fluxos principais

### Fluxo 1 — Lançar e validar movimento (UC-001/US-001)

1. Usuário autentica (C3) e abre "Novo lançamento" (C1).
2. Seleciona cliente e período; preenche data, valor, natureza, descrição (C1 valida obrigatórios — RN-001).
3. Confirma; C5 aplica validações de **duplicidade** (cliente+data+valor — RN-003) e **período** (data≠período — RN-004) — política **C**: sinalização com [Corrigir] [Manter mesmo assim].
4. C5 decide gravar (OK ou sinalizado) e persiste via C4 com transação ACID.
5. C3 registra auditoria (autor, ação, dados alterados). Status = "pendente de conferência".
6. Fração do resultado exibida; caso mantenha sinalização, fica identificável para conferência (RN-005).

### Fluxo 2 — Conferência em lote (UC-001/US-001, RF-005)

1. Contador abre fila de conferência (filtro pendente/sinalizado).
2. Revisa lote: marca conferido / corrige / devolve (RN-005).
3. C5 atualiza estados ("conferido", "corrigido", "devolvido") com auditoria (C3).
4. Ao editar/cancelar conferido, aplica RF-012 (reabre conferência; cancelamento com motivo, sem exclusão física).

### Fluxo 3 — Obrigações e prazos (UC-002/US-003, RF-006/007)

1. Contador cadastra catálogo de obrigações (configurável; padrão por regime) + parâmetro de alerta (padrão 7 dias) via C8.
2. Ao cadastrar/editar cliente, C8 aplica padrão de obrigações do regime com ajuste por cliente (B5).
3. C6 calcula status por data (em dia / a vencer / atrasado / **entregue** — RN-006).
4. Alerta "a vencer" é gerado conforme parâmetro; obrigação sem vencimento → registra **pendência manual** (exceção).
5. Contador registra entrega (data + autor obrigatórios; anexo opcional — B4) → status "entregue" + auditoria.

### Fluxo 4 — Pendências por cliente (UC-003/US-002/US-004, RF-008/009)

1. Usuário abre visão de pendências por cliente; C7 agrega pendências (manuais) + derivadas (atrasos/obrigações em aberto).
2. Registra/atualiza pendência (status aberta/em andamento/resolvida; autor/data — RN-007).
3. Filtros por cliente/status/período (RF-008).

### Fluxo 5 — Documento mínimo (UC-004/US-005, RF-010)

1. Atendimento/auxiliar/contador (perfil com permissão) registra documento na chegada (re-cadastro F3) com descrição/arquivo + situação (recebido/pendente).
2. Vínculo opcional a pendência/obrigação (RN-008); a partir do documento pode-se criar pendência (CA-002).
3. C9 persiste metadados e arquivo no repositório local de anexos; auditoria registra autor/data.

### Fluxo 6 — Backup e recuperação (RNF-006/BL-012)

1. Job diário no PC-base executa backup consistente (banco + anexos) para dispositivo externo/pasta de rede.
2. Contador **valida semanalmente** (restaura em ambiente de teste ou verifica integridade) — liga/desliga pelo contador titular.
3. Em falha, procedimento documentado de restauração (testado nos ambientes de homologação) reconstrói banco + anexos.

---

## 11. Dados

### 11.1 Principais entidades

| Entidade | Responsabilidade | Dados críticos |
|---|---|---|
| **Cliente** | Empresa atendida (RF-001) | CNPJ (único), razão social, regime tributário, contato, ativo |
| **Usuário** | Identidade interna (RF-002) | nome, credenciais (hash), perfil (auxiliar|contador|atendimento|socio/gestor), ativo |
| **Lançamento** | Movimento unitário (RF-003/004/012) | cliente, data, valor, natureza (débito/crédito), período/competência, descrição, status (pendente|conferido|corrigido|devolvido), sinalizações (duplicidade/período), cancelamento/motivo |
| **Obrigação (catálogo)** | Catálogo configurável por regime (RF-006, RNF-008) | nome, regime padrão, vencimento/recorrência (base), parâmetro de alerta (padrão 7d), ativo |
| **Obrigação (instância por cliente)** | Prazo específico por cliente/competência (RF-006/007) | cliente, catálogo (ou nome livre), data de vencimento, status (em dia|a vencer|atrasado|entregue), entrega (data/autor; anexo opcional), p/ sem vencimento → pendência manual |
| **Pendência** | Pendência manual por cliente (RF-009) | cliente, descrição, responsável, status (aberta|em andamento|resolvida), autor/data |
| **Documento** | Registro mínimo (RF-010) | cliente, descrição, caminho/arquivo, situação (recebido|pendente), vínculo opcional (pendência/obrigação), autor/data |
| **Configuração** | Parâmetros (RNF-008) | alerta padrão, obrigações/regime, parâmetros de backup, liga/desliga backup |
| **Auditoria (trilha)** | Registro imutável (RNF-003/004) | autor, data/hora, ação, entidade/ID, dados antes/depois (JSON) — append-only |
| **Evento de métrica** | Dados de uso (RF-011/RNF-007) | lançamentos/semana, usuários ativos/semana, resultado de conferência por lote, pendências atualizadas |

### 11.2 Ciclo de vida dos dados

- **criação:** lançamento/pendência/obrigação/documento criados com autor e data; auditoria registrada.
- **processamento:** validações e cálculos de status executados no núcleo (C5/C6) com transação ACID.
- **armazenamento:** banco relacional local no PC-base (on-premise); anexos em pasta local com caminho controlado.
- **retenção:** mínimo legal contábil (a confirmar com contador — PEN-PB-002/004); auditoria append-only sem exclusão física de conferido (RF-012).
- **arquivamento:** backup diário (RNF-006) + exportação para dispositivo externo; validação semanal.
- **eliminação:** por regra legal/LGPD (a confirmar) — com trilha; exclusão lógica de conferidos (cancelamento com motivo). **Política de exclusão de lançamento não conferido a definir explicitamente no BL-010 (P-ARC-007):** recomendado **exclusão lógica universal** (mais consistente com auditoria imutável e RF-012); se for física para não-conferido, a auditoria preserva o snapshot JSON (sem referência órfã quebrada).

---

## 12. Integrações

| Sistema/Serviço | Objetivo | Direção | Dados | Dependência | Risco |
|---|---|---|---|---|---|
| (nenhuma no MVP) | — | — | — | — | — |

> **Decisão explícita:** MVP 1 **sem integrações externas** (sem envio de obrigações, sem SPED, sem NF-e, sem importação). A obrigação é registrada (data/status/entrega), não enviada. Evita dependências, custo e risco operacional — alinhado ao escopo (DEC-MVP-002) e ao princípio de simplicidade. A arquitetura mantém mapeadas as fronteiras de futuras integrações (evolução) sem implementá-las.

---

## 13. Segurança

### Identidade e autenticação

- Login local por **usuário + senha** (RF-002, UC-005).
- **Hash de senha obrigatório** (bcrypt/argon2) — nunca em texto claro.
- **Decisão de transporte exigida antes do incremento de autenticação (BL-013/C3):** (a) **HTTP em LAN confiável assumido** — cookie de sessão **sem `Secure`**, com `HttpOnly` + `SameSite`, documento de aceitação de risco e controles compensatórios (ACL do SO, acesso físico, rede interna dedicada); ou (b) **TLS local (self-signed)** com chave distribuída às 2 estações, mantendo `Secure`. **Recomendação p/ este MVP:** opção (a), com controles compensatórios; revisar se houver Wi-Fi aberto/compartilhado (P-ARC-001; PEN-ARC-001/003).
- **Proteção CSRF** obrigatória no front web: token CSRF ou `SameSite=strict/lax` coerente com a decisão acima; validação de origem (P-ARC-006).
- **Política de lockout mínima:** N falhas (ex.: 5) → lockout temporário progressivo com registro em auditoria; timeout de sessão ociosa configurável (P-ARC-005).
- Bloqueio de credenciais inválidas sem bloqueio definitivo de conta (UC-005; lockout temporário acima).

### Autorização

- **Menor privilégio por perfil** conforme matriz UC-005 (auxiliar: lança/documentos; contador: tudo de domínio + config; atendimento: pendências/documentos; **sócio/gestor: somente leitura**).
- Ações críticas exigem perfil específico (conferir = contador; cadastrar cliente/usuário/config backup = contador).
- Negação com mensagem (UC-005 exceção 2); interface oculta/desabilita ações não permitidas (UX-DEC-005).

### Proteção de dados

- Anexos sensíveis em repositório local com **controle de acesso por perfil** (RNF-004).
- Criptografia em repouso a avaliar (recomendado para anexos/backup; a confirmar na implementação) — piso mínimo: permissões de sistema (ACL) e segredos não em texto.
- Dados de clientes (PJ/movimentações) protegidos conforme LGPD/CRC.

### Segredos

- Sem segredos de cloud no MVP. Segredos locais (chave de sessão, salt) em repositório de configuração com permissão restrita, fora do código versionado.

### Auditoria

- Trilha **append-only** para ações críticas: lançamento, conferência, edição/exclusão, pendência, entrega de obrigação, cadastros (RNF-003).
- Campos: autor, data/hora, ação, entidade/ID, dados antes/depois (JSON), estação origem.
- Auditoria de exclusão de conferido = **cancelamento com motivo imutável** (RF-012, RNF-003).
- **Limite declarado (P-ARC-012):** a imutabilidade da trilha é limitada pelo acesso administrativo do contador titular ao SO/banco do PC-base (aceito para ferramenta interna; aplicar hash chaining só se isso se tornar requisito).

### Ameaças relevantes

- Acesso não autorizado a estação/PC-base (mitigação: autenticação local + ACL do SO).
- Interceptação na rede local (risco baixo/médio; mitigação: recomendar TLS local ou restringir acesso físico; rede interna confiável — a confirmar).
- SQL injection/validação (mitigação: queries parametrizadas; validação no núcleo).
- Backup comprometido/perdido (mitigação: backup diário + validação semanal + recuperação testada).
- Perda de dados por corrupção/queda (mitigação: transações ACID; WAL/journal; backup testado).
- Funcionário malicioso/inadvertido com dados sensíveis (mitigação: menor privilégio + auditoria).

---

## 14. Observabilidade

- **Logs:** arquivos de log estruturados (aplicação, banco, backup) com nível configurável; sem serviço central (RNF-007).
- **Métricas de produto (RF-011):** eventos registrados na trilha/eventos (lançamentos/semana, usuários únicos ativos/semana, resultado de conferência por lote, pendências atualizadas) deriváveis da auditoria/eventos — para os indicadores de PB-001 §15.
- **Traces:** não aplicável no MVP (monólito sem serviços).
- **Alertas:** alerta de backup (sucesso/falha) e alerta de vencimento de obrigação (RN-006) — separação explícita entre alerta de negócio e sinal operacional.
- **Indicadores operacionais:** último backup bem-sucedido, tamanho do banco, erros de log, uso por estação.

---

## 15. Resiliência

- **tratamento de falhas:** mensagens claras sem gravação parcial (UC-001 exceção; UX-001 §10).
- **timeouts:** tempo curto de resposta em rede local; se indisponível, mensagem de erro imediata.
- **retries:** mínimos (sem integrações); garantir retry seguro de transações.
- **circuit breakers:** não aplicável (sem serviços externos).
- **recuperação:** procedimento documentado e testado de restauração (RNF-006/BL-012); testes periódicos de recuperação no ambiente de homologação; **o teste semanal valida também a restauração de ao menos 1 anexo**, não apenas o banco (P-ARC-004).
- **degradação controlada:** se o PC-base falhar, as outras estações não acessam dados até recuperação (aceito; mitigado por backup/rapidez de restauração); recomendação de hardware adequado ao PC-base.
- **backup:** automático diário para **alvo independente do PC-base** (disco externo removível ou outra máquina — NÃO pasta no próprio PC-base; P-ARC-008) + **validação semanal pelo contador** (liga/desliga pelo titular) — RESUMO-001 D3, P4.
- **anexos (P-ARC-004):** gravação atômica (write-temp + rename) para evitar arquivos truncados; cópia com retries em horário de baixa atividade; restauração de anexo exercitada na validação semanal.
- **recuperação de dados:** incluir validação de integridade do backup; restauração em diretório de teste antes de produção.

---

## 16. Ambientes

| Ambiente | Objetivo | Características | Restrições |
|---|---|---|---|
| Desenvolvimento | Implementação (dev único) | Máquina local; dados de teste/semear; reproduzível | Sem dados reais de clientes |
| Teste/Homologação | Validação de regras, golden cases, recuperação | Instância com dados de teste; restauração treinada | Simular 2 estações p/ concorrência |
| Produção | Uso real no escritório | PC-base + banco central; 2 estações clientes leves; backup diário + validação semanal | Dados reais; exclusão física de conferido proibida (auditoria) |

---

## 17. Tecnologias

> **Princípio:** tecnologias são **consequência** das necessidades. A stack é definida neste gate (antes, não estava decidida). A escolha considera: capacidade do dev único (programação básica), on-premise, rede local, baixo custo, segurança, maturidade, manutenção. **A confirmação final de stack pelo dev único é pendência controlada (PEN-ARC-001)**, mas as alternativas já são avaliadas para decisão.

| Categoria | Tecnologia/Opção | Justificativa | Alternativas |
|---|---|---|---|
| Arquitetura de entrega | **Aplicação web local (servidor no PC-base + browser nas estações)** | Multi-estação sem instalação por estação; dados centralizados; backup simples; atualização só no servidor; evita banco em arquivo compartilhado (corrupção) | Desktop PDF/Electron + destino central; cliente grosso + servidor de dados |
| Linguagem/plataforma | **Python (Flask ou Django) — recomendado** | Simples p/ dev básico; templates server-side; SQLite integrado; leitura/manutenção; ecossistema maduro; alinhado ao front-end recomendado (P-ARC-011) | Node.js/Express; .NET (C#); PHP |
| Persistência | **SQLite (modo WAL) centralizado no PC-base** | Volume baixo (RNF-001); 2–3 estações; zero admin; transações ACID; arquivo único backupável; maturidade | PostgreSQL (server local); SQL Server Express |
| Concorrência | **WAL + transações curtas + busy timeout + otimista com `version`/`updated_at`** | Uso simultâneo (D1b): leitura durante escrita; escrita serializada; evita corrupção e perda de atualização (RNF-002/RSK-UX-005). Mecanismo concreto (P-ARC-003): entidades editáveis (Lançamento, Pendência, Obrigação-instância, Documento, Cliente) têm `version` ou `updated_at`; escrita usa `WHERE version = ?` checando linhas afetadas; conflito → mensagem "dado obsoleto" + recarga (PEN-UX-005); escritas com `BEGIN IMMEDIATE`; conferência em lote com **transação curta por item** (evita `SQLITE_BUSY` prolongado na outra estação) | Banco servidor (Postgres) |
| Front-end | **Templates server-side (HTML/CSS/JS leve) — recomendado** | Simples, acessível (RNF-010), menos complexidade; sem SPA | React/Vue SPA (mais complexidade) |
| Autenticação | Sessão cookie seguro + hash de senha (lib madura p/ linguagem) | RNF-003/004; simples e conhecida | JWT/token (desnecessário no MVP local) |
| Backup | Script/job local (cópia consistente via VACUUM INTO/snapshot SQLite + anexos) para **disco externo removível/outra máquina (independente do PC-base)** | RNF-006; BL-012; simples e auditable; alvo independente evita perda total da máquina (RSK-ARC-002/P-ARC-008) | Agendador do SO + robocopy/rsync |
| Anexos | Pastas locais no PC-base com caminho controlado e ACL; metadados no banco | RF-010; RNF-004; simples | Blob em banco (mais complexo) |
| Auditoria/métricas | Tabelas especializadas + logs estruturados | RNF-003/007; RF-011 | Serviço externo (desnecessário) |

**Decisões preliminares recomendadas (a confirmar — PEN-ARC-001):**

- **DR-0010 (entrega): web local** (servidor no PC-base + browser) — melhor adequação multi-estação.
   - Se o dev preferir cliente grosso: manter banco central no PC-base (não arquivo compartilhado em rede — risco de corrupção).
- **DR-0011 (persistência): SQLite WAL centralizado** (se 2–3 estações e volume baixo).
   - Se risco de crescimento/concorrência aumentar: migrar p/ PostgreSQL local (ponto de evolução previsto).
- **DR-0012 (linguagem): Python (Flask ou Django)** — recomendado: templates server-side simples, alinhado ao front recomendado; FastAPI fica como opção do dev se preferência explícita (API-first) — sem evidência de preferência do dev (EVD-016/017; ver PEN-ARC-001, P-ARC-011).
   - Alternativas viáveis: Node.js, .NET. **Evidências de preferência do dev não existem** → decisão final deve ser confirmada com o solicitante/dev único (EVD-016/017; ver PEN-ARC-001).

> Importante: o contorno técnico (web local + SQLite WAL) **independe da linguagem**; a escolha da linguagem é a parte negociável final, sem impacto nas fronteiras componentes.

---

## 18. Alternativas consideradas

| Alternativa | Benefícios | Desvantagens | Motivo da decisão |
|---|---|---|---|
| Desktop puro (1 máquina) | Muito simples | Impossibilita uso simultâneo / contador afirmação | **Rejeitada** — contradiz multi-estação (dec-002/RESUMO-001 D1b) |
| Cliente grosso + SQLite em arquivo compartilhado na rede | Simples tecnicamente | Corrupção/contência com arquivo remoto Windows; backup inconsistente | **Rejeitada** — risco concreto de integridade (RNF-002) |
| Cliente grosso + banco servidor local (Postgres/SQL Server) | Robusto, multi-usuário | Instalação/admin banco maior p/ dev básico; mais operação | **Aceita como alternativa** de evolução; MVP usa SQLite WAL (DR-0011) |
| Web local (servidor no PC-base) | Multi-estação; dados centralizados; atualização central; backup simples; browser já existe | Requer servidor sempre ligado (PC-base) no expediente; pequena dependência de rede | **Recomendada** (DR-0010) — melhor trade-off p/ contexto |
| Web na nuvem (SaaS) | Acesso externo; fácil backup | Custo recorrente; dados fora do escritório; risco nuvem (RGPD/sigilo) | **Rejeitada** — decisão on-premise (ctx-002, EVD-018) |
| SPA (React/Vue) no front | Experiência rica | Complexidade e curva p/ dev básico; maior superfície | **Rejeitada para MVP** — templates server-side suficientes (RNF-010, simplicidade) |
| Audit quantidade via ORM completo (SQLAlchemy) | Produtividade; abstração | Complexidade para dev básico; curvas | **A definir na implementação** (recomendado iniciar com ORM leve ou SQL direto; PEN-ARC-001) |

---

## 19. Decisões arquiteturais

| ID | Decisão | Motivo | Consequências | Data |
|---|---|---|---|---|
| ADR-001 | Entrega **web local** (servidor no PC-base + browser nas estações) | Multi-estação com simplicidade; dados centralizados; atualização central; backup consistente (RNF-002/006) | PC-base deve ficar ligado no expediente; estações acessam via rede; atualizações no servidor | 2026-09-22 |
| ADR-002 | **SQLite WAL centralizado** no PC-base (volume baixo; 2–3 estações) | Zero admin; ACID; arquivo único fácil de backup; maturidade | Conclusão: limite de concorrência; evoluir p/ Postgres se necessário | 2026-09-22 |
| ADR-003 | **Concorrência**: WAL + transações curtas + busy timeout + tratamento de dado obsoleto (otimista) | Uso simultâneo sem corrupção; evita perda de atualização (RSK-UX-005) | Necessidade de aviso de "dado obsoleto" na UI (PEN-UX-005) | 2026-09-22 |
| ADR-004 | **Backup automático diário** (consistente) + **validação semanal** pelo contador (liga/desliga pelo titular) | RNF-006; redução de risco de perda; simplificado p/ dev básico | Procedimentos documentados/testados; checagem de integridade | 2026-09-22 |
| ADR-005 | **Autenticação local por usuário/senha + hash + sessão segura + autorização por perfil** (matriz UC-005) + **auditoria append-only** | RNF-003/004; sigilo CRC/LGPD; menor privilégio | Política de lockout a detalhar; auditoria cresce (mantida por retenção legal) | 2026-09-22 |
| ADR-006 | **Sem integrações externas no MVP** (obrigações registradas, não enviadas) | Escopo DEC-MVP-002; simplicidade; custo/risco | Fronteiras de evolução mapeadas para o futuro | 2026-09-22 |
| ADR-007 | **Arquitetura monolítica por domínio** (módulos C5–C11), não serviços | Dev único; baixo volume; simplicidade (evita complexidade antecipada) | Refatorar em serviços só se crescer de fato | 2026-09-22 |
| ADR-008 | **Anexos locais no PC-base** (repositório com ACL) com metadados no banco | RF-010; RNF-004; backup simples | Gerenciar ACL; caminhos relativos | 2026-09-22 |
| ADR-009 | **Alertas e status de obrigação isolados e configuráveis** (parâmetro 7d; estados canônicos RN-006) | RNF-005/008; golden cases testáveis | Configuração versionada; revisão periódica (RSK-PB-008) | 2026-09-22 |
| ADR-010 | **Linguagem:** Python web (FastAPI/Flask) — **recomendada, a confirmar** | Simplicidade p/ dev básico; ecossistema; SQLite | PEN-ARC-001 de confirmação do dev único | 2026-09-22 |

---

## 20. Dívida técnica

| ID | Dívida | Motivo | Impacto | Prioridade | Estratégia |
|---|---|---|---|---|---|
| TD-001 | Migração p/ PostgreSQL se crescer concorrência/volume | SQLite é limite conhecido | Médio (futuro) | Baixa | Mapear camada de dados p/ troca gradual |
| TD-002 | Criptografia em repouso não garantida no MVP inicial | Complexidade de chaves | Médio (RGPD) | Média | Avaliar criptografia de anexos/backup na implementação |
| TD-003 | Testes de concorrência com 2 estações só em homologação | Depende de infra | Médio | Média | Ambiente de homologação com 2 estações simuladas |
| TD-004 | Restauração de backup treinada apenas em teste | Depende de processo | Alto (perda) | Alta | Procedimento documentado + teste periódico |
| TD-005 | Sem migrações de schema automatizadas | Simplicidade inicial | Baixo | Baixa | Adotar migrations simples quando necessário |
| TD-006 | Sessão/política de lockout não detalhada | Pendência de segurança | Médio | Média | Detalhar com security review (PEN-ARC-002) |
| TD-007 | Dependência do dev único | Restrição organizacional | Alto | Alta | Manter código simples; documentação; modularização |

---

## 21. Riscos arquiteturais

| ID | Risco | Probabilidade | Impacto | Mitigação | Contingência |
|---|---|---|---|---|---|
| RSK-ARC-001 | SQLite WAL não suficiente p/ uso simultâneo intenso | Baixa (volume baixo) | Médio | Volume baixo; busy timeout; transações curtas; monitorar | Migrar p/ PostgreSQL local (ADR-002) |
| RSK-ARC-002 | Falha/perda do PC-base (único repositório) | Média | Alto | Backup diário + validação semanal + recuperação testada (RNF-006) | Restaurar backup; plano de contingência de hardware |
| RSK-ARC-003 | Rede local indisponível/instável | Média | Médio | Dependência de rede é aceita; mensagens de erro claras; PC-base estável | Restauração rápida; backup local externo |
| RSK-ARC-004 | Segurança por falta de TLS/proteção de rede | Média | Alto | Restrição de acesso físico; ACL; criptografia de dados/anexos; auditoria | TLS local; isolamento de rede (PEN-ARC-002) |
| RSK-ARC-005 | Regras de domínio incorretas (RSK-PB-002/006) | Alta | Alto | Golden cases antes do dev; regras isoladas e testáveis (ADR-009) | Revisão com contador; correção controlada |
| RSK-ARC-006 | Complexity que exceda capacidade do dev único | Média | Alto | Stack simples (ADR-001…010); escopo curto; backlog incremental | Cortes; simplificação; mais tempo |
| RSK-ARC-007 | Backup inconsistente (arquivos abertos/mid-backup) | Média | Alto | Cópia consistente (VACUUM INTO/snapshot) + validação semanal | Réplica local; teste de restauração |
| RSK-ARC-008 | Configuração de obrigações/alertas desatualizada (RSK-PB-008) | Média | Alto | Configuração versionada; revisão periódica com contador | Golden cases de alerta/status |

---

## 22. Evidências

| ID | Evidência | Fonte | Data | Confiabilidade | Decisão influenciada |
|---|---|---|---|---|---|
| EVD-014 | Sucesso = menos erros/retrabalho + prazos cumpridos | Solicitante | 2026-09-22 | medium | Núcleo do MVP; prioridade RNF-005 |
| EVD-015 | Volume baixo (~30 lanç/mês/cliente) | Solicitante | 2026-09-22 | medium | ADR-002 (SQLite suficiente) |
| EVD-016/017 | Dev único, programação básica, sem prazo rígido | Solicitante | 2026-09-22 | medium | ADR-001, ADR-010 (simplicidade) |
| EVD-018 | On-premise sem bloqueio real | Solicitante | 2026-09-22 | medium | ADR-001, ADR-006 (sem cloud) |
| dec-002 | Acesso multi-estação interno | Decisão solicitante | 2026-09-22 | high | ADR-001, ADR-002, ADR-003 |
| RESUMO-001 D1/D1b/D2/D3 | 2 estações; simultâneo; PC-base + rede; backup diário + validação semanal | Solicitante | 2026-09-22 | medium (provisória) | ADR-001…004 |
| RSK-UX-005/PEN-UX-005 | Concorrência multi-estação | UX-001 | 2026-09-22 | medium | ADR-003 |
| BE-02/03 | Suites do mercado complexas/caras; prazos via módulo | Benchmark | 2026-09-22 | medium | Simplicidade; sem suite |

---

## 23. Memória consultada

| ID | Memória | Influência arquitetural |
|---|---|---|
| ctx-001 | Contexto do produto | Escopo interno; sem multi-tenant |
| ctx-002 | Restrições (orçamento, on-premise, multi-estação, dev básico) | On-premise; simplicidade; PC-base + rede |
| ctx-003 | Resultado-alvo (menos erros + prazos) | RNF-005/006 prioridade |
| dec-001 | Escopo do MVP | Sem escrituração formal/SPED/portal; sem integrações |
| dec-002 | Acesso multi-estação | ADR-001/002/003 |
| dec-003 | Direções provisórias (modelo unitário, políticas, acesso, perfis, métricas) | RN-es, autorização, backup, validação, pilares |
| rsk-001 | Tensão desktop × clientes externos | Acesso externo fora; RSK-ARC-003 mitigado |
| rsk-002 | Escopo amplo × orçamento | Simplicidade; backlog incremental |
| apd-001 | Fonte única precisa de validação | Pendências PEN-PB-002/003; regras a confirmar |
| apd-002 | Subagentes indisponíveis (free tier) | Nota de governança; reviewer |

---

## 24. Memórias candidatas

| Informação | Tipo | Decisão de consolidação | Status | Origem |
|---|---|---|---|---|
| Decisões de arquitetura do MVP (web local + SQLite WAL + monolítica; sem integrações) + SQLite WAL suficiente p/ 2–3 estações + aprendizado técnico "SQLite em arquivo de rede corrompe" | decisão | **Consolidada em `dec-004`** | draft (ativa após confirmação da stack — PEN-ARC-001) | ARC-001 §17/ADR-001/002 |
| Backup = cópia consistente + validação semanal pelo contador | decisão | **Fundida em `dec-004`** (evita fragmentação com dec-003) | draft | ARC-001 §15/ADR-004 |
| Preferência de linguagem do dev não é evidenciada (EVD-016/017) | lacuna | Registrada como lacuna dentro de **PEN-ARC-001** (não é fato) | — | EVD-016/017 |
| Concorrência tratada com WAL + otimista + aviso de dado obsoleto | aprendizado | Aplicada — **especificada com detalhe mecânico obrigatório (P-ARC-003/PEN-ARC-010)**; manter apenas como `draft` em dec-004 até validação em 2 estações (PEN-ARC-004) | draft | ARC-001 §17/ADR-003 |

---

## 25. Rastreabilidade

| Requisito | Componente | Decisão | Risco | Teste | Operação |
|---|---|---|---|---|---|
| RF-001 (cliente) | C8, C4 | ADR-002 | — | Funcional | cadastro/auditoria |
| RF-002 (usuário) | C8, C3 | ADR-005 | RSK-ARC-004 | Funcional + segurança | cadastro/auditoria |
| RF-003/004 (lançar/validar) | C1, C5 | ADR-002 (ACID), RN-es | RSK-ARC-005 | Funcional + golden (PEN-PB-002) | logs |
| RF-005 (conferência) | C5 | ADR-003/005 | RSK-ARC-005 | Funcional | auditoria |
| RF-006/007 (obrigações) | C6 | ADR-009 | RSK-ARC-008 | Golden cases status | calendário/log |
| RF-008/009 (pendências) | C7 | ADR-002 | RSK-ARC-005 | Funcional | visão cliente |
| RF-010 (documento) | C9, C11 | ADR-008, ADR-004 | RSK-ARC-007 | Funcional | ACL/auditoria/backup |
| RF-011 (métricas) | C10 | ADR-005 | — | Validação logs | eventos de uso |
| RF-012 (edição/exclusão) | C5 | ADR-005 | RSK-ARC-005 | Funcional + segurança | auditoria |
| RNF-001 (desempenho) | C2, C4 | ADR-002 | — | Perf em 2 estações | monitor |
| RNF-002 (multi-estação) | C1, C4 | ADR-001/003 | RSK-ARC-001 | Teste 2 estações | rede/backup |
| RNF-003/004 (segurança) | C3 | ADR-005 | RSK-ARC-004 | Segurança | auditoria/ACL |
| RNF-005 (confiabilidade) | C6 | ADR-009 | RSK-ARC-008 | Golden cases | revisão regras |
| RNF-006 (disponibilidade) | C11 | ADR-004 | RSK-ARC-002/007 | Teste recuperação | backup semanal |
| RNF-007 (observabilidade) | C10 | ADR-005 | — | Validação logs | logs estruturados |
| RNF-008 (config) | C8 | ADR-009 | RSK-ARC-008 | Funcional | config versionada |
| RNF-009 (compatibilidade) | C1, C4 | ADR-001, ADR-010 | — | Instalação local | on-premise |
| RNF-010 (acessibilidade) | C1 | ADR-001 | — | Acessibilidade | — |

---

## 26. Pendências

| ID | Pendência | Responsável | Prioridade | Bloqueia implementação |
|---|---|---|---|---|
| PEN-ARC-001 | Confirmar **stack/linguagem** com o dev único (recomendação Python Flask/Django; alternativas Node/.NET) e **decidir transporte** (HTTP em LAN assumido vs TLS self-signed — P-ARC-001 obrigatório antes do incremento de autenticação) | Solicitante/dev | Alta | **Sim** (primeiro incremento; autenticação) |
| PEN-ARC-002 | Revisão de segurança detalhada (lockout/timeout — P-ARC-005, CSRF — P-ARC-006, criptografia em repouso) | security-engineer (quando disponível) | Média | Parcial (RNF-003/004) |
| PEN-ARC-003 | Detalhar **modelo de acesso** final (máquinas, Windows?, como liga/desliga, infraestrutura exata) — RESUMO-001 D provisório; decidir transporte (TLS sim/não) no caminho crítico da autenticação (P-ARC-001) | Solicitante | Alta | **Parcial (produção)** — desenvolvimento pode começar em Dev/Homologação |
| PEN-ARC-004 | Estabelecer **ambiente de homologação com 2 estações** p/ testes de concorrência (inclui validar mecanismo otimista — P-ARC-003) | DevOps/dev | Média | Testes multi-estação |
| PEN-ARC-005 | Padronizar **procedimento de backup/restauração** e treinar teste de recuperação (inclui **anexos**: restauração de ao menos 1 anexo + alvo de backup independente do PC-base — P-ARC-004/P-ARC-008) | dev + contador | Alta | RNF-006 (produção) |
| PEN-ARC-006 | Regras exatas de validação + **golden cases** (Q6/Q12) — carry-over PEN-PB-002 | Contador | Alta | **Sim (módulos de validação/status)** |
| PEN-ARC-007 | Validação de fluxo com auxiliares e 1 cliente — carry-over PEN-PB-003 | UX | Alta | **Sim (fechamento UX/Jornadas)** |
| PEN-ARC-008 | Lista definitiva de obrigações (PEN-PB-004/Q8/Q12) | Contador | Média | Módulo prazos fino |
| PEN-ARC-009 | Baseline de métricas (PEN-PB-007) manual 1–2 semanas | Contador | Média | Métrica de resultado |
| PEN-ARC-010 | **Mecanismo de concorrência otimista** especificado (coluna `version`/`updated_at`; `WHERE version = ?`; `BEGIN IMMEDIATE`; lote com transação curta por item — P-ARC-003 obrigatório) | Dev/Arquitetura | Alta | **Sim (módulos de escrita BL-003…010)** |

> **Liberação de implementação:** a **Arquitetura está definida** e permite iniciar desenvolvimento com pendências controladas — desde que **PEN-ARC-001 (stack)** seja resolvida e os *carry-over* de domínio (PEN-ARC-006/007) sejam liberados em paralelo nos módulos correspondentes. Para **produção**, PEN-ARC-003/005 devem estar fechadas (confirmação de infra + backup/recuperação).

---

## 27. Gate arquitetural

### Checklist

- [x] Requisitos relevantes foram analisados (RFs + RNFs mapeados em §5/§9/§25).
- [x] Atributos de qualidade foram considerados (§6).
- [x] Componentes estão definidos (C1–C11, §9).
- [x] Dados foram considerados (§11).
- [x] Integrações foram analisadas (§12 — nenhuma externa; decisão explícita).
- [x] Segurança foi considerada (§13).
- [x] Observabilidade foi considerada (§14).
- [x] Resiliência foi considerada (§15).
- [x] Riscos foram registrados (§21).
- [x] Alternativas foram avaliadas (§18).
- [x] Decisões foram justificadas (§17–19).
- [x] Dívida técnica foi registrada (§20).
- [x] Rastreabilidade foi estabelecida (§25).
- [x] Memória consultada e candidatas registradas (§23–24).
- [x] Pendências registradas com bloqueio explícito (§26).
- [x] **Revisão independente do reviewer realizada** (2026-09-22): veredito **APROVADO COM CONDIÇÕES** (P-ARC-001 e P-ARC-003 obrigatórios; P-ARC-004…012 recomendações/informativo incorporados abaixo).

### Resultado

- [ ] Aprovada.
- [x] **Aprovada com pendências (validade pelo reviewer).**
- [ ] Requer revisão.
- [ ] Rejeitada.

### Justificativa

A arquitetura contempla o problema arquitetural (multi-estação, segurança, confiabilidade, simplicidade, on-premise) com **solução monolítica web local + SQLite WAL**, decisões tecnológicas justificadas por requisitos/qualidade (não por preferência) e alternativas consideradas.

**Revisão independente do reviewer em 2026-09-22: APROVADO COM CONDIÇÕES.** Condições incorporadas: P-ARC-001 (decisão de transporte TLS/HTTP antes do incremento de autenticação; contradição cookie `Secure` resolvida em §13), P-ARC-003 (mecanismo otimista especificado com `version`/`updated_at`/`BEGIN IMMEDIATE`/transação curta em lote — §17/PEN-ARC-010). Recomendações incorporadas: P-ARC-004 (anexos atômicos + restauração de anexo no teste), P-ARC-005 (lockout/timeout), P-ARC-006 (CSRF/SameSite), P-ARC-007 (política de exclusão do não-conferido), P-ARC-008 (alvo de backup independente), P-ARC-009/010 (rastreabilidade e mapeamento BL completos), P-ARC-011 (Flask/Django recomendado), P-ARC-012 (limite de imutabilidade declarado + correções editoriais).

Pendências críticas que **bloqueiam módulos de implementação**: PEN-ARC-001/010 (stack + transporte + otimista), PEN-ARC-006/007 (golden cases + validação UX — carry-over). **Produção** depende de PEN-ARC-003/005 (infra + backup/recuperação). A definição arquitetural como um todo está **validada**. **Gate arquitetural: APROVADO COM PENDÊNCIAS CONTROLADAS** (não bloqueia planejamento/primeiro incremento desde que PEN-ARC-001 e PEN-ARC-010 sejam resolvidas no bloco correspondente).

---

## 28. Referências

- `projetos/imperacont/product/REQ-001-requirements-mvp.md` v1.3
- `projetos/imperacont/product/UX-001-ux-design.md` v1.1
- `projetos/imperacont/product/PB-001-product-brief.md` v1.1
- `projetos/imperacont/product/RESUMO-001-perguntas-urgentes.md` v1.2
- `projetos/imperacont/product/BACKLOG-001-mvp.md`
- `projetos/imperacont/product/US-001…005-*.md`
- `memoria/decisoes/dec-001…003`, `memoria/contexto/ctx-001…003`, `memoria/riscos/rsk-001/002`, `memoria/aprendizados/apd-001/002`
- `templates/architecture.md`, `workflows/04-architecture.md`, `.opencode/skills/architecture-design`

---

## 29. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação (workflow 04) a partir de REQ-001 v1.3, UX-001 v1.1, PB-001 v1.1, RESUMO-001 v1.2 e memória; produzido pelo Squad Lead após indisponibilidade do solution-architect (apd-002); revisão independente do reviewer pendente (gate) | Squad Lead |
| 1.1 | 2026-09-22 | Incorpora revisão independente do reviewer (APROVADO COM CONDIÇÕES): P-ARC-001 (transporte TLS/HTTP decisão obrigatória pré-autenticação), P-ARC-003 (mecanismo otimista especificado), P-ARC-004 (anexos + restauração no teste), P-ARC-005 (lockout/sessão), P-ARC-006 (CSRF/SameSite), P-ARC-007 (política de exclusão do não-conferido), P-ARC-008 (alvo de backup independente), P-ARC-009/010 (rastreabilidade/mapeamento BL), P-ARC-011 (Flask/Django recomendado), P-ARC-012 (editorial + limite de imutabilidade); novas pendências PEN-ARC-010; gate APROVADO COM PENDÊNCIAS CONTROLADAS | Squad Lead + reviewer |