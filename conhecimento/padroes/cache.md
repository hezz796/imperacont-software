---
title: Cache
description: Define o uso de armazenamento temporário para reduzir custo ou latência de acesso a informações.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - cache
  - desempenho
  - escalabilidade
---

# Cache

## Problema

Uma informação é acessada frequentemente e sua obtenção possui custo significativo.

## Intenção

Reduzir latência, carga ou custo por meio de armazenamento temporário de resultados ou dados.

## Solução

Armazenar temporariamente uma representação que possa ser reutilizada durante determinado período ou condição.

## Benefícios

Pode melhorar:

- latência;
- capacidade;
- experiência;
- custo operacional.

## Custos

Cache introduz problemas como:

- invalidação;
- dados desatualizados;
- consumo de memória;
- complexidade;
- inconsistência.

## Perguntas essenciais

Antes de utilizar cache:

- o dado pode estar desatualizado?
- por quanto tempo?
- como será invalidado?
- o que ocorre quando o cache falhar?
- qual o custo de não utilizar cache?

## Princípio

Cache não deve ser utilizado para esconder problemas estruturais de desempenho sem antes compreender a causa do problema.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `implementation`
- `performance-testing`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`