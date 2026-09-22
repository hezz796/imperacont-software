---
title: User Story
type: user-story
status: draft
scope: project
version: 1
---

# US-004 — Identificar e cobrar clientes pendentes

## 1. Identificação

- **ID:** US-004
- **Título:** Equipe identifica clientes com pendências e registra status/cobrança
- **Épico:** Gestão de clientes e pendências
- **Feature:** Gestão de clientes/pendências (núcleo MVP)
- **Produto:** ImperaCont
- **Status:** Draft
- **Prioridade:** Alta
- **Responsável:** Business Analyst (a confirmar com contador)

---

## 2. História

> Como **atendimento/administrativo**, quero **ver quais clientes estão pendentes (falta de documentos, obrigações em aberto) e registrar cobrança/status**, para **saber quem cobrar e em que situação cada cliente está**.

---

## 3. Contexto

Dor 6 (falta de visão por cliente sobre pendências e atrasos). A operação hoje depende de WhatsApp/Telegram (EVD-013) sem registro único. Esta história dá ao atendimento uma visão e um registro de cobrança simples.

---

## 4. Valor

### Valor para o usuário
Atendimento sabe o que cobrar e de quem.

### Valor para o negócio
Menos clientes esquecidos; documentos completos mais rapidamente.

### Resultado esperado
% de clientes com pendência registrada e atualizada (métrica §15 PB-001).

---

## 5. Critérios de aceitação

### CA-001 — Lista de pendentes

**Dado que** existem clientes com pendências (manuais ou derivadas de obrigações),
**Quando** acesso a visão "pendentes",
**Então** vejo a lista ordenável com status e responsável.

### CA-002 — Registro de cobrança

**Dado que** identifico um cliente pendente,
**Quando** registro uma ação de cobrança (data, canal, resultado),
**Então** a pendência/registro fica atualizado e rastreável.

### CA-003 — Atualização de status

**Dado que** resolvo uma pendência,
**Quando** marco como resolvida,
**Então** ela sai da lista de pendentes e a auditoria registra autor/data.

---

## 6. Regras de negócio

- RN-007 — Pendência com status (aberta, em andamento, resolvida); autor/data registrados.
- RN-008 — Documento vinculado registra situação.

---

## 7. Fluxo esperado

1. Abre visão de pendentes por cliente.
2. Lista clientes com pendências (manuais + derivadas).
3. Registra cobrança/ação.
4. Atualiza status quando resolvida.
5. Auditoria.

---

## 8. Cenários alternativos

- Pendência criada a partir de alerta de obrigação atrasada.
- Cobrança sem resposta → pendência permanece "em andamento".

---

## 9. Exceções e erros

- Duas pessoas cobram ao mesmo tempo (multi-estação) → manter histórico de ações.

---

## 10. Dependências

- RF-008/009 (pendências), RF-002 (perfis).
- Conceito de "pendência atualizada" (recência — PB-001 §15) a confirmar.

---

## 11. Fora do escopo

- Portal do cliente; comunicação automatizada (e-mail/SMS) — apenas registro manual.

---

## 12. Evidências

| Evidência | Fonte | Data | Observação |
|---|---|---|---|
| EVD-013 | Solicitante | 2026-09-22 | WhatsApp/Telegram hoje |
| EVD-014 | Solicitante | 2026-09-22 | Visibilidade de pendências |

---

## 13. Hipóteses

| Hipótese | Como validar | Status |
|---|---|---|
| Registro manual de cobrança já melhora visão (sem automatização) | Validar com atendimento (PEN-PB-003) | não testada |

---

## 14. Riscos

| Risco | Impacto | Mitigação |
|---|---|---|
| Não-aceitação pelo atendimento | Médio | Entrevistas/validação de fluxo |

---

## 15. Rastreabilidade

| Origem | Requisito | História | Design | Arquitetura | Implementação | Teste |
|---|---|---|---|---|---|---|
| PB-001 §11.1 | RF-008, RF-009 | US-004 | UX-001 | TBD | TBD | Funcional |

---

## 16. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| ctx-001 | Contexto | Operação WhatsApp/Telegram |

---

## 17. Memória candidata

| Informação | Tipo | Motivo | Confiança |
|---|---|---|---|
| Definição de "pendência atualizada" precisa de recência | decisão (pendente) | Métrica de visibilidade | medium |

---

## 18. Pronto para desenvolvimento

- [x] História compreendida.
- [x] Valor definido.
- [x] Critérios de aceitação definidos (provisórios).
- [ ] Definição de recência confirmada (pendente).
- [x] Dependências identificadas.
- [x] Riscos conhecidos.
- [ ] Design necessário disponível.
- [ ] Arquitetura necessária disponível.
- [ ] Testabilidade confirmada.

### Resultado

- [ ] Pronta.
- [x] Pronta com ressalvas.
- [ ] Necessita refinamento.
- [ ] Bloqueada.

---

## 19. Resultado da implementação

**Implementação realizada:** (vazio)

**Arquivos/componentes afetados:** (vazio)

**Testes associados:** (vazio)

**Observações:** PEN-PB-003 (validação com atendimento/auxiliares) antes do desenvolvimento.

---

## 20. Referências

- `projetos/imperacont/product/REQ-001-requirements-mvp.md`

---

## 21. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação | Squad Lead (subagente BA indisponível) |