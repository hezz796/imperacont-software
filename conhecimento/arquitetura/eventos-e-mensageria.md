---
title: Eventos e Mensageria
description: Fundamentos para comunicação assíncrona, eventos, mensagens e desacoplamento entre componentes de software.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - eventos
  - mensageria
  - assincrono
---

# Eventos e Mensageria

## Conceito

Eventos representam fatos relevantes que ocorreram em determinado contexto.

Mensagens representam informações transmitidas entre partes de um sistema.

## Evento versus comando

Um evento comunica algo que aconteceu.

Um comando expressa uma solicitação para que determinada ação seja realizada.

Essa distinção ajuda a definir responsabilidades e contratos.

## Assincronismo

Comunicação assíncrona permite que produtor e consumidor não precisem permanecer sincronizados durante toda a operação.

Isso pode reduzir acoplamento temporal.

## Benefícios

Mensageria pode ajudar em:

- desacoplamento;
- processamento posterior;
- distribuição de eventos;
- absorção de picos;
- integração entre contextos.

## Custos

Também introduz complexidade, incluindo:

- duplicidade;
- ordenação;
- entrega;
- retries;
- mensagens atrasadas;
- observabilidade;
- consistência eventual.

## Idempotência

Consumidores devem considerar que uma mensagem pode ser processada mais de uma vez quando o mecanismo de entrega permitir duplicidade.

## Ordem

A ordem dos eventos só deve ser assumida quando houver garantia arquitetural correspondente.

## Consistência eventual

Sistemas orientados a eventos frequentemente aceitam que diferentes partes reflitam determinado estado em momentos diferentes.

Essa característica precisa ser compatível com o domínio.

## Evolução

Contratos de mensagens devem ser tratados como interfaces evolutivas.

Mudanças incompatíveis podem afetar múltiplos consumidores.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `architecture-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`