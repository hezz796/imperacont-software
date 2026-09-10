---
name: development
description: Conduz planejamento técnico e implementação incremental do software conforme produto, requisitos, arquitetura e critérios de qualidade.
version: 1
---

# Workflow: Development

## Objetivo

Transformar requisitos e arquitetura aprovados em software funcional de maneira incremental, verificável e controlada.

---

## Entrada

Utilizar:

- requisitos;
- user stories;
- critérios de aceitação;
- arquitetura;
- decisões técnicas;
- plano de implementação;
- dependências;
- riscos;
- critérios de qualidade.

---

## Memória

Antes de decisões relevantes ou implementação, consultar:

```text
memoria/decisoes/
memoria/aprendizados/
memoria/problemas/
memoria/riscos/
```

Priorizar:

- decisões técnicas anteriores;
- padrões já utilizados;
- problemas recorrentes;
- dívida técnica;
- incidentes;
- aprendizados de implementação;
- restrições persistentes.

Não copiar automaticamente uma implementação anterior.

Verificar se ela continua adequada ao contexto atual.

---

## Etapas

### 1. Planejamento

Dividir o trabalho em unidades incrementais.

### 2. Preparação

Verificar:

- requisitos;
- arquitetura;
- dependências;
- critérios de aceitação;
- riscos;
- impacto.

### 3. Implementação

Implementar somente o necessário para atender ao objetivo definido.

Evitar expansão de escopo.

### 4. Testes

Executar testes adequados ao risco e à mudança.

### 5. Revisão

Submeter mudanças relevantes a revisão.

### 6. Dívida técnica

Identificar dívida criada, descoberta ou reduzida.

### 7. Observabilidade

Quando aplicável, garantir:

- logs;
- métricas;
- rastreabilidade;
- tratamento de erros;
- sinais operacionais.

---

## Memórias candidatas

Podem ser candidatas:

- decisão técnica relevante;
- problema recorrente;
- aprendizado de implementação;
- padrão que demonstrou eficácia;
- abordagem que demonstrou inadequação;
- dívida estrutural;
- risco persistente;
- evento técnico relevante.

Um defeito isolado não deve ser automaticamente transformado em memória.

---

## Revisão

Utilizar `@reviewer` quando:

- mudança for significativa;
- risco for elevado;
- arquitetura for afetada;
- houver alteração de comportamento crítico;
- houver dívida técnica relevante;
- houver conflito com decisão anterior.

---

## Gate

A implementação pode avançar quando:

- requisitos estiverem atendidos;
- arquitetura estiver respeitada;
- critérios de aceitação forem verificáveis;
- testes adequados tiverem sido executados;
- problemas críticos estiverem resolvidos;
- riscos conhecidos estiverem controlados;
- revisão necessária tiver sido realizada.

Resultado:

```text
APROVADO
APROVADO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA ARQUITETURA
RETORNAR PARA PLANEJAMENTO
BLOQUEADO
```

---

## Saída

Produzir:

- plano;
- implementação;
- arquivos alterados;
- testes;
- resultados;
- problemas;
- dívida técnica;
- riscos;
- decisões;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

```text
Development
     ↓
Quality
```

Quando houver problema arquitetural:

```text
Development
     ↓
Architecture
```