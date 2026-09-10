---
title: Rollback e Recuperação
description: Define princípios para retornar a estados operacionais seguros ou recuperar o serviço após falhas e mudanças problemáticas.
type: guide
status: active
scope: squad
tags:
  - devops
  - rollback
  - recuperacao
  - resiliencia
---

# Rollback e Recuperação

## Objetivo

Quando uma mudança causar impacto inaceitável, a squad deve possuir mecanismos para limitar o dano e recuperar o serviço.

## Rollback

Rollback significa retornar a uma versão ou estado anterior apropriado.

Nem toda mudança é reversível.

## Problema da reversibilidade

Mudanças em:

- dados;
- contratos;
- integrações;
- infraestrutura;

podem tornar um rollback simples de código insuficiente.

## Estratégias

A recuperação pode envolver:

- reversão;
- correção direta;
- desativação de funcionalidade;
- restauração;
- migração compensatória;
- isolamento;
- degradação controlada.

## Pré-planejamento

Para mudanças de risco elevado, definir previamente:

- sinais de falha;
- critérios de acionamento;
- responsável;
- procedimento;
- dependências;
- validação pós-recuperação.

## Teste

Um plano de recuperação que nunca foi validado pode não funcionar quando necessário.

## Resultado

O objetivo não é garantir que nenhuma falha ocorrerá.

É garantir que falhas possam ser detectadas, contidas e recuperadas com impacto controlado.

---

## Relações na Squad

### Skills relacionadas

- `rollback-and-recovery`
- `deployment`
- `release-strategy`
- `incident-response`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`