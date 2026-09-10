---
title: Contratos Explícitos
description: Define o uso de contratos claros para estabelecer expectativas entre componentes, sistemas ou participantes.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - contratos
  - integracao
  - apis
---

# Contratos Explícitos

## Problema

Partes de um sistema dependem de comportamentos que não estão claramente definidos.

## Intenção

Tornar explícitas as expectativas entre partes que precisam se comunicar.

## Solução

Um contrato deve definir, conforme o contexto:

- entradas;
- saídas;
- regras;
- estados;
- erros;
- limites;
- responsabilidades;
- compatibilidade;
- segurança;
- comportamento esperado.

## Aplicações

Pode ser utilizado em:

- APIs;
- eventos;
- módulos;
- integrações;
- arquivos;
- processos;
- interfaces internas.

## Benefícios

Contratos explícitos favorecem:

- previsibilidade;
- integração;
- testes;
- evolução;
- diagnóstico;
- redução de ambiguidades.

## Evolução

Mudanças no contrato devem considerar consumidores existentes.

Quando compatibilidade for necessária, deve existir estratégia de evolução.

## Princípio

Quanto maior a dependência entre partes, maior a importância de tornar suas expectativas explícitas.

---

## Relações na Squad

### Skills relacionadas

- `api-design`
- `integration-design`
- `implementation`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`