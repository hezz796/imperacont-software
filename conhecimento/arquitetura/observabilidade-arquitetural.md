---
title: Observabilidade Arquitetural
description: Fundamentos para tornar o comportamento interno e operacional de uma arquitetura compreensível por meio de sinais, contexto e evidências.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - observabilidade
  - operacao
  - diagnostico
---

# Observabilidade Arquitetural

## Conceito

Observabilidade é a capacidade de compreender o estado e o comportamento de um sistema a partir de informações produzidas durante sua execução.

## Por que é arquitetural

A observabilidade depende de decisões estruturais sobre:

- componentes;
- comunicação;
- identificação;
- eventos;
- dados;
- falhas;
- dependências.

Por isso, não deve ser considerada somente uma preocupação operacional.

## Sinais

Entre os sinais frequentemente utilizados estão:

- logs;
- métricas;
- traces;
- eventos;
- indicadores de negócio.

## Contexto

Um sinal isolado possui valor limitado.

É importante possuir contexto suficiente para relacionar:

- requisição;
- usuário ou processo, quando apropriado;
- componente;
- dependência;
- resultado;
- erro;
- tempo.

## Diagnóstico

Observabilidade deve permitir investigar perguntas como:

- o que aconteceu;
- quando aconteceu;
- onde ocorreu;
- quem foi afetado;
- qual dependência estava envolvida;
- qual foi o impacto.

## Negócio

Indicadores técnicos não substituem indicadores de produto.

Quando apropriado, sinais operacionais devem poder ser relacionados a impacto no negócio.

## Privacidade e segurança

Informações observacionais podem conter dados sensíveis.

Logs e outros sinais devem respeitar requisitos de proteção e minimização de dados.

## Custo

Observabilidade também possui custo de armazenamento, processamento e manutenção.

O nível adequado deve considerar criticidade e valor diagnóstico.

---

## Relações na Squad

### Skills relacionadas

- `observability`
- `logging-and-observability`
- `architecture-design`

### Agentes relacionados

- `solution-architect`
- `devops-engineer`

### Workflows relacionados

- `04-architecture`
- `07-delivery`