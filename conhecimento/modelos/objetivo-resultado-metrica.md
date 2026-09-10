---
title: Objetivo, Resultado e Métrica
description: Diferencia intenção, resultado esperado e indicador utilizado para avaliar desempenho ou mudança.
type: model
status: active
scope: squad
tags:
  - modelos
  - produto
  - objetivos
  - metricas
---

# Objetivo, Resultado e Métrica

## Estrutura

```text
OBJETIVO
   ↓
RESULTADO ESPERADO
   ↓
MÉTRICA
   ↓
OBSERVAÇÃO
```

## Objetivo

Representa aquilo que se pretende alcançar.

## Resultado

Representa a mudança observável esperada.

## Métrica

Representa uma medida utilizada para acompanhar determinada dimensão do resultado.

## Exemplo

```text
Objetivo:
Melhorar a conclusão de uma tarefa.

Resultado:
Mais usuários conseguem concluir a tarefa.

Métrica:
Taxa de conclusão.
```

## Cuidado

Uma métrica não é automaticamente um objetivo.

O aumento de uma métrica pode ocorrer sem produzir valor real.

## Boa métrica

Uma métrica deve:

- ter definição clara;
- possuir contexto;
- ser interpretável;
- apoiar uma decisão;
- possuir fonte confiável.

## Pergunta

Sempre que uma métrica for proposta:

> "Que decisão essa métrica ajudará a tomar?"

---

## Relações na Squad

### Skills relacionadas

- `product-metrics`
- `product-definition`
- `product-analytics`

### Agentes relacionados

- `product-strategist`

### Workflows relacionados

- `02-product-definition`
- `08-evolution`