---
title: Qualidade Baseada em Risco
description: Fundamentos para direcionar esforço de qualidade de acordo com probabilidade, impacto e características do risco.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - risco
  - testes
  - priorizacao
---

# Qualidade Baseada em Risco

## Conceito

Qualidade baseada em risco significa direcionar esforço de avaliação para as áreas em que uma falha pode produzir maior consequência ou probabilidade.

## Risco

De forma simplificada, risco pode ser analisado pela combinação entre:

- probabilidade;
- impacto.

Outros fatores também podem ser relevantes, como:

- detectabilidade;
- exposição;
- reversibilidade.

## Impacto

O impacto de uma falha pode envolver:

- usuários;
- receita;
- dados;
- segurança;
- reputação;
- operação;
- conformidade;
- continuidade.

## Probabilidade

A probabilidade pode aumentar devido a:

- complexidade;
- mudanças recentes;
- histórico de defeitos;
- dependências;
- falta de cobertura;
- incerteza.

## Priorização

Áreas de maior risco normalmente justificam maior atenção.

Isso não significa ignorar áreas de baixo risco, mas estabelecer uma proporção adequada entre esforço e consequência.

## Risco versus cobertura

Alta cobertura de testes não significa necessariamente baixo risco.

É possível possuir muitos testes e ainda deixar sem avaliação um cenário crítico.

## Mudança

Mudanças podem alterar o perfil de risco.

Uma funcionalidade anteriormente estável pode exigir nova avaliação depois de alterações importantes.

## Risco residual

Mesmo após testes, algum risco pode permanecer.

A decisão de aceitar esse risco deve ser consciente e compatível com o contexto.

## Evidência

O objetivo da abordagem baseada em risco é produzir evidência suficiente para apoiar decisões proporcionais ao risco.

---

## Relações na Squad

### Skills relacionadas

- `test-strategy`
- `quality-gates`
- `security-testing`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`
- `07-delivery`