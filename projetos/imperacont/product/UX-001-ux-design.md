---
title: UX Design
description: Design de experiência exploratório do MVP 1 do ImperaCont — usuários, jornadas, arquitetura da informação, fluxos, interação, conteúdo, acessibilidade mínima e prototipação inicial.
type: ux-design
status: reviewed
scope: project
version: 1.1
project: imperacont-software
---

> **Nota de governança (Squad Lead):** este artefato foi produzido **pelo Squad Lead** em 2026-09-22 após tentativa de delegação ao `ux-designer` falhar por indisponibilidade do provedor (erro free tier — mesmo padrão registrado em `memoria/aprendizados/apd-002`). Trabalho executado com rigor a partir de PB-001 (v1.1), REQ-001 (v1.1), user stories e memória, **em modo exploratório** (condição PEN-PB-003: não fechar telas/jornadas definitivas antes da validação com auxiliares e 1 cliente). **Revisão independente encaminhada ao `reviewer`** (ver §23).

# UX Design — UX-001 (MVP 1 ImperaCont)

## 1. Identificação

- **ID:** UX-001
- **Produto:** ImperaCont (nome provisório) — ferramenta contábil interna
- **Projeto:** imperacont-software
- **Responsável:** Squad Lead (initial exploratório); validação com usuários pendente (PEN-PB-003)
- **Data:** 2026-09-22
- **Versão:** 1.0
- **Status:** Exploratório (rascunho)

---

## 2. Contexto

Escritório contábil pequeno (<50 clientes) que opera manualmente (documentos via WhatsApp/Telegram, lançamentos sem validação). O produto organiza clientes, lançamentos, prazos de obrigações e pendências, com validação que sinaliza inconsistências, alertas de prazo e visão de quem está atrasado. Uso interno, on-premise, multi-estação (dec-002), volume baixo, dev único com programação básica.

**Nível de maturidade da experiência:** produto interno de apoio operacional; os usuários-alvo são o próprio solicitante (contador) e seus auxiliares — com **validação externa ainda pendente** (PEN-PB-003). O UX aqui é exploratório: propõe direção para validação, não telas fechadas.

---

## 3. Objetivos de UX

1. Lançamentos com menos erros e menos retrabalho (validação clara e ação imediata sobre inconsistências).
2. Garantia de que o contador veja pendências e prazos por cliente em uma tela (sem dispersão em WhatsApp).
3. Operação simples o suficiente para auxiliares aceitarem (não complicar a rotina — RSK-PB-003).
4. Operação simples com cadastros diretos para **migração manual de baixo esforço** (sem importação de dados no MVP — não há RF de importação; cadastro manual guiado).
5. Confiança: mensagens de validação explicáveis e rastreáveis (não "caixa preta").

---

## 4. Usuários

| Perfil | Objetivos | Necessidades | Dificuldades | Contexto |
|---|---|---|---|---|
| Auxiliar/estagiário (premissa PB-001 §5; validar PEN-PB-003) | Lançar movimentações rapidamente, sem erros | Feedback claro de inconsistência; fluxo curto; evitar retrabalho | Passa muito tempo em tarefas manuais; lança com pressa | Uso diário repetitivo; mesmo escritório |
| Contador titular (solicitante) | Conferir, validar, acompanhar pendências/prazos por cliente | Visão consolidada; autoridade sobre conferência; rastreabilidade | Responsabilidade técnica; tempo limitado; hoje informação dispersa | Revisão/alinhamento diário |
| Sócio/gestor | Visão de capacidade e pendências | Painel simples de "quem está pendente/atrasado" | Sem modernização para ler relatórios complexos | Consulta periódica |
| Atendimento/administrativo | Saber quem está pendente e cobrar | Lista de clientes pendentes por prioridade; registrar cobrança/status | Hoje depende de WhatsApp e memória | Uso diário leve |
| Clientes do escritório (fora do MVP 1) | Enviar documentos e acompanhar | — | — | Uso assistido apenas (DEC-MVP-002) |

