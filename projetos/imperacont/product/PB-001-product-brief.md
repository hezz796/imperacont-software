---
title: Product Brief
type: product-brief
status: reviewed
scope: project
version: 1.1
---

# Product Brief — ImperaCont

## 1. Identificação

- **ID:** PB-001
- **Nome do produto:** ImperaCont (nome provisório)
- **Projeto:** imperacont-software
- **Responsável:** Squad Lead + Solicitante
- **Data de criação:** 2026-09-22
- **Última atualização:** 2026-09-22
- **Versão:** 1.1
- **Status:** Revisado — correções P1–P11 incorporadas

### 1.1 Origem

- **Origem da demanda:** ideia do solicitante ("criar um software contábil") para ferramenta interna.
- **Solicitante:** dono de escritório de contabilidade (fonte única até aqui).
- **Contexto de origem:** escritório pequeno (<50 clientes), Brasil, regimes federais, já opera de forma mista (sócio + auxiliares) sem ferramenta estruturada; documentos via WhatsApp/Telegram.
- **Artefatos de origem:** `projetos/imperacont/discovery/DSC-001-discovery.md` (v1.3), `projetos/imperacont/discovery/PEN-008-benchmark.md`.

---

## 2. Contexto

- **Organizacional:** uso interno inicial, sem venda; escritório único.
- **Operacional:** operação ativa e informal: lançamentos/fechamentos executados por sócio + auxiliares; entrada de documentos via WhatsApp/Telegram; volume baixo (~até 30 lançamentos/mês por cliente).
- **Mercado:** líderes do setor (Domínio, Alterdata, Contmatic, Questor) oferecem suites completas (contábil+fiscal+DP+financeiro, SPED, NF-e, área do cliente), com custo e complexidade altos; há linhas "para pequenos escritórios", mas orientadas a nuvem e assinatura recorrente.
- **Usuários:** 5 perfis declarados (contador titular, auxiliares, atendimento, sócio/gestor, clientes do escritório).
- **Sistemas existentes:** nenhum — greenfield de ferramenta/dados; sem migração legada.
- **Restrições:** orçamento limitado; servidor próprio (on-premise) sem bloqueio técnico real; desenvolvimento por 1 pessoa com programação básica; sem prazo rígido.
- **Mudanças recentes relevantes:** Reforma Tributária (IBS/CBS) amplia complexidade do setor; relevante apenas para evolução futura do produto, não para o MVP.

---

## 3. Problema

### 3.1 Problema principal

Um escritório contábil pequeno que já opera de forma manual e desestruturada (documentos por WhatsApp, lançamentos sem validação) não consegue, com segurança, controlar erros, prazos de obrigações e pendências dos seus clientes, gerando retrabalho, risco de multa e perda de confiança — sem uma ferramenta simples, barata e adaptada ao seu tamanho.

### 3.2 Problemas relacionados

- Erros em lançamentos/concertação por ausência de validação (dor 1).
- Risco de perder prazos de obrigações acessórias (dor 5).
- Falta de visão por cliente sobre pendências e atrasos (dor 6).
- Retrabalho e manualidade (dor 3).
- Fechamento difícil/confecção de balancetes (dor 4) — **explicitamente fora do MVP 1** (depende de escrituração formal, §11.2; ver também DEC-MVP-002).
- Comunicação ineficiente com clientes via WhatsApp/Telegram (dor 2) — **não priorizada para o núcleo do MVP** (ver §11).

### 3.3 Impacto atual

- **Usuários:** auxiliares/sócio gastam tempo em tarefas manuais; risco de erro alto.
- **Negócio:** risco de multas por atraso de obrigações; retrabalho.
- **Operacional:** sem registro único de pendências por cliente; informação dispersa em WhatsApp.
- **Financeiro:** custo de multas/retrabalho; inviável adquirir suite completa do mercado.
- **Risco:** passivo contábil/fiscal do contador titular (RSK-004/RSK-008 do discovery).

