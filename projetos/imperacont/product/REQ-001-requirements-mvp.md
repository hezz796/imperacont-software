---
title: Requirements
description: Especificação de requisitos funcionais, não funcionais, regras de negócio, casos de uso e critérios de aceitação do MVP 1 do ImperaCont.
type: requirements
status: reviewed
scope: project
version: 1.4
project: imperacont-software
---

# Requirements — REQ-001 (MVP 1 ImperaCont)

> **Nota de governança (Squad Lead):** esta especificação foi produzida **pelo Squad Lead** em 2026-09-22 após duas tentativas de delegação ao `business-analyst` falharem por indisponibilidade do provedor (erro de free tier). O trabalho foi executado com o máximo de rigor a partir dos artefatos de entrada, e a **revisão independente foi encaminhada ao `reviewer`** (ver §20.2). Golden cases e catálogo de obrigações foram **confirmados pelo solicitante** em 2026-09-22 (PEN-CONTADOR-001 §10-A); a validação externa (PEN-PB-003) permanece obrigatória.

## 1. Identificação

- **ID:** REQ-001
- **Produto:** ImperaCont (nome provisório) — ferramenta contábil interna
- **Projeto:** imperacont-software
- **Versão:** 1.4
- **Responsável:** Squad Lead (definição inicial); contador titular (autoridade de domínio)
- **Data:** 2026-09-22
- **Status:** Revisado e complementado (revisões independentes v1.1/v1.2/v1.3 + golden cases/catálogo confirmados na v1.4)

---

## 2. Contexto

Escritório contábil pequeno (<50 clientes, Brasil, regimes federais) que opera de forma manual/desestruturada (documentos via WhatsApp/Telegram, lançamentos sem validação). O produto é uma ferramenta interna de **gestão e validação** — não um sistema de escrituração contábil formal no MVP 1.

### Referência ao Product Brief

- documento: PB-001 — Product Brief ImperaCont
- versão: 1.1 (revisado, correções P1–P11 incorporadas)
- localização: `projetos/imperacont/product/PB-001-product-brief.md`

---

## 3. Objetivo

Especificar, para o MVP 1, os requisitos funcionais, não funcionais, regras de negócio, casos de uso e critérios de aceitação capazes de orientar UX/Design, Arquitetura e Desenvolvimento, preservando:

- o núcleo de valor (validação + prazos + pendências);
- a restrição de capacidade (dev único, programação básica, on-premise);
- a decisão de acesso interno multi-estação (dec-002);
- a separação entre o que é decidido e o que depende do contador titular (PEN-PB-002/003/004).

---

## 4. Usuários envolvidos

| Usuário | Necessidade | Requisito relacionado |
|---|---|---|
| Auxiliar/estagiário | Lançar movimentações com rapidez e segurança, recebendo sinalização de inconsistência | RF-003, RF-004, RF-005 |
| Contador titular | Conferir/validar lançamentos, acompanhar prazos e pendências por cliente | RF-002, RF-004, RF-006, RF-008 |
| Sócio/gestor | Visão de capacidade e pendências do escritório | RF-008 |
| Atendimento/administrativo | Identificar clientes com pendência e registrar cobrança/status | RF-008, RF-009, RF-010 |
| (não usuário no MVP) Clientes do escritório | Enviar documentos e acompanhar — via uso assistido pelo escritório | Fora do escopo (DEC-MVP-002) |

---

## 5. Requisitos funcionais

