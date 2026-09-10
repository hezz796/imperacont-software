---
title: Capacidade e Escalabilidade
description: Define princípios para avaliar capacidade operacional, crescimento de carga e necessidade de expansão de recursos.
type: guide
status: active
scope: squad
tags:
  - devops
  - capacidade
  - escalabilidade
  - desempenho
---

# Capacidade e Escalabilidade

## Capacidade

Capacidade representa o volume de trabalho que o sistema consegue suportar dentro de critérios definidos.

## Escalabilidade

Escalabilidade representa a capacidade de lidar com crescimento de demanda por meio de mudanças apropriadas de recursos ou arquitetura.

## Demanda

A análise deve considerar:

- usuários;
- operações;
- dados;
- frequência;
- picos;
- crescimento esperado;
- comportamento imprevisível.

## Gargalos

Um sistema pode possuir gargalos em:

- processamento;
- memória;
- armazenamento;
- rede;
- banco de dados;
- dependências;
- componentes externos.

## Escalabilidade não é sinônimo de desempenho

Um sistema pode ter bom desempenho em determinada carga e ainda possuir baixa capacidade de crescimento.

## Planejamento

Capacidade deve ser avaliada com base em:

- evidências;
- métricas;
- testes;
- tendências;
- requisitos.

## Princípio

Não antecipar complexidade de escala sem evidência suficiente.

Ao mesmo tempo, não ignorar requisitos de crescimento quando forem relevantes para o produto.

---

## Relações na Squad

### Skills relacionadas

- `performance-testing`
- `architecture-design`
- `release-monitoring`

### Agentes relacionados

- `devops-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `07-delivery`