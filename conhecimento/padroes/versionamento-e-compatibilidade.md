---
title: Versionamento e Compatibilidade
description: Define padrões para evolução controlada de contratos, componentes, dados e interfaces.
type: pattern
status: active
scope: squad
tags:
  - padrões
  - versionamento
  - compatibilidade
  - evolucao
---

# Versionamento e Compatibilidade

## Problema

Uma parte do sistema precisa evoluir enquanto outras partes ainda dependem de seu comportamento atual.

## Intenção

Permitir evolução sem interromper consumidores desnecessariamente.

## Estratégias

Podem ser utilizadas:

- mudanças compatíveis;
- coexistência temporária;
- versionamento;
- adaptação;
- migração gradual;
- período de transição.

## Compatibilidade

Uma mudança pode afetar:

- estrutura;
- comportamento;
- dados;
- erros;
- desempenho;
- segurança;
- semântica.

Compatibilidade não deve ser avaliada apenas pela forma.

## Depreciação

Quando uma interface ou comportamento será substituído, deve existir, quando necessário:

1. comunicação;
2. alternativa;
3. período de transição;
4. monitoramento;
5. remoção planejada.

## Princípio

Quanto mais consumidores existirem, maior a importância de controlar a evolução do contrato.

---

## Relações na Squad

### Skills relacionadas

- `versioning`
- `api-design`
- `change-management`
- `release-planning`

### Agentes relacionados

- `solution-architect`
- `devops-engineer`
- `data-engineer`

### Workflows relacionados

- `07-delivery`
- `08-evolution`