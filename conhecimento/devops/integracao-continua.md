---
title: Integração Contínua
description: Define princípios para integrar mudanças frequentemente e verificar automaticamente sua consistência e qualidade.
type: guide
status: active
scope: squad
tags:
  - devops
  - integracao-continua
  - qualidade
  - automacao
---

# Integração Contínua

## Objetivo

Integração contínua busca reduzir o risco associado ao acúmulo de mudanças isoladas.

## Princípio

Mudanças devem ser integradas com frequência suficiente para permitir feedback rápido.

## Verificações

Um processo de integração pode executar:

- validação;
- compilação quando aplicável;
- testes;
- análise estática;
- verificações de segurança;
- empacotamento;
- outras verificações adequadas ao produto.

## Feedback

Quando uma mudança provoca falha, o problema deve ser identificado e tratado rapidamente.

## Integração não é implantação

Integração contínua verifica mudanças integradas.

Isso não significa necessariamente que cada integração será disponibilizada automaticamente em produção.

## Pequenas mudanças

Integrações menores facilitam:

- diagnóstico;
- revisão;
- correção;
- rollback;
- entendimento de impacto.

---

## Relações na Squad

### Skills relacionadas

- `deployment`
- `version-control-and-change-management`
- `integration-testing`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `05-development`
- `07-delivery`