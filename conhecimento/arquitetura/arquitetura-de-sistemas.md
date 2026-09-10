---
title: Arquitetura de Sistemas
description: Fundamentos para estruturar sistemas em partes, responsabilidades, relações, fronteiras e mecanismos de comunicação.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - sistemas
  - componentes
  - estrutura
---

# Arquitetura de Sistemas

## Conceito

Arquitetura de sistemas descreve a organização fundamental de uma solução, incluindo suas partes, responsabilidades, relações e decisões estruturais relevantes.

## Visões

Uma arquitetura pode ser analisada por diferentes perspectivas.

Entre elas:

- contexto;
- domínio;
- componentes;
- dados;
- integração;
- segurança;
- operação;
- implantação.

Nenhuma visão isolada representa necessariamente toda a arquitetura.

## Fronteiras

Uma arquitetura deve estabelecer limites compreensíveis entre partes do sistema.

Fronteiras podem existir entre:

- domínios;
- módulos;
- serviços;
- processos;
- sistemas;
- organizações.

## Responsabilidades

Cada parte deve possuir responsabilidades suficientemente claras para evitar sobreposição excessiva.

## Comunicação

Partes do sistema podem se comunicar por diferentes mecanismos.

A escolha depende de:

- necessidade de sincronismo;
- consistência;
- latência;
- volume;
- confiabilidade;
- acoplamento;
- criticidade.

## Distribuição

Distribuir componentes pode trazer benefícios, mas também introduz custos.

Entre os custos estão:

- latência;
- falhas de rede;
- observabilidade mais complexa;
- consistência distribuída;
- operações mais difíceis.

Portanto, distribuição não deve ser tratada como evolução automática de uma arquitetura.

## Contexto externo

Um sistema raramente existe isoladamente.

É necessário considerar:

- usuários;
- sistemas externos;
- parceiros;
- fornecedores;
- fontes de dados;
- mecanismos de autenticação;
- serviços de infraestrutura.

## Arquitetura e domínio

A estrutura técnica deve refletir, quando apropriado, as características do domínio.

Uma arquitetura que ignora o domínio pode produzir fronteiras artificiais e aumentar o custo de mudança.

## Comunicação arquitetural

Diagramas e descrições devem comunicar decisões relevantes sem adicionar complexidade visual desnecessária.

Uma boa representação deve ajudar a responder:

- o que existe;
- quem é responsável por quê;
- como as partes se relacionam;
- onde estão os principais riscos.

---

## Relações na Squad

### Skills relacionadas

- `architecture-design`
- `domain-modeling`
- `api-design`
- `integration-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`