---
name: architecture
description: Define a arquitetura da solução a partir dos requisitos, experiência, restrições, riscos e atributos de qualidade.
version: 1
---

# Workflow: Architecture

## Objetivo

Definir a arquitetura da solução a partir de:

- produto;
- requisitos;
- UX;
- domínio;
- riscos;
- atributos de qualidade;
- restrições;
- operação;
- segurança;
- dados;
- integrações.

A arquitetura deve permanecer tecnológica e conceitualmente justificada.

---

## Entrada

Utilizar:

- definição do produto;
- requisitos;
- regras de negócio;
- UX;
- critérios de aceitação;
- riscos;
- restrições;
- atributos de qualidade.

---

## Memória

Antes das decisões arquiteturais, consultar:

```text
memoria/decisoes/
memoria/aprendizados/
memoria/riscos/
memoria/problemas/
memoria/contexto/
```

Pesquisar especialmente:

- decisões arquiteturais anteriores;
- decisões técnicas;
- problemas recorrentes;
- dívida técnica relevante;
- incidentes;
- aprendizados de implementação;
- riscos operacionais;
- restrições persistentes.

Uma decisão anterior não deve ser repetida apenas por tradição.

Avaliar se:

```text
CONTEXTO ATUAL
+
EVIDÊNCIA
+
RISCO
+
CUSTO
```

continuam justificando a decisão.

---

## Etapas

### 1. Contexto arquitetural

Estabelecer:

- sistema;
- usuários;
- ambiente;
- fronteiras;
- dependências.

### 2. Domínio

Identificar:

- entidades;
- responsabilidades;
- regras;
- limites;
- relações.

### 3. Atributos de qualidade

Avaliar conforme o contexto:

- segurança;
- desempenho;
- disponibilidade;
- confiabilidade;
- escalabilidade;
- manutenibilidade;
- observabilidade;
- portabilidade;
- recuperabilidade.

### 4. Alternativas

Avaliar alternativas arquiteturais.

Não escolher tecnologia antes de compreender a decisão.

### 5. Arquitetura

Definir:

- componentes;
- responsabilidades;
- fronteiras;
- interfaces;
- dados;
- integrações;
- operação;
- segurança.

### 6. Decisões técnicas

Registrar decisões importantes, justificativas, alternativas rejeitadas e consequências.

### 7. Dívida técnica

Identificar dívida técnica potencial ou existente.

### 8. Operação

Considerar:

- implantação;
- observabilidade;
- recuperação;
- manutenção;
- evolução.

---

## Revisão

Utilizar:

- `@reviewer` para revisão independente;
- `@security-engineer` para riscos de segurança;
- `@data-engineer` para decisões relevantes de dados;
- `@devops-engineer` para operação e infraestrutura quando aplicável.

---

## Memórias candidatas

Podem ser candidatas:

- decisões arquiteturais relevantes;
- decisões técnicas;
- restrições persistentes;
- problemas estruturais;
- aprendizados arquiteturais;
- riscos de longa duração;
- eventos que alterem significativamente a arquitetura.

Uma decisão arquitetural deve continuar rastreável mesmo quando posteriormente for substituída.

---

## Gate

A arquitetura somente avança quando:

- contexto estiver definido;
- requisitos relevantes estiverem contemplados;
- atributos de qualidade estiverem identificados;
- riscos críticos estiverem avaliados;
- alternativas relevantes tiverem sido consideradas;
- decisões importantes estiverem justificadas;
- segurança estiver considerada;
- dados estiverem tratados;
- operação estiver considerada;
- dívida técnica relevante estiver identificada.

Resultado:

```text
APROVADO
APROVADO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA PRODUCT DEFINITION
RETORNAR PARA UX
RETORNAR PARA ARQUITETURA
BLOQUEADO
```

---

## Saída

Produzir:

- contexto arquitetural;
- domínio;
- fronteiras;
- componentes;
- dados;
- integrações;
- atributos de qualidade;
- segurança;
- operação;
- alternativas;
- decisões;
- dívida técnica;
- riscos;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

```text
Architecture
     ↓
Development / Planning
```

Quando uma decisão de produto estiver inadequada:

```text
Architecture
     ↓
Product Definition
```

Quando uma decisão de experiência for insuficiente:

```text
Architecture
     ↓
UX Design
```