---
title: User Story
type: user-story
status: draft
scope: project
version: 1
---

# US-001 — Lançar movimentação com validação

## 1. Identificação

- **ID:** US-001
- **Título:** Auxiliar lança movimentação financeira e recebe sinalização de inconsistência
- **Épico:** Lançamentos com validação
- **Feature:** Validação de lançamentos (núcleo MVP)
- **Produto:** ImperaCont
- **Status:** Draft
- **Prioridade:** Alta
- **Responsável:** Business Analyst (a confirmar com contador)

---

## 2. História

> Como **auxiliar/estagiário**, quero **lançar uma movimentação financeira de um cliente e receber sinalização imediata de inconsistências**, para **evitar erros e retrabalho na conciliação**.

---

## 3. Contexto

Dor 1 do discovery: ausência de validação gera erros e retrabalho (EVD-014: sucesso = menos erros/retrabalho). O padrão do setor (BE-01) inclui "análise crítica de lançamentos". No MVP, a validação **sinaliza** inconsistências (DEC-REQ-001) em vez de bloquear cegamente; **política provisória aplicada (RESUMO-001 A2):** duplicidade e período = confirmar antes de gravar (C); campos obrigatórios = bloqueio (RN-001); balanceamento N/A (modelo unitário). Validação externa com o contador permanece pendente (PEN-REQ-001).

---

## 4. Valor

### Valor para o usuário
Auxiliar lança com confiança e corrige erros antes da conferência do contador.

### Valor para o negócio
Menos retrabalho; redução de risco de erros contábeis (RSK-PB-002 mitigado com golden cases).

### Resultado esperado
Lançamentos conferidos com menos correções pós-lançamento (métrica §15 do PB-001).

---

## 5. Critérios de aceitação

### CA-001 — Lançamento válido

**Dado que** estou autenticado com perfil de lançamento e um cliente cadastrado,
**Quando** lanço uma movimentação preenchendo cliente, data, valor, natureza (débito/crédito) e descrição,
**Então** o sistema grava o lançamento com status "pendente de conferência" e não apresenta inconsistências.

### CA-002 — Obrigatório ausente

**Dado que** lanço uma movimentação sem preencher campos obrigatórios (cliente, data, valor, natureza),
**Quando** confirmo o lançamento,
**Então** o sistema sinaliza quais campos estão faltando e impede a gravação.

### CA-003 — Duplicidade suspeita

**Dado que** já existe lançamento com mesmo cliente, data e valor,
**Quando** confirmo um lançamento com esses mesmos dados,
**Então** o sistema apresenta "Já existe lançamento parecido" com [Corrigir] [Manter mesmo assim] — exige confirmação do usuário antes de gravar (**política C confirmada — RESUMO-001 A2a/A3 + golden cases Q6a**); manter grava sinalizado para conferência.

### CA-004 — Feedback visível

**Dado que** uma inconsistência é detectada,
**Quando** o lançamento é confirmado,
**Então** o sistema apresenta mensagem/clara indicando a inconsistência e o lançamento fica identificável para revisão do contador.

---

## 6. Regras de negócio

- RN-001 — Campos obrigatórios (cliente, data, valor, natureza): bloqueio por exceção consensual.
- RN-002 — Desbalanceamento débito/crédito: **não se aplica no MVP** (modelo unitário — direção provisória RESUMO-001 A1/A2b; agrupado fora do escopo).
- RN-003 — Duplicidade: **cliente + data + valor** (definição **confirmada** — golden cases Q6a) → **política C**: avisa "Já existe lançamento parecido", [Corrigir] [Manter mesmo assim]; manter grava sinalizado (RESUMO-001 A2a/A3).
- RN-004 — Período/competência inconsistente: **data ≠ período selecionado** → **política C**: avisa, usuário corrige ou mantém sinalizado (RESUMO-001 A2c/A4).
- RN-005 — Lançamento sinalizado exige conferência do contador antes de status "conferido"; conferência em lote (RESUMO-001 A5).
- RF-012 — Edição/exclusão (direção provisória RESUMO-001 C): autor até conferir; contador depois; edição de conferido reabre conferência; exclusão de conferido = cancelamento com motivo, só contador.

