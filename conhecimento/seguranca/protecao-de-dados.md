---
title: Proteção de Dados
description: Orienta princípios para proteção de dados durante coleta, processamento, armazenamento, transmissão, uso e descarte.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - dados
  - privacidade
  - protecao
---

# Proteção de Dados

## Objetivo

Dados devem ser protegidos de acordo com sua sensibilidade, finalidade, exposição e impacto potencial.

## Ciclo de vida

A análise deve considerar:

1. coleta;
2. entrada;
3. processamento;
4. armazenamento;
5. transmissão;
6. compartilhamento;
7. retenção;
8. arquivamento;
9. descarte.

## Minimização

Evitar coleta e armazenamento de dados que não sejam necessários para a finalidade definida.

## Classificação

Quando aplicável, os dados podem ser classificados conforme:

- sensibilidade;
- criticidade;
- impacto;
- necessidade de acesso;
- requisitos legais ou contratuais.

## Proteção

Controles podem envolver:

- controle de acesso;
- criptografia;
- segregação;
- minimização;
- mascaramento;
- proteção de cópias;
- retenção adequada;
- descarte seguro.

## Dados em trânsito e em repouso

A proteção deve considerar tanto dados armazenados quanto dados transmitidos entre componentes.

## Cópias

Backups, logs, caches, ambientes de teste e exportações podem conter os mesmos dados sensíveis do sistema principal.

Portanto, também fazem parte da superfície de proteção.

## Regra

A proteção de dados deve ser analisada desde o desenho do produto e não apenas na infraestrutura de armazenamento.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `data-modeling`
- `configuration-management`

### Agentes relacionados

- `security-engineer`
- `data-engineer`

### Workflows relacionados

- `04-architecture`
- `05-development`