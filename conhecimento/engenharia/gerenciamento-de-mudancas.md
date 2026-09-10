---
title: Gerenciamento de mudanças
description: Princípios para compreender, controlar e comunicar mudanças em produtos e sistemas.
type: guide
status: active
scope: squad
tags:
  - mudancas
  - engenharia
  - risco
  - entrega
---

# Gerenciamento de mudanças

## Princípio

Mudanças devem ser compreendidas e controladas de acordo com seu impacto e risco.

Nem toda mudança exige o mesmo processo.

## Avaliação

Uma mudança pode ser analisada considerando:

- objetivo;
- escopo;
- dependências;
- impacto funcional;
- impacto técnico;
- impacto operacional;
- impacto de segurança;
- risco;
- reversibilidade;
- necessidade de comunicação.

## Mudanças pequenas

Mudanças pequenas e de baixo risco podem seguir mecanismos leves.

## Mudanças críticas

Mudanças com alto impacto ou baixa reversibilidade podem exigir:

- análise adicional;
- revisão;
- testes ampliados;
- plano de implantação;
- monitoramento;
- estratégia de recuperação.

## Rastreabilidade

Quando necessário, uma mudança deve poder ser relacionada a:

```text
MOTIVAÇÃO
    ↓
DECISÃO
    ↓
IMPLEMENTAÇÃO
    ↓
VERIFICAÇÃO
    ↓
ENTREGA
    ↓
RESULTADO
```

## Resultado esperado

A squad deve conhecer suficientemente uma mudança para decidir como implementá-la, verificá-la e entregá-la com risco controlado.

---

## Relações na Squad

### Skills relacionadas

- `change-management`
- `version-control-and-change-management`
- `rollback-and-recovery`

### Agentes relacionados

- `squad-lead`
- `devops-engineer`

### Workflows relacionados

- `05-development`
- `07-delivery`