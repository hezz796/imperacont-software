---
title: Engenharia incremental
description: Princípios para construir e evoluir software por meio de mudanças pequenas, verificáveis e progressivas.
type: principle
status: active
scope: squad
tags:
  - incremental
  - desenvolvimento
  - qualidade
  - evolucao
---

# Engenharia incremental

## Princípio

O software deve evoluir por meio de mudanças que possam ser compreendidas, implementadas e verificadas de forma progressiva.

## Benefícios

Mudanças incrementais podem:

- reduzir o tamanho do risco;
- facilitar diagnóstico;
- reduzir o impacto de falhas;
- simplificar revisão;
- facilitar rollback;
- permitir feedback mais rápido;
- preservar maior controle sobre o estado do sistema.

## Unidade de mudança

Uma unidade de mudança deve ser suficientemente pequena para que seja possível compreender:

- o motivo;
- o comportamento esperado;
- os componentes afetados;
- os riscos;
- a forma de verificação;
- o resultado.

## Evitar

- grandes mudanças sem checkpoints;
- alterações não relacionadas no mesmo lote;
- refatorações extensas misturadas com mudanças funcionais sem necessidade;
- ausência de estratégia de recuperação;
- mudanças que não possam ser verificadas.

## Regra

Quando uma mudança puder ser dividida sem prejudicar o objetivo, deve-se considerar a divisão em incrementos menores.

## Resultado esperado

A squad mantém controle sobre a evolução do software em vez de depender de grandes mudanças difíceis de verificar.