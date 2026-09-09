---
name: observability
description: Define mecanismos para compreender o comportamento do sistema por meio de sinais, métricas, logs, traces e contexto operacional.
---

# Observability

## Objetivo

Permitir detectar, compreender e investigar o comportamento do produto em execução.

## Princípio

Observabilidade deve responder perguntas operacionais relevantes, não apenas gerar grandes volumes de dados.

## Processo

1. Identificar comportamentos importantes.
2. Identificar sinais necessários.
3. Definir métricas relevantes.
4. Definir logs apropriados.
5. Definir rastreamento quando necessário.
6. Definir alertas.
7. Definir dashboards ou mecanismos equivalentes.
8. Validar capacidade de diagnóstico.
9. Revisar continuamente.

## Sinais

Quando aplicável:

- métricas;
- logs;
- traces;
- eventos;
- indicadores de negócio;
- disponibilidade;
- erros;
- latência;
- utilização de recursos.

## Regras

- Não registrar dados sensíveis desnecessariamente.
- Logs devem possuir contexto suficiente para investigação.
- Alertas devem ser acionáveis.
- Métricas devem possuir significado operacional.
- Observabilidade deve considerar custos e volume.

## Saída

Produzir:

- sinais;
- métricas;
- logs;
- traces;
- alertas;
- dashboards;
- critérios de diagnóstico.