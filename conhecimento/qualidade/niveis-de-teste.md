---
title: Níveis de Teste
description: Fundamentos para distinguir níveis de avaliação desde unidades isoladas até o comportamento completo do produto.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - testes
  - niveis
---

# Níveis de Teste

## Conceito

Níveis de teste representam diferentes escopos de avaliação de um software.

## Teste de unidade

Avalia uma unidade relativamente isolada de comportamento.

É normalmente utilizado para verificar regras e comportamentos locais.

## Teste de integração

Avalia a interação entre partes que precisam funcionar conjuntamente.

Pode envolver:

- módulos;
- componentes;
- bancos;
- APIs;
- serviços;
- sistemas externos.

## Teste de sistema

Avalia o comportamento do sistema em um contexto mais amplo e próximo de sua utilização real.

## Teste de aceitação

Avalia se o produto atende aos critérios e necessidades definidos para determinada entrega ou objetivo.

## Relação entre níveis

Os níveis complementam-se.

Um teste de sistema não elimina necessariamente a necessidade de testes menores.

Da mesma forma, muitos testes unitários não garantem que integrações funcionem corretamente.

## Velocidade

Testes de menor escopo tendem a fornecer feedback mais rápido.

Testes de maior escopo podem oferecer maior realismo, mas geralmente possuem maior custo.

## Diagnóstico

Quanto maior o escopo de um teste, maior pode ser a dificuldade de identificar exatamente a origem da falha.

## Estratégia

A combinação dos níveis deve ser determinada pelo risco e pelo contexto do produto.

---

## Relações na Squad

### Skills relacionadas

- `unit-testing`
- `integration-testing`
- `system-testing`
- `acceptance-testing`

### Agentes relacionados

- `test-engineer`

### Workflows relacionados

- `06-quality`