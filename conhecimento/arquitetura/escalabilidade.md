---
title: Escalabilidade
description: Fundamentos para compreender como sistemas lidam com crescimento de carga, dados, usuários e operações.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - escalabilidade
  - desempenho
  - capacidade
---

# Escalabilidade

## Conceito

Escalabilidade representa a capacidade de um sistema lidar com crescimento de demanda sem degradação inadequada de suas características relevantes.

## Crescimento

O crescimento pode ocorrer em:

- usuários;
- requisições;
- dados;
- transações;
- integrações;
- processamento.

Cada dimensão pode exigir respostas diferentes.

## Escalabilidade vertical

Consiste em aumentar recursos de uma unidade existente.

Pode ser simples, mas possui limites.

## Escalabilidade horizontal

Consiste em distribuir carga entre múltiplas unidades.

Pode aumentar capacidade, mas introduz desafios adicionais.

## Estado

Estado compartilhado pode dificultar distribuição.

A arquitetura deve considerar onde o estado é mantido e como é sincronizado.

## Gargalos

A capacidade total de um sistema pode ser limitada por um único componente.

É importante identificar gargalos reais antes de introduzir complexidade.

## Desempenho versus escalabilidade

Desempenho trata do comportamento sob determinada carga.

Escalabilidade trata de como esse comportamento se altera quando a carga cresce.

São conceitos relacionados, mas não equivalentes.

## Capacidade

Decisões de capacidade devem considerar:

- carga esperada;
- crescimento;
- picos;
- custo;
- limites;
- margem operacional.

## Complexidade

Escalabilidade antecipada sem evidência pode aumentar custo de desenvolvimento e operação.

A arquitetura deve escalar de acordo com necessidades reais ou riscos suficientemente justificados.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `performance-testing`

### Agentes relacionados

- `solution-architect`
- `devops-engineer`

### Workflows relacionados

- `04-architecture`
- `06-quality`