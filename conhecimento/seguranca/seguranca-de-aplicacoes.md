---
title: Segurança de Aplicações
description: Reúne princípios para reduzir vulnerabilidades e comportamentos inseguros em aplicações de software.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - aplicacoes
  - desenvolvimento
  - vulnerabilidades
---

# Segurança de Aplicações

## Objetivo

A aplicação deve tratar entradas, estados, dados, erros e operações de forma segura.

## Áreas relevantes

A análise pode incluir:

- validação de entradas;
- controle de acesso;
- autenticação;
- gestão de sessão;
- proteção de dados;
- tratamento de erros;
- execução de operações;
- upload e processamento de arquivos;
- integrações;
- dependências;
- configuração.

## Entrada não confiável

Entradas provenientes de usuários ou sistemas externos devem ser validadas conforme o contexto de uso.

## Estado

Operações sensíveis devem considerar:

- transições de estado;
- concorrência;
- repetição;
- expiração;
- consistência;
- autorização.

## Erros

Erros não devem:

- ser silenciosamente ignorados;
- expor informações desnecessárias;
- provocar estados inseguros;
- comprometer rastreabilidade.

## Segurança funcional

Uma aplicação pode funcionar conforme os requisitos funcionais e ainda apresentar falhas de segurança.

Portanto, segurança deve possuir requisitos e critérios próprios.

## Desenvolvimento seguro

Segurança deve ser considerada durante:

- definição;
- implementação;
- revisão;
- testes;
- entrega;
- manutenção.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `security-testing`
- `implementation`

### Agentes relacionados

- `security-engineer`
- `software-engineer`

### Workflows relacionados

- `05-development`
- `06-quality`