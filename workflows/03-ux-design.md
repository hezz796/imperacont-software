---
name: ux-design
description: Conduz pesquisa, estruturação da experiência, arquitetura da informação, fluxos, interação e prototipação do produto.
version: 1
---

# Workflow: UX Design

## Objetivo

Projetar uma experiência adequada aos usuários e ao contexto do produto.

O workflow contempla:

- pesquisa;
- jornadas;
- arquitetura da informação;
- fluxos;
- interação;
- prototipação;
- acessibilidade;
- validação da experiência.

---

## Entrada

Utilizar:

- definição do produto;
- requisitos;
- usuários;
- objetivos;
- regras de negócio;
- restrições;
- riscos;
- métricas relevantes.

---

## Memória

Consultar seletivamente:

```text
memoria/contexto/
memoria/decisoes/
memoria/aprendizados/
memoria/problemas/
memoria/riscos/
```

Priorizar:

- aprendizados de UX anteriores;
- problemas recorrentes de experiência;
- decisões de produto;
- restrições persistentes;
- feedback histórico relevante;
- riscos conhecidos.

Não assumir que comportamento passado representa automaticamente comportamento atual.

---

## Etapas

### 1. Compreender usuários

Investigar:

- necessidades;
- objetivos;
- comportamentos;
- contexto;
- dificuldades;
- expectativas.

### 2. Estruturar jornadas

Mapear:

- etapas;
- objetivos;
- pontos de contato;
- fricções;
- oportunidades.

### 3. Arquitetura da informação

Definir:

- organização;
- navegação;
- hierarquia;
- agrupamento;
- nomenclatura.

### 4. Fluxos

Modelar os fluxos principais e alternativos.

### 5. Interação

Definir:

- estados;
- ações;
- respostas;
- feedback;
- erros;
- recuperação.

### 6. Protótipo

Produzir protótipos adequados ao nível de decisão necessário.

### 7. Acessibilidade

Considerar acessibilidade desde o design.

### 8. Validação

Validar a experiência conforme risco e evidência disponíveis.

---

## Revisão

Utilizar `@reviewer` quando:

- houver decisão crítica de UX;
- houver conflito entre requisitos e experiência;
- existir risco elevado;
- houver acessibilidade crítica;
- uma hipótese importante estiver sendo assumida como fato.

---

## Memórias candidatas

Podem ser candidatas:

- padrões de comportamento comprovados;
- problemas recorrentes;
- decisões relevantes de experiência;
- aprendizados de validação;
- restrições persistentes;
- eventos relevantes de pesquisa.

Não registrar como memória:

- hipótese ainda não validada;
- opinião de um participante isolado;
- solução descartada sem valor histórico;
- observação sem impacto futuro.

---

## Gate

A etapa pode avançar quando:

- usuários estiverem suficientemente compreendidos;
- jornadas relevantes estiverem mapeadas;
- fluxos principais estiverem definidos;
- problemas críticos estiverem tratados;
- acessibilidade relevante tiver sido considerada;
- protótipos forem suficientes para as decisões necessárias;
- riscos críticos estiverem controlados.

Resultado:

```text
APROVADO
APROVADO COM PENDÊNCIAS CONTROLADAS
RETORNAR PARA PRODUCT DEFINITION
BLOQUEADO
ENCERRADO
```

---

## Saída

Produzir:

- pesquisa;
- jornadas;
- arquitetura da informação;
- fluxos;
- decisões de interação;
- protótipos;
- critérios de UX;
- acessibilidade;
- riscos;
- aprendizados;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

```text
UX Design
    ↓
Architecture
```

Quando o produto precisar ser redefinido:

```text
UX Design
    ↓
Product Definition
```