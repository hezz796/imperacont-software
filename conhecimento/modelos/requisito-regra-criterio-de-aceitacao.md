---
title: Requisito, Regra e Critério de Aceitação
description: Diferencia requisitos, regras de negócio e critérios utilizados para verificar se uma entrega atende ao esperado.
type: model
status: active
scope: squad
tags:
  - modelos
  - requisitos
  - regras
  - aceitacao
---

# Requisito, Regra e Critério de Aceitação

## Relação

```text
REQUISITO
   ↓
REGRAS
   ↓
COMPORTAMENTO ESPERADO
   ↓
CRITÉRIOS DE ACEITAÇÃO
```

## Requisito

Define uma necessidade ou condição que a solução deve atender.

## Regra

Define uma condição, restrição ou comportamento obrigatório do domínio ou produto.

## Critério de aceitação

Define como verificar se o resultado atende ao requisito.

## Exemplo

```text
Requisito:
O sistema deve permitir registrar uma operação.

Regra:
A operação não pode ser registrada sem os dados obrigatórios.

Critério:
Dado que um campo obrigatório esteja ausente,
quando o usuário tentar registrar,
então o sistema deve impedir o registro
e informar o problema.
```

## Benefício

A separação ajuda a evitar requisitos vagos.

## Cuidado

Critério de aceitação não deve ser utilizado para esconder requisitos inexistentes.

Se uma condição for realmente necessária ao produto, ela deve estar representada adequadamente no conjunto de requisitos.

---

## Relações na Squad

### Skills relacionadas

- `requirements-engineering`
- `acceptance-testing`
- `user-stories`

### Agentes relacionados

- `business-analyst`
- `test-engineer`

### Workflows relacionados

- `02-product-definition`
- `06-quality`