---
title: Arquitetura de Dados
description: Fundamentos para estruturar armazenamento, fluxo, propriedade, consistência e uso dos dados em uma solução.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - dados
  - persistencia
  - consistencia
---

# Arquitetura de Dados

## Conceito

Arquitetura de dados trata de como dados são estruturados, armazenados, movimentados, protegidos e utilizados por uma solução.

## Dados como responsabilidade arquitetural

Decisões de dados afetam:

- comportamento;
- desempenho;
- segurança;
- integração;
- recuperação;
- evolução;
- operação.

## Modelo de dados

O modelo deve refletir as necessidades do domínio.

Estruturas excessivamente genéricas podem dificultar compreensão.

Estruturas excessivamente rígidas podem dificultar evolução.

## Propriedade

Quando diferentes partes do sistema utilizam o mesmo dado, deve existir clareza sobre:

- quem é responsável;
- quem pode alterar;
- quem pode consultar;
- qual é a fonte de verdade.

## Consistência

A consistência necessária depende do domínio.

Nem toda informação exige sincronização imediata entre todas as partes.

## Persistência

A escolha da estratégia de persistência deve considerar:

- natureza dos dados;
- padrões de acesso;
- volume;
- consistência;
- desempenho;
- recuperação;
- evolução.

A tecnologia de armazenamento é consequência da necessidade, não ponto de partida obrigatório.

## Ciclo de vida

Dados possuem ciclo de vida.

Devem ser considerados:

- criação;
- utilização;
- alteração;
- retenção;
- arquivamento;
- exclusão.

## Segurança

Dados devem ser protegidos de acordo com sua sensibilidade e finalidade.

## Recuperação

Dados importantes devem possuir mecanismos adequados de backup, restauração e recuperação conforme a criticidade.

## Evolução

Mudanças no modelo de dados podem possuir alto impacto.

Por isso, evolução de dados deve considerar compatibilidade e migração.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `architecture-design`
- `integration-design`

### Agentes relacionados

- `data-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`