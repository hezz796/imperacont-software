---
title: Perguntas ao contador — consolidação de pendências de domínio
type: dependencies
status: reviewed
scope: project
version: 1.1
project: imperacont-software
---

> **Nota de governança (Squad Lead):** documento consolidado em 2026-09-22 para destravar os gates de **Arquitetura** e **Development** do ImperaCont. Produzido pelo Squad Lead após indisponibilidade do `business-analyst` (apd-002). Consolida pendências já aprovadas (PEN-PB-002/004/006/007, PEN-REQ-001/002/003, PEN-UX-002/003/006/007) em perguntas objetivas — não introduz regras novas. Observações: PEN-UX-002 é atendida por **insumos** (Q2/Q6/Q12) — mensagens finais dependem dos golden cases; PEN-UX-007 é atendida por **Q24 (matriz perfil→ação)**. Pode ser respondido pelo próprio solicitante (contador titular) ou repassado a um contador colega para validação independente (apd-001 — fonte única).

# Perguntas ao contador — ImperaCont MVP 1

## 1. Objetivo

Coletar as decisões de **domínio contábil** que a squad não pode inventar, para destravar:

| Gate | Depende de |
|---|---|
| **Arquitetura** | PEN-PB-006 (acesso) + modelo de lançamento (parte de PEN-PB-002) |
| **Development** | PEN-PB-002 (golden cases) + PEN-PB-003 (validação usuários) + PEN-REQ-002 |

## 2. Instruções

- Responda com o **máximo de precisão**: cada resposta vira regra de negócio ou critério de aceite.
- Onde não souber, responda "não sei" em vez de chutar — melhor explicitamente incerto do que regra falsa.
- Para validação de lançamentos (seção 3) **e de obrigações/status (seção 4)**, forneça **3–5 casos reais por regra** (golden cases). Use o formato de exemplo das próprias seções; números fictícios são aceitáveis.
- Este documento NÃO pede nada de fora do MVP: escrituração formal, NF, SPED, folha e portal do cliente seguem fora de escopo.

---

## 3. Validação de lançamentos (PEN-PB-002 + PEN-REQ-001)

> Destrava: RF-003/004/005, RN-002…004, testes, mensagens de validação (PEN-UX-002). **Bloqueia Development.**

### 3.1 Modelo do lançamento

**Q1 — Como o escritório lança hoje?** Assinale o modelo dominante:

- [ ] **Unitário:** cada linha é um lançamento (ex.: um lançamento "cliente pagou R$ 1.000,00" com natureza débito OU crédito).
- [ ] **Agrupado:** um lançamento tem cabeçalho e múltiplas linhas de débito/crédito que precisam **bater** (ex.: compra em várias contas).
- [ ] **Misto:** maioria unitário, alguns agrupados.

Impacto: define RN-002 (se agrupado, valida balanceamento; se unitário, não aplica) e o formulário de lançamento (UX-001).

### 3.2 Regras de validação desejadas

**Q2 — Para cada inconsistência, o sistema deve BLOQUEAR a gravação, apenas SINALIZAR e deixar gravar para conferência, ou EXIGIR CONFIRMAÇÃO DO USUÁRIO antes de gravar?** (Obrigatórios ausentes já bloqueiam — consenso anterior.)

| Inconsistência | Bloquear | Sinalizar e gravar | Confirmar antes de gravar | N/A |
|---|---|---|---|---|
| Campo obrigatório ausente (cliente, data, valor, natureza) | ✔ (consenso) | | | |
| Duplicidade suspeita (mesmo cliente+data+valor+descrição) | | | | |
| Soma débito ≠ soma crédito (só se agrupado) | | | | |
| Data fora do período/competência informado | | | | |
| Outra regra que você use hoje: ______ | | | | |

> Observação: para a duplicidade, a direção atual (US-001 CA-003, UX-001) é "exigir confirmação antes de gravar"; confirme se concorda ou se prefere bloquear/sinalizar.

### 3.3 Definição de cada regra

**Q3 — Duplicidade:** o que configura uma duplicidade no seu escritório? (mesmo cliente + data + valor? + descrição? tolerância em minutos/dias?) _Descreva ou dê exemplos._

**Q4 — Período/competência:** o que é "data fora do período"? (Ex.: lançamento com data de 10/05 mas período informado = 06/2026?) _Descreva ou dê exemplos._

**Q5 — Balanceamento:** se o modelo for agrupado, o que conta como "bater"? Apenas valor total ou valor por conta/centro de custo?

### 3.4 Golden cases (crítico para testes)

**Q6 — Forneça 3–5 casos reais de lançamento **por regra** (duplicidade, balanceamento, período) com o resultado esperado da sua validação.** Use o formato:

