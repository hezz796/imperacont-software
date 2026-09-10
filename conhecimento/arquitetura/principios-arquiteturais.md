---
title: Princípios Arquiteturais
description: Fundamentos para orientar decisões arquiteturais de forma coerente com o domínio, os requisitos, os riscos e a evolução esperada.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - principios
  - decisoes
---

# Princípios Arquiteturais

## Contexto antes da solução

Uma arquitetura deve ser derivada do contexto e não escolhida apenas por preferência tecnológica.

Antes de decidir, é necessário compreender:

- problema;
- domínio;
- requisitos;
- restrições;
- riscos;
- escala;
- atributos de qualidade.

## Simplicidade

A arquitetura deve possuir apenas a complexidade necessária para atender às necessidades conhecidas.

Complexidade antecipada possui custo mesmo quando a necessidade nunca se concretiza.

## Separação de responsabilidades

Responsabilidades diferentes devem possuir limites compreensíveis.

Isso facilita:

- evolução;
- testes;
- entendimento;
- manutenção;
- substituição.

## Alta coesão

Responsabilidades relacionadas devem permanecer próximas quando isso produzir uma fronteira coerente.

## Acoplamento controlado

Componentes inevitavelmente possuem relações.

O objetivo não é eliminar todo acoplamento, mas controlar:

- quantidade;
- direção;
- estabilidade;
- impacto;
- conhecimento compartilhado.

## Contratos explícitos

Integrações entre partes do sistema devem possuir contratos compreensíveis.

Contratos podem definir:

- dados;
- comportamento;
- erros;
- versões;
- expectativas.

## Isolamento de mudanças

Mudanças frequentes não deveriam propagar desnecessariamente seus efeitos por toda a solução.

## Segurança por arquitetura

Segurança deve ser considerada nas decisões estruturais, e não apenas adicionada posteriormente.

## Observabilidade

Sistemas importantes devem possuir meios de compreender seu comportamento operacional.

## Reversibilidade

Quando possível, decisões de alto impacto devem considerar a possibilidade e o custo de reversão.

## Evolutividade

Uma arquitetura deve permitir evolução sem exigir mudanças desproporcionais em todo o sistema.

## Adequação ao contexto

Princípios arquiteturais não são regras absolutas.

Uma decisão deve considerar o contexto real e justificar exceções relevantes.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `technical-decisions`
- `domain-modeling`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`