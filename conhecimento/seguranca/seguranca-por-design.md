---
title: Segurança por Design
description: Consolida a integração da segurança às decisões de produto, UX, arquitetura, desenvolvimento, qualidade, entrega e evolução.
type: principle
status: active
scope: squad
tags:
  - seguranca
  - security-by-design
  - produto
  - arquitetura
  - qualidade
---

# Segurança por Design

## Objetivo

Segurança por design significa incorporar segurança às decisões do produto desde o início, em vez de tratá-la como uma etapa posterior.

## Durante a descoberta

Considerar:

- contexto;
- usuários;
- ativos;
- ameaças;
- consequências;
- requisitos de segurança;
- restrições.

## Durante a definição do produto

Identificar:

- dados envolvidos;
- operações críticas;
- níveis de acesso;
- requisitos de segurança;
- riscos aceitáveis;
- requisitos legais ou contratuais aplicáveis.

## Durante UX

Considerar:

- autenticação;
- autorização;
- privacidade;
- mensagens de erro;
- recuperação;
- consentimento quando aplicável;
- exposição de informações;
- acessibilidade dos mecanismos de segurança.

## Durante arquitetura

Considerar:

- fronteiras de confiança;
- isolamento;
- identidades;
- privilégios;
- dados;
- integrações;
- ameaças;
- resiliência;
- observabilidade.

## Durante desenvolvimento

Considerar:

- validação;
- autorização;
- tratamento de erros;
- dependências;
- segredos;
- configurações;
- registros.

## Durante qualidade

Considerar:

- testes de segurança;
- abuso;
- entradas maliciosas;
- controles de acesso;
- recuperação;
- regressões;
- vulnerabilidades.

## Durante entrega

Considerar:

- ambientes;
- credenciais;
- artefatos;
- pipeline;
- configuração;
- monitoramento;
- rollback.

## Durante evolução

Considerar:

- incidentes;
- vulnerabilidades;
- mudanças arquiteturais;
- novos dados;
- novas integrações;
- feedback;
- riscos emergentes.

## Princípio central

Segurança não deve ser uma barreira colocada no final do fluxo.

Ela deve fazer parte das decisões que moldam o produto.

## Resultado

O objetivo não é produzir um sistema "sem risco".

O objetivo é produzir um sistema no qual:

- riscos relevantes sejam conhecidos;
- controles sejam deliberados;
- exposição seja reduzida;
- eventos sejam detectáveis;
- impactos sejam limitados;
- recuperação seja possível;
- decisões sejam rastreáveis;
- segurança evolua junto com o produto.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `security-testing`
- `architecture-design`
- `technical-decisions`

### Agentes relacionados

- `security-engineer`

### Workflows relacionados

- `01-discovery`
- `04-architecture`
- `05-development`
- `06-quality`
- `07-delivery`