```
Duplicidade — Exemplo: Cliente Y lançado 2x mesmo dia mesmo valor — SINALIZAR para confirmação.
Balanceamento — Exemplo: agrupado com débito 1.000 e crédito 900 — SINALIZAR diferença.
Período — Exemplo: data 10/05 em período 06/2026 — SINALIZAR período.
```

### 3.5 Conferência

**Q7 — O que o contador faz na conferência?** (ex.: revisa lote; marca "conferido"; corrige; devolve para o auxiliar corrigir). Quem pode corrigir um lançamento sinalizado após conferência?

Impacto: refina RN-005 e o fluxo de conferência (UX-001/US-001).

---

## 4. Obrigações e prazos (PEN-PB-004 + PEN-REQ-003)

> Destrava: RF-006/007, RN-006, calendário/status. **Bloqueia parcialmente o módulo de prazos.**

**Q8 — Quais obrigações o escritório precisa controlar no MVP 1?** Liste as de maior consequência (ex.: **DAS (Simples Nacional), IRPJ, CSLL, PIS/COFINS, DCTF Web, declarações anuais**…). Para cada uma: nome, periodicidade (mensal/trimestral/anual), data típica de vencimento.

> Atenção: o MVP controla apenas **registro, vencimento, status e entrega** — **não gera, não calcula e não envia** nenhuma obrigação. Obrigações que dependam de escrituração formal/SPED/folha estão **fora do MVP 1**.

**Q9 — Alerta "a vencer":** quantos dias antes do vencimento o aviso deve aparecer? (ex.: 5 dias, 7 dias, 10 dias).

**Q10 — Estados canônicos:** confirma o modelo **em dia → a vencer → atrasado → entregue**? Precisa de outro estado (ex.: "cancelada", "em elaboração")?

**Q11 — Registro de entrega:** o contador pode marcar "entregue" manualmente? Precisa anexar comprovante (arquivo) ou basta o registro com data/autor?

**Q12 — Golden cases de obrigações/status (RNF-005):** forneça **3–5 casos reais por regra** com datas concretas (hoje → vencimento → status esperado; e o que acontece após registrar entrega). Use o formato:

```
Hoje 15/06 — obrigação vence 30/06 — "a vencer".
Hoje 05/07 — obrigação venceu 30/06 sem entrega — "atrasado".
Hoje 05/07 — obrigação venceu 30/06 e foi entregue em 28/06 — "entregue".
```

**Q13 — Modelagem das obrigações:** os clientes do escritório têm regimes diferentes (Simples vs Lucro Presumido etc.)?

- [ ] Sim, há vários regimes / [ ] Não, todos no mesmo regime
- As obrigações são **padrão por regime** (aplicáveis a todos os clientes do regime) ou **configuradas caso a caso**? Quem é o **responsável típico** por entregar cada obrigação?

---

## 5. Edição e exclusão de lançamentos (PEN-REQ-002)

> Destrava: RF-012 e fluxo de edição/exclusão (UX-001). **Alta prioridade — risco contábil real.**

**Q14 — Quem pode editar/excluir lançamentos?**

- [ ] Somente o contador
- [ ] O próprio autor (auxiliar)
- [ ] Autor até a conferência; contador depois
- [ ] Outro: _____

**Q15 — Editar um lançamento já "conferido" deve reabrir a conferência?**

- [ ] Sim / [ ] Não / [ ] Outro: _____

**Q16 — Exclusão de lançamento conferido:**

- [ ] Permitida com confirmação + trilha
- [ ] Proibida (apenas cancelamento com motivo)
- [ ] Permitida só pelo contador
- [ ] Outro: _____

---

## 6. Métricas — baseline (PEN-PB-007)

> Destrava: capacidade de medir "redução de erros/prazos" (§15 PB-001). Precisa ser coletado ANTES do MVP rodar — é **levantamento manual do contador**, não log do sistema.

**Q17 — Baseline atual (mês vigente):**
- Erros corrigidos na conferência no último mês (aprox.): ______
- Obrigações entregues fora do prazo no último mês (aprox.): ______
- Saldo de obrigações hoje: ______

**Q18 — Está disposto a registrar esses números manualmente por 1–2 semanas para estabelecer a linha de base?**

---

## 7. Acesso multi-estação (PEN-PB-006)

> Destrava: **Arquitetura**. Não é pergunta contábil — é pergunta de operação/implementação.

**Q19 — Quantas estações usam o sistema ao mesmo tempo?** (1 PC só? 2? 3+?)

**Q20 — Simultaneidade:** precisa que duas pessoas **usem ao mesmo tempo** (ex.: auxiliar lançando enquanto contador vê pendências)?

**Q21 — Onde os dados ficam?** (ex.: um PC "servidor" do escritório; o notebook usado como base; outro). Quem liga/desliga essa máquina?

**Q22 — Backup:** qual opção prefere?

