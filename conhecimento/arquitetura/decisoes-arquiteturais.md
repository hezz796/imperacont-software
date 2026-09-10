---
title: Decisões Arquiteturais
description: Fundamentos para registrar, comunicar e revisar decisões que possuem impacto estrutural significativo sobre a solução.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - decisoes
  - adr
  - governanca
---

# Decisões Arquiteturais

## Conceito

Uma decisão arquitetural é uma escolha que influencia significativamente a estrutura, comportamento, evolução ou operação de uma solução.

## Quando uma decisão é relevante

Uma decisão tende a ser arquiteturalmente relevante quando afeta:

- múltiplos componentes;
- atributos de qualidade;
- integrações;
- segurança;
- dados;
- operação;
- custos;
- capacidade de evolução.

## Registro

Uma decisão importante deve preservar seu contexto.

Um registro pode explicar:

- problema;
- contexto;
- opções consideradas;
- decisão;
- justificativa;
- consequências;
- riscos.

## Alternativas

Registrar alternativas ajuda a preservar o raciocínio e evita que decisões históricas sejam interpretadas como escolhas arbitrárias.

## Consequências

Toda decisão possui consequências.

Elas podem ser:

- positivas;
- negativas;
- aceitáveis;
- temporárias;
- condicionais.

## Premissas

Decisões podem depender de premissas.

Quando uma premissa deixa de ser válida, a decisão pode precisar ser revisitada.

## Reversibilidade

Decisões reversíveis e irreversíveis devem ser tratadas de maneira diferente.

Quanto maior o custo de reversão, maior a necessidade de compreensão e evidência.

## Evolução

Uma decisão arquitetural não deve permanecer válida apenas porque foi documentada.

Ela pode ser revisitada quando:

- contexto muda;
- evidências mudam;
- requisitos mudam;
- custos aumentam;
- riscos se materializam.

## Conhecimento institucional

Registros de decisões preservam conhecimento que poderia ser perdido quando membros da equipe mudam.

---

## Relações na Squad

### Skills relacionadas

- `technical-decisions`
- `architecture-design`
- `change-management`

### Agentes relacionados

- `solution-architect`
- `squad-lead`

### Workflows relacionados

- `04-architecture`