> Premissas de perfil (Auxiliar, Atendimento **e Sócio/gestor — somente leitura**) derivam do auto-relato do solicitante; **validação com auxiliares reais é pendência** (PEN-PB-003) e o papel exato do sócio/gestor está em PEN-UX-003. Não tratar como fato.

---

## 5. Evidências de pesquisa

| ID | Evidência | Método | Fonte | Data | Confiabilidade |
|---|---|---|---|---|---|
| EVD-014 | Sucesso = menos erros/retrabalho + prazos cumpridos | Entrevista estruturada | Solicitante (fonte única) | 2026-09-22 | medium |
| EVD-015 | Volume baixo (~30 lanç/mês/cliente) | Entrevista estruturada | Solicitante | 2026-09-22 | medium |
| EVD-016/017 | Dev único, programação básica, sem prazo rígido | Entrevista estruturada | Solicitante | 2026-09-22 | medium |
| EVD-018 | On-premise sem bloqueio real; multi-estação (dec-002) | Entrevista + decisão | Solicitante | 2026-09-22 | medium |
| BE-01/03 | Validação e controle de prazos são padrões do setor | Benchmark | PEN-008 | 2026-09-22 | medium |
| — | Aceitação dos auxiliares **não observada** | — | — | — | **lacuna (PEN-PB-003)** |

---

## 6. Insights

### Insight 1 — O núcleo de valor é redução de consequências, não "escrituração"

Usuários querem *não errar, não perder prazo, saber quem está pendente*. A experiência deve destacar **estado e exceção** (o que está errado/atrasado pendente) sobre funcionalidade formal de contabilidade (fora do MVP 1).

### Insight 2 — A validação precisa explicar-se

Sinalizar inconsistência sem explicar o porquê gera retrabalho e desconfiança. Mensagens devem indicar a regra violada e o que o usuário pode fazer (corrigir, manter para conferência do contador).

### Insight 3 — Visão por cliente é a cola da operação

Contador, atendimento e sócio olham o mesmo "sujeito" (cliente). A navegação deve permitir partir do **cliente** para ver prazos, pendências, lançamentos e documentos — reduzindo a dispersão em WhatsApp.

### Insight 4 — Simplicidade é requisito de aceitação

Auxiliares não validados; produto interno com dev único. Fluxos curtos, poucos campos por tela e padrões repetitivos são críticos para adoção (RSK-PB-003).

---

## 7. Problemas de experiência

| ID | Problema | Usuário afetado | Impacto | Evidência |
|---|---|---|---|---|
| UX-PROB-001 | Lançamentos sem validação geram erros só descobertos na conferência (retrabalho) | Auxiliar, Contador | Alto | Dor 1, EVD-014 |
| UX-PROB-002 | Informação de prazos/pendências dispersa em WhatsApp/planilhas — sem visão única | Todos | Alto | Dor 5/6, EVD-014 |
| UX-PROB-003 | Mesma tarefa precisa ser feita de forma diferente por usuário; sem padrão | Auxiliar | Médio | RSK-PB-003, lacuna de pesquisa |
| UX-PROB-004 | Mensagem de erro de validação ambígua → usuário não sabe se deve corrigir ou manter | Auxiliar | Médio | RN-001…005, Insight 2 |

---

## 8. Jornadas

### Jornada principal — Lançar e validar movimento (US-001)

| Etapa | Objetivo do usuário | Ação | Pensamento | Emoção | Problema | Oportunidade |
|---|---|---|---|---|---|---|
| 1. Selecionar cliente | Lançar sobre o cliente certo | Escolher cliente (busca/digitação) | "Preciso achar o cliente certo" | Neutro | Vários clientes | Busca com autocomplete |
| 2. Preencher lançamento | Registrar movimento | Preencher forma de lançamento | "Rápido, sem erro" | Focado | Campos demais = erro | Formulário enxuto, campos obrigatórios marcados |
| 3. Confirmar | Receber garantia de correção básica | Confirmar | "Será que está certo?" | Ansioso | Erro não detectado | Validação no momento da confirmação (UC-001) |
| 4. Ver resultado | Saber se houve inconsistência | Ler feedback | "O que significa?" | Confuso se ambíguo | Mensagem técnica | Mensagem com regra violada + ação (corrigir/manter) |
| 5. Corrigir (se aplicável) | Eliminar inconsistência | Editar/corrigir | "Errei, vou corrigir" | Aliviado | Retrabalho | Correção fluida sem recomeçar |
| 6. Conferência (contador) | Garantir qualidade técnica | Revisar lote | "Está correto o que foi lançado?" | Responsável | Responsabilidade alta | Filtrar por "pendente de conferência" (+ sinalizados) |

