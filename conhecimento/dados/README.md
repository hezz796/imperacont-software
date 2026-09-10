---
title: Dados
description: Organiza os conhecimentos fundamentais para modelagem, armazenamento, qualidade, integração, governança e evolução dos dados dos produtos.
type: guide
status: active
scope: squad
tags:
  - dados
  - modelagem
  - arquitetura
  - governanca
---

# Dados

## Finalidade

Esta categoria reúne conhecimentos para tratar dados como parte fundamental do produto e da arquitetura da solução.

Dados não devem ser considerados apenas como estruturas de armazenamento.

Eles representam informações utilizadas para:

- executar processos;
- tomar decisões;
- produzir resultados;
- registrar eventos;
- operar o produto;
- gerar aprendizado.

## Escopo

A categoria aborda:

- princípios de dados;
- dados como ativo;
- domínio;
- modelagem;
- qualidade;
- integridade;
- consistência;
- persistência;
- ciclo de vida;
- governança;
- acesso;
- compartilhamento;
- integração;
- migração;
- versionamento;
- dados analíticos;
- evolução da arquitetura de dados.

## Princípio geral

A squad deve buscar:

> dados corretos, compreensíveis, protegidos, rastreáveis e adequados à finalidade para a qual são utilizados.

## Relação com outras camadas

### Agent

`data-engineer` é o agente especializado em dados.

### Skills

As skills operacionalizam competências como:

- data-modeling;
- architecture-design;
- integration-design;
- technical-decisions.

### Arquitetura

A arquitetura deve definir responsabilidades, fronteiras, persistência, integrações e requisitos de qualidade relacionados aos dados.

### Segurança

Dados devem ser tratados em conjunto com os princípios de proteção e segurança.

### Produto

Os dados devem existir por uma finalidade de negócio ou operacional clara.

## Regra

Não escolher uma tecnologia de armazenamento apenas porque ela é conhecida pela equipe.

A decisão deve considerar:

- natureza dos dados;
- acesso;
- consistência;
- volume;
- desempenho;
- disponibilidade;
- evolução;
- segurança;
- custo;
- operação.

## Resultado esperado

A arquitetura de dados deve permitir que a squad:

- compreenda os dados;
- mantenha sua integridade;
- controle seu acesso;
- acompanhe seu ciclo de vida;
- evolua sem perda indevida de informação.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `domain-modeling`
- `architecture-design`
- `integration-design`
- `technical-decisions`
- `quality-gates`

### Agentes relacionados

- `data-engineer`
- `solution-architect`
- `software-engineer`
- `security-engineer`
- `devops-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`
- `07-delivery`
- `08-evolution`