| ID | Requisito | Justificativa | Prioridade | Fonte | Status |
|---|---|---|---|---|---|
| RF-001 | Cadastrar e manter clientes (empresas) com dados básicos (razão social, CNPJ, regime tributário, contato) | Base para pendências, prazos e lançamentos | Alta | PB-001 §11.1, EVD-014 | Draft |
| RF-002 | Cadastrar e manter usuários internos do escritório com perfil de acesso (auxiliar, contador, sócio/gestor, atendimento) | Acesso multi-estação exige identidade por usuário e autorização por perfil (RSK-PB-007); matriz perfil→ação provisória em UC-005 (RESUMO-001 E2) | Alta | PB-001 §5, dec-002, RSK-PB-007, RESUMO-001 E2 | Draft — direção provisória |
| RF-003 | Lançar movimentações financeiras de um cliente (data, valor, natureza/débito-crédito, período, descrição) — **modelo unitário** (uma linha por movimento), confirmado (RESUMO-001 A1; golden cases Q6 no PEN-CONTADOR-001 §10-A; validação externa pendente) | Dor 1: erros por ausência de validação | Alta | PB-001 §11.1, EVD-014, RESUMO-001 A1 | Draft — confirmado |
| RF-004 | Validar lançamentos **no momento da confirmação** conforme política por tipo de inconsistência: duplicidade e período = **C (confirmar antes de gravar** — avisa, pergunta; "manter mesmo assim" grava sinalizado p/ conferência); balanceamento = N/A (modelo unitário) — confirmado (RESUMO-001 A2; golden cases Q6a/Q6b) | Dor 1: retrabalho; conserta a ênfase em "sinalizar" (RSK-PB-002) | Alta | PB-001 §11.1, BE-01, HYP-005, RESUMO-001 A2 | Draft — confirmado |
| RF-005 | Registrar resultado da conferência/validação pelo contador (status do lançamento: pendente de conferência, conferido, corrigido, **devolvido**) — conferência em **lote** (revisa → marca conferido → corrige/devolve) — direção provisória (RESUMO-001 A5) | Responsabilidade técnica do contador (RSK-PB-002, RSK-006 no brief) | Alta | PB-001 §5, RSK-PB-006, RESUMO-001 A5 | Draft — direção provisória |
| RF-006 | Controlar prazos/obrigações por cliente (cadastrar obrigação, data de vencimento, status, responsável). Modelo: **catálogo configurável de obrigações, padrão por regime** aplicado ao cadastrar cliente com ajuste por cliente; **responsável típico por entrega = contador titular**; **lista inicial confirmada: DAS, DCTF Web, IRPJ, CSLL, PIS, COFINS** (PEN-CONTADOR-001 §10-A/Q8) | Dor 5: risco de perder prazos | Alta | PB-001 §11.1, EVD-014, BE-03, RESUMO-001 B1/B5, PEN-CONTADOR-001 Q8 | Draft — confirmado |
| RF-007 | Gerar/atualizar status do prazo automaticamente (em dia, a vencer, atrasado, **entregue**) com registro de entrega (**data + autor obrigatórios; anexo opcional**) e alertar vencimento próximo (**padrão 7 dias antes**, configurável) — RESUMO-001 B2/B4; **golden cases Q12 confirmados** (PEN-CONTADOR-001 §10-A) | Dor 5; confiabilidade dos alertas (RSK-PB-008) | Alta | PB-001 §11.1, RSK-PB-008; RN-006; RESUMO-001 B2/B4 | Draft — confirmado |
| RF-008 | Exibir visão de pendências por cliente (listagem de clientes com pendências registradas, atrasos, obrigações em aberto) | Dor 6: falta de visão por cliente | Alta | PB-001 §11.1, EVD-014 | Draft |
| RF-009 | Registrar pendências manuais por cliente (descrição, responsável, status, data) e atualizar status | Dor 6; apoio à cobrança pelo atendimento | Alta | PB-001 §11.1, §5.2 | Draft |
| RF-010 | Registrar documento por cliente em forma mínima (descrição/arquivo anexo, ligado a pendência ou obrigação) indicando situação (recebido/pendente) — **re-cadastro no recebimento: quem recebe (atendimento/auxiliar/contador) cadastra na chegada** (RESUMO-001 F3) | Dor 2/6 em forma mínima (desvio justificado da PEN-001); aceitação do re-cadastro manual | Média | PB-001 §11.1, PEN-001-priorizacao, RESUMO-001 F3 | Draft — direção provisória |
| RF-011 | Registrar dados de uso para métricas (lançamentos por semana, usuários únicos ativos por semana, resultado da conferência por lote, pendências atualizadas) | Viabiliza métricas §15 do PB-001 (adoção, erros, prazos, visibilidade) | Média | PB-001 §15 | Draft |
| RF-012 | Permitir edição e exclusão de lançamentos conforme **política provisória (RESUMO-001 C1–C3):** autor edita/corre até a conferência; após conferido, somente contador edita; edição de lançamento conferido **reabre a conferência**; exclusão de conferido = **cancelamento com motivo, só contador** (trilha preservada, sem exclusão física do conferido) | Risco contábil real (RNF-003 audita exclusão; correção flagrada em US-001); política antes a confirmar com contador — direção provisória do solicitante | Alta | RSK-PB-002, RNF-003, RESUMO-001 C1–C3 | Draft — direção provisória |

---

## 6. Requisitos não funcionais

