---
title: Strangler Pattern
description: Define o padrão de substituição gradual de uma solução existente por uma nova solução sem exigir reescrita integral imediata.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - migracao
  - legado
  - evolucao
---

# Strangler Pattern

## Problema

Uma solução existente precisa ser substituída, mas uma reescrita integral possui risco ou custo elevado.

## Intenção

Permitir substituição incremental.

## Solução

A nova solução assume gradualmente partes do comportamento existente.

Conceitualmente:

```text
SISTEMA EXISTENTE
       ↓
NOVA FRONTEIRA
       ↓
NOVA IMPLEMENTAÇÃO
```

Ao longo do tempo, partes do sistema antigo deixam de atender determinadas responsabilidades.

## Benefícios

Pode permitir:

- mudanças incrementais;
- validação progressiva;
- redução do risco de uma grande migração;
- recuperação mais controlada.

## Custos

Pode exigir coexistência temporária de:

- sistemas;
- dados;
- contratos;
- processos;
- infraestrutura.

## Riscos

Devem ser avaliados:

- inconsistência;
- duplicidade;
- sincronização;
- complexidade de roteamento;
- dependências ocultas.

## Quando utilizar

É especialmente útil quando:

- o sistema existente é grande;
- a substituição integral é arriscada;
- existem fronteiras que podem ser isoladas;
- a migração pode ocorrer por partes.

## Princípio

A migração deve possuir uma estratégia explícita para reduzir progressivamente a dependência da solução antiga.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `technical-debt-management`
- `refactoring`
- `deprecation-management`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `08-evolution`