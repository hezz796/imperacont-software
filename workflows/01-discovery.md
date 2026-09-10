---
name: discovery
description: Conduz a descoberta do problema, contexto, usuários, oportunidades e hipóteses antes da definição do produto.
version: 1
---

# Workflow: Discovery

## Objetivo

Compreender o problema antes de definir a solução.

A discovery deve produzir entendimento suficiente sobre:

- contexto;
- problema;
- usuários;
- necessidades;
- evidências;
- oportunidades;
- hipóteses;
- restrições;
- riscos;
- incertezas.

Não iniciar implementação durante a discovery.

---

## Entrada

A discovery pode receber:

- ideia;
- problema percebido;
- oportunidade;
- solicitação de usuário;
- mudança de contexto;
- feedback;
- incidente;
- informação de negócio.

Antes de iniciar, verificar se existem informações mínimas suficientes para compreender o objetivo da investigação.

---

## Memória

Antes de iniciar a investigação, consultar seletivamente:

```text
memoria/contexto/
memoria/decisoes/
memoria/problemas/
memoria/riscos/
memoria/aprendizados/
```

A consulta deve buscar apenas memórias relacionadas ao problema, domínio, usuário, projeto ou contexto atual.

Verificar:

- status;
- data;
- confiança;
- contexto;
- evidências;
- decisões posteriores.

Memórias antigas não devem ser tratadas automaticamente como fatos atuais.

---

## Etapas

### 1. Compreender o contexto

Identificar:

- contexto atual;
- objetivo;
- origem da solicitação;
- partes interessadas;
- restrições conhecidas;
- informações já disponíveis.

### 2. Investigar o problema

Determinar:

- qual problema está sendo observado;
- quem é afetado;
- em qual contexto;
- qual impacto existe;
- quais evidências sustentam o problema.

Não confundir sintoma com causa.

### 3. Identificar usuários

Investigar:

- usuários;
- necessidades;
- comportamentos;
- objetivos;
- dificuldades;
- contexto de uso.

### 4. Identificar oportunidades

Explorar:

- oportunidades;
- necessidades não atendidas;
- alternativas;
- possibilidades de intervenção.

Não assumir que uma solução proposta pelo solicitante seja necessariamente a solução adequada.

### 5. Formular hipóteses

Registrar hipóteses explicitamente.

Uma hipótese deve ser diferenciada de:

- fato;
- decisão;
- aprendizado;
- opinião.

### 6. Avaliar evidências

Classificar as informações conforme sua sustentação.

Identificar:

- evidências fortes;
- evidências fracas;
- informações desconhecidas;
- contradições;
- lacunas.

### 7. Identificar riscos

Registrar riscos relevantes relacionados a:

- problema;
- usuários;
- negócio;
- contexto;
- validação;
- premissas.

### 8. Consolidar discovery

Consolidar:

- problema;
- contexto;
- usuários;
- evidências;
- oportunidades;
- hipóteses;
- riscos;
- incertezas;
- perguntas abertas;
- recomendação.

---

## Revisão

Utilizar `@reviewer` quando:

- houver conflito entre evidências;
- houver risco elevado;
- houver hipótese crítica;
- houver conclusão controversa;
- houver possibilidade de confundir fato com inferência;
- houver impacto significativo na definição futura do produto.

---

## Memórias candidatas

Ao finalizar a discovery, avaliar se existem informações que merecem ser preservadas.

Podem ser candidatas:

- contexto persistente descoberto;
- problema recorrente;
- risco relevante;
- aprendizado comprovado;
- decisão tomada durante a discovery;
- evento histórico relevante.

Não registrar automaticamente:

- hipóteses não validadas;
- opiniões;
- especulações;
- informações temporárias;
- observações sem impacto futuro.

As candidatas devem ser apresentadas ao `@squad-lead` para avaliação e eventual consolidação.

---

## Gate

A discovery pode avançar quando:

- o problema estiver suficientemente compreendido;
- os usuários relevantes estiverem identificados;
- houver evidências adequadas;
- hipóteses críticas estiverem explicitadas;
- riscos relevantes estiverem identificados;
- incertezas importantes estiverem registradas;
- não houver confusão entre problema e solução;
- o resultado tiver sido revisado quando necessário.

Resultados possíveis:

```text
APROVADO
APROVADO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA INVESTIGAÇÃO
BLOQUEADO
ENCERRADO
```

---

## Saída

Produzir:

- contexto;
- problema;
- usuários;
- necessidades;
- evidências;
- oportunidades;
- hipóteses;
- riscos;
- incertezas;
- perguntas abertas;
- recomendação;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

Quando aprovado, o trabalho pode avançar para:

```text
Discovery
   ↓
Product Definition
```

Quando houver incerteza relevante sobre o problema:

```text
Discovery
   ↓
investigação adicional
```

Quando o problema não justificar continuidade:

```text
Discovery
   ↓
Encerramento
```