---
title: Decisão baseada em risco
description: O esforço de análise, desenvolvimento, teste e controle deve ser proporcional aos riscos envolvidos.
type: principle
status: active
scope: squad
tags:
  - risk
  - quality
  - security
  - architecture
---

# Decisão baseada em risco

## Princípio

A squad deve direcionar esforço de análise, engenharia, testes, segurança e revisão de acordo com o risco associado ao contexto.

Nem todas as partes de um sistema exigem o mesmo nível de controle.

## Dimensões

O risco pode envolver:

- impacto;
- probabilidade;
- incerteza;
- complexidade;
- exposição;
- criticidade;
- dependências;
- reversibilidade;
- impacto operacional;
- impacto sobre usuários ou negócio.

## Aplicação

Decisões de maior risco podem exigir:

- investigação adicional;
- validação;
- revisão independente;
- testes mais abrangentes;
- análise de segurança;
- observabilidade adicional;
- plano de recuperação;
- documentação mais detalhada.

## Regra

Não utilizar simplesmente "mais esforço" como sinônimo de qualidade.

O objetivo é utilizar o esforço certo no lugar certo.

## Resultado esperado

A squad deve concentrar seus mecanismos de controle onde um erro teria maior consequência.

---

## Relações na Squad

### Skills relacionadas

- `test-strategy`
- `security-design`
- `technical-decisions`
- `quality-gates`

### Agentes relacionados

- `squad-lead`
- `reviewer`

### Workflows relacionados

- `01-discovery`
- `04-architecture`
- `06-quality`
- `07-delivery`