---

## 4. Necessidade

Precisa-se de uma ferramenta interna simples que centralize clientes, lançamentos, prazos de obrigações e pendências, com **validação automática que sinalize inconsistências**, alertas de prazo e visão de quem está atrasado — proporcional a um escritório pequeno, operável por pessoa com programação básica e hospedável no próprio escritório.

Necessidade ≠ solução: a necessidade é **não errar, não perder prazo e saber quem está pendente**; a preferência declarada por "desktop Windows na 1ª versão" (EVD-009) é uma *preferência de entrega*, não a necessidade em si — e está **em avaliação** frente à tensão acesso-cliente (HYP-004, PEN-003). *(Interpretação da squad a partir da declaração conflitante registrada na discovery.)*

---

## 5. Usuários e partes interessadas

### 5.1 Usuários principais

| Usuário | Necessidade | Contexto de uso | Impacto |
|---|---|---|---|
| Auxiliares/estagiários | Lançar movimentações com rapidez e segurança | Uso diário, volume alto repetitivo | Médio-alto (volume de uso) |
| Contador titular | Conferir, validar, acompanhar pendências por cliente | Revisão/alinhamento | Alto (responsabilidade técnica) |
| Sócio/gestor | Visão de capacidade e pendências | Consulta periódica | Médio (decisão) |

### 5.2 Usuários secundários

| Usuário | Necessidade | Contexto de uso |
|---|---|---|
| Atendimento/administrativo | Saber quem está pendente e cobrar | Uso diário leve |
| Clientes do escritório | Enviar documentos e acompanhar | **Fora do MVP 1** (decisão: portal do cliente adiada; uso assistido no MVP) |

### 5.3 Stakeholders

| Stakeholder | Interesse | Influência | Necessidade |
|---|---|---|---|
| Solicitante (dono/contador) | Ferramenta funcional e simples | Alta | Reduzir erro, prazo e retrabalho |
| Auxiliares (não ouvidos ainda) | Não complicar a rotina | Média (aceitação) | Fluxo simples de lançamentos |
| Contador titular | Segurança técnica | Alta | Validação confiável |

---

## 6. Evidências

| ID | Evidência | Fonte | Data | Confiabilidade | Observação |
|---|---|---|---|---|---|
| EVD-014 | Sucesso = menos erros/retrabalho + prazos cumpridos | Solicitante | 2026-09-22 | medium | Norte para métricas |
| EVD-015 | Volume baixo (~30 lanç/mês/cliente) | Solicitante | 2026-09-22 | medium | Escala do MVP |
| EVD-016 | Dev único, programação básica | Solicitante | 2026-09-22 | medium | Restrição de complexidade |
| EVD-018 | On-premise, sem bloqueio real | Solicitante | 2026-09-22 | medium | Viabilidade desktop/web local |
| BE-01 | Market parlance: "análise crítica de lançamentos" é padrão em plano iniciante (Alterdata First) | Benchmark | 2026-09-22 | medium | Valida validação como núcleo |
| BE-02 | Suites completas do setor são caras/complexas; linhas "pequenas" são cloud SaaS | Benchmark | 2026-09-22 | medium | Justifica MVP enxuto interno |
| BE-03 | Controle de prazos/obrigações normalmente via módulo/parceiro dedicado | Benchmark | 2026-09-22 | medium | Valida controle de prazos como núcleo sem exigir SPED |

> **Nota (P3/P5):** DEC-MVP-001 foi removida desta tabela — decisão não é evidência. O registro da sessão de priorização (participantes, critérios, resultado por dor) está em `product/PEN-001-priorizacao.md`; a decisão consolidada está em §16 e em `memoria/decisoes/dec-001`.

### 6.1 Evidências faltantes

- Validação com auxiliares reais (PEN-007) e com 1 cliente (uso assistido).
- Confirmação das obrigações/prazos específicos dos clientes (PEN-006, INC-007).
- Detalhe de "ambiente restrito" operacional já resolvido, mas sem confirmação de infra (ex.: qual computador/Windows).

