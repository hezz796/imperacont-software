---
title: Vulnerabilidades e Dependências
description: Orienta a identificação, avaliação, tratamento e acompanhamento de vulnerabilidades presentes no software e em suas dependências.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - vulnerabilidades
  - dependencias
  - manutencao
---

# Vulnerabilidades e Dependências

## Objetivo

Componentes utilizados pelo produto podem introduzir riscos mesmo quando não foram desenvolvidos pela própria equipe.

## Dependência como risco

Uma dependência pode possuir:

- vulnerabilidades conhecidas;
- manutenção insuficiente;
- comportamento inesperado;
- licença inadequada;
- cadeia de dependências extensa;
- risco de abandono;
- risco de comprometimento.

## Avaliação

Uma vulnerabilidade deve ser avaliada considerando:

- existência;
- exposição;
- possibilidade de exploração;
- impacto;
- contexto de uso;
- mitigação existente;
- versão afetada;
- capacidade de atualização.

## Tratamento

Possíveis respostas:

- atualizar;
- substituir;
- remover;
- mitigar;
- isolar;
- aceitar conscientemente o risco.

## Não utilizar apenas severidade

Uma classificação externa de severidade é importante, mas não substitui a análise contextual.

## Inventário

A squad deve buscar manter visibilidade sobre componentes relevantes utilizados pelo produto.

## Ciclo contínuo

Gestão de vulnerabilidades não termina com uma correção.

Novas vulnerabilidades podem surgir durante toda a vida útil do produto.

---

## Relações na Squad

### Skills relacionadas

- `security-testing`
- `dependency-management`
- `security-design`

### Agentes relacionados

- `security-engineer`
- `software-engineer`

### Workflows relacionados

- `05-development`
- `06-quality`
- `07-delivery`