---
name: development
description: Conduz planejamento técnico e implementação incremental do software conforme produto, requisitos, arquitetura e critérios de qualidade.
version: 1
---

# Workflow: Development

## Objetivo

Transformar requisitos e arquitetura aprovados em software funcional, testável e sustentável.

## Princípio

Implementar somente aquilo que possui contexto, objetivo e critérios suficientemente definidos.

## Entrada

- requisitos;
- backlog;
- user stories;
- arquitetura;
- decisões técnicas;
- critérios de aceitação.

## Agente principal

`@software-engineer`

## Agentes participantes

- `@data-engineer`
- `@security-engineer`
- `@test-engineer`
- `@reviewer`

## Skills

- `implementation`
- `coding-standards`
- `refactoring`
- `dependency-management`
- `error-handling`
- `logging-and-observability`
- `configuration-management`
- `version-control-and-change-management`

## Etapas

### 1. Planejamento técnico

Identificar:

- item;
- dependências;
- impacto;
- estratégia;
- critérios de conclusão.

### 2. Implementação

Desenvolver incrementalmente respeitando:

- requisitos;
- arquitetura;
- contratos;
- padrões;
- segurança.

### 3. Testes durante desenvolvimento

Executar verificações adequadas ao nível da mudança.

### 4. Integração

Integrar componentes e validar contratos.

### 5. Refatoração

Melhorar estrutura sem alterar comportamento esperado.

### 6. Segurança

Verificar controles relevantes durante a implementação.

### 7. Revisão

`@reviewer` verifica:

- requisitos;
- arquitetura;
- qualidade;
- segurança;
- manutenção;
- dívida técnica.

## Gate

Uma unidade de trabalho pode ser considerada concluída quando:

- implementação atende aos requisitos;
- testes relevantes estão passando;
- critérios de aceitação são atendidos;
- problemas críticos foram tratados;
- alterações estão rastreáveis;
- documentação necessária foi atualizada.

## Saída

Produzir:

- código;
- testes;
- alterações de configuração;
- documentação técnica necessária;
- decisões;
- evidências;
- itens pendentes.

## Decisão

- `PRONTO PARA QUALITY`
- `REQUER CORREÇÃO`
- `REQUER REVISÃO ARQUITETURAL`