---
title: Segredos e Credenciais
description: Define princípios para proteção, utilização, rotação e revogação de segredos e credenciais.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - credenciais
  - segredos
  - acesso
---

# Segredos e Credenciais

## Objetivo

Segredos e credenciais devem ser protegidos contra exposição, uso indevido e permanência desnecessária.

## Exemplos

Podem incluir:

- senhas;
- tokens;
- chaves;
- certificados;
- credenciais de serviços;
- códigos de acesso;
- material criptográfico.

## Princípios

Segredos devem:

- possuir acesso restrito;
- ser utilizados somente quando necessários;
- não ser incorporados desnecessariamente ao código;
- não ser expostos em logs;
- possuir ciclo de vida controlado;
- ser revogáveis;
- ser substituíveis.

## Rotação

Credenciais relevantes devem possuir mecanismos apropriados para renovação ou substituição.

## Revogação

Deve existir capacidade de invalidar credenciais comprometidas.

## Exposição acidental

A descoberta de um segredo em:

- código;
- histórico;
- log;
- configuração;
- documentação;
- artefato;

deve ser tratada como possível incidente de segurança.

## Regra

Segredo não deve ser considerado seguro apenas porque o repositório ou ambiente parece privado.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `configuration-management`
- `deployment`

### Agentes relacionados

- `security-engineer`
- `devops-engineer`

### Workflows relacionados

- `05-development`
- `07-delivery`