---

## 7. Fluxo esperado

1. Seleciona cliente e período.
2. Preenche dados do lançamento.
3. Confirma o lançamento.
4. Sistema valida **no momento da confirmação** (RN-001…004).
5. Apresenta resultado (gravado OK ou sinalização).
6. Lançamento registrado com status "pendente de conferência" + auditoria.

---

## 8. Cenários alternativos

- Correção de dados do lançamento após sinalização.
- Manutenção do lançamento com sinalização (encaminhado para conferência).

---

## 9. Exceções e erros

- Cliente/usuário inválido → bloqueio com mensagem.
- Falha de rede → mensagem de erro; sem gravação parcial.

---

## 10. Dependências

- RF-001 (cliente cadastrado), RF-002 (usuário/perfil), RF-004 (validação), RF-005 (conferência).
- Regras de validação **confirmadas com golden cases** (PEN-CONTADOR-001 §10-A Q6a/Q6b); validação externa (PEN-PB-003) pendente.

---

## 11. Fora do escopo

- Escrituração formal/balancete; NF-e; SPED.
- Conciliação bancária automática.

---

## 12. Evidências

| Evidência | Fonte | Data | Observação |
|---|---|---|---|
| EVD-014 | Solicitante | 2026-09-22 | Sucesso = menos erros/retrabalho |
| BE-01 | Benchmark | 2026-09-22 | Validação como padrão |

---

## 13. Hipóteses

| Hipótese | Como validar | Status |
|---|---|---|
| Regras simples já reduzem erros (HYP-005) | Testar com volume real | não testada |

---

## 14. Riscos

| Risco | Impacto | Mitigação |
|---|---|---|
| Regras de validação mal especificadas (RSK-PB-002) | Alto | Golden cases com contador antes do dev |

---

## 15. Rastreabilidade

| Origem | Requisito | História | Design | Arquitetura | Implementação | Teste |
|---|---|---|---|---|---|---|
| PB-001 §11.1 | RF-003, RF-004, RF-005 | US-001 | UX-001 | TBD | TBD | Teste funcional + golden |

---

## 16. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| ctx-003 | Resultado-alvo | Foco em redução de erros |

---

## 17. Memória candidata

| Informação | Tipo | Motivo | Confiança |
|---|---|---|---|
| Política de "sinalizar vs bloquear" depende do contador | decisão (pendente) | Evita assumir regra de domínio | medium |

---

## 18. Pronto para desenvolvimento

- [x] História compreendida.
- [x] Valor definido.
- [x] Critérios de aceitação definidos (confirmados com golden cases Q6a/Q6b).
- [x] Regras de negócio confirmadas (golden cases aprovados — PEN-CONTADOR-001 §10-A); validação externa (PEN-PB-003) pendente.
- [x] Dependências identificadas.
- [x] Riscos conhecidos.
- [x] Design necessário disponível (UX-001 v1.1; telas a validar em PEN-PB-003).
- [x] Arquitetura necessária disponível (ARC-001 v1.2 — stack C#/.NET confirmada).
- [x] Testabilidade confirmada (golden cases Q6a/Q6b aprovados).

### Resultado

- [ ] Pronta.
- [x] Pronta com ressalvas (validação externa PEN-PB-003 pendente).
- [ ] Necessita refinamento.
- [ ] Bloqueada.

---

## 19. Resultado da implementação

**Implementação realizada:** (vazio — não implementada)

**Arquivos/componentes afetados:** (vazio)

**Testes associados:** (vazio)

**Observações:** Golden cases Q6a/Q6b aprovados (PEN-CONTADOR-001 §10-A) — regras RN-003/004 confirmadas; resta validação externa (PEN-PB-003).

---

## 20. Referências

- `projetos/imperacont/product/REQ-001-requirements-mvp.md`

---

## 21. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação | Squad Lead (subagente BA indisponível) |