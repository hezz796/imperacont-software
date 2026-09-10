---
title: Composição de Componentes
description: Define o uso de componentes menores combinados para construir comportamentos mais complexos.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - composicao
  - modularidade
  - reutilizacao
---

# Composição de Componentes

## Problema

Uma solução cresce concentrando comportamento em estruturas grandes e difíceis de modificar.

## Intenção

Construir comportamentos maiores combinando partes menores e bem definidas.

## Solução

Cada componente deve possuir responsabilidade compreensível e interfaces adequadas.

Componentes podem ser combinados para produzir comportamentos mais complexos.

## Benefícios

Pode favorecer:

- reutilização;
- teste isolado;
- substituição;
- manutenção;
- evolução incremental.

## Custos

Composição excessiva pode gerar:

- cadeias difíceis de compreender;
- excesso de abstração;
- dificuldade de rastreamento;
- dependências indiretas.

## Critério

Um componente deve ser separado quando sua independência produzir benefício real.

## Princípio

Composição deve reduzir complexidade total, não apenas distribuir a complexidade em mais arquivos.

---

## Relações na Squad

### Skills relacionadas

- `implementation`
- `architecture-design`

### Agentes relacionados

- `software-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`