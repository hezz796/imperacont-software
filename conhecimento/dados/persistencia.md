---
title: Persistência
description: Define princípios para armazenamento durável, acesso e recuperação dos dados necessários ao produto.
type: guide
status: active
scope: squad
tags:
  - dados
  - persistencia
  - armazenamento
  - arquitetura
---

# Persistência

## Objetivo

Persistência trata da manutenção de dados além do ciclo de execução de determinado processo.

## Decisões

A estratégia de persistência deve considerar:

- natureza dos dados;
- padrão de acesso;
- consistência;
- volume;
- crescimento;
- disponibilidade;
- recuperação;
- segurança;
- custo.

## Durabilidade

Dados críticos devem possuir mecanismos compatíveis com sua importância.

## Acesso

O mecanismo de armazenamento deve suportar os padrões de acesso necessários sem criar complexidade desnecessária.

## Persistência não é necessariamente banco relacional

A tecnologia deve ser escolhida conforme o problema.

Podem existir diferentes modelos de persistência dependendo do contexto.

## Acoplamento

O produto deve evitar acoplamento desnecessário a detalhes de persistência quando isso prejudicar evolução.

## Backup

Backup não substitui completamente uma estratégia de recuperação.

É necessário considerar:

- restauração;
- integridade;
- frequência;
- retenção;
- tempo de recuperação;
- testes.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `architecture-design`
- `configuration-management`

### Agentes relacionados

- `data-engineer`
- `solution-architect`

### Workflows relacionados

- `04-architecture`