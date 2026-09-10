---
title: Integração de Dados
description: Orienta a troca, transformação, sincronização e distribuição de dados entre sistemas e componentes.
type: guide
status: active
scope: squad
tags:
  - dados
  - integracao
  - sincronizacao
  - arquitetura
---

# Integração de Dados

## Objetivo

Integração de dados permite que diferentes componentes compartilhem informações necessárias para suas responsabilidades.

## Aspectos fundamentais

Uma integração deve considerar:

- origem;
- destino;
- significado;
- formato;
- frequência;
- transformação;
- consistência;
- falhas;
- segurança;
- observabilidade.

## Fonte de verdade

Quando múltiplos sistemas possuem uma mesma informação, deve ser definido, quando necessário, qual sistema possui autoridade sobre determinado dado.

## Sincronização

Pode ocorrer de forma:

- imediata;
- periódica;
- orientada a eventos;
- sob demanda.

## Transformação

Transformações devem ser compreensíveis e rastreáveis quando forem relevantes para a integridade dos dados.

## Falhas

Devem ser consideradas:

- perda;
- duplicação;
- atraso;
- inconsistência;
- indisponibilidade;
- reprocessamento.

## Idempotência

Operações de integração devem ser projetadas para evitar efeitos incorretos quando uma mensagem ou operação for processada novamente.

## Evolução

Contratos de dados devem possuir estratégia de evolução.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `data-modeling`
- `api-design`

### Agentes relacionados

- `data-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`