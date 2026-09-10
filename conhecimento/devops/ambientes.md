---
title: Ambientes
description: Define princípios para organização, finalidade, isolamento e governança dos ambientes utilizados durante o ciclo de vida do software.
type: guide
status: active
scope: squad
tags:
  - devops
  - ambientes
  - desenvolvimento
  - operacoes
---

# Ambientes

## Objetivo

Ambientes existem para fornecer contextos controlados para desenvolver, testar, validar, implantar e operar software.

## Tipos conceituais

Podem existir ambientes como:

- desenvolvimento;
- integração;
- teste;
- homologação;
- staging;
- produção.

A nomenclatura e quantidade devem refletir o contexto do produto.

## Não confundir ambiente com máquina

Um ambiente representa um contexto operacional, não necessariamente um único servidor ou recurso físico.

## Diferenças

Ambientes podem possuir diferenças de:

- configuração;
- dados;
- permissões;
- integrações;
- capacidade;
- observabilidade;
- exposição.

Diferenças excessivas podem gerar comportamentos inconsistentes.

## Isolamento

Ambientes devem possuir isolamento proporcional ao risco.

Produção deve receber proteção especial quando houver possibilidade de impacto real.

## Dados

Dados reais devem ser tratados com cuidado quando utilizados fora de produção.

É necessário considerar:

- sensibilidade;
- privacidade;
- acesso;
- retenção;
- anonimização ou mascaramento quando aplicável.

## Configuração

Configurações específicas do ambiente não devem ser confundidas com o código da aplicação.

## Governança

Cada ambiente deve possuir:

- finalidade;
- responsáveis;
- critérios de acesso;
- regras de alteração;
- mecanismos de observação;
- estratégia de recuperação.

---

## Relações na Squad

### Skills relacionadas

- `environment-management`
- `configuration-management`
- `deployment`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`