---
name: version-control-and-change-management
description: Orienta controle de versão, organização de mudanças, histórico, revisão e rastreabilidade do desenvolvimento de software.
---

# Version Control and Change Management

## Objetivo

Garantir que mudanças no software sejam rastreáveis, revisáveis e recuperáveis.

## Princípio

O histórico deve ajudar a compreender:

- o que mudou;
- por que mudou;
- quando mudou;
- quem realizou;
- qual requisito ou problema motivou a mudança.

## Mudanças

Cada alteração deve possuir escopo compreensível.

Evitar misturar em uma mesma mudança:

- funcionalidades não relacionadas;
- refatorações extensas;
- alterações de configuração sem relação;
- correções independentes.

## Histórico

Mensagens e registros devem explicar o propósito da alteração.

Evitar descrições vagas como:

- "ajustes";
- "correções";
- "mudanças".

## Revisão

Antes da integração, quando aplicável, verificar:

- comportamento;
- testes;
- segurança;
- impacto;
- arquitetura;
- documentação.

## Branches ou equivalentes

A estratégia deve ser definida pelo projeto.

Não impor um modelo universal.

## Rollback

Mudanças relevantes devem considerar como retornar a um estado conhecido quando necessário.

## Rastreabilidade

Relacionar, quando apropriado:

`Requisito → Item → Mudança → Teste → Release`

## Saída esperada

Produzir:

1. estratégia de versionamento;
2. convenções;
3. organização das mudanças;
4. revisão;
5. rastreabilidade;
6. rollback;
7. políticas de integração.