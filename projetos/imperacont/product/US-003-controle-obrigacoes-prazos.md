---
title: User Story
type: user-story
status: draft
scope: project
version: 1
---

# US-003 — Controlar obrigações e prazos

## 1. Identificação

- **ID:** US-003
- **Título:** Equipe controla obrigações e prazos por cliente
- **Épico:** Gestão de prazos e pendências
- **Feature:** Controle de prazos/obrigações (núcleo MVP)
- **Produto:** ImperaCont
- **Status:** Draft
- **Prioridade:** Alta
- **Responsável:** Business Analyst (a confirmar com contador)

---

## 2. História

> Como **equipe do escritório**, quero **cadastrar obrigações e respectivos prazos por cliente e manter um calendário com status**, para **não perder uma obrigação acessória e ter visão de cada prazo**.

---

## 3. Contexto

Dor 5 (risco de perder prazos). O benchmark (BE-03) confirma controle de prazos como módulo/espaço padrão. Lista inicial **confirmada**: DAS, DCTF Web, IRPJ, CSLL, PIS, COFINS (PEN-CONTADOR-001 §10-A/Q8); o catálogo é **configurável** — ajustes por regime/cliente podem evoluir a lista sem alterar código.

---

## 4. Valor

### Valor para o usuário
Trace up de obrigações e prazos em um lugar confiável.

### Valor para o negócio
Mitigação de multas por atraso; cumprimento de prazos (EVD-014).

### Resultado esperado
Calendário de obrigações por cliente com status confiável.

---

## 5. Critérios de aceitação

### CA-001 — Cadastro de obrigação

**Dado que** um cliente existe,
**Quando** cadastro uma obrigação com nome, data de vencimento, responsável e periodicidade,
**Então** a obrigação aparece no calendário/lista do cliente com status inicial.

### CA-002 — Status automático por data

**Dado que** a data de hoje é posterior ao vencimento e a obrigação não foi entregue,
**Quando** visualizo o calendário,
**Então** a obrigação aparece como "atrasada".

### CA-003 — Alerta configurável

**Dado que** uma obrigação tem vencimento em X dias (parâmetro — **padrão 7 dias antes**, configurável, RESUMO-001 B2),
**Quando** o prazo entra na janela de alerta,
**Então** o sistema sinaliza "a vencer" e/ou emite alerta conforme configuração (RNF-008; validação externa pendente).

### CA-004 — Registro de entrega

**Dado que** marco a obrigação como entregue (com **data e autor obrigatórios**; anexo opcional — RESUMO-001 B4), incluso possibilidade de entrega em data diferente do vencimento,
**Quando** confirmo,
**Então** o status muda para "entregue" e a auditoria é registrada.

---

## 6. Regras de negócio

- RN-006 — Status automático (em dia / a vencer / atrasado / **entregue**) por vencimento e registro de entrega — modelo canônico no REQ-001 (RN-006); alerta "a vencer" **padrão 7 dias antes, configurável**; registro de entrega = **data + autor (anexo opcional)**; obrigação sem vencimento → pendência manual (direção provisória RESUMO-001 B2/B3/B4).
- RN-008 — Documento vinculado a obrigação (opcional) registra situação.

---

## 7. Fluxo esperado

1. Acessa calendário de obrigações por cliente.
2. Cadastra/edita obrigação (nome, vencimento, responsável, periodicidade).
3. Sistema calcula status por data.
4. Registra entrega quando aplicável.
5. Auditoria e visualização atualizada.

---

## 8. Cenários alternativos

- Obrigação recorrente (mensal, etc.) com repetição de prazos.
- Entrega antecipada ou atrasada registrada com data real.

---

## 9. Exceções e erros

- Obrigação sem vencimento → não gera status automático; vira pendência manual com aviso.
- Vencimento alterado → recalcular status e registrar histórico.

---

## 10. Dependências

- RF-001 (cliente), RF-006/007 (obrigações/alertas), RNF-005 (confiabilidade).
- Lista de obrigações específicas (PEN-PB-004) e política de parâmetros (PEN-REQ-001).

---

## 11. Fora do escopo

- Execução/envio automático de obrigações; integração com sistemas fiscais.

---

## 12. Evidências

| Evidência | Fonte | Data | Observação |
|---|---|---|---|
| EVD-014 | Solicitante | 2026-09-22 | Prazos cumpridos |
| BE-03 | Benchmark | 2026-09-22 | Controle de prazos padrão |

---

## 13. Hipóteses

| Hipótese | Como validar | Status |
|---|---|---|
| Obrigações por cliente podem ser padronizadas por regime | Confirmar lista com contador (PEN-PB-004) | não testada |

---

## 14. Riscos

| Risco | Impacto | Mitigação |
|---|---|---|
| Lista de obrigações desatualizada (RSK-PB-008) | Médio | Configuráveis, revisão periódica |

---

## 15. Rastreabilidade

| Origem | Requisito | História | Design | Arquitetura | Implementação | Teste |
|---|---|---|---|---|---|---|
| PB-001 §11.1 | RF-006, RF-007 | US-003 | UX-001 | TBD | TBD | Funcional + golden |

---

## 16. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| ctx-003 | Resultado-alvo | Prazos cumpridos |

---

## 17. Memória candidata

| Informação | Tipo | Motivo | Confiança |
|---|---|---|---|
| Obrigações mudam por norma → configuráveis | aprendizado (setor) | Mitiga RSK-PB-008 | medium |

---

## 18. Pronto para desenvolvimento

- [x] História compreendida.
- [x] Valor definido.
- [x] Critérios de aceitação definidos (provisórios).
- [x] Lista/parâmetros de obrigações confirmados (catálogo inicial — PEN-CONTADOR-001 §10-A/Q8).
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

**Observações:** PEN-PB-004 (obrigações específicas) antes do refinamento.

---

## 20. Referências

- `projetos/imperacont/product/REQ-001-requirements-mvp.md`

---

## 21. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação | Squad Lead (subagente BA indisponível) |