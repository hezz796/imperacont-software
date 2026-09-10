---
title: Evolução da Arquitetura de Dados
description: Orienta a evolução incremental dos modelos, estruturas, integrações e mecanismos de dados conforme o produto cresce.
type: guide
status: active
scope: squad
tags:
  - dados
  - arquitetura
  - evolucao
  - migracao
  - divida-tecnica
---

# Evolução da Arquitetura de Dados

## Objetivo

Arquiteturas de dados devem evoluir conforme mudam:

- produto;
- domínio;
- volume;
- requisitos;
- integrações;
- riscos;
- operação.

## Evolução incremental

Sempre que possível, preferir mudanças que possam ser:

- isoladas;
- validadas;
- observadas;
- revertidas ou compensadas.

## Dívida de dados

Pode existir dívida quando decisões anteriores dificultam:

- manutenção;
- qualidade;
- desempenho;
- integração;
- segurança;
- evolução.

## Reescrita

Uma reestruturação completa pode ser necessária em determinados contextos, mas deve ser justificada por evidências.

Não assumir que reconstruir tudo é automaticamente melhor.

## Migração

Mudanças importantes devem possuir:

- estratégia;
- etapas;
- validação;
- observabilidade;
- recuperação.

## Compatibilidade

Durante a evolução, pode ser necessário manter temporariamente estruturas ou contratos antigos.

Isso deve ser tratado como parte consciente da estratégia de transição.

## Resultado

A arquitetura de dados deve evoluir de maneira controlada, evitando tanto:

- estagnação;
- quanto complexidade antecipada.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `technical-debt-management`
- `architecture-design`

### Agentes relacionados

- `data-engineer`

### Workflows relacionados

- `04-architecture`
- `08-evolution`