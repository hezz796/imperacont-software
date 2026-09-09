---
title: Observabilidade desde o desenho
description: Sistemas relevantes devem ser projetados para permitir compreensão de seu comportamento durante a operação.
type: principle
status: active
scope: squad
tags:
  - observability
  - operations
  - reliability
  - monitoring
---

# Observabilidade desde o desenho

## Princípio

Um sistema deve fornecer informações suficientes para que sua equipe consiga compreender seu comportamento e identificar problemas relevantes.

## Observabilidade não é apenas monitoramento

A observabilidade deve permitir investigar perguntas como:

- O sistema está funcionando?
- Onde está ocorrendo o problema?
- Qual comportamento mudou?
- Quem ou o que foi afetado?
- Qual foi a causa provável?
- O sistema conseguiu se recuperar?

## Elementos

Dependendo do contexto, podem ser necessários:

- logs;
- métricas;
- traces;
- eventos;
- indicadores de negócio;
- alertas;
- auditoria;
- informações de diagnóstico.

## Proporcionalidade

Nem todo componente exige o mesmo nível de observabilidade.

O esforço deve considerar criticidade, risco e impacto operacional.

## Resultado esperado

A operação deve conseguir detectar, investigar e responder a problemas relevantes com evidências suficientes.