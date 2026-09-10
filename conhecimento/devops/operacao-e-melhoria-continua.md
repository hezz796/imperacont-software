---
title: Operação e Melhoria Contínua
description: Consolida princípios para operar software de forma sustentável e transformar resultados operacionais em melhorias contínuas.
type: guide
status: active
scope: squad
tags:
  - devops
  - operacoes
  - melhoria-continua
  - evolucao
---

# Operação e Melhoria Contínua

## Objetivo

Operação não é o ponto final do desenvolvimento.

É uma fonte contínua de evidências sobre o comportamento real do produto.

## Fontes de aprendizado

Podem incluir:

- métricas;
- logs;
- incidentes;
- alertas;
- custos;
- desempenho;
- feedback;
- falhas;
- tickets;
- mudanças;
- comportamento dos usuários.

## Ciclo

Um ciclo operacional pode ser representado como:

`OBSERVAR → INTERPRETAR → DECIDIR → MUDAR → VALIDAR → OBSERVAR`

## Melhoria

Melhorias podem envolver:

- produto;
- arquitetura;
- código;
- infraestrutura;
- automação;
- processos;
- observabilidade;
- segurança;
- documentação.

## Evitar otimização local

Melhorar uma parte do fluxo não significa necessariamente melhorar o sistema inteiro.

Exemplos:

- aumentar velocidade de implantação pode aumentar incidentes;
- adicionar monitoramento pode aumentar ruído;
- aumentar redundância pode aumentar complexidade;
- automatizar um processo ruim pode apenas torná-lo mais rápido.

## Sustentabilidade

A operação deve considerar:

- custo;
- complexidade;
- capacidade da equipe;
- manutenção;
- segurança;
- confiabilidade;
- evolução.

## Relação com Evolution

Resultados operacionais devem alimentar o workflow de evolução.

O objetivo é transformar observações em decisões conscientes.

## Resultado

A operação deve gerar não apenas disponibilidade, mas também aprendizado capaz de melhorar continuamente o produto e o sistema que o sustenta.

---

## Relações na Squad

### Skills relacionadas

- `continuous-improvement`
- `release-monitoring`
- `post-release-analysis`
- `feedback-management`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`
- `08-evolution`