---
title: Quality Gates
description: Fundamentos para estabelecer critérios objetivos de decisão sobre avanço entre etapas, liberação e aceitação de risco.
type: guide
status: active
scope: squad
tags:
  - qualidade
  - quality-gates
  - governanca
  - release
---

# Quality Gates

## Conceito

Quality gate é um conjunto de critérios utilizados para determinar se uma entrega pode avançar para determinada etapa.

## Finalidade

Um gate reduz decisões baseadas apenas em percepção subjetiva.

Ele pode avaliar:

- requisitos;
- testes;
- defeitos;
- segurança;
- desempenho;
- documentação;
- riscos;
- evidências.

## Gate não é burocracia

Um gate deve existir quando ajuda a controlar risco ou garantir uma condição importante.

Critérios que não influenciam decisões podem gerar burocracia sem valor.

## Critérios objetivos

Sempre que possível, critérios devem ser:

- claros;
- verificáveis;
- relevantes;
- proporcionais ao risco.

## Bloqueadores

Algumas condições podem impedir o avanço, especialmente quando envolvem:

- risco crítico;
- perda de dados;
- falha de segurança grave;
- comportamento essencial incorreto;
- incapacidade de recuperação.

## Exceções

Pode haver situações em que um risco conhecido seja aceito conscientemente.

Nesse caso, a decisão deve registrar:

- risco;
- impacto;
- justificativa;
- responsável pela decisão;
- condições;
- eventual prazo de revisão.

## Evidência

Um gate deve utilizar evidências, e não apenas declarações.

## Evolução

Os critérios de gate devem evoluir conforme:

- histórico de incidentes;
- defeitos;
- mudanças;
- criticidade;
- maturidade da equipe.

---

## Relações na Squad

### Skills relacionadas

- `quality-gates`
- `test-strategy`
- `release-planning`

### Agentes relacionados

- `test-engineer`
- `squad-lead`

### Workflows relacionados

- `06-quality`
- `07-delivery`