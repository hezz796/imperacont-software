---
title: Retry, Timeout e Circuit Breaker
description: Define padrões complementares para controlar falhas e dependências instáveis em operações remotas.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - resiliencia
  - retry
  - timeout
---

# Retry, Timeout e Circuit Breaker

Esses mecanismos ajudam a controlar falhas em dependências, mas não devem ser utilizados indiscriminadamente.

## Timeout

Define quanto tempo uma operação pode aguardar antes de ser considerada indisponível para aquele contexto.

Evita espera indefinida.

## Retry

Tenta novamente uma operação que falhou.

É apropriado principalmente para falhas potencialmente transitórias.

## Cuidados com retry

Retries excessivos podem provocar:

- tempestade de requisições;
- aumento de latência;
- sobrecarga;
- duplicidade;
- propagação da falha.

Quando aplicável, utilizar:

- limite de tentativas;
- espera progressiva;
- aleatoriedade;
- idempotência.

## Circuit breaker

Interrompe temporariamente chamadas para uma dependência que apresenta falhas persistentes.

Isso permite evitar que uma falha externa consuma continuamente recursos internos.

## Recuperação

O sistema deve definir como e quando tentará novamente utilizar a dependência.

## Princípio

Resiliência não significa repetir indefinidamente.

Significa falhar de forma controlada e recuperar quando houver condições.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `architecture-design`
- `reliability-testing`
- `error-handling`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`