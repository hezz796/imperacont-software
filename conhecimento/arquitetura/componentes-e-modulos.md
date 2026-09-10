---
title: Componentes e Módulos
description: Fundamentos para organizar software em unidades com responsabilidades, interfaces e dependências compreensíveis.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - componentes
  - modulos
  - modularidade
---

# Componentes e Módulos

## Conceito

Componentes e módulos são unidades estruturais utilizadas para organizar responsabilidades dentro de um sistema.

## Boa modularidade

Uma modularidade adequada busca:

- responsabilidades claras;
- alta coesão;
- acoplamento controlado;
- interfaces compreensíveis;
- baixo conhecimento desnecessário entre partes.

## Tamanho

Não existe tamanho universalmente correto para um módulo.

Módulos excessivamente grandes podem concentrar responsabilidades.

Módulos excessivamente pequenos podem criar:

- fragmentação;
- indireção;
- complexidade de navegação;
- dependências desnecessárias.

## Interfaces

Uma interface define como uma parte do sistema pode ser utilizada por outra.

Interfaces devem minimizar conhecimento desnecessário sobre implementação interna.

## Dependências

Dependências devem ser analisadas considerando:

- direção;
- estabilidade;
- frequência de mudança;
- impacto;
- ciclo de vida.

## Encapsulamento

Detalhes internos devem permanecer ocultos quando não precisam ser conhecidos externamente.

Isso reduz o impacto de mudanças internas.

## Composição

Componentes podem ser combinados para produzir comportamentos maiores.

A composição deve preservar limites compreensíveis.

## Evolução

Módulos devem poder evoluir sem propagar mudanças desnecessárias.

A modularidade deve servir à mudança e não apenas à organização visual do código.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `implementation`
- `domain-modeling`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`