---

## 7. Oportunidade

### 7.1 Oportunidade principal

Estruturar a operação existente de um escritório pequeno com uma ferramenta simples que ataca os três pontos de maior consequência (erro, prazo, pendência), dentro do orçamento e da capacidade de desenvolvimento.

### 7.2 Oportunidades relacionadas

- Base evolutiva para uma futura ferramenta comercial.
- Área do cliente como evolução natural pós-MVP (entrada de documentos, na forma mínima, já está no MVP — ver §11.1).

### 7.3 Potencial de impacto

- **high** para o escritório (mitiga risco de multa/erro e retrabalho), **baixo/médio** como negócio (uso interno; comercialização é evolução opcional).

---

## 8. Hipóteses

| ID | Hipótese | Evidência atual | Como validar | Status |
|---|---|---|---|---|
| HYP-001 | As 6 dores têm pesos muito diferentes (núcleo pequeno) | EVD-014, BE-01/02/03 | Refazer ranking com contador + auxiliares | **fechada via priorização PEN-001** (fonte única; validação com usuários pendente) |
| HYP-002 | Validação automática + controle de prazos é o núcleo de valor | EVD-014, BE-01, BE-03 | Protótipo/teste com contador e auxiliar | em validação |
| HYP-003 | Escrituração formal não é necessária no MVP 1 | BE-02 | Revisão em evolução | não testada — decisão de escopo tomada (DEC-MVP-002); validação adiada |
| HYP-004 | Clientes podem ser atendidos sem acesso direto ao desktop no MVP (portal adiado; uso assistido) | EVD-003 vs EVD-009 | Testar fluxo assistido com 1 cliente | não testada — decisão de escopo tomada (portal fora, DEC-MVP-002); validação adiada |
| HYP-005 | Regras simples de validação (ex.: débito/crédito desbalanceado, duplicidade, data/período) já reduzem erros reais sem exigir regras fiscais complexas | EVD-014, BE-01 | Testar com volume real de lançamentos do escritório | não testada |

---

## 9. Proposta de valor

### 9.1 Valor para o usuário

- Auxiliares lançam com validação imediata (menos retrabalho).
- Contador vê pendências e prazos por cliente em uma tela.

### 9.2 Valor para o negócio

- Redução de risco de multa por atraso; menos retrabalho; operação organizada.
- Custo baixo (interno, on-premise, dev único).

### 9.3 Resultado esperado

- Nos primeiros 6 meses: menos erros/retrabalho e prazos cumpridos (EVD-014), com visão de pendências por cliente.

---

## 10. Direcionamento da solução

### 10.1 Direção inicial

Aplicação on-premise, **compartilhada entre múltiplos PCs/notebooks do escritório** (decisão do solicitante em 2026-09-22: "o sistema deve ser compartilhado com outro PC ou notebook"), focada em: cadastro de clientes, lançamentos com validação, calendário/prazos de obrigações por cliente, dashboard pendências. **Sem** escrituração formal, NF-e, SPED ou folha.

> Implicação para Arquitetura: precisa haver acesso multi-estação (dados centralizados acessíveis por outra máquina), sem exigir, no MVP, acesso externo/nuvem.

### 10.2 Alternativas consideradas

- Suite completa de mercado (Domínio/Alterdata/Contmatic): rejeitada — custo/complexidade desproporcionais; usar como referência de fluxo.
- Desenvolver com escrituração formal no MVP: rejeitada — complexidade regulatória alta, inviável p/ dev único.
- Adquirir SaaS "pequeno escritório": rejeitada — assinatura recorrente; não atende a preferência on-premise. *(Premissa a validar com o solicitante: residência dos dados/nuvem não foi declarada como requisito.)*

### 10.3 O que ainda não está decidido