### Jornada secundária — Acompanhar prazos (US-002/US-003)

| Etapa | Objetivo | Ação | Pensamento | Emoção | Problema | Oportunidade |
|---|---|---|---|---|---|---|
| 1. Abrir calendário/lista | Ver próximos prazos | Acessar visão de obrigações | "O que vence esta semana?" | Atento | Vários clientes | Filtros por cliente/status/vencimento |
| 2. Notar atrasos/vencimentos | Não perder prazo | Ler status (em dia/a vencer/atrasado) | "Este está atrasado!" | Alerta | Depende de dados/obrigações cadastradas | Status automático (RN-006) + alerta visível |
| 3. Registrar entrega | Encerrar obrigação | Marcar "entregue" | "Enviei, concluído" | Satisfeito | Manual/vinculado a doc? | Registro de entrega simples + auditoria |

### Jornada terciária — Ver pendências por cliente (US-004)

| Etapa | Objetivo | Ação | Pensamento | Emoção | Problema | Oportunidade |
|---|---|---|---|---|---|---|
| 1. Visão por cliente | Saber quem está pendente | Abrir visão "pendências por cliente" | "Quem tenho que cobrar?" | Alerta | Disperso | Lista com resumo (atrasos + obrigações em aberto) |
| 2. Registrar/atualizar pendência | Manter registro vivo | Criar/atualizar status | "Registro para não esquecer" | Controlado | Hoje em WhatsApp | Registro com autor/data (RN-007/RF-009) |
| 3. Cobrar/solucionar | Resolver pendência | Mudar status p/ resolvida | "Resolvido" | Aliviado | — | Histórico rastreável |

### Jornada do documento — Receber/registrar documento (US-005)

| Etapa | Objetivo | Ação | Pensamento | Emoção | Problema | Oportunidade |
|---|---|---|---|---|---|---|
| 1. Receber documento | Guardar informação recebida | Anexar/descrever documento no cliente | "Não quero perder isso" | Aliviado | Hoje fica em WhatsApp | Registro mínimo rastreável |
| 2. Associar | Contextualizar documento | Vincular a pendência/obrigação existente **ou criar pendência a partir do documento (CA-002)** | "Para lembrar de tratar" | Focado | Vínculo que bloqueia = atrito | Vínculo opcional, sem bloqueio (RN-008) |
| 3. Registrar situação | Sinalizar estado | Marcar recebido/pendente | "Feito" | Satisfeito | — | Visível por cliente |

---

## 9. Arquitetura da informação

### Estrutura

- **Entidade central de navegação: CLIENTE** (detalhe com abas: Visão geral · Lançamentos · Obrigações/Prazos · Pendências · Documentos).
- **Visão transacional própria:** Lançamentos (com fila de conferência para o contador).
- **Visão transversal:** Obrigações/calendário (todos os clientes) e Pendências (todos os clientes).
- **Administração:** Clientes, Usuários/perfis, Parâmetros (obrigações, alertas), Backup.

### Categorias

- Clientes (cadastro + detalhe integrado).
- Lançamentos (listagem + conferência).
- Obrigações e prazos (calendário/lista por status).
- Pendências por cliente.
- Documentos (registro mínimo anexável a cliente/pendência/obrigação).
- Configurações/Administração (usuários, perfis, parâmetros, backup).

### Navegação

