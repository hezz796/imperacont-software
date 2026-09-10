---
title: Modelagem de Dados
description: Define princípios para representar entidades, atributos, relacionamentos, regras e estruturas de dados de forma coerente.
type: guide
status: active
scope: squad
tags:
  - dados
  - modelagem
  - entidades
  - relacionamentos
---

# Modelagem de Dados

## Objetivo

Modelagem de dados busca representar informações necessárias ao domínio e aos processos do produto.

## Níveis conceituais

Uma modelagem pode considerar diferentes níveis de abstração:

- conceitual;
- lógico;
- físico.

## Modelo conceitual

Concentra-se em:

- conceitos;
- entidades;
- relacionamentos;
- regras.

## Modelo lógico

Detalha estruturas necessárias para representar o domínio sem depender necessariamente de uma tecnologia específica.

## Modelo físico

Representa como os dados serão efetivamente armazenados em determinada tecnologia.

## Princípios

O modelo deve buscar:

- clareza;
- consistência;
- integridade;
- simplicidade;
- evolução;
- adequação ao domínio.

## Normalização e desnormalização

Normalização pode reduzir redundância e inconsistência.

Desnormalização pode ser apropriada quando requisitos de acesso, desempenho ou arquitetura justificarem.

Nenhuma deve ser tratada como regra absoluta.

## Modelo não é contrato imutável

O modelo deve evoluir conforme:

- domínio;
- requisitos;
- arquitetura;
- operação;
- aprendizado.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `domain-modeling`
- `architecture-design`

### Agentes relacionados

- `data-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`