- Modelo técnico exato (desktop puro vs web local vs híbrido) — decisão de **Arquitetura**, não daqui.
- Detalhe das regras de validação — será refinado com o contador (PEN-006/007).
- Quais obrigações/prazos específicos — depende dos clientes (INC-007).

> A existência desta seção não representa aprovação de uma solução técnica.

---

## 11. Escopo preliminar

### 11.1 Dentro do escopo (MVP 1)

- Cadastro de clientes (empresas) e usuários do escritório.
- Lançamentos financeiros com validação básica (débito/crédito, duplicidade, data/período, campos obrigatórios) e sinalização de inconsistências.
- Controle de prazos/obrigações por cliente (cadastro de obrigações, calendário, alertas/status).
- Gestão de pendências por cliente (visão de quem está atrasado/incompleto).
- Registro/entrada de documentos por cliente de forma simples (anexo ligado a pendência) — **forma mínima, dentro do MVP 1**. *Desvio justificado da PEN-001 (não priorizada como núcleo): baixo custo relativo, apoio direto à dor 6, alívio parcial da dor 2 sem portal — ver `product/PEN-001-priorizacao.md`.*

### 11.2 Fora do escopo (MVP 1 — evoluir depois)

- Escrituração contábil formal (razão, balancete, plano de contas completo).
- Notas fiscais (NF-e/NFS-e) e escrituração fiscal.
- SPED/ECD/ECF e obrigações que dependam de dados formais.
- Folha de pagamento/departamento pessoal.
- Portal/área do cliente (acesso externo) — clientes atendidos via uso assistido pelo escritório no MVP.
- Financeiro básico (contas a pagar/receber, conciliação OFX) — **não priorizado como núcleo (PEN-001); não entra no MVP 1 sem nova decisão; revisitar como evolução pós-MVP.**
- Conciliação bancária avançada (requer demanda declarada; ver incerteza).
- Painéis analíticos/BI.

### 11.3 Escopo ainda indefinido

- Obrigações/prazos específicas por regime e por cliente — depende de INC-007/PEN-PB-004 (não decidido hoje).
- Escopo exato dos alertas (frequência, canais) — a decidir com o contador.

---

## 12. Restrições

### 12.1 Negócio

- Uso interno inicial; sem venda; orçamento limitado.

### 12.2 Operacionais

- On-premise (servidor próprio), sem bloqueio técnico real (EVD-018).
- **Acesso à 1ª versão:** desktop Windows (EVD-009) **e deve ser compartilhado com outro PC/notebook do escritório** (decisão do solicitante, 2026-09-22) — acesso multi-estação interna; acesso externo de clientes permanece fora do MVP (PEN-PB-006).
- Volume baixo; atividades manuais hoje via WhatsApp/Telegram.

### 12.3 Legais ou regulatórias

- Dados de clientes (JP, movimentações financeiras) — sigilo contábil (CRC) e LGPD; retenção e conformidade.
- Prazos de obrigações são legais/tributários — alertas devem ser confiáveis, mas não substituem o contador.

### 12.4 Organizacionais

- Desenvolvedor único, programação básica, sem prazo rígido.

### 12.5 Técnicas conhecidas

- Sem stack definida ainda; cap. de dev básica reduz complexidade possível.

---

## 13. Riscos iniciais

