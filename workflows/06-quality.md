---
name: quality
description: Verifica qualidade funcional, técnica, não funcional e de segurança antes da liberação do produto.
version: 1
---

# Workflow: Quality

## Objetivo

Produzir evidências suficientes para determinar se uma mudança ou release apresenta qualidade adequada para avançar.

## Princípio

Qualidade é responsabilidade do produto inteiro e deve ser avaliada com base em risco.

## Entrada

- software implementado;
- requisitos;
- critérios de aceitação;
- arquitetura;
- riscos;
- estratégia de testes.

## Agente principal

`@test-engineer`

## Agentes participantes

- `@security-engineer`
- `@software-engineer`
- `@reviewer`

## Skills

- `test-strategy`
- `test-design`
- `unit-testing`
- `integration-testing`
- `system-testing`
- `acceptance-testing`
- `regression-testing`
- `performance-testing`
- `reliability-testing`
- `security-testing`
- `quality-gates`

## Etapas

### 1. Estratégia

Confirmar:

- escopo;
- riscos;
- níveis de teste;
- critérios.

### 2. Test design

Definir cenários relevantes.

### 3. Testes funcionais

Executar conforme o risco:

- unitários;
- integração;
- sistema;
- aceitação;
- regressão.

### 4. Testes não funcionais

Quando aplicável:

- desempenho;
- confiabilidade;
- compatibilidade;
- segurança.

### 5. Defeitos

Registrar:

- comportamento;
- esperado;
- observado;
- evidência;
- impacto;
- severidade.

### 6. Revalidação

Após correções, executar os testes necessários novamente.

### 7. Quality gate

Avaliar evidências e riscos remanescentes.

## Gate

Considerar:

- requisitos críticos;
- critérios de aceitação;
- defeitos bloqueadores;
- segurança;
- desempenho relevante;
- confiabilidade;
- riscos conhecidos.

## Saída

Produzir:

- resultados de testes;
- defeitos;
- evidências;
- cobertura relevante;
- riscos;
- decisão de qualidade.

## Decisão

- `APROVADO`
- `APROVADO COM RESSALVAS`
- `REPROVADO`
- `REQUER NOVOS TESTES`