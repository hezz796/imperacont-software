---
title: Adaptação entre Interfaces
description: Define o padrão de adaptação entre interfaces incompatíveis sem alterar diretamente as partes existentes.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - adaptacao
  - integracao
  - interfaces
---

# Adaptação entre Interfaces

## Problema

Duas partes precisam colaborar, mas possuem interfaces ou modelos incompatíveis.

## Intenção

Permitir colaboração sem obrigar cada parte a conhecer os detalhes internos da outra.

## Solução

Introduzir uma camada de adaptação que:

- recebe o formato esperado;
- transforma os dados;
- traduz comportamentos quando necessário;
- apresenta a interface compatível.

## Benefícios

Pode reduzir:

- dependência direta;
- impacto de mudanças;
- necessidade de alterar sistemas existentes.

## Custos

A adaptação adiciona:

- código;
- manutenção;
- transformação;
- possibilidade de perda de informação;
- ponto adicional de falha.

## Quando utilizar

É especialmente útil quando:

- uma interface externa não pode ser alterada;
- dois modelos possuem diferenças legítimas;
- uma migração precisa ocorrer gradualmente.

## Cuidado

Não utilizar adaptação para esconder incompatibilidades que deveriam ser resolvidas na origem.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `implementation`
- `architecture-design`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`