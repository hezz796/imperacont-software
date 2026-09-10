---
title: Padrões de Observabilidade
description: Define padrões para tornar comportamento, estado, falhas e resultados de sistemas observáveis.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - observabilidade
  - monitoramento
  - diagnostico
---

# Padrões de Observabilidade

## Problema

Um sistema apresenta comportamento inesperado, mas não existem informações suficientes para compreender o que ocorreu.

## Intenção

Produzir sinais úteis para responder:

- o que aconteceu?
- onde aconteceu?
- quando aconteceu?
- para quem?
- com qual impacto?
- qual fluxo estava sendo executado?
- qual dependência estava envolvida?

## Sinais

Conforme o contexto, podem ser utilizados:

- logs;
- métricas;
- traces;
- eventos;
- indicadores de negócio;
- alertas.

## Contexto

Informações observáveis devem possuir contexto suficiente para investigação.

Podem ser relevantes:

- identificador da operação;
- correlação;
- componente;
- ambiente;
- momento;
- resultado;
- erro;
- duração.

## Privacidade

Observabilidade não deve justificar exposição indiscriminada de dados sensíveis.

Devem ser considerados:

- minimização;
- controle de acesso;
- retenção;
- anonimização ou mascaramento quando aplicável.

## Custo

Produzir sinais demais também pode gerar:

- ruído;
- custo;
- armazenamento excessivo;
- dificuldade de investigação.

## Princípio

Observabilidade deve ser projetada para responder perguntas operacionais e de negócio relevantes, e não apenas para acumular dados.

---

## Relações na Squad

### Skills relacionadas

- `logging-and-observability`
- `observability`
- `incident-response`

### Agentes relacionados

- `devops-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `07-delivery`