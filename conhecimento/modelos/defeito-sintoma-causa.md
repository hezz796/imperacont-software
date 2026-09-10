---
title: Defeito, Sintoma e Causa
description: Diferencia manifestação observada, defeito identificado e causa provável ou confirmada.
type: model
status: active
scope: squad
tags:
  - modelos
  - defeitos
  - diagnostico
  - qualidade
---

# Defeito, Sintoma e Causa

## Estrutura

```text
OBSERVAÇÃO
   ↓
SINTOMA
   ↓
DEFEITO
   ↓
CAUSA
   ↓
AÇÃO CORRETIVA
   ↓
VALIDAÇÃO
```

## Observação

Aquilo que foi efetivamente percebido.

## Sintoma

Manifestação visível do problema.

## Defeito

Condição inadequada existente no produto ou processo.

## Causa

Fator que contribuiu para produzir o defeito.

A causa pode ser:

- conhecida;
- provável;
- ainda desconhecida.

## Cuidado

Não declarar causa sem evidência suficiente.

Uma hipótese causal deve ser diferenciada de uma causa confirmada.

## Ação corretiva

Deve considerar se é necessário:

- corrigir o defeito;
- eliminar ou reduzir a causa;
- melhorar detecção;
- reduzir impacto;
- alterar processo.

## Princípio

Corrigir o sintoma pode restaurar o comportamento, mas não necessariamente impede recorrência.

---

## Relações na Squad

### Skills relacionadas

- `root-cause-analysis`
- `test-design`
- `incident-response`

### Agentes relacionados

- `test-engineer`
- `software-engineer`

### Workflows relacionados

- `06-quality`
- `08-evolution`