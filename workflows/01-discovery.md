---
name: discovery
description: Conduz a descoberta do problema, contexto, usuários, oportunidades e hipóteses antes da definição do produto.
version: 1
---

# Workflow: Discovery

## Objetivo

Transformar uma ideia, necessidade ou problema inicial em entendimento suficientemente sólido para decidir se existe uma oportunidade relevante a ser explorada.

## Princípio

Não começar pela tecnologia ou pela solução.

A discovery deve responder:

- qual problema existe;
- para quem;
- em qual contexto;
- qual evidência existe;
- qual oportunidade pode existir;
- quais hipóteses ainda precisam ser validadas.

## Entrada

Pode receber:

- ideia;
- problema percebido;
- solicitação de usuário;
- oportunidade de negócio;
- hipótese;
- necessidade operacional;
- mudança de contexto.

## Agente principal

`@squad-lead`

## Agentes participantes

- `@product-strategist`
- `@business-analyst`
- `@ux-researcher`
- `@reviewer`

## Skills

- `brainstorming`
- `problem-framing`
- `opportunity-analysis`
- `hypothesis-validation`
- `market-research`
- `product-discovery`

## Etapas

### 1. Enquadramento inicial

Identificar:

- contexto;
- problema percebido;
- origem da demanda;
- público afetado;
- objetivo inicial.

### 2. Problem framing

Separar:

- problema;
- sintoma;
- causa presumida;
- solução presumida;
- restrições conhecidas.

### 3. Investigação

Buscar evidências relevantes sobre:

- usuários;
- contexto;
- processo atual;
- alternativas existentes;
- mercado;
- restrições;
- necessidades.

### 4. Oportunidade

Avaliar:

- relevância;
- frequência;
- impacto;
- público;
- alternativas;
- oportunidade potencial.

### 5. Hipóteses

Registrar:

- hipótese;
- evidência existente;
- grau de incerteza;
- método de validação;
- resultado esperado.

### 6. Review

`@reviewer` verifica:

- premissas;
- evidências;
- lacunas;
- conclusões;
- riscos de viés;
- hipóteses não comprovadas.

## Gate

Discovery pode avançar quando:

- o problema está suficientemente definido;
- o público está identificado;
- as principais evidências foram registradas;
- hipóteses relevantes estão explícitas;
- incertezas importantes estão conhecidas;
- existe base suficiente para decisão de produto.

## Saída

Produzir:

- problem statement;
- contexto;
- usuários;
- evidências;
- oportunidades;
- hipóteses;
- riscos;
- incertezas;
- recomendação.

## Decisão

Possíveis resultados:

- `PROSSEGUIR`
- `VALIDAR MAIS`
- `REFORMULAR PROBLEMA`
- `ENCERRAR`

## Regra de bloqueio

Não iniciar arquitetura ou implementação apenas porque uma solução foi sugerida.

A squad deve primeiro estabelecer entendimento suficiente do problema.