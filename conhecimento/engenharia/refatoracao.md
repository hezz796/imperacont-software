---
title: Refatoração
description: Princípios para melhorar a estrutura interna do software preservando seu comportamento pretendido.
type: guide
status: active
scope: squad
tags:
  - refatoracao
  - manutencao
  - qualidade
  - engenharia
---

# Refatoração

## Princípio

Refatoração é a alteração da estrutura interna do software com o objetivo de melhorar sua qualidade interna sem alterar intencionalmente o comportamento funcional estabelecido.

## Motivações

Pode ser utilizada para:

- reduzir complexidade;
- melhorar legibilidade;
- reduzir acoplamento;
- aumentar coesão;
- remover duplicação;
- preparar uma mudança;
- corrigir deterioração estrutural;
- reduzir dívida técnica.

## Segurança da mudança

Refatoração deve ser conduzida com controle adequado.

Quando o comportamento existente for relevante, testes e outras evidências devem ajudar a verificar que ele permanece preservado.

## Refatoração não é reescrita

Uma refatoração normalmente procura melhorar a estrutura existente de maneira controlada.

Uma reescrita pode representar uma mudança de escopo, arquitetura ou implementação muito maior.

As duas atividades não devem ser tratadas como equivalentes.

## Regra

Não utilizar refatoração como justificativa genérica para introduzir mudanças funcionais não relacionadas.

Mudanças de comportamento devem ser identificadas separadamente.

## Resultado esperado

A estrutura interna deve melhorar sem introduzir mudanças funcionais não planejadas.