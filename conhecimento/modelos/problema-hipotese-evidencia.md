---
title: Problema, Hipótese e Evidência
description: Estrutura o raciocínio utilizado para diferenciar problemas conhecidos, hipóteses e evidências.
type: model
status: active
scope: squad
tags:
  - modelos
  - discovery
  - hipoteses
  - evidencias
---

# Problema, Hipótese e Evidência

Este modelo ajuda a evitar que suposições sejam tratadas como fatos.

## Estrutura

```text
PROBLEMA
   ↓
HIPÓTESE
   ↓
EVIDÊNCIA
   ↓
APRENDIZADO
```

## Problema

Representa uma situação indesejada ou necessidade relevante que merece investigação.

## Hipótese

Representa uma explicação, expectativa ou suposição que ainda precisa de validação.

## Evidência

Representa informação observada ou obtida de uma fonte capaz de aumentar ou reduzir a confiança na hipótese.

## Aprendizado

Representa a interpretação obtida após analisar as evidências.

## Exemplo conceitual

```text
Problema:
Usuários abandonam determinado processo.

Hipótese:
A quantidade de etapas está causando abandono.

Evidência:
Dados de uso e pesquisa com usuários.

Aprendizado:
A principal dificuldade ocorre em uma etapa específica.
```

## Cuidado

Não transformar:

- opinião em evidência;
- preferência em requisito;
- solução sugerida em problema;
- hipótese em fato.

## Aplicação

Pode ser utilizado em:

- discovery;
- UX research;
- produto;
- análise de incidentes;
- evolução;
- melhoria contínua.

---

## Relações na Squad

### Skills relacionadas

- `hypothesis-validation`
- `product-discovery`
- `ux-research`

### Agentes relacionados

- `ux-researcher`
- `product-strategist`

### Workflows relacionados

- `01-discovery`
- `08-evolution`