---
title: Componente, Responsabilidade e Contrato
description: Estrutura a definição de componentes a partir de responsabilidade clara e contratos explícitos.
type: model
status: active
scope: squad
tags:
  - modelos
  - arquitetura
  - componentes
  - contratos
---

# Componente, Responsabilidade e Contrato

## Estrutura

```text
COMPONENTE
   ↓
RESPONSABILIDADE
   ↓
INTERFACE
   ↓
CONTRATO
   ↓
DEPENDÊNCIAS
```

## Componente

Unidade estrutural que possui uma responsabilidade dentro da solução.

## Responsabilidade

Aquilo pelo qual o componente é responsável.

## Interface

Forma pela qual outras partes interagem com o componente.

## Contrato

Expectativas explícitas sobre essa interação.

## Dependências

Elementos externos dos quais o componente depende.

## Perguntas

Para cada componente relevante:

- qual problema ele resolve?
- qual responsabilidade possui?
- o que ele conhece?
- do que depende?
- como outros componentes interagem com ele?
- quais mudanças devem permanecer isoladas?

## Objetivo

Evitar componentes que acumulam responsabilidades sem relação clara ou interfaces que escondem dependências importantes.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `api-design`
- `domain-modeling`
- `implementation`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`