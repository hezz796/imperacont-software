---
name: evolution
description: Converte resultados operacionais, feedback, métricas e aprendizados em decisões de evolução do produto, tecnologia e processos.
version: 1
---

# Workflow: Evolution

## Objetivo

Transformar evidências obtidas após a operação do produto em decisões de evolução.

A evolução deve considerar:

- feedback;
- comportamento dos usuários;
- métricas;
- incidentes;
- defeitos;
- riscos;
- custos;
- dívida técnica;
- oportunidades;
- contexto;
- aprendizados anteriores.

---

## Entrada

Utilizar:

- feedback;
- métricas;
- observabilidade;
- incidentes;
- resultados de releases;
- problemas;
- defeitos;
- dívida técnica;
- riscos;
- contexto do produto;
- aprendizados.

---

## Memória

A evolução deve consultar amplamente, mas de forma contextual:

```text
memoria/decisoes/
memoria/aprendizados/
memoria/contexto/
memoria/riscos/
memoria/problemas/
memoria/historico/
```

Avaliar:

- decisões anteriores;
- aprendizados;
- padrões recorrentes;
- riscos persistentes;
- problemas estruturais;
- mudanças históricas;
- memórias superseded ou deprecated que possam explicar decisões atuais.

Não assumir que uma memória ativa permanece válida sem verificar contexto e evidência.

---

## Etapas

### 1. Coletar evidências

Analisar:

- feedback;
- métricas;
- comportamento;
- incidentes;
- qualidade;
- operação;
- custos;
- riscos.

### 2. Separar sinais

Distinguir:

```text
PROBLEMA
SINTOMA
CAUSA
SOLICITAÇÃO
OPORTUNIDADE
HIPÓTESE
SOLUÇÃO
```

Não transformar automaticamente uma solicitação em requisito.

### 3. Identificar padrões

Pesquisar recorrência:

- problemas;
- falhas;
- comportamentos;
- riscos;
- oportunidades;
- custos;
- dívida técnica.

### 4. Avaliar aprendizados

Determinar o que foi aprendido.

Perguntar:

- o aprendizado possui evidência suficiente?
- é específico ou generalizável?
- contradiz alguma memória existente?
- altera alguma decisão?
- deve gerar uma nova decisão?

### 5. Priorizar evolução

Priorizar conforme:

- valor;
- evidência;
- risco;
- urgência;
- impacto;
- custo;
- dependências;
- aprendizado esperado.

### 6. Decidir próximos movimentos

A evolução pode retornar para diferentes etapas:

```text
EVOLUTION
   ├──→ DISCOVERY
   ├──→ PRODUCT DEFINITION
   ├──→ UX DESIGN
   ├──→ ARCHITECTURE
   ├──→ DEVELOPMENT
   ├──→ QUALITY
   └──→ DELIVERY
```

Não retornar automaticamente para o início.

O destino deve ser determinado pela natureza do aprendizado ou problema.

---

## Memória

A evolução é o principal ponto de avaliação da memória.

Para cada candidato, determinar:

```text
É RELEVANTE?
      ↓
TEM EVIDÊNCIA?
      ↓
É PERSISTENTE?
      ↓
MUDA DECISÕES FUTURAS?
      ↓
QUAL CATEGORIA?
```

Possíveis categorias:

```text
DECISÃO
APRENDIZADO
CONTEXTO
RISCO
PROBLEMA
EVENTO HISTÓRICO
```

---

## Atualização de memórias

Quando uma memória anterior perder validade:

```text
MEMÓRIA ANTERIOR
       ↓
AVALIAÇÃO
       ↓
SUPERSEDED / DEPRECATED / ARCHIVED
       ↓
NOVA MEMÓRIA OU NOVA DECISÃO
```

Não apagar automaticamente a memória anterior quando ela possuir valor histórico.

---

## Promoção para conhecimento

Quando um aprendizado deixar de ser apenas contextual e possuir evidência suficiente para generalização:

```text
EXPERIÊNCIA
    ↓
MEMÓRIA
    ↓
RECORRÊNCIA
    ↓
EVIDÊNCIA
    ↓
GENERALIZAÇÃO
    ↓
CONHECIMENTO
```

A promoção deve ser deliberada.

Não transformar um caso isolado em regra geral.

---

## Revisão

Utilizar `@reviewer` quando:

- houver aprendizado controverso;
- houver conflito entre memórias;
- uma decisão importante estiver sendo alterada;
- houver risco elevado;
- existir proposta de generalização;
- uma memória estiver sendo promovida para conhecimento;
- houver impacto significativo no produto ou arquitetura.

---

## Gate

A evolução pode ser concluída quando:

- evidências relevantes tiverem sido analisadas;
- problemas e oportunidades estiverem diferenciados;
- aprendizados estiverem explicitados;
- prioridades estiverem justificadas;
- decisões necessárias estiverem registradas;
- riscos estiverem atualizados;
- candidatas a memória tiverem sido avaliadas;
- alterações relevantes de memória tiverem sido encaminhadas;
- próximo estado estiver definido.

Resultado:

```text
EVOLUÇÃO APROVADA
EVOLUÇÃO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA ETAPA ANTERIOR
BLOQUEADO
ENCERRADO
```

---

## Saída

Produzir:

- evidências;
- feedback analisado;
- métricas;
- problemas;
- causas ou hipóteses;
- oportunidades;
- aprendizados;
- riscos;
- dívida técnica;
- prioridades;
- decisões;
- mudanças de contexto;
- candidatas a memória;
- memórias atualizadas;
- eventual proposta de promoção para conhecimento;
- próximo estado.

---

## Fechamento do ciclo

O workflow encerra o ciclo:

```text
PRODUTO
   ↓
USO
   ↓
OBSERVAÇÃO
   ↓
FEEDBACK
   ↓
EVIDÊNCIA
   ↓
APRENDIZADO
   ↓
MEMÓRIA
   ↓
DECISÃO
   ↓
EVOLUÇÃO
   ↓
DISCOVERY / PRODUCT / UX / ARCHITECTURE / DEVELOPMENT
```

A evolução não deve apenas adicionar funcionalidades.

Ela deve aumentar o conhecimento, reduzir incerteza, reduzir riscos, corrigir problemas e melhorar continuamente o produto e a própria squad.