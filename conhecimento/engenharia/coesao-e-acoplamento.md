---
title: Coesão e acoplamento
description: Critérios para avaliar a relação entre responsabilidades internas e dependências entre partes do software.
type: guide
status: active
scope: squad
tags:
  - coesao
  - acoplamento
  - modularidade
  - arquitetura
---

# Coesão e acoplamento

## Coesão

Coesão representa o quanto os elementos de uma unidade estão relacionados por uma responsabilidade ou propósito comum.

Como orientação geral, unidades com responsabilidades relacionadas tendem a ser mais compreensíveis e previsíveis.

## Acoplamento

Acoplamento representa o grau de dependência entre partes de um sistema.

Dependências podem ser necessárias, mas devem ser compreendidas e controladas.

## Objetivo

Uma estrutura saudável busca:

```text
ALTA COESÃO
+
ACOPLAMENTO CONTROLADO
```

Isso não significa buscar acoplamento zero.

Sistemas reais precisam colaborar.

## Perguntas de avaliação

Ao analisar uma estrutura, considerar:

- As responsabilidades pertencem juntas?
- Uma mudança exige alterações em muitas partes?
- Existem dependências desnecessárias?
- Existem dependências circulares?
- Uma unidade conhece detalhes internos de outra?
- As interfaces representam necessidades reais?
- O relacionamento entre componentes é compreensível?

## Trade-off

Reduzir acoplamento pode aumentar:

- abstrações;
- indireção;
- complexidade;
- quantidade de componentes.

Portanto, o objetivo não é minimizar uma métrica isoladamente.

O objetivo é encontrar uma estrutura adequada ao contexto.

## Resultado esperado

Mudanças relacionadas devem permanecer próximas quando apropriado, enquanto dependências entre responsabilidades distintas devem permanecer explícitas e controláveis.

---

## Relações na Squad

### Skills relacionadas

- `implementation`
- `architecture-design`
- `refactoring`

### Agentes relacionados

- `software-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`