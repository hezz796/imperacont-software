---
title: Versionamento de Dados
description: Define princípios para controlar mudanças em estruturas, contratos e informações de dados ao longo do tempo.
type: guide
status: active
scope: squad
tags:
  - dados
  - versionamento
  - mudancas
  - contratos
---

# Versionamento de Dados

## Objetivo

Mudanças em estruturas e contratos de dados devem ser controladas para reduzir impactos inesperados.

## Elementos que podem evoluir

- modelos;
- esquemas;
- contratos;
- eventos;
- APIs;
- transformações;
- migrações.

## Compatibilidade

Mudanças podem ser:

- compatíveis;
- parcialmente compatíveis;
- incompatíveis.

A classificação deve considerar os consumidores afetados.

## Estratégia

Uma mudança importante pode exigir:

1. introdução;
2. coexistência;
3. migração;
4. validação;
5. remoção da versão anterior.

## Rastreabilidade

Deve ser possível compreender:

- qual mudança ocorreu;
- por que ocorreu;
- quais consumidores foram afetados;
- como a transição será feita.

## Regra

Alterar a estrutura de dados sem avaliar seus consumidores pode produzir falhas fora do componente alterado.

---

## Relações na Squad

### Skills relacionadas

- `versioning`
- `data-modeling`
- `change-management`

### Agentes relacionados

- `data-engineer`

### Workflows relacionados

- `05-development`
- `07-delivery`