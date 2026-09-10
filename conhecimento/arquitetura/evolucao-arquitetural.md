---
title: Evolução Arquitetural
description: Fundamentos para adaptar arquiteturas à mudança do produto, do domínio, dos requisitos, da tecnologia e das condições operacionais.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - evolucao
  - modernizacao
  - divida-tecnica
---

# Evolução Arquitetural

## Conceito

Evolução arquitetural é a adaptação deliberada da estrutura de uma solução conforme novas necessidades, evidências e restrições surgem.

## Mudança contínua

Produtos evoluem.

Consequentemente, podem mudar:

- domínio;
- volume;
- usuários;
- integrações;
- requisitos;
- riscos;
- custos;
- tecnologias disponíveis.

## Evoluir versus reescrever

Uma arquitetura pode ser melhorada incrementalmente.

Reescrita completa pode ser adequada em alguns contextos, mas possui riscos significativos.

Antes de substituir uma solução inteira, devem ser avaliados:

- problemas reais;
- alternativas incrementais;
- custo;
- risco;
- valor esperado;
- conhecimento perdido.

## Dívida arquitetural

Dívida arquitetural representa consequências futuras de decisões que aumentam o custo ou risco de evolução.

Nem toda dívida precisa ser eliminada imediatamente.

Ela deve ser avaliada em relação ao impacto atual e futuro.

## Sinais de deterioração

Podem indicar necessidade de evolução:

- aumento contínuo da complexidade;
- mudanças simples exigindo alterações extensas;
- dependências difíceis de compreender;
- falhas recorrentes;
- baixa capacidade de teste;
- gargalos persistentes;
- dificuldade de observação;
- crescimento do custo operacional.

## Migração

Mudanças arquiteturais podem exigir migração gradual.

Estratégias incrementais podem reduzir:

- risco;
- indisponibilidade;
- retrabalho;
- dificuldade de rollback.

## Evidência

A evolução deve ser orientada por evidências sempre que possível.

Problemas observados devem ser distinguidos de preferências tecnológicas.

## Arquitetura como sistema vivo

Uma arquitetura saudável deve ser capaz de mudar.

O objetivo não é preservar a arquitetura original indefinidamente, mas manter a estrutura adequada ao contexto atual e ao caminho provável de evolução.

---

## Relações na Squad

### Skills relacionadas

- `technical-debt-management`
- `architecture-design`
- `refactoring`
- `lifecycle-management`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `08-evolution`