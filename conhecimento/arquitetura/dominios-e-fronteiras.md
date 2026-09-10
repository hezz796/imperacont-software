---
title: Domínios e Fronteiras
description: Fundamentos para identificar responsabilidades, limites e contextos de um domínio de negócio dentro da arquitetura.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - dominio
  - fronteiras
  - modelagem
---

# Domínios e Fronteiras

## Conceito

Um domínio representa uma área de conhecimento ou atividade relevante para o produto.

A identificação de domínios ajuda a compreender responsabilidades e relações existentes.

## Fronteiras

Uma fronteira define onde determinado modelo, responsabilidade ou contexto deixa de ser aplicável.

Uma boa fronteira reduz ambiguidades.

## Contextos

Conceitos podem possuir significados diferentes em partes diferentes de uma organização.

Um mesmo termo pode representar entidades ou regras distintas dependendo do contexto.

## Linguagem

A linguagem do domínio deve ser considerada na definição das fronteiras.

Termos ambíguos são sinais de que o modelo pode precisar de maior esclarecimento.

## Responsabilidade

Cada fronteira deve possuir uma razão de existir.

Criar fronteiras apenas para aumentar o número de componentes pode aumentar complexidade sem produzir valor.

## Dependências entre domínios

Domínios podem depender uns dos outros.

Essas dependências devem ser compreendidas em termos de:

- informação;
- comportamento;
- contrato;
- direção;
- frequência;
- impacto de mudança.

## Consistência

Nem toda informação precisa possuir consistência global imediata.

A necessidade de consistência deve ser analisada de acordo com o domínio e o negócio.

## Evolução

Fronteiras podem mudar quando o entendimento do domínio melhora.

Arquitetura deve permitir que novos conhecimentos sejam incorporados sem exigir reestruturação indiscriminada.

---

## Relações na Squad

### Skills relacionadas

- `domain-modeling`
- `architecture-design`
- `product-modeling`

### Agentes relacionados

- `solution-architect`
- `business-analyst`

### Workflows relacionados

- `02-product-definition`
- `04-architecture`