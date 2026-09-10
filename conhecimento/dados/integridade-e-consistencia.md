---
title: Integridade e Consistência
description: Orienta decisões sobre preservação de regras, relacionamentos e coerência dos dados.
type: guide
status: active
scope: squad
tags:
  - dados
  - integridade
  - consistencia
  - arquitetura
---

# Integridade e Consistência

## Integridade

Integridade representa a preservação das regras e relações que tornam os dados válidos dentro do contexto.

## Consistência

Consistência representa o grau em que os dados mantêm um estado coerente conforme as regras estabelecidas.

## Tipos de regras

Podem existir regras sobre:

- obrigatoriedade;
- unicidade;
- relacionamento;
- domínio de valores;
- estado;
- temporalidade;
- dependência.

## Consistência forte

Pode ser necessária quando uma operação depende de que determinadas informações estejam imediatamente coerentes.

## Consistência eventual

Pode ser adequada quando diferentes partes do sistema podem convergir para o mesmo estado posteriormente.

## Decisão arquitetural

A escolha deve considerar:

- domínio;
- risco;
- experiência do usuário;
- operações;
- integrações;
- disponibilidade;
- desempenho.

## Trade-off

Aumentar consistência pode aumentar:

- coordenação;
- latência;
- acoplamento;
- complexidade.

Reduzir consistência pode aumentar:

- complexidade de reconciliação;
- possibilidade de estados temporariamente divergentes;
- exigência de tratamento no produto.

## Regra

A consistência necessária deve ser explicitamente definida, não presumida.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `architecture-design`
- `integration-design`

### Agentes relacionados

- `data-engineer`

### Workflows relacionados

- `04-architecture`