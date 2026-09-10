---
title: Rastreabilidade
description: Define como manter relações verificáveis entre necessidades, decisões, requisitos, mudanças, implementação e resultados.
type: guide
status: active
scope: squad
tags:
  - processos
  - rastreabilidade
  - evidencias
  - governanca
---

# Rastreabilidade

Rastreabilidade é a capacidade de relacionar elementos relevantes do trabalho ao longo do ciclo de vida.

## Relações possíveis

Conforme o contexto, pode existir relação entre:

```text
PROBLEMA
  ↓
HIPÓTESE
  ↓
OBJETIVO
  ↓
REQUISITO
  ↓
DECISÃO
  ↓
IMPLEMENTAÇÃO
  ↓
TESTE
  ↓
RELEASE
  ↓
RESULTADO
```

## Finalidade

A rastreabilidade ajuda a responder:

- por que algo existe;
- qual problema originou uma decisão;
- qual requisito uma mudança atende;
- como uma decisão foi validada;
- quais partes podem ser afetadas por uma mudança;
- qual resultado foi obtido.

## Proporcionalidade

Nem todo detalhe precisa ser rastreado formalmente.

O nível de rastreabilidade deve ser proporcional a:

- risco;
- impacto;
- complexidade;
- criticidade;
- necessidade de auditoria;
- expectativa de evolução.

## Rastreabilidade não é burocracia documental

O objetivo é preservar relações úteis.

Registrar informação que nunca será utilizada não necessariamente aumenta rastreabilidade.

## Evidência

Quando uma conclusão depende de evidência, deve ser possível identificar a origem dessa evidência quando isso for relevante para a decisão.

---

## Relações na Squad

### Skills relacionadas

- `technical-decisions`
- `change-management`
- `version-control-and-change-management`

### Agentes relacionados

- `squad-lead`
- `reviewer`

### Workflows relacionados

- `01-discovery`
- `02-product-definition`
- `03-ux-design`
- `04-architecture`
- `05-development`
- `06-quality`
- `07-delivery`
- `08-evolution`