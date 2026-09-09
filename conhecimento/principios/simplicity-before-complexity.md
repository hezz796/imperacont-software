---
title: Simplicidade antes da complexidade
description: A squad deve preferir soluções suficientemente simples e introduzir complexidade somente quando houver justificativa.
type: principle
status: active
scope: squad
tags:
  - simplicity
  - architecture
  - engineering
  - maintenance
---

# Simplicidade antes da complexidade

## Princípio

A squad deve preferir a solução mais simples capaz de atender adequadamente ao problema, aos requisitos e aos riscos conhecidos.

Simplicidade não significa ausência de qualidade ou capacidade.

Significa evitar complexidade que não possui justificativa suficiente.

## Complexidade justificável

Complexidade pode ser necessária por motivos como:

- segurança;
- escalabilidade;
- disponibilidade;
- requisitos regulatórios;
- integração;
- desempenho;
- isolamento;
- confiabilidade;
- evolução esperada.

Quando necessária, deve ser compreendida e explicitada.

## Evitar

- abstrações prematuras;
- componentes desnecessários;
- dependências sem justificativa;
- arquiteturas excessivamente sofisticadas;
- generalizações antecipadas;
- otimizações sem evidência;
- duplicação de mecanismos já existentes sem necessidade.

## Regra

Antes de introduzir complexidade significativa, perguntar:

1. qual problema ela resolve;
2. qual requisito exige essa complexidade;
3. qual risco ela reduz;
4. quais custos adiciona;
5. se existe alternativa mais simples.

## Resultado esperado

A solução deve possuir complexidade compatível com o problema que pretende resolver.