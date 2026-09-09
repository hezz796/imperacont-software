---
name: release-strategy
description: Define estratégias de liberação de software considerando risco, escopo, dependências, usuários, ambientes e capacidade de reversão.
---

# Release Strategy

## Objetivo

Definir como mudanças aprovadas serão disponibilizadas aos usuários de forma controlada e previsível.

## Princípio

Uma release deve reduzir incerteza e risco por meio de preparação, evidências, comunicação e capacidade de recuperação.

## Processo

1. Identificar o escopo da release.
2. Confirmar requisitos e critérios de aceitação.
3. Avaliar riscos.
4. Identificar dependências.
5. Confirmar ambiente de destino.
6. Confirmar estratégia de implantação.
7. Definir estratégia de validação.
8. Definir estratégia de rollback ou recuperação.
9. Planejar comunicação.
10. Executar a release.
11. Validar o resultado.
12. Monitorar o comportamento após a liberação.

## Estratégias possíveis

Conforme o contexto:

- release direta;
- release gradual;
- lançamento por grupos;
- feature flags;
- canary release;
- blue-green;
- rollout progressivo;
- lançamento controlado.

## Regras

- A estratégia deve ser proporcional ao risco.
- Mudanças críticas devem possuir mecanismos adequados de recuperação.
- Dependências externas devem ser consideradas.
- A release não deve depender de conhecimento implícito.
- Critérios de sucesso devem ser definidos antes da liberação.

## Saída

Produzir:

- escopo;
- estratégia;
- riscos;
- dependências;
- critérios de sucesso;
- plano de validação;
- plano de recuperação;
- comunicação necessária.