---
title: Domínio e Dados
description: Relaciona conceitos de domínio, regras de negócio e representação dos dados utilizados pelo produto.
type: guide
status: active
scope: squad
tags:
  - dados
  - dominio
  - negocio
  - modelagem
---

# Domínio e Dados

## Objetivo

O modelo de dados deve representar conceitos relevantes do domínio de maneira coerente.

## Conceitos

Um dado não deve ser analisado apenas pelo seu tipo técnico.

É necessário compreender:

- significado;
- finalidade;
- regras;
- relacionamentos;
- ciclo de vida;
- responsável.

## Domínio antes da estrutura

A estrutura de armazenamento deve decorrer do entendimento do domínio, e não o contrário.

## Linguagem

Termos importantes devem possuir significado consistente entre:

- produto;
- negócio;
- requisitos;
- arquitetura;
- dados;
- implementação.

## Responsabilidade

Quando possível, identificar quem é responsável por:

- definir;
- criar;
- alterar;
- validar;
- consumir;
- eliminar.

## Fronteiras

Dados podem possuir significados diferentes em diferentes contextos.

Não assumir que uma mesma estrutura representa necessariamente o mesmo conceito em todos os lugares.

## Regra

O modelo técnico deve servir ao modelo conceitual necessário para o produto.

---

## Relações na Squad

### Skills relacionadas

- `domain-modeling`
- `data-modeling`
- `product-modeling`

### Agentes relacionados

- `data-engineer`
- `business-analyst`

### Workflows relacionados

- `02-product-definition`
- `04-architecture`