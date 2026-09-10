---
title: Casos e Cenários de Teste
description: Fundamentos para representar situações de avaliação de comportamento, condições, resultados esperados e evidências.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - testes
  - cenarios
  - casos
---

# Casos e Cenários de Teste

## Cenário

Um cenário representa uma situação ou comportamento relevante que precisa ser avaliado.

## Caso de teste

Um caso de teste descreve uma avaliação específica, incluindo condições, entradas, ações e resultado esperado.

## Características

Casos úteis devem possuir:

- objetivo claro;
- contexto;
- condições;
- entradas;
- comportamento esperado;
- resultado observável.

## Dados

Dados de teste devem representar condições relevantes do domínio.

Quando necessário, devem incluir:

- dados válidos;
- dados inválidos;
- limites;
- combinações;
- estados anteriores.

## Critérios

O resultado esperado deve ser verificável.

Descrições vagas dificultam determinar se o teste passou ou falhou.

## Cenários de erro

Casos devem considerar não apenas o caminho feliz, mas também situações como:

- entradas inválidas;
- ausência de dados;
- duplicidade;
- timeout;
- falha de dependência;
- acesso não autorizado;
- estado inconsistente.

## Manutenção

Casos de teste também possuem custo de manutenção.

Testes devem ser mantidos quando requisitos e comportamento evoluírem.

## Valor

Um grande número de casos não significa necessariamente boa cobertura.

A seleção deve priorizar comportamentos e riscos relevantes.

---

## Relações na Squad

### Skills relacionadas

- `test-design`
- `acceptance-testing`
- `regression-testing`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`