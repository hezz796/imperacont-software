---
title: Eventos e Comunicação Desacoplada
description: Define o uso de eventos para comunicar ocorrências entre partes de um sistema com menor dependência temporal.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - eventos
  - mensageria
  - desacoplamento
---

# Eventos e Comunicação Desacoplada

## Problema

Uma parte do sistema precisa informar outras partes sobre algo ocorrido sem depender diretamente da execução imediata dessas partes.

## Intenção

Reduzir dependência temporal entre produtores e consumidores.

## Solução

Um componente publica um evento representando uma ocorrência.

Outros componentes podem consumi-lo conforme suas necessidades.

## Evento

Evento representa algo que aconteceu.

Exemplo conceitual:

```text
PEDIDO_CONFIRMADO
```

Não deve ser confundido automaticamente com uma solicitação de ação.

## Benefícios

Pode favorecer:

- desacoplamento;
- extensibilidade;
- processamento assíncrono;
- integração entre contextos.

## Custos

Pode introduzir:

- consistência eventual;
- duplicidade;
- ordenação;
- reprocessamento;
- rastreabilidade mais complexa;
- maior dificuldade de diagnóstico.

## Requisitos importantes

Quando aplicável, considerar:

- identificador do evento;
- origem;
- momento;
- versão;
- correlação;
- idempotência;
- retenção;
- tratamento de falhas.

## Cuidado

Não transformar toda comunicação em evento.

Comunicação direta pode ser mais simples quando o contexto exigir resposta imediata e acoplamento explícito for aceitável.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `architecture-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`