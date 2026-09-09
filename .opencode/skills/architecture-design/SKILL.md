---
name: architecture-design
description: Define a arquitetura da solução a partir de requisitos, atributos de qualidade, domínio, restrições, integrações e decisões de engenharia.
---

# Architecture Design

## Objetivo

Definir uma arquitetura que permita atender aos objetivos do produto de forma sustentável, considerando requisitos funcionais, atributos de qualidade, restrições e riscos.

## Princípio central

Seguir a sequência:

`Problema → Produto → Requisitos → Qualidade → Arquitetura → Tecnologia`

Não começar pela tecnologia.

## Entradas

Considerar:

- Product Definition;
- requisitos;
- regras de negócio;
- jornadas;
- capacidades;
- dados;
- integrações;
- segurança;
- operação;
- restrições;
- riscos;
- requisitos regulatórios.

## Atributos de qualidade

Avaliar, quando relevantes:

- desempenho;
- disponibilidade;
- confiabilidade;
- segurança;
- privacidade;
- escalabilidade;
- interoperabilidade;
- observabilidade;
- manutenibilidade;
- testabilidade;
- portabilidade;
- recuperação;
- custo operacional.

Não assumir que todos possuem a mesma prioridade.

## Fronteiras

Definir:

- responsabilidades;
- módulos;
- componentes;
- serviços, quando necessários;
- interfaces;
- dependências;
- limites de contexto;
- sistemas externos.

## Alternativas

Para decisões arquiteturais importantes:

1. identificar alternativas;
2. definir critérios;
3. avaliar trade-offs;
4. registrar consequências;
5. selecionar a alternativa;
6. documentar a decisão.

## Simplicidade

Preferir a arquitetura mais simples capaz de atender aos requisitos atuais e às necessidades razoavelmente previsíveis.

Evitar:

- complexidade antecipada;
- abstrações sem necessidade;
- distribuição sem justificativa;
- componentes excessivos;
- dependências desnecessárias.

## Tecnologia

Tecnologias podem ser selecionadas quando necessário.

A escolha deve considerar:

- requisitos;
- equipe;
- ecossistema;
- maturidade;
- segurança;
- custo;
- manutenção;
- interoperabilidade;
- desempenho;
- disponibilidade;
- riscos.

## Evolução

A arquitetura deve permitir evolução sem exigir mudanças desproporcionais.

Identificar:

- pontos de extensão;
- acoplamentos;
- dependências críticas;
- riscos de evolução.

## Saída esperada

Produzir:

1. contexto arquitetural;
2. requisitos relevantes;
3. atributos de qualidade;
4. fronteiras;
5. componentes;
6. responsabilidades;
7. integrações;
8. fluxos;
9. alternativas;
10. decisões;
11. trade-offs;
12. riscos;
13. tecnologias selecionadas, quando justificadas;
14. questões em aberto.