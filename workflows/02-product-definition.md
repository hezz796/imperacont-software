---
name: product-definition
description: Converte o entendimento obtido na discovery em definição estruturada de produto, requisitos, escopo, backlog e métricas.
version: 1
---

# Workflow: Product Definition

## Objetivo

Transformar o entendimento obtido na discovery em uma definição estruturada de produto.

O workflow deve estabelecer:

- visão;
- objetivo;
- público;
- proposta de valor;
- escopo;
- requisitos;
- regras de negócio;
- histórias de usuário;
- critérios de aceitação;
- backlog inicial;
- métricas;
- riscos;
- premissas.

Não antecipar decisões técnicas que pertençam à arquitetura.

---

## Entrada

Utilizar como entrada:

- resultado da discovery;
- evidências;
- problema validado;
- contexto;
- usuários;
- oportunidades;
- hipóteses;
- restrições;
- riscos;
- aprendizados relevantes.

---

## Memória

Antes da definição do produto, consultar:

```text
memoria/contexto/
memoria/decisoes/
memoria/aprendizados/
memoria/riscos/
memoria/problemas/
```

Priorizar memórias relacionadas a:

- domínio;
- usuários;
- problemas;
- decisões de produto anteriores;
- restrições persistentes;
- aprendizados de iniciativas anteriores;
- riscos conhecidos.

Não permitir que uma memória antiga determine automaticamente o produto atual.

Verificar sua validade no contexto atual.

---

## Etapas

### 1. Consolidar visão

Definir:

- qual produto está sendo considerado;
- qual problema resolve;
- para quem;
- qual valor pretende gerar.

### 2. Definir objetivo

Estabelecer resultados esperados.

Separar:

- objetivo;
- solução;
- métrica.

### 3. Definir público

Caracterizar:

- usuários;
- compradores;
- administradores;
- partes interessadas;
- demais atores relevantes.

### 4. Definir valor

Estabelecer:

- benefícios esperados;
- resultados;
- diferenciais;
- hipóteses de valor.

### 5. Definir escopo

Separar claramente:

```text
IN-SCOPE
OUT-OF-SCOPE
```

Evitar expansão não justificada do escopo.

### 6. Engenharia de requisitos

Identificar:

- requisitos funcionais;
- requisitos não funcionais;
- regras de negócio;
- restrições;
- dependências;
- premissas.

### 7. User stories

Transformar necessidades relevantes em histórias de usuário quando apropriado.

Cada história deve possuir critérios de aceitação verificáveis.

### 8. Backlog

Estruturar o backlog inicial conforme:

- valor;
- risco;
- dependência;
- urgência;
- evidência;
- esforço quando conhecido.

Não utilizar esforço técnico como único critério de prioridade.

### 9. Métricas

Definir métricas capazes de verificar se o produto está atingindo seus objetivos.

### 10. Riscos

Atualizar riscos identificados durante a definição.

---

## Revisão

Solicitar `@reviewer` quando houver:

- requisito crítico;
- conflito entre requisitos;
- escopo controverso;
- risco elevado;
- regra de negócio ambígua;
- hipótese importante tratada como fato;
- impacto relevante em arquitetura futura.

---

## Memórias candidatas

Avaliar ao final:

- decisões de produto;
- restrições persistentes;
- aprendizados relevantes;
- riscos que continuarão existindo;
- problemas recorrentes;
- mudanças significativas de contexto.

Hipóteses devem permanecer hipóteses até que exista evidência suficiente.

As candidatas devem ser encaminhadas ao `@squad-lead`.

---

## Gate

Avançar somente quando:

- visão estiver clara;
- objetivo estiver definido;
- público estiver identificado;
- valor estiver explicitado;
- escopo estiver delimitado;
- requisitos críticos estiverem definidos;
- critérios de aceitação estiverem adequados;
- riscos relevantes estiverem identificados;
- métricas principais estiverem definidas;
- conflitos críticos estiverem resolvidos ou explicitados.

Resultado:

```text
APROVADO
APROVADO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA DISCOVERY
BLOQUEADO
ENCERRADO
```

---

## Saída

Produzir:

- visão do produto;
- objetivo;
- público;
- proposta de valor;
- escopo;
- requisitos;
- regras de negócio;
- user stories;
- critérios de aceitação;
- backlog;
- métricas;
- riscos;
- premissas;
- decisões;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

```text
Product Definition
        ↓
UX / Design
```

Quando houver necessidade de reexaminar o problema:

```text
Product Definition
        ↓
Discovery
```