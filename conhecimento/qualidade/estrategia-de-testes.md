---
title: Estratégia de Testes
description: Fundamentos para definir como uma solução será avaliada considerando riscos, requisitos, arquitetura, comportamento e contexto.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - testes
  - estrategia
---

# Estratégia de Testes

## Conceito

Estratégia de testes define uma abordagem coerente para obter evidências sobre o comportamento e a qualidade de um produto.

## Objetivo

Uma estratégia deve responder, entre outras questões:

- o que precisa ser avaliado;
- por que precisa ser avaliado;
- quais riscos existem;
- quais níveis de teste são apropriados;
- quais evidências são necessárias.

## Base da estratégia

A estratégia deve considerar:

- requisitos;
- regras de negócio;
- arquitetura;
- riscos;
- mudanças;
- integrações;
- usuários;
- atributos de qualidade.

## Cobertura

Cobertura deve ser analisada de forma significativa.

Pode envolver:

- requisitos;
- comportamentos;
- caminhos;
- riscos;
- componentes;
- integrações.

Cobertura de código é apenas uma das possíveis dimensões.

## Automação

Automação pode aumentar repetibilidade e velocidade.

Entretanto, nem todo teste precisa ou deve ser automatizado.

## Testes manuais

Avaliações manuais podem ser importantes para:

- exploração;
- experiência;
- comportamento inesperado;
- aspectos difíceis de automatizar.

## Pirâmide e distribuição

A distribuição entre diferentes níveis de teste deve considerar:

- custo;
- velocidade;
- confiabilidade;
- valor diagnóstico;
- risco.

Não existe uma distribuição universal válida para todos os sistemas.

## Feedback

Uma estratégia adequada deve produzir feedback suficientemente rápido para que problemas sejam corrigidos com menor custo.

## Evolução

A estratégia de testes deve evoluir conforme:

- produto;
- arquitetura;
- riscos;
- histórico de defeitos;
- mudanças.

---

## Relações na Squad

### Skills relacionadas

- `test-strategy`
- `test-design`
- `quality-gates`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`