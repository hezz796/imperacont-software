---
title: Identidade e Autenticação
description: Define conceitos fundamentais para identificação de entidades e verificação de identidade em sistemas.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - identidade
  - autenticacao
  - acesso
---

# Identidade e Autenticação

## Identidade

Identidade representa uma entidade reconhecível dentro de determinado contexto.

Pode representar:

- pessoa;
- organização;
- serviço;
- aplicação;
- dispositivo;
- processo.

## Autenticação

Autenticação é a verificação de uma identidade declarada.

Ela deve ser distinguida de autorização.

- autenticação: quem é a entidade?
- autorização: o que essa entidade pode fazer?

## Fatores de autenticação

Os fatores podem envolver categorias como:

- algo que a pessoa sabe;
- algo que possui;
- algo que é.

A combinação de fatores pode aumentar a resistência a determinados ataques.

## Princípios

Sistemas de autenticação devem considerar:

- proteção das credenciais;
- resistência a ataques;
- recuperação segura;
- expiração e renovação quando aplicável;
- proteção contra abuso;
- gestão do ciclo de vida da identidade;
- rastreabilidade;
- privacidade.

## Ciclo de vida

Uma identidade pode passar por:

1. criação;
2. ativação;
3. alteração;
4. suspensão;
5. recuperação;
6. revogação;
7. encerramento.

## Recuperação de acesso

Mecanismos de recuperação devem ser tratados como parte da superfície de autenticação.

Um sistema fortemente protegido no login pode continuar vulnerável se a recuperação for fraca.

## Regra

Autenticação deve ser analisada junto com autorização, sessão, recuperação, auditoria e proteção dos dados envolvidos.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `api-design`
- `implementation`

### Agentes relacionados

- `security-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`