| ID | Risco | Probabilidade | Impacto | Severidade | Mitigação |
|---|---|---|---|---|---|
| RSK-PB-001 | Escopo do MVP ainda grande para dev único | Média | Alto | Alta | Cortes programadas; priorização por frente; pequenas versões incrementais |
| RSK-PB-002 | Regras de validação contábil mal especificadas → sinaliza errado (pior modo de falha: sinalizar "OK" incorreto → falsa confiança + passivo do contador; carry-over RSK-004/RSK-008) | Alta | Alto | Alta | Especificar validações com o contador (PEN-006/007) **com casos de teste reais (golden cases) revisados e aprovados pelo contador titular antes do dev**; registrar quem responde tecnicamente pela correção das regras; revisão independente das regras pela squad |
| RSK-PB-003 | Usuários (auxiliares) não validados → produto rejeitado na prática | Desconhecida (base: auxiliares não ouvidos) | Médio | Alta | Entrevistar/validar com auxiliares antes de Development (PEN-007) |
| RSK-PB-004 | Desenvolvimento arrasta e nunca atinge MVP utilizável | Média | Alto | Alta | Entregas incrementais pequenas; definir critério de "versão utilizável" |
| RSK-PB-005 | Dados sensíveis em desktop on-premise sem backup → perda | Média | Alto | Alta | Backup automático (RSK-009 do discovery → tratado na Arquitetura) |
| RSK-PB-006 | Falha de domínio: squad sem capacidade de julgar correção de regras contábeis (carry-over RSK-008) | Média | Alto | Alta | Casos de teste "golden" aprovados pelo contador; revisão de regras por especialista antes do dev |
| RSK-PB-007 | Segurança/LGPD/sigilo CRC: acesso entre 5 perfis em instalação compartilhada sem controle (carry-over RSK-005) | Média | Alto | Alta | Modelar autorização/auditoria na Arquitetura; envolver security-engineer |
| RSK-PB-008 | Alertas de obrigações incorretos/obsoletos → falsa sensação de segurança e multa (carry-over RSK-007) | Média | Alto | Alta | Fonte de obrigações versionada; validação periódica com contador; responsável claro pela manutenção |
| RSK-PB-009 | Tensão desktop Windows × acesso de clientes × comunicação (carry-over RSK-002) | Média | Médio | Média | **Acesso interno multi-estação definido** (solicitante, 2026-09-22); acesso externo de clientes permanece **aceito/adiado** no MVP 1 via uso assistido (HYP-004, DEC-MVP-002); confirmar detalhes em PEN-PB-006 antes da Arquitetura |

---

## 14. Incertezas

- Detalhe das obrigações/prazos que o escritório precisa controlar (INC-007) — definir antes dos requisitos de obrigações.
- Regras específicas de validação desejadas pelo contador.
- Aceitação dos auxiliares (não ouvidos).
- Se portal do cliente deve ser priorizado logo após o MVP.
- Necessidade real de conciliação bancária/financeiro básico (não priorizado).

---

## 15. Métricas preliminares

| Métrica | Objetivo | Indicador | Forma de medição | Baseline / Meta / Janela |
|---|---|---|---|---|
| Redução de erros/retrabalho | Validar valor (EVD-014) | Erros detectados na conferência do contador por lote (não apenas correções pós-lançamento — evita proxy trivializável) | Contagem na conferência | **Baseline obrigatória antes do MVP:** levantamento manual com o contador (erros corrigidos no mês atual); meta e janela (6 meses) a fixar com ele |
| Prazos cumpridos | Validar valor (EVD-014) | % de obrigações entregues dentro do prazo | Status no calendário de obrigações | Baseline manual antes do MVP; meta a fixar; janela 6 meses; depende de PEN-PB-004 |
| Visibilidade de pendências | Uso da gestão | % de clientes com pendência registrada **e atualizada nas últimas 2 semanas** (definição de recência fixada) | Relatório de pendências | 100% dos clientes ativos |
| Adoção | Verificar uso real | Lançamentos cadastrados por semana; usuários únicos ativos (definição: ≥1 ação por semana) | Logs/auditoria (**requisito não funcional mínimo** — registrar em requisitos) | Meta ≥80% das semanas com uso pelos auxiliares — **valor provisório, a justificar** |

> Métricas, baselines, metas e janelas serão refinadas com o contador (PEN-PB-002/003) **antes do MVP**; baseline é pré-condição para medir "redução".

---

## 16. Decisões

