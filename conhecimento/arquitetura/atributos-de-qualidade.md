---
title: Atributos de Qualidade
description: Fundamentos para compreender características não funcionais que influenciam decisões arquiteturais e comportamento do sistema.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - qualidade
  - requisitos-nao-funcionais
---

# Atributos de Qualidade

## Conceito

Atributos de qualidade representam características importantes do comportamento ou das propriedades de um sistema.

Eles influenciam diretamente decisões arquiteturais.

## Exemplos

Podem incluir:

- desempenho;
- disponibilidade;
- confiabilidade;
- segurança;
- escalabilidade;
- manutenibilidade;
- testabilidade;
- observabilidade;
- portabilidade;
- interoperabilidade;
- recuperabilidade.

## Contexto

Nem todo atributo possui a mesma importância em todo produto.

Um sistema crítico pode priorizar disponibilidade e recuperação.

Outro sistema pode priorizar velocidade de evolução.

## Requisitos verificáveis

Sempre que possível, atributos devem ser associados a critérios verificáveis.

Termos vagos como "rápido", "seguro" ou "escalável" possuem pouco valor isoladamente.

## Trade-offs

Atributos podem entrar em conflito.

Por exemplo:

- maior consistência pode aumentar latência;
- maior redundância pode aumentar custo;
- maior flexibilidade pode aumentar complexidade.

## Priorização

A prioridade deve considerar:

- impacto no negócio;
- risco;
- frequência;
- custo da falha;
- expectativa do usuário;
- restrições.

## Arquitetura

A arquitetura deve responder aos atributos realmente importantes.

Não é necessário maximizar todos os atributos simultaneamente.

O objetivo é alcançar o nível adequado para o contexto.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `test-strategy`
- `security-design`

### Agentes relacionados

- `solution-architect`
- `test-engineer`

### Workflows relacionados

- `04-architecture`
- `06-quality`