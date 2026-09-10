---
title: Testes de Regressão
description: Fundamentos para verificar se mudanças introduziram defeitos ou alteraram comportamentos previamente corretos.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - testes
  - regressao
  - mudancas
---

# Testes de Regressão

## Conceito

Teste de regressão busca identificar se uma mudança provocou comportamento incorreto em funcionalidades que anteriormente funcionavam adequadamente.

## Causa

Regressões podem ocorrer por:

- alterações de código;
- mudanças de dependências;
- alterações de configuração;
- modificações de dados;
- mudanças de infraestrutura;
- alterações de contratos.

## Seleção

Nem sempre é necessário executar todos os testes existentes.

A seleção pode considerar:

- área modificada;
- dependências;
- histórico;
- risco;
- criticidade.

## Regressão seletiva

Uma estratégia seletiva pode reduzir tempo mantendo atenção sobre áreas relevantes.

## Regressão ampla

Pode ser apropriada quando:

- a mudança é extensa;
- o impacto é difícil de delimitar;
- o risco é elevado;
- existem dependências complexas.

## Automação

Testes automatizados são particularmente úteis para regressão repetitiva.

## Limitação

Uma suíte de regressão somente protege contra problemas que seus testes conseguem detectar.

Se a cobertura for inadequada, regressões podem permanecer invisíveis.

## Evolução

A suíte de regressão deve evoluir com:

- defeitos encontrados;
- mudanças;
- novos requisitos;
- riscos identificados.

---

## Relações na Squad

### Skills relacionadas

- `regression-testing`
- `test-design`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`
- `07-delivery`