---
title: Confiabilidade Operacional
description: Orienta a construção e operação de sistemas capazes de funcionar de maneira previsível e recuperar-se de falhas.
type: guide
status: active
scope: squad
tags:
  - devops
  - confiabilidade
  - disponibilidade
  - resiliencia
---

# Confiabilidade Operacional

## Objetivo

Confiabilidade representa a capacidade de um sistema manter comportamento adequado ao longo do tempo e diante das condições previstas.

## Dimensões

Pode envolver:

- disponibilidade;
- estabilidade;
- recuperação;
- tolerância a falhas;
- consistência;
- desempenho;
- previsibilidade.

## Falhas esperadas

Sistemas reais devem considerar que:

- componentes falham;
- redes falham;
- dependências ficam indisponíveis;
- configurações podem estar incorretas;
- mudanças podem introduzir defeitos.

## Degradação

Quando apropriado, o sistema pode degradar de maneira controlada em vez de falhar completamente.

## Recuperação

A confiabilidade depende também da capacidade de:

- detectar;
- diagnosticar;
- conter;
- recuperar.

## Medição

Indicadores devem ser escolhidos de acordo com o comportamento que realmente importa para usuários e operação.

## Equilíbrio

Buscar disponibilidade absoluta pode gerar complexidade excessiva.

As metas devem ser proporcionais à criticidade e ao valor do produto.

---

## Relações na Squad

### Skills relacionadas

- `reliability-testing`
- `incident-response`
- `release-monitoring`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`
- `08-evolution`