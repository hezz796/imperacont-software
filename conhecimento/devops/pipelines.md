---
title: Pipelines
description: Estrutura conhecimentos sobre pipelines de automação para validação, construção, empacotamento, entrega e implantação de software.
type: guide
status: active
scope: squad
tags:
  - devops
  - pipelines
  - automacao
  - ci-cd
---

# Pipelines

## Objetivo

Pipeline representa uma sequência automatizada e controlada de atividades relacionadas ao ciclo de entrega.

## Etapas possíveis

Dependendo do contexto:

1. obter código;
2. validar;
3. construir;
4. testar;
5. analisar;
6. empacotar;
7. publicar;
8. implantar;
9. validar;
10. monitorar.

## Princípio

Cada etapa deve possuir finalidade clara e produzir evidência útil para a próxima.

## Falhas

Falhas devem interromper ou alterar o fluxo quando o risco justificar.

Não se deve ignorar automaticamente uma falha apenas para concluir o pipeline.

## Segurança

Pipelines possuem privilégios e acesso a recursos importantes.

Devem ser protegidos contra:

- execução indevida;
- alteração não autorizada;
- exposição de segredos;
- manipulação de artefatos;
- execução de código não confiável.

## Rastreabilidade

Uma execução deve permitir relacionar:

- mudança;
- versão;
- artefato;
- ambiente;
- resultado;
- momento da execução.

## Automação com responsabilidade

Automatizar uma etapa não elimina a necessidade de definir critérios para sua execução.

---

## Relações na Squad

### Skills relacionadas

- `deployment`
- `release-planning`
- `test-strategy`

### Agentes relacionados

- `devops-engineer`

### Workflows relacionados

- `07-delivery`