- Navegação primária por **menu lateral/esquerdo**: Clientes | Lançamentos | Obrigações | Pendências | Documentos | Configurações.
- **Número de ações por fluxo:** independe do nível — para MVP manter fluxos de 2–4 passos (formulário → confirmação → resultado).
- **Perfil do usuário** condiciona visibilidade/ações (**RF-002, UC-005, RNF-003/004**): auxiliar lança e registra documentos; contador confere e gerencia parâmetros; atendimento vê pendências/clientes e registra documentos/pendências; **sócio/gestor — somente leitura/consulta (visão RF-008), sem ações de escrita** (menor privilégio). Matriz perfil→área a detalhar nos wireframes (ver PEN-UX-007).

### Organização de conteúdo

- Resumo do cliente: foto/nome, CNPJ, regime, contato, **status de pendências/prazos em destaque** (badges: atrasado, pendência, obrigação a vencer).
- Listas ordenáveis/filtráveis por status e vencimento.

---

## 10. Fluxos

### Fluxo principal — Lançamento (UC-001/US-001)

1. Abrir "Lançamentos → Novo lançamento".
2. Selecionar cliente (com autocomplete) e período.
3. Preencher data, valor, natureza (débito/crédito), descrição (campos obrigatórios marcados — RN-001).
4. Confirmar.
5. Sistema valida **no momento da confirmação** (UC-001): obrigatórios, balanceamento (se modelo agrupado confirmado), duplicidade, período (RN-002…004).
6. Resultado:
   - **Gravado OK** → status "pendente de conferência" + auditoria.
   - **Sinalizado** → lançamento gravado com marcação de inconsistência, ficando para conferência (RN-005); usuário vê mensagem com a regra e a opção de corrigir ou manter.
   - **Duplicidade** → **exige confirmação explícita do usuário (corrigir/manter) antes da gravação** (US-001 CA-003); detalhes condicionados a PEN-REQ-001 (política de sinalização).
7. Contador abre fila de conferência, filtra "pendente/sinalizado", confere e atualiza status (RF-005).

### Fluxos alternativos

- **Edição/exclusão de lançamento (RF-012):** conforme política PEN-REQ-002 (a confirmar). Direção exploratória: editar mantém trilha; exclusão exige confirmação e auditoria; edição de lançamento conferido **reabre** conferência.
- **Cadastro de cliente:** formulário curto; CNPJ único.
- **Cadastro de obrigação:** cliente + nome + vencimento + responsável + parâmetro de alerta (RNF-008).
- **Registro de documento mínimo (US-005):** anexar arquivo/descrição a cliente com situação (recebido/pendente); vínculo **opcional** a pendência/obrigação existente; **na ausência da pendência, permitir criá-la a partir do documento (CA-002)** — o vínculo não bloqueia o registro (RN-008).

### Estados de erro

- Campos obrigatórios ausentes → **bloqueio com mensagem listando os campos** (consenso PEN-REQ-001; RN-001).
- Duplicidade/balanceamento/período → **sinalização com explicação da regra** + opção corrigir/manter (RN-002…004).
- Falha de rede/conexão → mensagem clara, **nenhuma gravação parcial** (UC-001 exceção).
- Credenciais inválidas → bloqueio de autenticação; ação não permitida → negada com mensagem (UC-005).

---

## 11. Interações

| Elemento | Ação | Resposta esperada | Estado | Observação |
|---|---|---|---|---|
| Formulário de lançamento | Preencher campos | Marcação visual de obrigatórios; (futuro) validação inline | Dinâmico | Validação de confirmação é requisito (UC-001); inline é melhoria |
| Botão "Confirmar" | Submeter | Processa validação e mostra resultado (gravado/sinalizado) | Loading → Resultado | Evita double submit |
| Mensagem de inconsistência | Visualizar | Mensagem com regra violada + ação (corrigir/manter) | Visível | Crucial p/ confiança (Insight 2) |
| Lista de pendências | Atualizar status | Mudança de status com autor/data (RN-007) | Atualizado | Histórico visível |
| Obrigação | Marcar "entregue" | Status vira "entregue" (RN-006) + auditoria | Concluído | Registro simples |
| Busca de cliente | Digitar | Autocomplete | Lista filtrada | Reduz erro de seleção |
| Exclusão de lançamento | Confirmar exclusão | Diálogo de confirmação + auditoria (quando política definida) | Confirmado | Depende de PEN-REQ-002 |

