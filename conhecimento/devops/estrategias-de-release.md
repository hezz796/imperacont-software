---
title: Estratégias de Release
description: Apresenta princípios para selecionar e executar estratégias de disponibilização de versões conforme risco e contexto.
type: guide
status: active
scope: squad
tags:
  - devops
  - release
  - entrega
  - risco
---

# Estratégias de Release

## Objetivo

Uma release deve controlar a exposição de uma mudança de acordo com seu risco.

## Estratégias

Dependendo do contexto, podem ser utilizadas estratégias como:

- liberação total;
- liberação gradual;
- grupos controlados;
- exposição progressiva;
- coexistência de versões;
- ativação controlada por configuração.

## Seleção

A estratégia deve considerar:

- impacto;
- número de usuários;
- criticidade;
- capacidade de monitoramento;
- facilidade de recuperação;
- complexidade operacional.

## Liberação gradual

Reduzir inicialmente a exposição pode limitar o impacto de problemas desconhecidos.

## Feature flags

Podem separar:

- implantação técnica;
- ativação funcional.

Entretanto, flags também criam complexidade e devem possuir ciclo de vida controlado.

## Release não é apenas versão

Uma release representa uma mudança disponibilizada a um contexto de usuários ou operação.

Sua avaliação deve considerar o comportamento real após a disponibilização.

---

## Relações na Squad

### Skills relacionadas

- `release-strategy`
- `release-planning`
- `deployment`
- `rollback-and-recovery`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`