| ID | Categoria | Requisito | Critério mensurável | Prioridade |
|---|---|---|---|---|
| RNF-001 | Desempenho | Resposta fluida para volume baixo (até ~30 lançamentos/mês/cliente, <50 clientes) | Operações de lançamento/consulta respondem em < 2s em rede local | Alta |
| RNF-002 | Dispositivo/Estação | Acessível a partir de múltiplos PCs/notebooks do escritório (rede local) | 2 estações acessam e alteram dados sem corrupção; modelo de implementação a definir na Arquitetura (PEN-PB-006) | Alta |
| RNF-003 | Segurança | Autenticação por usuário e autorização por perfil (menor privilégio); trilha de auditoria das ações críticas (lançamento, conferência, edição/exclusão, pendência) | Usuário sem perfil não executa ação proibida; auditoria registra autor, data, ação e dados alterados | Alta |
| RNF-004 | Privacidade/LGPD | Dados de clientes protegidos; sigilo profissional contábil (CRC); retenção controlada | Trilha de auditoria verificada; acesso por perfil: dados sensíveis acessíveis somente por usuários autorizados (teste de segurança) | Alta |
| RNF-005 | Confiabilidade | Alertas de prazos confiáveis (não gerar alerta incorreto que induza a multa) | Regras de status validáveis com casos de teste ("golden cases") aprovados pelo contador antes do dev | Alta |
| RNF-006 | Disponibilidade | Sistema operante durante o expediente; falha sem perda de dados | Restauração testada a partir de backup (cenário de perda); plano de recuperação (RSK-009) | Alta |
| RNF-007 | Observabilidade | Logs de uso e auditoria para métricas de produto e diagnóstico | Logs registram lançamentos, conferências, alertas e pendências com autor e data | Média |
| RNF-008 | Manutenibilidade | Configuração de obrigações/regras possíveis sem alterar código (simples) | Cadastro de obrigações e de parâmetros de alerta via interface administrativa | Média |
| RNF-009 | Compatibilidade | Compatível com a restrição on-premise e com rede local multi-estação (modelo de implementação em aberto para a Arquitetura; o Windows é preferência declarada em avaliação — EVD-009 — não bloqueio) | Executa em instalação on-premise na rede local; não depende de nuvem externa para dados | Alta |
| RNF-010 | Acessibilidade | Uso mínimo acessível (leitura, contraste, tamanho de fonte) | Atende a padrão básico de acessibilidade (ex.: WCAG AA funcional essencial) | Baixa |
| RNF-011 | Escalabilidade | Não exigida para MVP (volume baixo, uso interno) | — | Baixa |

---

## 7. Regras de negócio

> Regras marcadas com **"A CONFIRMAR (PEN-PB-002)"** dependem de validação pelo contador titular (autoridade de domínio). Não são regras inventadas pela squad.

| ID | Regra | Condição | Resultado | Fonte |
|---|---|---|---|---|
| RN-001 | Obrigatoriedade de campos mínimos no lançamento | Lançamento sem cliente, data, valor ou natureza (débito/crédito) | Sinalizar inconsistência e **impedir gravação** enquanto obrigatório ausente — **exceção consensual de bloqueio** (independe de domínio contábil) | PB-001 §11.1; consenso (PEN-REQ-001) |
| RN-002 | Desbalanceamento débito/crédito (aplicável **somente se** o modelo do lançamento for agrupado) | Total de débitos ≠ total de créditos (apenas lançamento agrupado) | **Não se aplica no MVP — modelo unitário confirmado como direção provisória** (RESUMO-001 A1/A2b). Se agrupado no futuro: bloquear | PB-001 §11.1; RESUMO-001 A1/A2b (direção provisória; validação externa pendente) |
| RN-003 | Duplicidade | Lançamento com **mesmo cliente + mesma data + mesmo valor** já registrado — definição **confirmada** (RESUMO-001 A3; golden cases Q6a no PEN-CONTADOR-001 §10-A) | **Política C — confirmar antes de gravar**: avisa "Já existe lançamento parecido"; [Corrigir] [Manter mesmo assim]; manter grava sinalizado p/ conferência (RN-005) | RESUMO-001 A2a/A3 + golden cases Q6a (confirmados) |
| RN-004 | Período/data incorreto | **Data do lançamento ≠ período selecionado** — definição **confirmada** (RESUMO-001 A4; golden cases Q6b no PEN-CONTADOR-001 §10-A) | **Política C — confirmar antes de gravar**: avisa; usuário corrige ou mantém sinalizado | RESUMO-001 A2c/A4 + golden cases Q6b (confirmados) |
| RN-005 | Conferência pelo contador | Lançamento sinalizado como inconsistente | Exigir conferência do contador antes de status "conferido"; conferência em **lote** (revisa → marca conferido → corrige/devolve) — direção provisória (RESUMO-001 A5) | RSK-PB-002; RESUMO-001 A5 |
| RN-006 | Status de obrigação | Data de vencimento da obrigação | **Modelo canônico de estados:** em dia (antes do vencimento), a vencer (**padrão 7 dias antes, configurável** — RESUMO-001 B2), atrasado (após vencimento não entregue), **entregue** (registro manual: **data + autor; anexo opcional** — RESUMO-001 B4). Obrigação **sem vencimento** não gera status automático e vira **pendência manual**. Única fonte de verdade — referenciar nas user stories. **Golden cases Q12 confirmados** (PEN-CONTADOR-001 §10-A): hoje 10/06→vence 20/06 = em dia; 15/06→20/06 = a vencer; 21/06 vencida sem entrega = atrasado; vencida 20/06 entregue 15/06 = entregue (não atrasado) | PB-001 §11.1; RESUMO-001 B2/B3/B4 + golden cases Q12 (confirmados) |
| RN-007 | Atualização de pendência | Pendência registrada por usuário do escritório | Status atualizável (aberta, em andamento, resolvida); registro de autor e data | PB-001 §11.1, EVD-014 |
| RN-008 | Documento vinculado | Documento anexado a cliente/pendência/obrigação | Registrar situação (recebido/pendente) e autor | PB-001 §11.1 |

---

## 8. Restrições

### Negócio
- Uso interno inicial, sem venda; orçamento limitado.