---

## 12. Protótipos

| Artefato | Versão | Objetivo | Status | Referência |
|---|---|---|---|---|
| Wireframe de navegação (menu lateral + telas principais) | rascunho 1.0 | Validar arquitetura da informação com usuários | Produzidos (WIRE-001 v1.1) — validar com usuários (PEN-PB-003) | Exploratório — NÃO fechado |
| Wireframe do formulário de lançamento | rascunho 1.0 | Validar fluxo de validação e mensagem de inconsistência | Produzidos (WIRE-001 v1.1) — validar com usuários (PEN-PB-003) | Exploratório |
| Wireframe do dash "Pendências por cliente" | rascunho 1.0 | Validar visão central para contador/atendimento | Produzidos (WIRE-001 v1.1) — validar com usuários (PEN-PB-003) | Exploratório |
| Fluxo de obrigações/status | rascunho 1.0 | Validar estado canônico + alerta | Produzidos (WIRE-001 v1.1) — validar com usuários (PEN-PB-003) | Exploratório |

> **Decisão exploratória explícita:** NÃO produzir protótipos de alta fidelidade agora; produzir wireframes de baixa fidelidade **para validação com auxiliares + 1 cliente** (PEN-PB-003). Evita retrabalho se a validação mudar fluxos.

---

## 13. Hipóteses de UX

| ID | Hipótese | Como validar | Resultado | Status |
|---|---|---|---|---|
| HYP-UX-001 | "Começar do cliente" (navegação centrada em cliente) reduz o esforço para saber pendências/prazos | Teste com contador/atendimento em wireframes (PEN-PB-003) | — | Em validação |
| HYP-UX-002 | Validação na confirmação + mensagem explicativa reduz retrabalho sem perder velocidade | Teste de lançamento com auxiliar (PEN-PB-003) | — | Em validação |
| HYP-UX-003 | Sinalizar (não bloquear) inconsistências mantém o fluxo sem fragilizar conferência | Observar uso real pós-MVP + conferência do contador | — | Em validação |
| HYP-UX-004 | Painel único de pendências por cliente substitui a dispersão em WhatsApp | Entrevista de tarefa com contador (PEN-PB-003) | — | Em validação |

---

## 14. Acessibilidade

### Necessidades consideradas

- Uso desktop; perfis heterogêneos; leitura confortável e contraste (RNF-010, prioridade baixa).

### Critérios (mínimos — RNF-010)

- Contraste suficiente entre texto e fundo.
- Fonte/tamanho ajustável (zoom de sistema/tela).
- Navegação por teclado e foco visível (essencial para formulários).
- Labels explícitas nos campos (não apenas placeholder).

### Pendências

- Validar necessidades específicas de acessibilidade dos usuários na pesquisa (PEN-PB-003).
- Critérios WCAG AA "essencial" a confirmar na implementação (a prioridade é baixa no MVP).

---

## 15. Conteúdo

### Mensagens

> **Exemplos exploratórios** — textos finais dependem dos golden cases aprovados pelo contador (PEN-PB-002). Não tratar como redação definitiva.

- De validação (ex.: "Cliente é obrigatório." / "Verifique: lançamento parece duplicado." / "Soma de débitos difere de créditos." / "Data fora do período.").
- De estado (ex.: "Pendente de conferência", "Conferido", "Entregue", "Atrasado").
- De erro de sistema (ex.: "Não foi possível salvar. Verifique a conexão e tente novamente.") — sem gravação parcial.

### Labels

- Términos curtos e do domínio: Cliente, Lançamento, Obrigação, Pendência, Conferência, Entregue, Atrasado, A vencer.

### Feedback ao usuário

