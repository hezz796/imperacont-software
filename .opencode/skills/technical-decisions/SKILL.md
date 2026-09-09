---
name: technical-decisions
description: Estrutura, avalia e registra decisões técnicas importantes, seus contextos, alternativas, trade-offs e consequências.
---

# Technical Decisions

## Objetivo

Garantir que decisões técnicas relevantes sejam compreensíveis, justificáveis e rastreáveis.

## Quando registrar

Registrar decisões que:

- afetam arquitetura;
- introduzem dependências importantes;
- possuem impacto significativo;
- são difíceis de reverter;
- envolvem trade-offs relevantes;
- estabelecem padrões;
- afetam segurança;
- afetam custos;
- afetam operação;
- afetam evolução.

Não registrar toda decisão trivial.

## Estrutura

Uma decisão deve conter:

- título;
- contexto;
- problema;
- requisitos;
- alternativas;
- critérios;
- decisão;
- justificativa;
- trade-offs;
- consequências;
- riscos;
- alternativas rejeitadas;
- data;
- status.

## Alternativas

Para cada alternativa relevante registrar:

- benefícios;
- desvantagens;
- custos;
- riscos;
- impactos;
- dependências.

## Trade-offs

Explicitar o que foi:

- priorizado;
- sacrificado;
- aceito como risco.

## Reversibilidade

Classificar decisões, quando útil, como:

- facilmente reversível;
- parcialmente reversível;
- difícil de reverter.

Decisões difíceis de reverter exigem maior nível de análise.

## Tecnologia

A decisão tecnológica deve explicar:

- qual requisito motivou a escolha;
- quais alternativas foram consideradas;
- quais riscos foram aceitos.

Evitar justificativas como:

> "é a tecnologia mais moderna."

## Evolução

Uma decisão pode ser revisitada quando:

- contexto muda;
- requisitos mudam;
- premissas deixam de ser verdadeiras;
- nova evidência surge.

## Saída esperada

Produzir um registro de decisão contendo:

1. contexto;
2. problema;
3. alternativas;
4. critérios;
5. decisão;
6. justificativa;
7. trade-offs;
8. consequências;
9. riscos;
10. status.