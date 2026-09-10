---
title: Acesso e Compartilhamento de Dados
description: Define princípios para controlar acesso, exposição e compartilhamento de dados entre usuários, componentes e sistemas.
type: guide
status: active
scope: squad
tags:
  - dados
  - acesso
  - compartilhamento
  - seguranca
---

# Acesso e Compartilhamento de Dados

## Objetivo

Dados devem ser acessíveis apenas nos contextos necessários à finalidade definida.

## Menor privilégio

Usuários e sistemas devem receber somente o acesso necessário.

## Compartilhamento

Antes de compartilhar dados, avaliar:

- finalidade;
- destinatário;
- necessidade;
- sensibilidade;
- impacto;
- segurança;
- rastreabilidade.

## Dados derivados

Relatórios, exportações, caches e cópias podem conter informações equivalentes às fontes originais.

Devem receber proteção compatível.

## Interfaces

APIs e integrações devem expor somente os dados necessários.

## Acesso interno

"Interno" não significa automaticamente "sem risco".

O acesso deve continuar sujeito a controles apropriados.

## Revogação

Acesso que deixa de ser necessário deve ser removido ou reduzido.

## Auditoria

Acessos relevantes devem possuir rastreabilidade proporcional ao risco.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `data-modeling`
- `api-design`

### Agentes relacionados

- `data-engineer`
- `security-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`