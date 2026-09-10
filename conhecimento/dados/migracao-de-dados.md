---
title: Migração de Dados
description: Define princípios para mover, transformar ou reorganizar dados preservando sua integridade e disponibilidade.
type: guide
status: active
scope: squad
tags:
  - dados
  - migracao
  - evolucao
  - recuperacao
---

# Migração de Dados

## Objetivo

Migração altera o local, estrutura, formato ou modelo dos dados.

## Riscos

Pode provocar:

- perda;
- duplicidade;
- inconsistência;
- corrupção;
- indisponibilidade;
- incompatibilidade.

## Planejamento

Uma migração relevante deve considerar:

- origem;
- destino;
- volume;
- transformação;
- dependências;
- validação;
- janela;
- recuperação.

## Estratégias

Podem existir diferentes estratégias:

- migração direta;
- migração incremental;
- coexistência;
- replicação;
- transformação gradual.

## Validação

Após a migração, verificar:

- quantidade;
- integridade;
- relacionamentos;
- regras;
- amostras;
- comportamento funcional.

## Recuperação

Deve existir estratégia proporcional para lidar com falhas.

## Regra

Migração de dados deve ser tratada como mudança arquitetural e operacional, não apenas como tarefa de implementação.

---

## Relações na Squad

### Skills relacionadas

- `data-modeling`
- `deployment`
- `rollback-and-recovery`
- `technical-debt-management`

### Agentes relacionados

- `data-engineer`
- `devops-engineer`

### Workflows relacionados

- `07-delivery`
- `08-evolution`