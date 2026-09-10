---
title: Defeitos e Falhas
description: Fundamentos para distinguir erro humano, defeito interno e falha observada no comportamento de um sistema.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - defeitos
  - falhas
  - diagnostico
---

# Defeitos e Falhas

## Conceitos

É útil distinguir diferentes fenômenos.

### Erro

Ação, interpretação ou decisão humana que pode introduzir incorreção.

### Defeito

Problema existente em um artefato, implementação, configuração ou estrutura.

### Falha

Comportamento observado que não corresponde ao esperado.

## Relação

Um erro pode introduzir um defeito.

Um defeito pode permanecer invisível até determinadas condições ocorrerem.

Quando essas condições são satisfeitas, uma falha pode ser observada.

## Sintoma versus causa

O comportamento observado pode ser apenas um sintoma.

Investigar a causa ajuda a evitar correções superficiais.

## Impacto

Defeitos devem ser analisados considerando:

- usuários afetados;
- frequência;
- consequência;
- criticidade;
- possibilidade de contorno.

## Prioridade

Severidade e prioridade não são necessariamente iguais.

Uma falha tecnicamente grave pode ter baixa urgência em determinado contexto, enquanto uma falha aparentemente pequena pode exigir correção imediata devido ao momento ou impacto.

## Correção

A correção deve considerar:

- causa;
- impacto;
- risco de regressão;
- necessidade de testes;
- possibilidade de recorrência.

## Aprendizado

Defeitos recorrentes podem indicar problemas sistêmicos em:

- requisitos;
- arquitetura;
- processo;
- testes;
- comunicação;
- observabilidade.

---

## Relações na Squad

### Skills relacionadas

- `root-cause-analysis`
- `test-design`

### Agentes relacionados

- `test-engineer`
- `software-engineer`

### Workflows relacionados

- `06-quality`
- `08-evolution`