### Operacionais
- On-premise (servidor próprio), sem bloqueio técnico real (EVD-018).
- Acesso interno **multi-estação** (compartilhado com outro PC/notebook — dec-002).
- Volume baixo; operação manual hoje via WhatsApp/Telegram.

### Regulatórias
- Dados de clientes (PJ, movimentações) — sigilo contábil (CRC) e LGPD.
- Prazos de obrigações são legais/tributários — alertas não substituem o contador (RNF-005).

### Organizacionais
- Desenvolvedor único, programação básica, sem prazo rígido (EVD-016/017).

### Técnicas
- Stack não definida (fica para Arquitetura); restrição de complexidade imposta pela capacidade de dev.

---

## 9. Casos de uso

### UC-001 — Lançar e validar movimentação

**Ator principal:** Auxiliar/estagiário

**Objetivo:** Registrar um lançamento financeiro de um cliente e receber sinalização de inconsistências.

**Pré-condições:** usuário autenticado com perfil de lançamento; cliente cadastrado.

**Fluxo principal:**
1. Usuário seleciona cliente e período.
2. Preenche dados do lançamento (data, valor, natureza, descrição).
3. Usuário confirma o lançamento.
4. Sistema executa validações de campos, de **período** e de **duplicidade** no momento da confirmação (RN-001, RN-003, RN-004; balanceamento N/A — modelo unitário, RN-002; validação inline durante digitação pode ser melhoria UX, não é requisito).
5. Sistema apresenta resultado: gravado sem inconsistência **ou** grava com sinalização de inconsistência (quando configurado assim).
6. Lançamento fica com status "pendente de conferência".
7. Usuário visualiza feedback e, se aplicável, ajusta/corrige.

**Fluxos alternativos:**
1. Usuário corrige dados após sinalização.
2. Usuário decide manter lançamento sinalizado (fica para conferência do contador).

**Exceções:**
1. Cliente/usuário inválido → bloqueio com mensagem.
2. Falha de rede/conexão → mensagem de erro e nenhuma gravação parcial.

**Pós-condições:** lançamento registrado com status, sinalizações e trilha de auditoria.

---

### UC-002 — Acompanhar prazos de obrigações

**Ator principal:** Contador titular / usuários autorizados

**Objetivo:** Visualizar e gerenciar prazos e obrigações por cliente.

**Pré-condições:** usuário autenticado; obrigações cadastradas.

**Fluxo principal:**
1. Usuário acessa calendário/lista de obrigações por cliente.
2. Sistema exibe obrigações com status (em dia, a vencer, atrasado, entregue).
3. Usuário filtra por cliente/status/período.
4. Usuário registra entrega/conclusão da obrigação (status "entregue").
5. Sistema atualiza status e auditoria.

**Exceções:**
1. Obrigação sem vencimento → não gera status automático; registra pendência manual.

**Pós-condições:** status atualizado, rastreável.

---

### UC-003 — Gerenciar pendências por cliente

**Ator principal:** Atendimento/administrativo / contador

**Objetivo:** Registrar e acompanhar pendências por cliente (quem está atrasado/incompleto).

**Pré-condições:** usuário autenticado.

**Fluxo principal:**
1. Usuário abre visão de pendências por cliente.
2. Sistema lista clientes com pendências (manuais + derivadas de obrigações/alertas).
3. Usuário registra nova pendência ou atualiza status.
4. Sistema registra autor/data e reflete na visão.

**Pós-condições:** pendência atualizada com trilha.

---

### UC-004 — Registrar documento vinculado

**Ator principal:** Atendimento/auxiliar

**Objetivo:** Registrar documento recebido (forma mínima) vinculado a cliente/pendência.

**Pré-condições:** usuário autenticado.

**Fluxo principal:**
1. Usuário seleciona cliente (e opcionalmente pendência/obrigação).
2. Registra descrição/arquivo anexo e situação (recebido/pendente).
3. Sistema associa e registra autor/data.

**Pós-condições:** documento rastreável no cliente/pendência.

---

### UC-005 — Acessar sistema com perfil e trilha de auditoria

**Ator principal:** Todos os perfis

**Objetivo:** Autenticar e operar ações conforme perfil, com auditoria.

**Matriz perfil→ação (direção provisória — RESUMO-001 E2):**

| Ação | Auxiliar | Contador | Atendimento | Sócio |
|---|---|---|---|---|
| Lançar | X | X | X | |
| Conferir | | X | | |
| Cadastrar cliente | | X | | |
| Cadastrar usuário | | X | | |
| Ver pendências | X | X | X | X |
| Registrar documento | X | X | X | |
| Config. backup | | X | | |

**Pré-condições:** usuário cadastrado.

**Fluxo principal:**
1. Usuário autentica (usuário/senha).
2. Sistema valida perfil e habilita ações permitidas.
3. Ações críticas geram registro de auditoria.

**Exceções:**
1. Credenciais inválidas → bloqueio de autenticação (conta não bloqueada de forma definitiva; reavaliar na segurança).
2. Ação não permitida → negada com mensagem.

**Pós-condições:** sessão autenticada; auditoria registrada.

