---
title: User Story
type: user-story
status: draft
scope: project
version: 1
---

# US-002 — Acompanhar pendências e prazos por cliente

## 1. Identificação

- **ID:** US-002
- **Título:** Contador acompanha pendências e prazos por cliente
- **Épico:** Gestão de prazos e pendências
- **Feature:** Controle de prazos/obrigações + pendências (núcleo MVP)
- **Produto:** ImperaCont
- **Status:** Draft
- **Prioridade:** Alta
- **Responsável:** Business Analyst (a confirmar com contador)

---

## 2. História

> Como **contador titular**, quero **ver em uma única tela as pendências e os prazos de obrigações de cada cliente**, para **não perder prazo, saber quem está atrasado e priorizar corretamente**.

---

## 3. Contexto

Dores 5 (prazos de obrigações) e 6 (visão por cliente sobre pendências) do discovery. O sucesso declarado (EVD-014) = prazos cumpridos. O benchmark (BE-03) mostra controle de prazos como padrão do setor. A visão centralizada por cliente é o valor desta história.

---

## 4. Valor

### Valor para o usuário
Contador enxerga o risco de atraso antes que aconteça.

### Valor para o negócio
Menos multas por atraso; confiança dos clientes.

### Resultado esperado
% de obrigações entregues dentro do prazo (métrica §15 PB-001).

---

## 5. Critérios de aceitação

### CA-001 — Visão por cliente

**Dado que** existem clientes com obrigações e pendências cadastradas,
**Quando** acesso a visão de pendências/prazos,
**Então** vejo uma lista por cliente com obrigações (em dia, a vencer, atrasado) e pendências (abertas/em andamento/resolvidas).

### CA-002 — Filtros

**Dado que** a lista é grande,
**Quando** aplico filtro por cliente, status ou período,
**Então** a lista é filtrada corretamente.

### CA-003 — Status refletidos

**Dado que** uma obrigação passou da data de vencimento sem ser entregue,
**Quando** consulto a visão,
**Então** a obrigação aparece como "atrasada".

### CA-004 — Entrega registrada

**Dado que** marco uma obrigação como entregue,
**Quando** confirmo,
**Então** o status muda para "entregue" e a auditoria registra autor/data.

---

## 6. Regras de negócio

- RN-006 — Modelo canônico de estados de obrigação (em dia / a vencer / atrasado / entregue) — ver REQ-001 RN-006.
- RN-007 — Atualização de pendências registra autor e data.

---

## 7. Fluxo esperado

1. Abre visão de pendências/prazos.
2. Sistema agrega obrigações + pendências por cliente.
3. Usuário filtra e visualiza.
4. Usuário registra entrega/conclusão quando aplicável.
5. Status atualizado e auditado.

---

## 8. Cenários alternativos

- Pendência manual criada junto a uma obrigação.
- Obrigação sem vencimento → tratada como pendência manual.

---

## 9. Exceções e erros

- Dados não atualizados (obrigação cadastrada sem vencimento) → exibida com aviso.

---

## 10. Dependências

- RF-006/007 (obrigações/prazos), RF-008/009 (pendências).
- Catálogo de obrigações confirmado (PEN-CONTADOR-001 §10-A/Q8) e golden cases de status Q12 aprovados.

---

## 11. Fora do escopo

- Escrituração formal; entrega de SPED/obrigações completas (apenas status/registro de entrega).

---

## 12. Evidências

| Evidência | Fonte | Data | Observação |
|---|---|---|---|
| EVD-014 | Solicitante | 2026-09-22 | Prazos cumpridos |
| BE-03 | Benchmark | 2026-09-22 | Prazos via módulo dedicado |

---

## 13. Hipóteses

| Hipótese | Como validar | Status |
|---|---|---|
| Visão centralizada reduz atraso de prazos | Medir % de entrega no prazo (baseline antes do MVP) | não testada |

---

## 14. Riscos

| Risco | Impacto | Mitigação |
|---|---|---|
| Alertas incorretos → falsa segurança/multa (RSK-PB-008) | Alto | Golden cases + revisão periódica |

---

## 15. Rastreabilidade

| Origem | Requisito | História | Design | Arquitetura | Implementação | Teste |
|---|---|---|---|---|---|---|
| PB-001 §11.1 | RF-006…009 | US-002 | UX-001 | TBD | TBD | Funcional + golden |

---

## 16. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| ctx-003 | Resultado-alvo | Prazos cumpridos como métrica |

---

## 17. Memória candidata

| Informação | Tipo | Motivo | Confiança |
|---|---|---|---|
| Obrigações sem vencimento precisam cair como pendência manual | regra (a validar) | Evita falso "em dia" | medium |

---

## 18. Pronto para desenvolvimento

- [x] História compreendida.
- [x] Valor definido.
- [x] Critérios de aceitação definidos (provisórios).
- [x] Regras de status confirmadas (RN-006 + golden cases Q12 aprovados — PEN-CONTADOR-001 §10-A).
- [x] Dependências identificadas.
- [x] Riscos conhecidos.
- [x] Design necessário disponível (UX-001 v1.1; telas a validar em PEN-PB-003).
- [x] Arquitetura necessária disponível (ARC-001 v1.2 — stack C#/.NET confirmada).
- [x] Testabilidade confirmada (golden cases Q12 aprovados).

### Resultado

- [ ] Pronta.
- [x] Pronta com ressalvas (validação externa PEN-PB-003 pendente).
- [ ] Necessita refinamento.
- [ ] Bloqueada.

---

## 19. Resultado da implementação

**Implementação realizada:** (vazio)

**Arquivos/componentes afetados:** (vazio)

**Testes associados:** (vazio)

**Observações:** Pendência PEN-PB-004 (obrigações específicas) antes do refinamento do módulo de prazos.

---

## 20. Referências

- `projetos/imperacont/product/REQ-001-requirements-mvp.md`

---

## 21. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação | Squad Lead (subagente BA indisponível) |