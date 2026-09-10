---
title: Segurança
description: Organiza os conhecimentos fundamentais de segurança utilizados pela software squad ao longo de todo o ciclo de vida do produto.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - cybersecurity
  - engenharia
  - arquitetura
  - qualidade
---

# Segurança

## Finalidade

Esta categoria reúne os conhecimentos necessários para incorporar segurança ao ciclo de vida de produtos e sistemas de software.

Segurança deve ser tratada como uma preocupação transversal, e não como uma atividade restrita ao final do desenvolvimento.

## Escopo

A base aborda:

- princípios de segurança;
- modelagem de ameaças;
- riscos de segurança;
- identidade;
- autenticação;
- autorização;
- controle de acesso;
- proteção de dados;
- segurança de aplicações;
- segurança de APIs e integrações;
- segurança de infraestrutura;
- segredos e credenciais;
- logs, auditoria e monitoramento;
- resposta a incidentes;
- vulnerabilidades;
- dependências;
- cadeia de software;
- segurança por design.

## Princípio geral

A squad deve buscar:

> identificar riscos cedo, reduzir exposição, limitar impacto e manter capacidade de detectar, responder e recuperar.

## Relação com outras camadas

### Agent

`security-engineer` é o agente especializado responsável por análises de segurança.

### Skills

As skills operacionalizam atividades como:

- security-design;
- security-testing;
- análise de riscos;
- identificação de ameaças;
- avaliação de controles.

### Workflows

A segurança aparece em diferentes etapas:

- discovery;
- definição do produto;
- UX;
- arquitetura;
- desenvolvimento;
- qualidade;
- entrega;
- evolução.

### Conhecimento

Os documentos desta categoria explicam conceitos e princípios que orientam essas atividades.

## Regra de uso

Nenhum conhecimento desta categoria deve ser interpretado isoladamente.

As decisões devem considerar:

- contexto;
- usuários;
- dados;
- ameaças;
- impacto;
- probabilidade;
- exposição;
- controles existentes;
- custo;
- complexidade;
- capacidade de detecção;
- capacidade de recuperação.

## Governança

Conhecimentos específicos de tecnologia, legislação, fornecedores ou padrões externos devem ser tratados como referências sujeitas a atualização.

Quando uma decisão depender de informação atualizada, a squad deve buscar a fonte apropriada antes de assumir que o conhecimento permanece válido.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `security-testing`
- `incident-response`
- `dependency-management`
- `configuration-management`
- `logging-and-observability`
- `technical-decisions`

### Agentes relacionados

- `security-engineer`
- `solution-architect`
- `devops-engineer`
- `software-engineer`
- `data-engineer`
- `reviewer`

### Workflows relacionados

- `01-discovery`
- `02-product-definition`
- `03-ux-design`
- `04-architecture`
- `05-development`
- `06-quality`
- `07-delivery`
- `08-evolution`