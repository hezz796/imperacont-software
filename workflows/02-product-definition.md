---
name: product-definition
description: Converte o entendimento obtido na discovery em definição estruturada de produto, requisitos, escopo, backlog e métricas.
version: 1
---

# Workflow: Product Definition

## Objetivo

Transformar o problema validado em uma definição clara do produto e de seu primeiro escopo de entrega.

## Princípio

Definir o que deve ser construído e por quê antes de decidir como será implementado.

## Entrada

Requer:

- resultado da discovery;
- problema;
- usuários;
- evidências;
- oportunidade;
- hipóteses relevantes.

## Agente principal

`@product-strategist`

## Agentes participantes

- `@business-analyst`
- `@ux-researcher`
- `@reviewer`

## Skills

- `requirements-engineering`
- `user-stories`
- `backlog-management`
- `product-modeling`
- `product-metrics`
- `product-definition`

## Etapas

### 1. Visão do produto

Definir:

- visão;
- objetivo;
- público;
- proposta de valor;
- resultados esperados.

### 2. Escopo

Determinar:

- MVP;
- funcionalidades essenciais;
- funcionalidades futuras;
- fora de escopo;
- restrições.

### 3. Requisitos

Identificar:

- requisitos funcionais;
- requisitos não funcionais;
- regras de negócio;
- restrições;
- dependências.

### 4. User stories

Estruturar necessidades em unidades compreensíveis e verificáveis.

### 5. Backlog

Organizar:

- itens;
- prioridades;
- dependências;
- critérios de aceitação;
- riscos.

### 6. Métricas

Definir indicadores relacionados aos resultados esperados.

### 7. Review

`@reviewer` verifica:

- coerência;
- completude;
- ambiguidades;
- requisitos conflitantes;
- critérios de aceitação;
- escopo.

## Gate

Avançar somente quando:

- objetivo do produto estiver claro;
- escopo estiver definido;
- requisitos críticos estiverem identificados;
- critérios de aceitação forem verificáveis;
- prioridades estiverem estabelecidas;
- principais riscos forem conhecidos.

## Saída

Produzir:

- product brief;
- requisitos;
- user stories;
- backlog inicial;
- critérios de aceitação;
- métricas;
- riscos;
- escopo;
- fora de escopo.

## Decisão

- `APROVADO PARA UX`
- `REQUER REFINAMENTO`
- `REQUER NOVA DISCOVERY`