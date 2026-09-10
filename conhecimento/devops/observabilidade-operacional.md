---
title: Observabilidade Operacional
description: Define princípios para compreender o comportamento de sistemas em operação por meio de sinais, contexto e evidências.
type: guide
status: active
scope: squad
tags:
  - devops
  - observabilidade
  - monitoramento
  - operacoes
---

# Observabilidade Operacional

## Objetivo

Observabilidade é a capacidade de obter informações suficientes para compreender o estado e o comportamento de um sistema.

## Sinais

Podem incluir:

- logs;
- métricas;
- traces;
- eventos;
- indicadores de negócio;
- alertas.

## Contexto

Um sinal isolado pode não ser suficiente.

A observabilidade deve permitir relacionar:

- mudança;
- versão;
- componente;
- ambiente;
- evento;
- impacto.

## Alertas

Um alerta deve possuir finalidade operacional clara.

Alertas excessivos produzem:

- ruído;
- fadiga;
- perda de atenção;
- resposta inadequada.

## Monitoramento

Monitorar não significa apenas verificar se o processo está ativo.

Deve-se observar aquilo que seja relevante para:

- disponibilidade;
- desempenho;
- confiabilidade;
- segurança;
- experiência;
- objetivos do produto.

## Privacidade

Logs e sinais podem conter dados sensíveis.

Observabilidade deve respeitar os controles de proteção de dados aplicáveis.

## Custo

Observabilidade também possui custo de:

- armazenamento;
- processamento;
- operação;
- análise.

Deve ser proporcional à necessidade.

---

## Relações na Squad

### Skills relacionadas

- `observability`
- `logging-and-observability`
- `release-monitoring`
- `incident-response`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`
- `08-evolution`