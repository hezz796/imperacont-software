---
title: Ciclo de Trabalho
description: Define o ciclo conceitual pelo qual o trabalho da squad passa desde a identificação de uma necessidade até sua avaliação e evolução.
type: guide
status: active
scope: squad
tags:
  - processos
  - ciclo
  - trabalho
  - lifecycle
---

# Ciclo de Trabalho

O trabalho da squad deve ser entendido como um ciclo contínuo, e não como uma sequência necessariamente linear.

## Ciclo conceitual

```text
IDEIA
  ↓
DESCOBERTA
  ↓
VALIDAÇÃO
  ↓
PRODUTO
  ↓
UX
  ↓
ARQUITETURA
  ↓
PLANEJAMENTO
  ↓
DESENVOLVIMENTO
  ↓
TESTES
  ↓
REVISÃO
  ↓
RELEASE
  ↓
OBSERVAÇÃO
  ↓
FEEDBACK
  ↓
EVOLUÇÃO
  ↓
DESCOBERTA
```

## Características

O ciclo pode retornar a etapas anteriores quando novas evidências demonstrarem que uma decisão precisa ser reconsiderada.

Por exemplo:

- um teste pode revelar problema de requisito;
- uma decisão arquitetural pode revelar restrição de produto;
- uma release pode revelar problema de UX;
- dados operacionais podem invalidar uma hipótese;
- feedback pode indicar que o problema original foi mal compreendido.

## Princípio

Voltar uma etapa não representa necessariamente falha.

Pode representar aprendizado.

A squad deve preferir corrigir premissas quando novas evidências justificarem a mudança.

## Controle

Cada transição relevante deve considerar:

- resultado produzido;
- evidências;
- riscos;
- pendências;
- critérios de saída;
- decisão de continuidade.

## Ciclos menores

O ciclo completo pode conter ciclos menores.

Exemplo:

```text
REQUISITO
→ IMPLEMENTAÇÃO
→ TESTE
→ FEEDBACK
→ AJUSTE
→ NOVO TESTE
```

O objetivo é evitar grandes períodos de trabalho sem validação intermediária.

---

## Relações na Squad

### Workflows relacionados

- `01-discovery`
- `02-product-definition`
- `03-ux-design`
- `04-architecture`
- `05-development`
- `06-quality`
- `07-delivery`
- `08-evolution`