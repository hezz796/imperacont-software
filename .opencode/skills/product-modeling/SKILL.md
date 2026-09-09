---
name: product-modeling
description: Modela capacidades, jornadas, domínios, processos e relações do produto para transformar necessidades em uma visão estruturada da solução.
---

# Product Modeling

## Objetivo

Criar modelos conceituais que ajudem a compreender o produto antes de definir sua implementação.

## Princípio

Modelos devem reduzir complexidade e melhorar decisões.

Não criar modelos apenas por formalidade.

## Elementos

Quando aplicável, modelar:

- atores;
- usuários;
- objetivos;
- jornadas;
- capacidades;
- processos;
- eventos;
- estados;
- entidades conceituais;
- regras;
- relações;
- integrações;
- limites.

## Capacidades

Identificar o que o produto precisa ser capaz de fazer, independentemente da implementação.

Exemplo:

> Gerenciar solicitações de clientes.

Em vez de:

> Criar endpoint POST `/requests`.

## Processos

Representar:

- entrada;
- etapas;
- decisões;
- regras;
- saídas;
- exceções;
- responsáveis.

## Estados

Quando um objeto possuir ciclo de vida, identificar:

- estados;
- transições;
- eventos;
- condições;
- ações;
- estados inválidos.

## Jornadas

Considerar:

- início;
- objetivo;
- etapas;
- pontos de decisão;
- dificuldades;
- resultados;
- exceções;
- término.

## Domínio

Quando o domínio for complexo, identificar:

- conceitos centrais;
- relações;
- regras;
- vocabulário;
- fronteiras;
- responsabilidades.

Evitar criar um modelo técnico antes de compreender o domínio.

## Consistência

Utilizar terminologia consistente entre:

- produto;
- requisitos;
- UX;
- arquitetura;
- desenvolvimento;
- testes;
- documentação.

## Saída esperada

Produzir, conforme necessário:

1. mapa de capacidades;
2. jornadas;
3. processos;
4. estados;
5. modelo conceitual;
6. regras;
7. vocabulário;
8. relações;
9. fronteiras;
10. questões em aberto.