| ID | Decisão | Motivo | Data | Responsável | Referência |
|---|---|---|---|---|---|
| DEC-MVP-001 | Núcleo MVP 1 = validação de lançamentos + controle de prazos/obrigações + gestão de clientes/pendências | Priorização das dores (EVD-014, BE-01, BE-03); registro da sessão em `product/PEN-001-priorizacao.md` | 2026-09-22 | Solicitante + Squad | PEN-001 (registro) |
| DEC-MVP-002 | Sem escrituração formal, NF-e, SPED completo, folha e portal do cliente no MVP 1 | Complexidade regulatória/técnica desproporcional p/ dev único; benchmark | 2026-09-22 | Solicitante + Squad | PEN-001, BE-02 |
| DEC-MVP-003 | Financeiro básico e entrada de documentos sofisticada fora do núcleo; **entrada de documentos na forma mínima mantida dentro do MVP 1 (desvio justificado da PEN-001)** | Não priorizados como núcleo; forma mínima mantida por baixo custo e apoio à dor 6 | 2026-09-22 | Solicitante + Squad | PEN-001 (registro) |
| DEC-ORIGEM-001 | Produto é ferramenta interna (sem venda) | Contexto do solicitante | 2026-09-22 | Solicitante | DSC-001 EVD-002 |

> Decisões consolidadas já registradas em `memoria/decisoes/dec-001-imperacont-mvp-scope.md` (PEN-PB-005 concluída).

---

## 17. Memória consultada

| ID | Memória | Como influenciou |
|---|---|---|
| ctx-001 | Contexto do produto | Definiu público/restrições |
| ctx-002 | Restrições | Definiu escopo/stack de viabilidade |
| ctx-003 | Resultado-alvo | Definiu métricas e núcleo de valor |
| rsk-001 | Desktop × clientes × comunicação | Decisão de adiar portal do cliente (HYP-004 adiada) |
| rsk-002 | Escopo amplo × capacidade | Corte de MVP (DEC-MVP-001/002) |
| apd-001 | Evidência de fonte única | Pendências PEN-006/007 reforçadas |

---

## 18. Memórias candidatas

| Candidato | Tipo | Motivo | Confiança | Necessita revisão |
|---|---|---|---|---|
| DEC-MVP-001 (núcleo MVP) | decisão | Condiciona todo o backlog/arquitetura | high (decisão, ainda a validar com usuários) | sim |
| DEC-MVP-002/003 (fora do escopo) | decisão | Evita retrabalho futuro de escopo | high (decisão) | sim |
| Direção on-premise desktop/web local p/ MVP | decisão (preliminar) | Restringe Arquitetura; mas stack ainda não decidida | medium | sim (revisão após Arquitetura) |

---

## 19. Rastreabilidade

| Elemento | Origem | Evidência | Decisão relacionada | Próximo artefato |
|---|---|---|---|---|
| Núcleo MVP | Discovery (dores 1, 5, 6) | EVD-014, BE-01/03 | DEC-MVP-001 | Requisitos + UX (nesta ordem: PEN-PB-001 primeiro, depois UX) |
| Fora do escopo | Discovery + benchmark | BE-02, DEC-MVP-002/003 | DEC-MVP-002/003 | Backlog de evolução |
| Entrada de documentos (forma mínima) | Desvio da PEN-001 | BE-02 (custo relativo) | DEC-MVP-003 (desvio registrado) | Requisitos (PEN-PB-001) |
| Métricas | Discovery | EVD-014 | DEC-MVP-001 | Product analytics |

---

## 20. Pendências

