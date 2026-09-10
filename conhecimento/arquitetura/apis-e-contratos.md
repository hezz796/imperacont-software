---
title: APIs e Contratos
description: Fundamentos para definir interfaces de comunicação estáveis, compreensíveis e evolutivas entre partes de um sistema.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - api
  - contratos
  - integracao
---

# APIs e Contratos

## Conceito

Uma API é uma interface pela qual uma parte de um sistema disponibiliza capacidades para outra parte.

O contrato define expectativas sobre essa interação.

## Contrato

Um contrato pode estabelecer:

- operações;
- dados;
- formatos;
- regras;
- erros;
- autenticação;
- limites;
- versionamento;
- comportamento esperado.

## Abstração

Uma API deve expor o que o consumidor precisa utilizar, evitando expor detalhes internos desnecessários.

## Estabilidade

Mudanças em contratos podem afetar consumidores.

Por isso, devem ser avaliadas quanto a:

- compatibilidade;
- impacto;
- migração;
- versionamento;
- comunicação.

## Erros

Erros fazem parte do contrato.

O consumidor precisa possuir informações suficientes para compreender e tratar falhas previsíveis.

## Idempotência

Quando apropriado, operações devem considerar o comportamento diante de repetição.

Isso é especialmente relevante em ambientes com:

- retries;
- redes instáveis;
- processamento assíncrono.

## Segurança

APIs devem considerar:

- autenticação;
- autorização;
- proteção de dados;
- validação de entrada;
- limites de uso;
- auditoria quando necessária.

## Evolução

Contratos devem possuir uma estratégia para evolução.

Uma mudança tecnicamente pequena pode ser arquiteturalmente significativa quando muitos consumidores dependem dela.

---

## Relações na Squad

### Skills relacionadas

- `api-design`
- `integration-design`
- `architecture-design`
- `security-design`

### Agentes relacionados

- `solution-architect`
- `software-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`