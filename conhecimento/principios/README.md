---
title: Princípios da Squad
description: Reúne os princípios fundamentais que orientam decisões, comportamentos e práticas da software squad durante todo o ciclo de desenvolvimento.
type: guide
status: active
scope: squad
tags:
  - principios
  - engenharia
  - produto
  - qualidade
  - arquitetura
---

# Princípios da Squad

## Finalidade

Esta categoria reúne os princípios fundamentais que orientam a forma como a software squad pensa, decide, constrói, valida, entrega e evolui produtos e sistemas.

Os princípios funcionam como referências gerais para decisões e comportamentos ao longo de todo o ciclo de vida do produto.

Eles não substituem workflows, skills, agentes, comandos ou conhecimento técnico específico.

Seu papel é estabelecer **critérios de pensamento e decisão** que permaneçam válidos mesmo quando tecnologias, ferramentas, produtos, equipes ou contextos mudarem.

---

## Princípios disponíveis

### 1. Problem Before Solution

Arquivo:

`problem-before-solution.md`

Orienta a squad a compreender o problema, contexto, necessidade e objetivo antes de assumir uma solução.

---

### 2. Evidence Before Assumption

Arquivo:

`evidence-before-assumption.md`

Orienta decisões baseadas em evidências disponíveis, deixando explícitas as hipóteses e incertezas que ainda precisam ser investigadas.

---

### 3. Technology as Means

Arquivo:

`technology-as-means.md`

Estabelece que tecnologia é meio para atingir objetivos do produto e do negócio, e não o objetivo em si.

---

### 4. Simplicity Before Complexity

Arquivo:

`simplicity-before-complexity.md`

Orienta a preferência por soluções suficientemente simples, evitando complexidade sem justificativa proporcional ao problema ou ao risco.

---

### 5. Incremental Delivery

Arquivo:

`incremental-delivery.md`

Orienta a construção e entrega em incrementos pequenos, verificáveis e capazes de produzir aprendizado ou valor.

---

### 6. Risk-Based Decision Making

Arquivo:

`risk-based-decision-making.md`

Orienta decisões considerando riscos, impacto, probabilidade, exposição, reversibilidade e evidências disponíveis.

---

### 7. Quality by Design

Arquivo:

`quality-by-design.md`

Estabelece que qualidade deve ser considerada desde a definição do produto e da solução, e não somente verificada ao final.

---

### 8. Security by Design

Arquivo:

`security-by-design.md`

Estabelece que segurança deve ser considerada desde as primeiras decisões e permanecer presente durante todo o ciclo de vida.

---

### 9. Observability by Design

Arquivo:

`observability-by-design.md`

Orienta a construção de produtos e sistemas capazes de fornecer evidências suficientes para compreender seu comportamento e diagnosticar problemas.

---

### 10. Continuous Learning

Arquivo:

`continuous-learning.md`

Orienta a utilização de resultados, feedback, métricas, falhas, incidentes e novas evidências para melhorar continuamente o produto, a engenharia e os processos.

---

## Como utilizar os princípios

Os princípios devem ser utilizados como referência transversal.

Eles podem ser aplicados durante:

- discovery;
- definição do produto;
- análise de requisitos;
- pesquisa com usuários;
- UX;
- arquitetura;
- desenvolvimento;
- testes;
- segurança;
- entrega;
- operação;
- evolução.

A aplicação deve ser proporcional ao contexto.

Nem toda decisão exige uma análise extensa de todos os princípios. O objetivo é utilizar aqueles que forem relevantes para a decisão em questão.

---

## Relação com as demais camadas

Os princípios ocupam uma posição de orientação dentro da arquitetura da squad.

A relação conceitual é:

`PRINCÍPIOS → CONHECIMENTO → SKILLS → WORKFLOWS → AGENTES → COMMANDS`

Isso não significa que um princípio seja executado diretamente.

Um princípio influencia a forma como as demais camadas são utilizadas.

Por exemplo:

`Problem Before Solution`

pode influenciar:

- uma skill de problem framing;
- um workflow de discovery;
- uma decisão do Squad Lead;
- uma análise de requisitos;
- uma revisão de arquitetura.

---

## Princípios não são regras absolutas

Os princípios devem orientar decisões, mas não devem ser utilizados de maneira dogmática.

Uma decisão pode justificar uma exceção quando houver:

- contexto específico;
- restrição relevante;
- evidência suficiente;
- risco conhecido;
- benefício proporcional;
- decisão consciente;
- consequência registrada quando necessário.

O objetivo não é eliminar trade-offs.

O objetivo é tornar os trade-offs conscientes e justificáveis.

---

## Conflitos entre princípios

Princípios podem entrar em tensão.

Exemplos:

- simplicidade versus resiliência;
- velocidade versus profundidade de validação;
- segurança versus conveniência;
- entrega incremental versus necessidade de mudança estrutural;
- custo imediato versus sustentabilidade futura.

Quando isso ocorrer, a squad deve:

1. identificar o conflito;
2. compreender o contexto;
3. avaliar riscos;
4. buscar evidências;
5. comparar alternativas;
6. explicitar o trade-off;
7. tomar a decisão;
8. registrar a decisão quando sua importância justificar;
9. validar o resultado.

Nenhum princípio deve ser utilizado isoladamente para justificar automaticamente uma decisão.

---

## Relação com tecnologia

Os princípios são deliberadamente independentes de tecnologia.

Eles não determinam:

- linguagem de programação;
- framework;
- banco de dados;
- provedor de nuvem;
- sistema operacional;
- ferramenta de CI/CD;
- ferramenta de observabilidade;
- ferramenta de gestão;
- arquitetura específica.

A tecnologia deve ser escolhida posteriormente, conforme as necessidades, restrições, riscos e atributos de qualidade identificados.

---

## Governança

Alterações nesta categoria devem preservar:

- clareza;
- generalidade;
- aplicabilidade;
- coerência com a constituição da squad;
- independência tecnológica;
- ausência de contradições com outros princípios;
- capacidade de orientar decisões reais.

Um novo princípio somente deve ser adicionado quando representar uma orientação suficientemente geral e relevante para diferentes contextos da squad.

Orientações específicas de uma tecnologia, projeto ou implementação devem permanecer em suas respectivas camadas de conhecimento.

---

## Regra central

Os princípios devem ajudar a squad a responder:

> **Estamos tomando esta decisão da maneira mais coerente com o problema, as evidências, os riscos, a qualidade e o contexto disponíveis?**

Essa pergunta complementa a regra geral da squad:

`CLAREZA → EVIDÊNCIA → DECISÃO → EXECUÇÃO → VALIDAÇÃO → APRENDIZADO`

---

## Relações na Squad

### Skills relacionadas

- `problem-framing`
- `hypothesis-validation`
- `technical-decisions`
- `quality-gates`
- `security-design`
- `observability`
- `learning-loop`
- `continuous-improvement`

### Agentes relacionados

- `squad-lead`
- `product-strategist`
- `business-analyst`
- `ux-researcher`
- `ux-designer`
- `solution-architect`
- `data-engineer`
- `software-engineer`
- `test-engineer`
- `security-engineer`
- `devops-engineer`
- `technical-writer`
- `reviewer`

### Workflows relacionados

- `01-discovery`
- `02-product-definition`
- `03-ux-design`
- `04-architecture`
- `05-development`
- `06-quality`
- `07-delivery`
- `08-evolution`