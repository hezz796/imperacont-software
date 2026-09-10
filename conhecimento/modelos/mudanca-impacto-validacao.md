---
title: Mudança, Impacto e Validação
description: Estrutura a análise de mudanças desde sua origem até a verificação dos efeitos produzidos.
type: model
status: active
scope: squad
tags:
  - modelos
  - mudancas
  - impacto
  - validacao
---

# Mudança, Impacto e Validação

## Estrutura

```text
MUDANÇA
   ↓
IMPACTO
   ↓
RISCO
   ↓
IMPLEMENTAÇÃO
   ↓
VALIDAÇÃO
   ↓
RESULTADO
```

## Mudança

Aquilo que será alterado.

## Impacto

Partes potencialmente afetadas.

## Risco

Possíveis consequências indesejadas.

## Implementação

Execução da alteração.

## Validação

Verificação de que a mudança produziu o comportamento esperado e não introduziu efeitos inadequados.

## Resultado

O efeito observado após a mudança.

## Aplicação

Pode ser utilizado para mudanças em:

- produto;
- requisitos;
- código;
- arquitetura;
- dados;
- infraestrutura;
- processos.

## Princípio

Não considerar uma mudança concluída apenas porque foi implementada.

A conclusão depende da validação adequada ao risco.

---

## Relações na Squad

### Skills relacionadas

- `change-management`
- `technical-decisions`
- `post-release-analysis`

### Agentes relacionados

- `squad-lead`
- `reviewer`

### Workflows relacionados

- `07-delivery`
- `08-evolution`