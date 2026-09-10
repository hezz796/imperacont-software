---
name: quality
description: Verifica qualidade funcional, técnica, não funcional e de segurança antes da liberação do produto.
version: 1
---

# Workflow: Quality

## Objetivo

Verificar se o produto atende aos requisitos, critérios de aceitação e atributos de qualidade relevantes antes da liberação.

---

## Entrada

Utilizar:

- requisitos;
- user stories;
- critérios de aceitação;
- arquitetura;
- implementação;
- riscos;
- estratégia de testes;
- decisões relevantes.

---

## Memória

Consultar:

```text
memoria/decisoes/
memoria/aprendizados/
memoria/problemas/
memoria/riscos/
```

Priorizar:

- falhas recorrentes;
- incidentes anteriores;
- riscos conhecidos;
- decisões de qualidade;
- aprendizados de testes;
- problemas históricos relevantes.

Memórias devem orientar a investigação, não substituir evidência atual.

---

## Etapas

### 1. Estratégia de qualidade

Definir cobertura adequada ao risco.

### 2. Testes

Executar quando aplicável:

- unitários;
- integração;
- sistema;
- aceitação;
- regressão;
- desempenho;
- confiabilidade;
- segurança.

### 3. Análise de resultados

Classificar:

- aprovado;
- falha;
- defeito;
- risco;
- inconsistência;
- limitação;
- evidência insuficiente.

### 4. Segurança

Avaliar riscos de segurança relevantes.

### 5. Regressão

Verificar impactos sobre funcionalidades existentes.

### 6. Revisão

Submeter resultados críticos a revisão independente.

---

## Aprendizados e memória

Avaliar se os resultados produziram:

- novo aprendizado;
- padrão de falha recorrente;
- risco persistente;
- problema estrutural;
- decisão relevante;
- informação histórica importante.

Uma falha de teste não é automaticamente um aprendizado.

A transformação deve seguir:

```text
RESULTADO
    ↓
ANÁLISE
    ↓
EVIDÊNCIA
    ↓
APRENDIZADO OU PROBLEMA
    ↓
CANDIDATA A MEMÓRIA
```

As candidatas são encaminhadas ao `@squad-lead`.

---

## Gate

A liberação somente pode avançar quando:

- testes necessários forem executados;
- defeitos críticos estiverem resolvidos ou explicitamente aceitos;
- riscos críticos estiverem controlados;
- requisitos relevantes forem atendidos;
- segurança estiver adequada ao risco;
- regressão estiver aceitável;
- evidências forem suficientes.

Resultado:

```text
APROVADO
APROVADO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA DEVELOPMENT
RETORNAR PARA ARCHITECTURE
BLOQUEADO
```

---

## Saída

Produzir:

- estratégia;
- testes;
- resultados;
- falhas;
- defeitos;
- severidade;
- evidências;
- riscos;
- aprendizados;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

```text
Quality
   ↓
Delivery
```

Quando houver falha que exija correção:

```text
Quality
   ↓
Development
```