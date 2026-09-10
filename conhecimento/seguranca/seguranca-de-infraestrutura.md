---
title: Segurança de Infraestrutura
description: Define princípios para proteção de ambientes, recursos computacionais, redes, serviços e componentes de infraestrutura.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - infraestrutura
  - ambientes
  - operacoes
---

# Segurança de Infraestrutura

## Objetivo

A infraestrutura deve reduzir exposição e limitar o impacto de comprometimentos.

## Superfície de exposição

Deve-se identificar:

- serviços expostos;
- interfaces;
- portas;
- ambientes;
- redes;
- identidades;
- componentes administrativos;
- dependências externas.

## Segregação

Quando apropriado, separar:

- ambientes;
- funções;
- recursos;
- redes;
- dados;
- privilégios.

## Hardening

A configuração deve reduzir recursos, serviços e permissões desnecessários.

## Ambientes

Desenvolvimento, teste e produção devem possuir controles apropriados ao risco de cada contexto.

## Privilégios administrativos

Acesso administrativo deve ser limitado, protegido e rastreável.

## Disponibilidade

Segurança também deve considerar disponibilidade e capacidade de recuperação.

## Infraestrutura como superfície de ataque

Comprometimento da infraestrutura pode afetar vários componentes simultaneamente.

Por isso, controles devem considerar dependências e impacto sistêmico.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `environment-management`
- `configuration-management`
- `security-testing`

### Agentes relacionados

- `security-engineer`
- `devops-engineer`

### Workflows relacionados

- `04-architecture`
- `07-delivery`