- Sucesso: "Lançamento salvo com status pendente de conferência." + link para novo lançamento.
- Inconsistência: mensagem com regra + ações (Corrigir / Manter para conferência).
- Atualização de status: confirmação + trilha (autor/data).

### Estados vazios

- Sem clientes: "Cadastre o primeiro cliente para começar."
- Sem lançamentos no período: "Nenhum lançamento neste período."
- Sem pendências: "Nenhuma pendência para este cliente." (estado positivo de confiança).

### Erros

- Campos obrigatórios ausentes listados claramente (RN-001, bloqueio).
- Duplicidade/balanceamento/período explicados com possibilidade de ação (RN-002…004).
- Falha de conexão → mensagem sem gravação parcial.

---

## 16. Decisões de UX

| ID | Decisão | Motivo | Evidência | Data |
|---|---|---|---|---|
| UX-DEC-001 | Exploratório: **começar pela arquitetura da informação e navegação centrada em cliente** (prototipar 3 visões: lançamento, prazos, pendências) | Núcleo do valor; insumo direto p/ validação | EVD-014, Insight 1/3 | 2026-09-22 |
| UX-DEC-002 | Validação **no momento da confirmação** com mensagem explicativa + ação (corrigir/manter) | UC-001 (REQ-001); evita bloqueio cego | RN-001…005 | 2026-09-22 |
| UX-DEC-003 | Sinalizar (não bloquear) inconsistências não obrigatórias; **bloquear apenas obrigatórios ausentes** | Política de sinalização (PEN-REQ-001); RN-001 | RN-001…005 | 2026-09-22 |
| UX-DEC-004 | Não produzir alta fidelidade até PEN-PB-003 | Condição do gate de requisitos; evita retrabalho | REQ-001 §20 | 2026-09-22 |
| UX-DEC-005 | Perfis condicionam visibilidade/ações; contador vê conferência e parâmetros | RNF-003/004 | REQ-001 | 2026-09-22 |
| UX-DEC-006 | Fluxos curtos (2–4 passos por ação) para reduzir rejeição dos auxiliares | Aceitação (RSK-PB-003); Insight 4 | RSK-PB-003 | 2026-09-22 |

---

## 17. Riscos

| ID | Risco | Impacto | Mitigação |
|---|---|---|---|
| RSK-UX-001 | Diretrizes de UX baseadas apenas no auto-relato do solicitante (auxiliares não ouvidos) | Aceitação | Validar wireframes com auxiliares (PEN-PB-003) antes de fechar |
| RSK-UX-002 | Mensagens de validação ambíguas → usuário mantém erro por engano | Falsa confiança | Golden cases + revisão de linguagem com contador (PEN-PB-002/003) |
| RSK-UX-003 | Fluxo com muitos passos → rejeição dos auxiliares | Abandono | Teste de tarefa; fluxos curtos; UX-DEC-006 |
| RSK-UX-004 | Confundir UX exploratório com aprovação definitiva | Retrabalho | Registrar status/condições (este doc) e versionar |
| RSK-UX-005 | Concorrência multi-estação (dec-002/RNF-002): dois usuários alteram o mesmo dado ao mesmo tempo → perda de atualização/estado obsoleto (ex.: dois auxiliares no mesmo lançamento; duas cobranças simultâneas — US-004 §9) | Dado incorreto/desatualizado | Direção exploratória: aviso de dado obsoleto, bloqueio otimista/refresh antes dos wireframes colaborativos (PEN-UX-005); tratar na Arquitetura |

---

## 18. Dependências

- PEN-PB-002 — regras exatas de validação (+ modelo de lançamento) para refinar mensagens/rótulos exatos.
- PEN-PB-003 — validação com auxiliares e 1 cliente (bloqueia fechamento de telas/jornadas).
- PEN-PB-004 — obrigações/prazos específicos para o calendário real.
- **PEN-REQ-001 — política de sinalização (bloquear vs sinalizar) da qual dependem UX-DEC-003 e o fluxo de duplicidade.**
- PEN-REQ-002 — política de edição/exclusão para fluxo de confirmação.
- PEN-PB-006 — modelo de acesso (não bloqueia UX, confirma estações/máquinas para testes).

