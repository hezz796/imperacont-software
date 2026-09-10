---
title: Feature Flags
description: Define o uso de mecanismos de ativação controlada de funcionalidades durante desenvolvimento, release e operação.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - feature-flags
  - release
  - evolucao
---

# Feature Flags

## Problema

Uma funcionalidade precisa ser entregue ou implantada sem necessariamente ser disponibilizada imediatamente para todos os usuários.

## Intenção

Separar, quando apropriado, a implantação técnica da ativação funcional.

## Possibilidades

Uma funcionalidade pode ser ativada:

- para ninguém;
- para um grupo;
- gradualmente;
- em determinado ambiente;
- sob determinada condição.

## Benefícios

Pode favorecer:

- releases graduais;
- testes controlados;
- redução de risco;
- rollback funcional;
- experimentação.

## Riscos

Feature flags podem gerar:

- complexidade condicional;
- estados difíceis de testar;
- comportamento inconsistente;
- flags esquecidas;
- dívida técnica.

## Governança

Cada flag relevante deve possuir:

- propósito;
- responsável;
- estado esperado;
- condição de ativação;
- estratégia de remoção.

## Princípio

Feature flag temporária deve possuir caminho de remoção.

Uma flag permanente deve ser tratada como configuração ou regra arquitetural, se esse for seu verdadeiro propósito.

---

## Relações na Squad

### Skills relacionadas

- `release-strategy`
- `deployment`
- `implementation`

### Agentes relacionados

- `devops-engineer`
- `software-engineer`

### Workflows relacionados

- `05-development`
- `07-delivery`