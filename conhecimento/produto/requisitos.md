---
title: Requisitos
description: Princípios para identificar, estruturar, analisar, validar e manter requisitos de produtos de software.
type: guide
status: active
scope: squad
tags:
  - requisitos
  - produto
  - analise
  - engenharia
---

# Requisitos

## Princípio

Requisitos devem representar necessidades, comportamentos, restrições ou condições relevantes para o produto e sua solução.

## Tipos

Dependendo do contexto, podem existir:

- requisitos funcionais;
- requisitos não funcionais;
- regras de negócio;
- restrições;
- requisitos de integração;
- requisitos de segurança;
- requisitos operacionais;
- requisitos legais ou regulatórios.

## Qualidade

Requisitos devem ser, na medida apropriada:

- compreensíveis;
- relevantes;
- verificáveis;
- consistentes;
- rastreáveis;
- suficientemente completos;
- não excessivamente prescritivos.

## Requisito não é necessariamente implementação

Um requisito deve expressar o que precisa ser atendido sem prescrever uma tecnologia específica quando essa tecnologia não for uma restrição real.

## Exemplo conceitual

Evitar:

```text
"Utilizar tecnologia X para resolver Y."
```

quando a necessidade real for:

```text
"O sistema deve realizar Y sob as condições Z."
```

A decisão tecnológica pode ser tratada posteriormente pela arquitetura.

## Resultado esperado

Requisitos devem permitir que produto, UX, arquitetura, desenvolvimento e qualidade compartilhem uma compreensão suficientemente comum do que precisa ser alcançado.