---

## 10. Critérios de aceitação

| Requisito | Critério | Método de verificação | Resultado esperado |
|---|---|---|---|
| RF-001 | Cliente com dados mínimos é salvo e editável; regimes listados conforme contexto | Teste funcional (cenário) | CRUD de cliente operante |
| RF-002 | Usuário com perfil definido; autenticação e autorização por perfil | Teste de segurança/funcional | Acesso negado para ação não permitida |
| RF-003/RF-004 | Lançamento com dados inválidos gera sinalização antes de confirmar; lançamento válido é gravado com status "pendente de conferência" | Teste funcional + caso golden (PEN-PB-002) | Sinalização visível e status correto |
| RF-005 | Conferência pelo contador (em **lote**: revisa → marca conferido → corrige/devolve) altera status e registra trilha | Teste funcional | Status "conferido/corrigido/devolvido" + auditoria |
| RF-006/RF-007 | Obrigação com vencimento gera status correto (em dia/a vencer/atrasado/**entregue**) e alerta conforme parâmetro (padrão 7 dias configurável) | Teste funcional com datas fixas | Status/alertas corretos; golden cases aprovados |
| RF-008/RF-009 | Visão de pendências lista clientes com pendências e permite atualizar status | Teste funcional | Visão correta; status atualizável com autor/data |
| RF-010 | Documento registrado vinculado a cliente/pendência com situação | Teste funcional | Documento rastreável |
| RF-011 | Métricas de uso são registradas (para cálculo futuro de adoção/erros) | Verificação de logs | Logs de lançamento/conferência/pendência presentes |
| RNF-003 | Auditoria registra ação crítica com autor/data | Teste de segurança | Auditoria completa |
| RNF-005 | Alertas validados com casos "golden" do contador | Revisão de regras + testes de aceitação | Nenhum alerta incorreto nos casos validados |

---

## 11. Dependências

| Dependência | Tipo | Impacto | Responsável | Status |
|---|---|---|---|---|
| Regras de validação exatas (normalização contábil) confirmadas | Domínio | Corrige/ajusta RN-002…004 | Contador titular | **Parcial** (direção provisória aplicada via RESUMO-001 A1–A5; aguarda golden cases Q6/Q12 + validação externa) |
| Obrigações/prazos específicos por regime/cliente | Domínio | Corrige RF-006/RF-007 | Contador titular | **Parcial** (direção catálogo configurável + padrão por regime — RESUMO-001 B1/B5; aguarda golden cases Q12 + lista definitiva de obrigações) |
| Validação de fluxo com auxiliares e 1 cliente | Usuário | Garante aceitação e usabilidade | Squad UX + usuários | Aberta (PEN-PB-003) |
| Modelo de implementação multi-estação | Arquitetura | Define RNF-002/009 concretamente | Arquitetura | Aberta (PEN-PB-006) |
| Baseline de métricas (erros corrigidos, prazos atrasados) | Dado | Mede "redução" (PB-001 §15) | Contador | Aberta (PEN-PB-007 novo) |

---

## 12. Hipóteses e premissas

| ID | Hipótese/Premissa | Impacto caso seja falsa | Validação |
|---|---|---|---|
| HYP-002 | Validação automática + controle de prazos é o núcleo de valor | Núcleo do MVP errado → retrabalho | Protótipo/teste com contador + auxiliares |
| HYP-005 | Regras simples de validação já reduzem erros reais | Exigir regras contábeis complexas no MVP | Teste com volume real (PEN-PB-002) |
| PREM-001 | O contador é a autoridade de domínio para regras de validação e obrigações | Regras incorretas → passivo (RSK-PB-006) | Confirmação formal do contador antes do dev |
| PREM-002 | Uso 100% interno no MVP; clientes atendidos via uso assistido | Necessidade de acesso externo antes do previsto | Validação com 1 cliente (PEN-PB-003) |
| PREM-003 | Volume baixo e uso interno suficientes para MVP sem escalabilidade | Esforço adicional de escalabilidade | Revisão na Arquitetura |

---

## 13. Evidências

| ID | Evidência | Fonte | Data | Confiabilidade |
|---|---|---|---|---|
| EVD-014 | Sucesso = menos erros/retrabalho + prazos cumpridos | Solicitante | 2026-09-22 | medium |
| EVD-015 | Volume baixo (~30 lanç/mês/cliente) | Solicitante | 2026-09-22 | medium |
| EVD-016/017 | Dev único, programação básica, sem prazo rígido | Solicitante | 2026-09-22 | medium |
| EVD-018 | On-premise, sem bloqueio real | Solicitante | 2026-09-22 | medium |
| BE-01/03 | Validação e controle de prazos são padrões do setor | Benchmark | 2026-09-22 | medium |

---

## 14. Riscos

| ID | Risco | Requisitos afetados | Impacto | Mitigação |
|---|---|---|---|---|
| RSK-PB-001 | Escopo ainda grande p/ dev único | Todos | Alto | Cortes programados; incrementos pequenos; revisar corte após UX |
| RSK-PB-004 | Desenvolvimento arrasta e nunca atinge MVP utilizável | Todos | Alto | Entregas incrementais pequenas; critério de "versão utilizável" (carry-over PB-001) |
| RSK-PB-002 | Regras de validação incorretas ou ausentes | RF-004, RNF-005 | Alto | Golden cases aprovados pelo contador antes do dev; contador como autoridade |
| RSK-PB-003 | Não-aceitação dos auxiliares | RF-003/RF-004 | Alto | Entrevistas/validação de fluxo (PEN-PB-003) |
| RSK-PB-005 | Perda de dados | RNF-006 | Alto | Backup automático, exportação, plano de recuperação |
| RSK-PB-006 | Falha de domínio: squad sem capacidade de julgar regras contábeis | RF-004, RN-002/004 | Alto | Contador como autoridade de domínio; golden cases revisados (carry-over PB-001) |
| RSK-PB-007 | Segurança entre perfis em instalação compartilhada | RNF-003/004 | Alto | Menor privilégio, auditoria, security-engineer |
| RSK-PB-008 | Alertas incorretos → falsa segurança ± multa | RF-007, RNF-005 | Alto | Golden cases; configuração versionada; revisão periódica |
| RSK-PB-009 | Modelo acesso (PEN-PB-006) não detalhado | RNF-002 | Médio | Confirmar antes da Arquitetura |

---

## 15. Decisões

| ID | Decisão | Motivo | Data | Referência |
|---|---|---|---|---|
| DEC-MVP-001 | Núcleo MVP = validação + prazos + pendências | Priorização com evidência | 2026-09-22 | PB-001, dec-001 |
| DEC-MVP-002/003 | Fora do escopo (escrituração, NF, SPED, folha, portal, financeiro) | Complexidade/desproporção | 2026-09-22 | PB-001, dec-001 |
| dec-002 | Acesso interno multi-estação | Solicitação do solicitante | 2026-09-22 | dec-002 |
| DEC-REQ-001 | Validação **sinaliza** inconsistência em vez de bloquear todas as situações no MVP (política de sinalização a confirmar com contador) | Respeita RSK-PB-002/006; evita bloquear lançamento legítimo | 2026-09-22 | Este documento (a confirmar) |
| DEC-REQ-002 | Política por inconsistência (direção provisória): duplicidade e período = **C — confirmar antes de gravar**; balanceamento = N/A (modelo unitário); campos obrigatórios = bloqueio (RN-001) | Consistência de UX + reduz erro silencioso sem travar o lançamento | 2026-09-22 | RESUMO-001 A2/RF-004 |
| DEC-REQ-003 | Modelo de lançamento **unitário** no MVP | Volume baixo, dev único; agrupado adiciona complexidade desnecessária | 2026-09-22 | RESUMO-001 A1/RF-003 |

---

## 16. Rastreabilidade

| Requisito | Origem | Problema | Usuário | História | Arquitetura | Teste | Release |
|---|---|---|---|---|---|---|---|
| RF-001 | PB-001 §11.1 | Dor 6 | Todos | US-002/004 | UX-001 | Teste funcional | MVP 1 |
| RF-002 | PB-001 §5/12 | Segurança | Todos | (auditoria) | UX-001 | Segurança | MVP 1 |
| RF-003/004 | PB-001 §3.1 | Dor 1 | Auxiliar | US-001 | UX-001 | Funcional + golden | MVP 1 |
| RF-005 | PB-001 §5 | Dor 1/resp. técnica | Contador | US-001 | UX-001 | Funcional | MVP 1 |
| RF-006/007 | PB-001 §3.1 | Dor 5 | Contador/equipe | US-002/US-003 | UX-001 | Funcional + golden | MVP 1 |
| RF-008/009 | PB-001 §3.1 | Dor 6 | Atendimento/contador | US-004 | UX-001 | Funcional | MVP 1 |
| RF-010 | PB-001 §11.1 | Dor 2/6 (mínimo) | Atendimento | US-005 | UX-001 | Funcional | MVP 1 |
| RF-011 | PB-001 §15 | Métricas | — | (RF-011) | TBD | Validação de logs | MVP 1 |
| RF-012 | RSK-PB-002, RNF-003, US-001 | Edição/exclusão segura | Todos | US-001 | UX-001 | Funcional + segurança | MVP 1 |

---

## 17. Memória consultada

| ID | Memória | Impacto na especificação |
|---|---|---|
| ctx-001/002/003 | Contexto/restrições/resultado-alvo | Base da seção 8 e prioridades |
| dec-001 | Escopo MVP | RF-001…010 dentro do núcleo; exclusões |
| dec-002 | Acesso multi-estação | RNF-002/009 |
| rsk-001/002 | Tensão acesso; escopo × capacidade | RESTRIÇÃO forte; adiamento do acesso externo |
| apd-001 | Fonte única | Pendências de validação com usuários |

---

## 18. Memórias candidatas

| Informação | Tipo | Motivo | Confiança |
|---|---|---|---|
| Subagente business-analyst indisponível (erro free tier) em 2026-09-22 → Squad Lead executou etapa 10 | problema/decisão de processo | Evita tentativas repetidas sem necessidade; guia escolha de ferramenta | high (ocorreu duas vezes) |
| Regras de validação exigem golden cases antes do dev (não bloquear cegamente) | aprendizado | Orienta futuras etapas de domínio contábil | medium (recomendação) |

---

## 19. Pendências

| ID | Pendência | Responsável | Prioridade | Bloqueio |
|---|---|---|---|---|
| PEN-PB-001 | Refinar requisitos com business-analyst + contador (quando disponível) | Squad/BA/contador | Alta | Refinamento |
| PEN-PB-002 | Regras exatas de validação + **golden cases aprovados** (Q6/Q12 do PEN-CONTADOR-001) — **ATENDIDO em 2026-09-22** (Q6a/Q6b/Q12 confirmados no PEN-CONTADOR-001 §10-A; RN-003/004/006 deixam de ser provisórias). Resta apenas validação externa (PEN-PB-003) | Contador | Alta | ~~Development~~ **Menor (validação externa)** |
| PEN-PB-003 | Validação de fluxo com auxiliares e 1 cliente — **UX pode iniciar exploração, mas NÃO fecha telas/jornadas antes desta pendência**; participantes já definidos (RESUMO-001 F4/F5); **agendamento da sessão pendente** | UX/solicitante | Alta | Development (UX não fecha antes) |
| PEN-PB-004 | Obrigações/prazos — **lista definitiva de obrigações e golden cases (Q12)**; direção de modelo (catálogo configurável + padrão por regime) já provisória (RESUMO-001 B) | Contador | Média | RF-006/007 finos |
| PEN-PB-005 | Registrar decisões na memória | Squad Lead | Média | Concluída (dec-001/002) |
| PEN-PB-006 | Modelo de acesso detalhado antes da Arquitetura — **direção parcial provisória respondida** (RESUMO-001 D): 2 estações; uso simultâneo; PC-base + rede local; backup automático diário + **validação semanal pelo contador**; **liga/desliga pelo contador titular**; confirmação final e detalhe de infraestrutura pendentes | Squad + solicitante | Alta | **Arquitetura** |
| PEN-PB-007 | Baseline de métricas (erros corrigidos e prazos atrasados) — **solicitante aceitou coletar manualmente por 1–2 semanas** (RESUMO-001 F1/F2) | Contador | Alta | Métrica de resultado |
| PEN-REQ-001 | Definir política de sinalização (bloquear vs só sinalizar) para cada tipo de inconsistência — **campos obrigatórios são exceção consensual (bloqueio)**; direção provisória aplicada (C p/ duplicidade e período — RESUMO-001 A2); falta validação externa | Contador | Alta | RF-004/RN-002…004 |
| PEN-REQ-002 | Política de edição/exclusão de lançamentos — **direção provisória aplicada** (autor até conferir; contador depois; reabre conferência; cancelamento com motivo — RESUMO-001 C); falta validação externa | Contador | Alta | RF-012 |
| PEN-REQ-003 | Estados canônicos de obrigação validados pelo contador (em dia / a vencer / atrasado / entregue) — direção provisória aplicada (RESUMO-001 B3); falta validação externa e golden cases | Contador | Média | RF-007/RN-006 |

---

## 20. Gate de requisitos

### 20.1 Checklist

- [x] Problema relacionado identificado (núcleo valor).
- [x] Usuários identificados (com pendência de validação externa).
- [x] Requisitos suficientemente claros para avançar a UX/Arquitetura (grau de incerteza em domínio contábil registrado).
- [x] Regras de negócio documentadas (com as dependentes de domínio marcadas).
- [x] Requisitos não funcionais relevantes considerados.
- [x] Critérios de aceitação existem (alguns dependem de golden cases).
- [x] Dependências identificadas.
- [x] Riscos registrados.
- [x] Rastreabilidade estabelecida.
- [ ] Pendências críticas tratadas (pen-PB-002/003/004 pendentes — não bloqueiam UX).

### 20.2 Resultado

- [ ] Aprovado.
- [x] **Aprovado com condições.**
- [ ] Requer refinamento.
- [ ] Rejeitado.

> Revisão independente pelo `reviewer` **realizada em 2026-09-22**: veredito APROVADO COM CONDIÇÕES; correções P1–P13 incorporadas na v1.1. Condições objetivas:
> 1. **Antes de UX fechar telas/fluxos:** resolver P2 (limite da PEN-PB-003) e P9 (US-005 CA-002) — aplicadas.
> 2. **Antes de iniciar Arquitetura:** resolver P1 (RNF-009/fonte), P3 (modelo do lançamento), P4 (estados canônicos), P5 (critérios RNF-002/004/006), P11 (política edição/exclusão) — aplicadas (com pendências de domínio PEN-REQ-001/002/003 e PEN-PB-002/006).
> 3. **Antes de Development:** estava bloqueado até golden cases (PEN-PB-002) e validação com usuários (PEN-PB-003). **Atualização 2026-09-22:** golden cases **confirmados** (PEN-PB-002 atendido — Q6a/Q6b/Q12/Q8 no PEN-CONTADOR-001 §10-A); PEN-PB-003 (validação externa + agendamento da sessão de UX) permanece como condição restante.
>
> **Atualização em 2026-09-22 (v1.2):** respostas provisórias do solicitante (RESUMO-001 A–F) aplicadas em RF-003…007/010/012, RN-002…006 e matriz de perfis (UC-005) — **como direções provisórias** que **permitem iniciar** a Arquitetura (modelo de acesso indicado: 2 estações, uso simultâneo, PC-base + rede local, backup automático diário + validação semanal; ver PEN-PB-006). **Arquitetura pode iniciar; conclusão depende de confirmação final (PEN-PB-006)**. **Development permanece bloqueado** até golden cases (Q6/Q12), lista definitiva de obrigações (PEN-PB-004) e validação externa com contador/auxiliares (PEN-PB-003).

### 20.3 Justificativa

Os requisitos delimitam corretamente o MVP ao núcleo de valor e respeitam as decisões perseguidas (dec-001/002). As lacunas críticas são de **domínio contábil e validação com usuários** — explicitamente marcadas como pendências (PEN-PB-002/003/004, PEN-REQ-001/002/003), sem inventar regras. A revisão independente confirmou a direção e as condições de avanço foram incorporadas. UX pode avançar em modo exploratório sem fechar telas antes de PEN-PB-003; Arquitetura aguarda P1/P3/P4/P5/P11 e PEN-PB-006.

---

## 21. Referências

- `projetos/imperacont/product/PB-001-product-brief.md` v1.1
- `projetos/imperacont/product/PEN-001-priorizacao.md`
- `projetos/imperacont/discovery/DSC-001-discovery.md` v1.4
- `projetos/imperacont/discovery/PEN-008-benchmark.md`
- `memoria/decisoes/dec-001-imperacont-mvp-scope.md`, `memoria/decisoes/dec-002-acesso-multi-estacao.md`
- `templates/requirements.md`, `templates/user-story.md`, `workflows/02-product-definition.md`

---

## 22. Histórico de alterações

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação (etapa 10 do workflow 02) a partir de PB-001/dec-001/dec-002/discovery; produziu em nome do Squad Lead após não-disponibilidade do business-analyst (registrado em §header) | Squad Lead |
| 1.1 | 2026-09-22 | Correções P1–P13 da revisão independente: RNF-009 (P1), PEN-PB-003 limite UX (P2), RN-002 modelo lançamento + RF-012 (P3/P11), RN-006 estados canônicos (P4), critérios RNF-002/004/006 (P5), RN-001 exceção consensual (P6), RF-011 usuários únicos (P7), timing validação UC-001 (P8), US-005 CA-002 (P9), RSK-PB-004/006 (P10), RF-002 justificativa (P13), gate e pendências (P2/P12) | Squad Lead (após revisão reviewer) |
| 1.2 | 2026-09-22 | Respostas provisórias do solicitante (RESUMO-001 A–F) aplicadas como direções provisórias: RF-003 unitário, RF-004 política C, RF-005 conferência em lote, RF-006/007 catálogo + padrão por regime + alerta 7d + entrega data/autor, RF-012 edição/exclusão; RN-002 N/A, RN-003 duplicidade cliente+data+valor com C, RN-004 período data≠período com C, RN-006 alerta/entrega; matriz de perfis UC-005; DEC-REQ-002/003; pendências e dependências atualizadas. Validação externa (contador/auxiliares) e golden cases (Q6/Q12) ainda bloqueiam Development | Squad Lead (aplicação das respostas RESUMO-001) |
| 1.3 | 2026-09-22 | Correções da segunda revisão independente (aplicação das respostas v1.2): US-001 CA-003 duplicidade sem descrição + política C (P1), UC-001 remove balanceamento N/A (P2), RF-010 F3 re-cadastro no recebimento + PEN-PB-003 F4 (P3), PEN-PB-006 validação semanal/liga-desliga + §20.2 qualificado (P4), RF-002 sócio/gestor (P5), RF-005/§10 devolvido (P6), frontmatter RESUMO-001 1.2 + status REQ §1 (P7), US-001 contexto política provisória (P8), US-003 CA-003/004 7d+autor (P9), RF-006/US-003 lista sugerida (P10), UC-002/§10/PEN-PB-001 entregue + redação (P11), A2a/A2b/A2c rotulados (P12) | Squad Lead (após segunda revisão reviewer) |
| 1.4 | 2026-09-22 | Golden cases e catálogo **confirmados** (PEN-CONTADOR-001 §10-A): RN-003/004 (Q6a/Q6b), RN-006 (Q12), RF-006 (Q8); RF-003/004/006/007 status "Draft — confirmado"; PEN-PB-002 atendido; §20.2 condição 3 atualizada (resta PEN-PB-003 validação externa + agendamento UX) | Squad Lead (aplicação das respostas complementares do solicitante) |