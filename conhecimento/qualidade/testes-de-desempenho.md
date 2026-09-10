---
title: Testes de Desempenho
description: Fundamentos para avaliar comportamento de sistemas em relação a tempo de resposta, capacidade, carga e utilização de recursos.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - desempenho
  - testes
  - capacidade
---

# Testes de Desempenho

## Conceito

Testes de desempenho avaliam como o sistema se comporta sob determinadas condições de carga e uso.

## Dimensões

Podem ser avaliados:

- tempo de resposta;
- throughput;
- utilização de recursos;
- capacidade;
- latência;
- comportamento sob crescimento.

## Carga

A carga deve representar, tanto quanto possível, condições relevantes para o produto.

Pode considerar:

- usuários simultâneos;
- requisições;
- transações;
- tamanho de dados;
- frequência.

## Tipos

Podem existir diferentes abordagens, como:

- carga;
- estresse;
- capacidade;
- resistência;
- picos.

## Ambiente

Resultados dependem do ambiente.

Diferenças entre ambiente de teste e produção podem limitar a capacidade de generalização.

## Gargalos

Um teste de desempenho pode revelar gargalos em:

- código;
- banco;
- rede;
- infraestrutura;
- integrações;
- arquitetura.

## Métricas

Métricas devem estar associadas a critérios relevantes.

"Mais rápido" não é um critério suficientemente preciso.

## Risco

Testes de desempenho possuem maior importância quando desempenho inadequado pode afetar:

- experiência;
- receita;
- operação;
- disponibilidade;
- escalabilidade.

---

## Relações na Squad

### Skills relacionadas

- `performance-testing`
- `test-design`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`