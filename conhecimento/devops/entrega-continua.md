---
title: Entrega Contínua
description: Define princípios para manter o software em condição adequada para ser liberado de maneira controlada.
type: guide
status: active
scope: squad
tags:
  - devops
  - entrega-continua
  - release
  - qualidade
---

# Entrega Contínua

## Objetivo

Entrega contínua busca manter mudanças em estado suficientemente validado para que possam ser disponibilizadas quando apropriado.

## Princípios

O fluxo deve favorecer:

- automação;
- validação;
- rastreabilidade;
- repetibilidade;
- controle;
- recuperação.

## Separação entre entrega e liberação

Uma mudança pode estar pronta para entrega sem necessariamente ser disponibilizada imediatamente a todos os usuários.

Essa separação permite estratégias graduais e controladas.

## Qualidade

A condição de entrega deve considerar:

- requisitos;
- testes;
- riscos;
- segurança;
- observabilidade;
- dependências;
- critérios de release.

## Resultado

O processo deve reduzir a distância entre:

`mudança validada → software liberável`

sem eliminar os controles necessários.

---

## Relações na Squad

### Skills relacionadas

- `release-strategy`
- `release-planning`
- `deployment`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`