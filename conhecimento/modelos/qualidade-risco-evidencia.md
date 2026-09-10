---
title: Qualidade, Risco e Evidência
description: Estrutura a avaliação da qualidade considerando risco e evidências disponíveis.
type: model
status: active
scope: squad
tags:
  - modelos
  - qualidade
  - riscos
  - testes
---

# Qualidade, Risco e Evidência

## Estrutura

```text
REQUISITOS
   ↓
RISCOS
   ↓
ESTRATÉGIA DE VERIFICAÇÃO
   ↓
TESTES
   ↓
EVIDÊNCIAS
   ↓
DECISÃO DE QUALIDADE
```

## Requisitos

Definem o comportamento ou qualidade esperada.

## Riscos

Indicam onde falhas podem produzir maior impacto.

## Estratégia de verificação

Determina como obter evidências suficientes.

## Testes

Produzem evidências sobre comportamentos ou propriedades observáveis.

## Evidências

Devem permitir compreender:

- o que foi verificado;
- como;
- em qual contexto;
- com qual resultado.

## Decisão

A decisão deve considerar:

- resultados;
- riscos residuais;
- criticidade;
- critérios de qualidade.

## Princípio

Não existe uma quantidade universalmente correta de testes.

A profundidade deve ser proporcional ao risco e ao contexto.

---

## Relações na Squad

### Skills relacionadas

- `test-strategy`
- `quality-gates`
- `test-design`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`