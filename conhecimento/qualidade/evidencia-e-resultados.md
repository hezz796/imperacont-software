---
title: Evidência e Resultados de Qualidade
description: Fundamentos para registrar resultados de avaliações de qualidade de forma objetiva, rastreável e útil para tomada de decisão.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - evidencia
  - resultados
  - rastreabilidade
---

# Evidência e Resultados de Qualidade

## Conceito

Evidência é a informação utilizada para sustentar uma conclusão sobre o comportamento ou a qualidade do produto.

## Resultado

Um resultado de teste deve permitir compreender:

- o que foi avaliado;
- em qual contexto;
- qual condição foi utilizada;
- qual comportamento foi observado;
- qual resultado era esperado.

## Passou não significa produto perfeito

Um teste aprovado demonstra que determinado comportamento foi observado sob determinada condição.

Não demonstra ausência de todos os problemas.

## Falha

Uma falha deve possuir informações suficientes para permitir investigação.

Quando possível, devem ser preservados:

- condições;
- entradas;
- passos;
- resultado;
- evidências;
- ambiente;
- versão.

## Rastreabilidade

Resultados podem ser relacionados a:

- requisitos;
- histórias;
- riscos;
- defeitos;
- versões;
- mudanças.

## Reprodutibilidade

Quanto mais facilmente uma falha puder ser reproduzida, maior tende a ser a capacidade de diagnóstico.

## Evidência proporcional

Nem todo resultado exige o mesmo nível de documentação.

A profundidade deve ser proporcional a:

- risco;
- criticidade;
- impacto;
- necessidade de auditoria;
- complexidade.

## Decisão

Resultados devem apoiar decisões como:

- avançar;
- corrigir;
- investigar;
- aceitar risco;
- bloquear;
- repetir avaliação.

---

## Relações na Squad

### Skills relacionadas

- `test-strategy`
- `quality-gates`
- `post-release-analysis`

### Agentes relacionados

- `test-engineer`
- `reviewer`

### Workflows relacionados

- `06-quality`
- `07-delivery`