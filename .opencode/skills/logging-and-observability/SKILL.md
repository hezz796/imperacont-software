---
name: logging-and-observability
description: Define práticas de logs, métricas, traces e sinais operacionais para tornar o comportamento do software observável e diagnosticável.
---

# Logging and Observability

## Objetivo

Permitir compreender o comportamento do sistema, identificar problemas e apoiar diagnóstico e operação.

## Princípio

Observabilidade deve responder perguntas operacionais relevantes.

Não significa simplesmente gerar mais logs.

## Sinais

Considerar:

- logs;
- métricas;
- traces;
- eventos;
- indicadores de negócio;
- sinais de disponibilidade;
- sinais de desempenho.

## Logs

Registrar eventos relevantes com:

- contexto;
- severidade;
- timestamp;
- componente;
- correlação;
- resultado.

Evitar excesso de logs.

## Métricas

Quando aplicável, medir:

- volume;
- erros;
- latência;
- disponibilidade;
- utilização;
- filas;
- capacidade;
- indicadores de negócio.

## Tracing

Quando houver múltiplos componentes, considerar mecanismos que permitam acompanhar uma operação através das fronteiras.

## Alertas

Alertas devem representar situações que exigem ação.

Evitar alertas:

- excessivamente sensíveis;
- redundantes;
- sem responsável;
- sem procedimento de resposta.

## Privacidade

Nunca registrar dados sensíveis ou segredos sem necessidade e proteção apropriada.

## Diagnóstico

Para problemas relevantes, permitir responder:

- o que aconteceu?
- quando?
- onde?
- para quem?
- qual impacto?
- qual dependência estava envolvida?
- qual foi a causa provável?

## Saída esperada

Produzir:

1. eventos observáveis;
2. logs;
3. métricas;
4. traces, quando aplicável;
5. indicadores;
6. alertas;
7. requisitos de retenção;
8. controles de privacidade;
9. procedimentos de diagnóstico.