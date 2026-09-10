---
title: Autorização e Controle de Acesso
description: Define conceitos e princípios para controlar quais ações e recursos podem ser acessados por cada entidade.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - autorizacao
  - acesso
  - privilegios
---

# Autorização e Controle de Acesso

## Objetivo

Autorização determina quais ações uma entidade autenticada pode realizar dentro de determinado contexto.

## Menor privilégio

Conceder somente as permissões necessárias para a finalidade prevista.

## Separação de responsabilidades

Funções críticas podem exigir separação de responsabilidades para reduzir abuso ou erro.

## Controle contextual

Uma decisão de autorização pode depender de:

- identidade;
- função;
- recurso;
- ação;
- contexto;
- estado;
- finalidade;
- política.

## Recursos

O controle deve considerar não apenas funcionalidades, mas também os recursos acessados.

Por exemplo:

- registros;
- documentos;
- operações;
- configurações;
- relatórios;
- dados sensíveis.

## Falhas de autorização

Falhas podem ocorrer quando:

- uma permissão é concedida excessivamente;
- uma permissão não é verificada;
- uma regra é aplicada apenas na interface;
- um recurso pode ser acessado por referência indevida;
- permissões antigas permanecem ativas.

## Revogação

A remoção ou alteração de privilégios deve ser efetiva e verificável.

## Interface não é controle

Ocultar um botão ou funcionalidade na interface não substitui a autorização no ponto que realmente protege o recurso.

## Auditoria

Ações relevantes de acesso devem possuir rastreabilidade proporcional ao risco.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `api-design`
- `data-modeling`

### Agentes relacionados

- `security-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`