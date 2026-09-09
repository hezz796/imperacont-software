---
name: user-stories
description: Estrutura necessidades do usuário em histórias de usuário pequenas, compreensíveis, orientadas a valor e verificáveis.
---

# User Stories

## Objetivo

Representar necessidades e comportamentos do produto de forma compreensível para produto, UX, engenharia e qualidade.

## Princípio

Uma história de usuário deve representar uma necessidade ou resultado relevante para alguém, e não simplesmente uma tarefa técnica.

## Estrutura

Utilizar, quando apropriado:

> Como [tipo de usuário], quero [objetivo], para [benefício].

A estrutura é um guia, não uma obrigação mecânica.

## Componentes

Uma história pode conter:

- identificador;
- título;
- usuário;
- necessidade;
- benefício;
- contexto;
- regras de negócio;
- critérios de aceitação;
- dependências;
- restrições;
- observações.

## Critérios de aceitação

Devem permitir determinar objetivamente se a história foi atendida.

Podem utilizar formatos como:

### Given / When / Then

- Given: contexto inicial;
- When: ação ou evento;
- Then: resultado esperado.

### Lista verificável

Quando o comportamento for simples, utilizar condições objetivas.

## Qualidade

Avaliar a história segundo:

- independência;
- valor;
- clareza;
- tamanho adequado;
- verificabilidade.

Evitar histórias excessivamente grandes.

## Decomposição

Quando uma história for grande demais, decompor considerando:

- fluxo;
- comportamento;
- regras;
- cenários;
- valor incremental;
- diferentes resultados;
- diferentes tipos de usuário.

Não decompor simplesmente por camada técnica.

Evitar histórias como:

- criar banco de dados;
- criar API;
- criar tela;
- criar classe.

Essas atividades podem existir no planejamento técnico, mas não substituem uma necessidade do usuário.

## Regras de negócio

Uma história deve referenciar regras relevantes sem duplicar informações desnecessariamente.

Regras complexas devem ser documentadas de forma independente quando apropriado.

## Dependências

Registrar dependências que realmente impeçam ou condicionem a execução.

Não criar dependências artificiais entre histórias.

## Saída esperada

Produzir histórias contendo:

1. título;
2. usuário;
3. objetivo;
4. valor;
5. contexto;
6. critérios de aceitação;
7. regras relacionadas;
8. dependências;
9. questões em aberto.