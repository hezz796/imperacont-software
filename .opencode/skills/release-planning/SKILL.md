---
name: release-planning
description: Organiza o planejamento operacional de releases, incluindo escopo, dependências, sequência, responsabilidades, validações e contingências.
---

# Release Planning

## Objetivo

Transformar uma release aprovada em um plano executável e verificável.

## Princípio

Planejamento de release deve tornar explícito o que será alterado, em qual ordem, sob quais condições e como o resultado será validado.

## Processo

1. Consolidar mudanças.
2. Confirmar versão ou identificador da release.
3. Identificar dependências.
4. Identificar pré-condições.
5. Definir sequência de execução.
6. Definir pontos de validação.
7. Definir responsáveis.
8. Definir critérios de sucesso.
9. Definir contingências.
10. Registrar o plano.

## Verificações

Antes da execução, verificar quando aplicável:

- artefatos disponíveis;
- ambiente preparado;
- configuração validada;
- migrações planejadas;
- dependências disponíveis;
- backups ou mecanismos equivalentes;
- observabilidade disponível;
- plano de recuperação;
- comunicação preparada.

## Regras

- Não ocultar dependências.
- Não assumir que produção é equivalente ao ambiente de teste.
- Mudanças irreversíveis devem ser identificadas.
- O plano deve permitir acompanhamento durante a execução.

## Saída

Produzir:

- escopo;
- versão;
- sequência;
- pré-condições;
- responsáveis;
- validações;
- contingências;
- critérios de sucesso.