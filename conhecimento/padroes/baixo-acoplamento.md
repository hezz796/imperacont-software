---
title: Baixo Acoplamento
description: Define o padrão de reduzir dependências desnecessárias entre partes de um sistema.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - acoplamento
  - arquitetura
  - modularidade
---

# Baixo Acoplamento

## Problema

Alterações em uma parte do sistema provocam impactos inesperados ou excessivos em outras partes.

## Intenção

Reduzir dependências desnecessárias entre componentes, módulos ou domínios.

## Solução

Utilizar:

- interfaces claras;
- contratos explícitos;
- encapsulamento;
- dependências mínimas;
- comunicação bem definida;
- responsabilidades coesas.

## Benefícios

Pode reduzir:

- impacto de mudanças;
- propagação de defeitos;
- dificuldade de testes;
- dependência entre equipes;
- custo de evolução.

## Cuidado

Baixo acoplamento não significa acoplamento zero.

Alguma dependência pode ser necessária.

O objetivo é controlar dependências relevantes.

## Custos

Buscar desacoplamento excessivo pode produzir:

- abstrações artificiais;
- duplicação;
- maior complexidade;
- comunicação indireta.

## Critério

A pergunta principal não é:

> "Como eliminar todo acoplamento?"

Mas:

> "Quais dependências precisam ser controladas e por quê?"

---

## Relações na Squad

### Skills relacionadas

- `implementation`
- `architecture-design`
- `integration-design`

### Agentes relacionados

- `software-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`