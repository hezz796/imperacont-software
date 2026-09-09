---
title: Tratamento de erros
description: Princípios para representar, tratar, propagar e observar falhas de software de maneira previsível.
type: guide
status: active
scope: squad
tags:
  - erros
  - confiabilidade
  - engenharia
  - observabilidade
---

# Tratamento de erros

## Princípio

Falhas devem ser tratadas de forma explícita, previsível e compatível com o contexto do sistema.

Um erro não deve simplesmente desaparecer para evitar que seja percebido.

## Categorias

Dependendo do sistema, podem existir:

- erros esperados;
- erros de validação;
- falhas de dependências;
- falhas de infraestrutura;
- erros de programação;
- indisponibilidade;
- timeout;
- inconsistência de dados;
- falhas de integração.

## Tratamento

Ao tratar uma falha, considerar:

1. quem precisa saber dela;
2. se ela pode ser recuperada;
3. se deve ser propagada;
4. qual informação deve ser preservada;
5. qual informação pode ser exposta;
6. como será observada;
7. qual comportamento o usuário deve receber.

## Evitar

- capturar erros sem tratá-los;
- esconder falhas;
- retornar mensagens ambíguas;
- expor informações sensíveis;
- usar um único mecanismo para todas as classes de erro;
- transformar falhas inesperadas em comportamentos aparentemente normais.

## Observabilidade

Erros relevantes devem produzir evidências suficientes para diagnóstico, respeitando segurança e privacidade.

## Resultado esperado

Falhas devem ser compreensíveis, tratáveis e observáveis na medida necessária ao risco e à criticidade do sistema.