| ID | Pendência | Responsável | Prioridade | Prazo | Bloqueia Development |
|---|---|---|---|---|---|
| PEN-PB-001 | Detalhar requisitos funcionais/user stories do MVP (validação, prazos, pendências) | Squad (business-analyst) + contador | Alta | — | Não (próximo artefato da Product Definition) |
| PEN-PB-002 | Especificar regras de validação com o contador **+ golden cases revisados/aprovados (PEN-006/007)** | Squad + contador | Alta | antes do dev | **Sim** (qualidade do MVP) |
| PEN-PB-003 | Validar fluxo com auxiliares e 1 cliente (PEN-007) | Squad (UX) | Alta | antes do dev | **Sim** |
| PEN-PB-004 | Definir obrigações/prazos específicos (INC-007) | Contador | Média | antes do dev | Parcial (módulo prazos) |
| PEN-PB-005 | Registrar DEC-MVP na memória de decisões | Squad Lead | Média | no fechamento do gate | **Concluída** (`memoria/decisoes/dec-001`) |
| PEN-PB-006 | Modelo de acesso: **acesso interno multi-estação definido** (compartilhar com outro PC/notebook, 2026-09-22); **confirmar detalhes** (simultâneo? dados centralizados? quais máquinas?) e aceitar explicitamente que cliente externo fica fora do MVP — antes da Arquitetura (DSC-001 PEN-003) | Squad + solicitante | Alta | antes de Arquitetura | **Sim (para Arquitetura)** |

---

## 21. Gate

### Critérios de saída

- [x] Problema compreendido.
- [x] Usuários identificados (auto-relato; pendência de validação externa registrada).
- [x] Evidências registradas.
- [x] Oportunidade caracterizada.
- [x] Hipóteses identificadas.
- [x] Riscos iniciais registrados.
- [x] Incertezas explicitadas.
- [x] Revisão independente aplicada (P1–P11 incorporadas).
- [x] Próxima etapa definida: **requisitos/user stories (PEN-PB-001) → UX/Design; Arquitetura após PEN-PB-006**.

### Resultado (v1.1 — após revisão independente P1–P11)

- [ ] Aprovado para próxima etapa.
- [x] Aprovado com pendências.
- [ ] Necessita investigação adicional.
- [ ] Rejeitado.
- [ ] Suspenso.

### Justificativa

O produto está delimitado ao núcleo de valor (validação + prazos + pendências), alinhado às evidências, com escopo fora (escrituração, NF, SPED, folha, portal, financeiro básico) explícito e a entrada de documentos classificada de forma única (forma mínima, dentro — desvio registrado). Correções P1–P11 da revisão independente incorporadas nesta versão 1.1.

**Condições explícitas do gate (bloqueiam Development, não este gate):**

- PEN-PB-002 — regras de validação com golden cases aprovados pelo contador.
- PEN-PB-003 — validação com auxiliares e 1 cliente.
- PEN-PB-004 — obrigações/prazos específicos (parcial).
- PEN-PB-006 — modelo de acesso resolvido/aceito antes de Arquitetura.

Por isso **aprovado com pendências**, não aprovação plena.

### Histórico do gate

| Versão | Resultado | Observação |
|---|---|---|
| 1.0 | Devolvido para revisão (reviewer) | P1–P3 obrigatórios; P4–P11 recomendados |
| 1.1 | Aprovado com pendências (correções incorporadas) | Este estado |

---

## 22. Referências

- `projetos/imperacont/discovery/DSC-001-discovery.md` v1.3
- `projetos/imperacont/discovery/PEN-008-benchmark.md`
- `projetos/imperacont/product/PEN-001-priorizacao.md` (registro da sessão de priorização)
- `memoria/decisoes/dec-001-imperacont-mvp-scope.md`
- `templates/product-brief.md`, `workflows/02-product-definition.md`

---

## 23. Histórico de alterações

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação a partir da discovery + benchmark + priorização PEN-001 | Squad Lead |
| 1.1 | 2026-09-22 | Correções P1–P11 da revisão independente: classificação única de entrada de documentos (P1), §11.3 limpo (P2), registro da priorização + limpeza §6/§8 (P3), riscos carry-over RSK-004/005/007/002 (P4), fato×decisão×hipótese (P5), métricas com baseline (P6), dor 4 + PEN-P006 (P7), EVD-009 (P8), premissa SaaS (P9), semântica/status (P10), golden cases (P11) | Squad Lead (após revisão reviewer) |