---

## 19. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| ctx-002 | Restrições (multi-estação, dev único, on-premise) | Navegação/simplicidade; protótipos locais |
| dec-001 | Escopo MVP (validação+prazos+pendências) | Prioridade das telas propostas |
| dec-002 | Acesso multi-estação | Testes em 2 estações; navegação de perfis |
| rsk-001 | Tensão desktop × clientes externos | Portal fora; apenas uso assistido no fluxo atual |
| apd-002 | Subagente indisponível (free tier) | Nota de governança + reviewer |

---

## 20. Memórias candidatas

| Informação | Tipo | Evidência | Confiança | Motivo |
|---|---|---|---|---|
| "Navegação centrada em cliente" proposta como direção de UX | decisão (preliminar) | EVD-014, reconhecida como hipótese HYP-UX-001 | medium | Influencia Arquitetura e futuras validações; consolidar só após PEN-PB-003 |
| Rejeição de alta fidelidade prematura (fluxo exploratório) | aprendizado (processo) | Condição do gate de requisitos | high | Evita retrabalho em etapas futuras |

---

## 21. Rastreabilidade

| Problema | Insight | Jornada | Fluxo | Decisão | Requisito | Teste |
|---|---|---|---|---|---|---|
| Dor 1 (erro/retrabalho) | Insight 2 | Jornada principal | Lançamento | UX-DEC-002/003 | RF-003/004/005, RN-001…005, UC-001 | Funcional + golden (PEN-PB-002) |
| Dor 5 (prazo) | Insight 1 | Jornada secundária | Obrigações | UX-DEC-001 | RF-006/007, RN-006, UC-002 | Funcional + golden |
| Dor 6 (pendências) | Insight 3 | Jornada terciária | Pendências | UX-DEC-001 | RF-008/009, RN-007, UC-003 | Funcional |
| Dor 2/6 (documento mínimo) | Insight 3 | Jornada do documento | Documento | UX-DEC-001 | RF-010, RN-008, UC-004 | Funcional |
| Segurança/acesso | — | — | Autenticação/perfis | UX-DEC-005 | RF-002, UC-005, RNF-003/004 | Segurança |
| Aceitação (RSK-PB-003) | Insight 4 | — | Fluxos curtos | UX-DEC-006 | RNF-010, RSK-PB-003 | Teste com usuários (PEN-PB-003) |
| Concorrência multi-estação | — | — | Lançamento/pendências em 2 estações | (Arquitetura) | RNF-002, dec-002 | Teste multi-estação (PEN-UX-005) |

> Não há superfície de UX para RF-011/RNF-001/RNF-005/RNF-007/RNF-009 (métricas, desempenho, alertas, logs, compatibilidade) — exclusão deliberada, tratadas em requisitos/arquitetura/testes.

---

## 22. Pendências

| ID | Pendência | Responsável | Prioridade | Impacto |
|---|---|---|---|---|
| PEN-UX-001 | Validar wireframes (navegação por cliente, fluxo de lançamento, visão de pendências **e fluxo de registro de documento — US-005**) com auxiliares e 1 cliente | UX + usuários | Alta | Fechamento de telas e fluxos (condição para Development) |
| PEN-UX-002 | Definir linguagem/mensagens de validação com o contador após golden cases | UX + contador | Alta | Mensagens finais |
| PEN-UX-003 | Confirmar perfil/papel do **sócio/gestor** (proposta exploratória: somente leitura/consulta) | Solicitante | Média | Escopo de telas |
| PEN-UX-004 | Reavaliar acessibilidade específica com usuários | UX | Baixa | Ajustes finos |
| PEN-UX-005 | Direção de concorrência multi-estação (aviso de dado obsoleto/bloqueio otimista) antes dos wireframes colaborativos | UX + Arquitetura | Alta | Robustez com 2 estações |
| PEN-UX-006 | Jornada mínima de "receber/registrar documento" para validar aceitação do re-cadastro manual | UX | Média | Validação US-005 |
| PEN-UX-007 | Matriz perfil→área (ações permitidas por perfil) explícita antes dos wireframes de perfis/documentos | UX + segurança | Alta | Permissão correta por perfil (RF-002/RNF-003/004) |