- [ ] Automático diário para HD externo
- [ ] Automático diário para pasta de rede
- [ ] Manual semanal
- [ ] Outro: _____

Quem valida o backup periodicamente?

---

## 8. Perfis e permissões (PEN-UX-003 + PEN-UX-007)

**Q23 — O perfil sócio/gestor deve ser SOMENTE LEITURA (ver pendências/prazos, sem lançar/editar)?**

- [ ] Sim, somente leitura
- [ ] Precisa lançar/editar também
- [ ] Não existe esse perfil no uso real
- [ ] Outro: _____

**Q24 — Matriz perfil→ação (PEN-UX-007):** indique quem pode fazer cada ação (marque os perfis):

| Ação | Auxiliar | Contador | Atendimento | Sócio/gestor |
|---|---|---|---|---|
| Lançar movimentações | | | | |
| Conferir lançamentos | | | | |
| Cadastrar/editar cliente | | | | |
| Cadastrar usuários | | | | |
| Ver pendências por cliente | | | | |
| Registrar documento | | | | |
| Configurar backup | | | | |

> A resposta ajuda a matriz perfil→área exigida antes de detalhar os wireframes de perfis/documentos.

---

## 9. Validação com usuários (PEN-PB-003)

> Destrava: fechamento de telas (UX) e aceitação. Não é pergunta contábil — é agendamento.

**Q25 — Quais pessoas (além de você) usarão o sistema?** Liste perfis e disponibilidade para uma sessão curta (30–60 min) de validação de wireframes/telas.

**Q26 — Um cliente pode ser usado como caso real de validação (uso assistido) ainda no MVP?** Se sim, qual perfil de cliente (simples, com poucos lançamentos)?

**Q27 — Rotina de re-cadastro de documentos (PEN-UX-006):** hoje os documentos chegam via WhatsApp e serão registrados manualmente no sistema. Quem fará esse re-cadastro? Qual volume diário aproximado? Esse re-cadastro manual é aceitável no MVP?

---

## 10. Resumo de impacto por resposta

| Seção | Perguntas | Destrava | Bloqueia |
|---|---|---|---|
| 3 | Q1–Q7 | RF-003/004/005, testes, mensagens | **Development** |
| 4 | Q8–Q13 | RF-006/007, RN-006, RNF-005 | Módulo de prazos |
| 5 | Q14–Q16 | RF-012 | **Development** |
| 6 | Q17–Q18 | Métricas de valor | Medição "redução" |
| 7 | Q19–Q22 | Arquitetura (PEN-PB-006) | **Arquitetura** |
| 8 | Q23–Q24 | Telas/perfis, matriz perfil→área | UX (perfis/documentos) |
| 9 | Q25–Q27 | Validação de UX e aceitação | **Development** (fechamento de telas) |

---

## 11. Rastreabilidade

| Pergunta | Requisito/Regra | Origem | Teste |
|---|---|---|---|
| Q1–Q2 | RN-002, RF-003/004 | PEN-PB-002, PEN-REQ-001 | Golden cases |
| Q3–Q6 | RN-003/004, RF-003/004 | PEN-PB-002 | Golden cases |
| Q7 | RN-005 | PEN-PB-002/003 | Funcional |
| Q8–Q12 | RF-006/007, RN-006, RNF-005 | PEN-PB-004, PEN-REQ-003 | Golden + funcional |
| Q13 | RF-006, RNF-008 | PEN-PB-004 | Modelagem / funcional |
| Q14–Q16 | RF-012 | PEN-REQ-002 | Funcional + segurança |
| Q17–Q18 | RF-011/métricas | PEN-PB-007 | Levantamento manual / registro de baseline |
| Q19–Q22 | RNF-002/006/009 | PEN-PB-006 (dec-002) | Arquitetura |
| Q23 | RF-002/RF-008 | PEN-UX-003 | Segurança/funcional |
| Q24 | RF-002, RNF-003/004 | PEN-UX-007 | Segurança (matriz perfil→ação) |
| Q25–Q26 | UX-001 | PEN-PB-003 | Teste com usuários |
| Q27 | RF-010, US-005 | PEN-UX-006 | Validação US-005 |

---

## 12. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Consolidação das pendências de domínio/operação em perguntas objetivas | Squad Lead (BA indisponível — apd-002) |
| 1.1 | 2026-09-22 | Correções P-A1…P-A9 da revisão independente: golden cases de obrigações/status (P-A1), contagem "por regra" (P-A2), opção "confirmar antes de gravar" (P-A3), matriz perfil→ação Q24 + claims PEN-UX-002/007 corrigidas (P-A4), escopo de Q8 (P-A5), modelagem por regime (P-A6), neutralidade Q14/Q22 (P-A7), rastreabilidade Q17–Q18 manual (P-A8), rotina de re-cadastro Q27 (P-A9) | Squad Lead (após revisão reviewer) |