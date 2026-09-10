---
title: Princípios de Segurança
description: Define princípios gerais para orientar decisões de segurança durante o ciclo de vida de produtos e sistemas.
type: principle
status: active
scope: squad
tags:
  - seguranca
  - principios
  - risco
  - arquitetura
---

# Princípios de Segurança

## Objetivo

Segurança deve ser resultado de decisões sistemáticas, e não apenas de controles adicionados após a implementação.

## Princípios fundamentais

### Segurança por design

Considerar segurança desde a definição do problema, produto, arquitetura e experiência.

### Menor privilégio

Cada usuário, componente, processo ou serviço deve possuir somente os privilégios necessários para cumprir sua função.

### Defesa em profundidade

Não depender de um único controle de segurança.

Controles independentes ou complementares devem reduzir a probabilidade de comprometimento e limitar seu impacto.

### Negação segura

Quando uma decisão não puder ser determinada com segurança, o comportamento padrão deve evitar concessão indevida de acesso ou privilégio.

### Minimização

Coletar, processar, armazenar e expor somente os dados necessários para a finalidade definida.

### Isolamento

Separar componentes, dados, processos ou contextos quando essa separação reduzir risco.

### Transparência operacional

Eventos relevantes de segurança devem ser detectáveis e investigáveis.

### Segurança proporcional ao risco

Nem todo contexto exige o mesmo nível de controle.

A intensidade dos controles deve ser proporcional ao impacto potencial, exposição e contexto.

### Recuperabilidade

Segurança não significa apenas impedir incidentes.

O sistema também deve possuir capacidade adequada de:

- detectar;
- conter;
- responder;
- recuperar;
- aprender.

## Segurança versus complexidade

Um controle pode reduzir determinado risco e, simultaneamente, aumentar:

- complexidade;
- custo;
- superfície operacional;
- possibilidade de erro;
- dificuldade de manutenção.

Portanto, controles de segurança também devem ser avaliados por seus efeitos colaterais.

## Resultado esperado

As decisões de segurança devem produzir sistemas que sejam:

- mais resistentes;
- mais observáveis;
- mais controláveis;
- mais recuperáveis;
- menos expostos a riscos desnecessários.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `security-testing`

### Agentes relacionados

- `security-engineer`

### Workflows relacionados

- `04-architecture`
- `06-quality`