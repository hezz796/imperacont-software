---
title: Idempotência
description: Define o princípio de permitir que uma mesma operação seja repetida sem produzir efeitos adicionais indevidos.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - idempotencia
  - confiabilidade
  - integracao
---

# Idempotência

## Problema

Uma operação pode ser repetida devido a:

- retry;
- timeout;
- duplicidade de mensagens;
- falhas de comunicação;
- reprocessamento;
- ação repetida do usuário.

## Intenção

Evitar que repetições produzam efeitos indevidos.

## Solução

Identificar operações nas quais a repetição precisa ser segura e estabelecer mecanismo para reconhecer ou neutralizar duplicidades.

Podem ser utilizados, conforme o contexto:

- identificadores únicos;
- chaves de idempotência;
- registros de processamento;
- verificações de estado.

## Benefícios

Pode aumentar:

- confiabilidade;
- segurança operacional;
- capacidade de recuperação;
- previsibilidade.

## Limitações

Idempotência não elimina todos os problemas de duplicidade.

É necessário considerar:

- concorrência;
- transações;
- consistência;
- expiração de identificadores;
- falhas parciais.

## Aplicação

Deve receber atenção especial em:

- operações financeiras;
- criação de recursos;
- processamento de eventos;
- integrações externas;
- jobs reexecutáveis.

---

## Relações na Squad

### Skills relacionadas

- `api-design`
- `implementation`
- `integration-design`

### Agentes relacionados

- `software-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`