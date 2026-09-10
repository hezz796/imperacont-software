---
title: Implantação
description: Define princípios para disponibilizar versões do software em ambientes de maneira controlada, verificável e recuperável.
type: guide
status: active
scope: squad
tags:
  - devops
  - implantacao
  - deployment
  - release
---

# Implantação

## Objetivo

Implantação é o processo de colocar uma versão ou mudança em determinado ambiente.

## Pré-condições

Antes da implantação, avaliar:

- versão;
- artefato;
- ambiente;
- dependências;
- configuração;
- riscos;
- critérios de validação;
- plano de recuperação.

## Execução

A implantação deve ser:

- controlada;
- rastreável;
- repetível quando possível;
- observável.

## Validação

Após a implantação, verificar se o sistema apresenta comportamento esperado.

A conclusão técnica da implantação não significa que a mudança foi validada funcionalmente.

## Estratégias

Podem ser adotadas estratégias diferentes conforme risco e contexto.

A estratégia deve ser escolhida pela necessidade do produto, não pela preferência por uma ferramenta.

## Recuperação

Toda implantação relevante deve considerar o que fazer se:

- a implantação falhar;
- o sistema degradar;
- usuários forem impactados;
- uma dependência falhar;
- surgir um comportamento inesperado.

---

## Relações na Squad

### Skills relacionadas

- `deployment`
- `rollback-and-recovery`
- `release-strategy`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`