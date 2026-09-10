---
title: Segurança de APIs e Integrações
description: Define princípios de segurança para interfaces, integrações e comunicação entre sistemas e componentes.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - apis
  - integracoes
  - contratos
---

# Segurança de APIs e Integrações

## Objetivo

Toda interface entre componentes representa uma superfície potencial de exposição.

## Aspectos fundamentais

Uma integração deve considerar:

- autenticação;
- autorização;
- validação de entradas;
- proteção de dados;
- limites de uso;
- tratamento de erros;
- rastreabilidade;
- disponibilidade;
- confiança entre sistemas;
- evolução do contrato.

## Validação de entrada

Dados recebidos de sistemas externos devem ser tratados como não confiáveis até serem adequadamente validados.

## Privilégios

Uma integração não deve possuir permissões maiores que as necessárias para sua finalidade.

## Erros

Mensagens de erro devem evitar exposição desnecessária de:

- credenciais;
- dados internos;
- detalhes sensíveis;
- estrutura interna;
- informações úteis para exploração.

Ao mesmo tempo, falhas relevantes devem permanecer diagnosticáveis internamente.

## Disponibilidade

Integrações devem considerar:

- timeout;
- limites;
- retry controlado;
- circuit breaking quando aplicável;
- degradação;
- idempotência;
- recuperação.

## Confiança

Uma integração externa não deve ser considerada confiável simplesmente por estar fora ou dentro de determinado ambiente.

A confiança deve ser explicitamente definida e controlada.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `api-design`
- `integration-design`
- `security-testing`

### Agentes relacionados

- `security-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`