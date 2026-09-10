---
title: Modularidade
description: Princípios para dividir software em partes compreensíveis, coesas e com responsabilidades bem definidas.
type: guide
status: active
scope: squad
tags:
  - modularidade
  - arquitetura
  - engenharia
---

# Modularidade

## Princípio

Software deve ser organizado em partes que possam ser compreendidas, modificadas, testadas e evoluídas com o mínimo de impacto desnecessário sobre outras partes.

Um módulo deve possuir uma responsabilidade suficientemente clara para que seus limites sejam compreendidos.

## Objetivos

A modularidade busca:

- reduzir complexidade;
- limitar impactos de mudanças;
- facilitar testes;
- melhorar compreensão;
- permitir evolução independente quando apropriado;
- tornar responsabilidades explícitas.

## Bons limites

Um limite modular deve considerar:

- responsabilidade;
- domínio;
- dependências;
- fluxo de dados;
- regras de negócio;
- necessidade de mudança;
- requisitos de qualidade.

## Evitar

Modularidade não significa criar o maior número possível de módulos.

Devem ser evitados:

- fragmentação excessiva;
- abstrações artificiais;
- módulos sem responsabilidade clara;
- dependências circulares;
- interfaces criadas sem necessidade;
- separações que aumentam complexidade sem benefício.

## Regra

A existência de um módulo deve possuir uma justificativa relacionada à compreensão, mudança, teste, isolamento ou evolução do sistema.

## Resultado esperado

O sistema deve possuir fronteiras que reduzam a complexidade em vez de apenas distribuí-la entre vários componentes.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `implementation`
- `refactoring`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`