---
title: Processamento Síncrono e Assíncrono
description: Orienta a escolha entre processamento síncrono e assíncrono de acordo com dependências, experiência, consistência e operação.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - processamento
  - sincronismo
  - assincronismo
---

# Processamento Síncrono e Assíncrono

## Processamento síncrono

O solicitante aguarda a conclusão ou resposta da operação.

Pode ser adequado quando:

- o resultado é necessário imediatamente;
- a operação é curta;
- a dependência temporal é importante;
- a experiência exige resposta direta.

## Processamento assíncrono

O solicitante inicia uma operação que será concluída posteriormente.

Pode ser adequado quando:

- o processamento é demorado;
- a operação pode ocorrer independentemente;
- é desejável desacoplar produtores e consumidores;
- há necessidade de absorver picos de demanda.

## Trade-offs

O processamento assíncrono pode introduzir:

- consistência eventual;
- complexidade operacional;
- necessidade de rastreamento;
- reprocessamento;
- duplicidade;
- ordenação;
- tratamento de falhas.

## Decisão

A escolha deve considerar:

- experiência do usuário;
- latência;
- consistência;
- disponibilidade;
- volume;
- falhas;
- observabilidade;
- recuperação.

## Princípio

Não utilizar assincronismo simplesmente porque ele parece mais escalável.

Utilizá-lo quando suas características resolvem uma necessidade concreta.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `architecture-design`
- `api-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`