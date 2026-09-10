---
title: Infraestrutura e Automação
description: Define princípios para provisionamento, configuração e gerenciamento automatizado de recursos necessários à operação do software.
type: guide
status: active
scope: squad
tags:
  - devops
  - infraestrutura
  - automacao
  - operacoes
---

# Infraestrutura e Automação

## Objetivo

Infraestrutura deve ser tratada como parte do sistema que sustenta o produto.

## Automação

Automação pode reduzir:

- esforço manual;
- inconsistências;
- tempo de execução;
- erros repetitivos;
- dificuldade de reprodução.

## Repetibilidade

Um ambiente importante deve poder ser reconstruído de forma previsível sempre que possível.

## Provisionamento

O provisionamento deve considerar:

- recursos;
- dependências;
- configuração;
- segurança;
- capacidade;
- observabilidade;
- recuperação.

## Mudanças

Alterações de infraestrutura podem afetar diretamente o produto e devem possuir controle proporcional ao risco.

## Infraestrutura como código

Quando aplicável, representar infraestrutura por definições versionáveis pode melhorar:

- rastreabilidade;
- revisão;
- repetibilidade;
- recuperação;
- colaboração.

## Abstração tecnológica

Os princípios permanecem independentes da ferramenta utilizada.

A escolha tecnológica deve decorrer do contexto e dos requisitos.

---

## Relações na Squad

### Skills relacionadas

- `environment-management`
- `deployment`
- `configuration-management`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`