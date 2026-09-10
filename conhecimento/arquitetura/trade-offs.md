---
title: Trade-offs Arquiteturais
description: Fundamentos para avaliar benefícios, custos, riscos e compromissos envolvidos em escolhas arquiteturais.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - trade-offs
  - decisoes
  - risco
---

# Trade-offs Arquiteturais

## Conceito

Trade-off representa uma situação em que melhorar determinada característica pode exigir aceitar custo, risco ou perda em outra dimensão.

## Não existe solução perfeita

Arquiteturas são escolhas condicionadas por:

- objetivos;
- recursos;
- riscos;
- restrições;
- tempo;
- contexto.

Uma solução excelente em determinado cenário pode ser inadequada em outro.

## Exemplos

Decisões podem envolver relações como:

- simplicidade versus flexibilidade;
- desempenho versus consistência;
- disponibilidade versus consistência;
- velocidade de entrega versus robustez;
- custo versus capacidade;
- isolamento versus complexidade operacional.

## Custo

O custo de uma decisão pode envolver:

- desenvolvimento;
- infraestrutura;
- operação;
- manutenção;
- aprendizado;
- suporte;
- migração;
- complexidade.

## Risco

O risco deve considerar:

- probabilidade;
- impacto;
- detectabilidade;
- reversibilidade;
- exposição.

## Horizonte

Uma decisão pode ser adequada para o presente e inadequada para o futuro.

Isso não significa que deva ser evitada.

A questão é compreender quando a decisão precisará ser revisitada.

## Complexidade

Complexidade é um custo arquitetural.

Ela deve ser introduzida quando o benefício esperado justificar o custo e o risco.

## Comunicação

Trade-offs relevantes devem ser explícitos para que a equipe compreenda não apenas o que foi escolhido, mas também o que foi conscientemente sacrificado.

---

## Relações na Squad

### Skills relacionadas

- `technical-decisions`
- `architecture-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`