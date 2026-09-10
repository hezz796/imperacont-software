---
title: Resiliência
description: Fundamentos para projetar sistemas capazes de lidar com falhas, degradações e recuperação sem perder controle operacional.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - resiliencia
  - falhas
  - recuperacao
---

# Resiliência

## Conceito

Resiliência é a capacidade de um sistema continuar funcionando adequadamente ou recuperar-se diante de falhas e condições adversas.

## Falhas são esperadas

Sistemas reais podem sofrer:

- indisponibilidade;
- falhas de rede;
- lentidão;
- corrupção;
- erros de software;
- sobrecarga;
- dependências externas indisponíveis.

Uma arquitetura robusta considera essas possibilidades.

## Isolamento

Falhas devem ser impedidas, quando possível, de se propagarem por todo o sistema.

## Degradação

Quando a funcionalidade completa não pode ser oferecida, pode existir uma forma degradada de operação.

A degradação precisa ser compatível com o domínio.

## Retry

Retentativas podem ajudar em falhas transitórias.

Entretanto, retries excessivos podem aumentar a sobrecarga e piorar a falha.

## Timeouts

Operações externas devem possuir limites de espera adequados ao contexto.

Esperas indefinidas podem consumir recursos e provocar efeito cascata.

## Recuperação

A arquitetura deve considerar:

- detecção;
- contenção;
- recuperação;
- validação;
- retorno à operação normal.

## Dados

Resiliência também envolve preservação e recuperação de dados.

## Teste

Resiliência não deve ser apenas uma propriedade declarada.

Quando a criticidade justificar, comportamentos diante de falhas devem ser avaliados de forma controlada.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `reliability-testing`
- `integration-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `06-quality`