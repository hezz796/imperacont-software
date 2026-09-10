---
title: Separação de Responsabilidades
description: Define o padrão de separar responsabilidades distintas para reduzir complexidade e facilitar evolução.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - responsabilidades
  - coesao
  - acoplamento
---

# Separação de Responsabilidades

## Problema

Um componente ou módulo acumula responsabilidades diferentes e passa a ser difícil de compreender, testar, alterar ou reutilizar.

## Intenção

Separar responsabilidades que possuem motivos diferentes para mudar.

## Solução

Identificar responsabilidades distintas e estabelecer fronteiras claras entre elas.

A separação pode ocorrer em diferentes níveis:

- função;
- módulo;
- componente;
- serviço;
- processo;
- domínio.

## Benefícios

Pode melhorar:

- compreensão;
- testabilidade;
- manutenção;
- evolução;
- reutilização;
- isolamento de mudanças.

## Custos

Separação excessiva pode gerar:

- fragmentação;
- interfaces desnecessárias;
- complexidade de comunicação;
- dificuldade de navegação.

## Quando utilizar

É especialmente útil quando responsabilidades:

- possuem ciclos de mudança diferentes;
- possuem regras diferentes;
- apresentam riscos diferentes;
- precisam ser testadas isoladamente.

## Quando evitar

Evitar criar fronteiras artificiais quando as responsabilidades:

- sempre mudam juntas;
- são pequenas;
- possuem forte dependência natural;
- não apresentam benefício real de separação.

## Princípio

Separar responsabilidades para reduzir complexidade, não simplesmente para aumentar o número de componentes.

---

## Relações na Squad

### Skills relacionadas

- `implementation`
- `architecture-design`
- `domain-modeling`

### Agentes relacionados

- `software-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`