---

## 23. Gate de UX

### Checklist

- [x] Usuários foram considerados (premissas registradas; validação pendente — não tratado como fato).
- [x] Evidências foram registradas (e lacunas explicitadas).
- [x] Problemas de experiência foram identificados.
- [x] Jornadas foram analisadas (3 jornadas).
- [x] Arquitetura da informação foi considerada (centrada em cliente).
- [x] Fluxos principais foram definidos (lançamento, obrigações, pendências, documento).
- [x] Estados alternativos e de erro foram considerados.
- [x] Acessibilidade foi considerada (mínima, RNF-010).
- [x] Hipóteses relevantes foram identificadas (HYP-UX-001…004).
- [ ] Protótipos foram avaliados quando necessários — **NÃO avaliados com usuários ainda** (pendência PEN-PB-003; wireframes "A produzir" em §12).
- [x] Decisões foram registradas (UX-DEC-001…006).
- [x] Rastreabilidade foi estabelecida.

### Resultado

- [ ] Aprovado.
- [x] **Aprovado com pendências controladas.**
- [ ] Requer pesquisa adicional.
- [ ] Requer redesign.
- [ ] Bloqueado.

### Justificativa

A direção de UX está fundamentada nas evidências disponíveis e alinhada ao núcleo de valor. **Não é aprovação plena**: wireframes precisam ser validados com auxiliares e 1 cliente (PEN-PB-003) antes de fechar telas/fluxos, e as mensagens finais dependem de golden cases (PEN-PB-002). Decisões exploratórias (UX-DEC-001…006) são reversíveis. **Revisão independente pelo `reviewer` executada em 2026-09-22: veredito APROVADO COM CONDIÇÕES; correções P1–P10 incorporadas na v1.1** (P1/P2 obrigatórias antes dos wireframes das áreas afetadas; P3–P10 recomendações incorporadas). O gate final de UX será uma nova avaliação após PEN-PB-003.

---

## 24. Referências

- `projetos/imperacont/product/PB-001-product-brief.md` v1.1
- `projetos/imperacont/product/REQ-001-requirements-mvp.md` v1.1
- `projetos/imperacont/product/US-001…005-*.md`
- `projetos/imperacont/product/BACKLOG-001-mvp.md`
- `projetos/imperacont/discovery/DSC-001-discovery.md` v1.4
- `projetos/imperacont/product/WIRE-001-wireframes-mvp.md` v1.1
- `projetos/imperacont/product/PEN-CONTADOR-001-perguntas.md` v1.1
- `memoria/contexto/ctx-002-imperacont-restricoes.md`, `memoria/decisoes/dec-001`, `dec-002`, `memoria/riscos/rsk-001`, `memoria/aprendizados/apd-002`
- `templates/ux-design.md`, `workflows/03-ux-design.md`

---

## 25. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação exploratória (workflow 03) a partir de PB-001/REQ-001/US/BACKLOG; produzido pelo Squad Lead após indisponibilidade do ux-designer (apd-002) | Squad Lead |
| 1.1 | 2026-09-22 | Correções P1–P10 da revisão independente: P1 (fluxo documento + US-005 CA-002), P2 (perfil→área RF-002/UC-005/RNF-003/004 + sócio somente leitura + PEN-UX-007), P3 (duplicidade exige confirmação antes de gravar), P4 (RSK-UX-005/PEN-UX-005 concorrência multi-estação), P5 (PEN-UX-001 ampliado + jornada de documento), P6 (sem importação Excel), P7 (UX-DEC-006 fluxos curtos), P8 (PEN-REQ-001 em dependências), P9 (mensagens como exemplos exploratórios), P10 (tipografia, checklist protótipos, notas perfil) | Squad Lead (após revisão reviewer) |