---
title: Segurança da Cadeia de Software
description: Define princípios para reduzir riscos associados à origem, construção, distribuição e dependências do software.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - supply-chain
  - dependencias
  - build
  - entrega
---

# Segurança da Cadeia de Software

## Objetivo

A segurança do produto depende não apenas do código produzido pela squad, mas também dos componentes e processos utilizados para produzi-lo e entregá-lo.

## Elementos da cadeia

Podem fazer parte da análise:

- código-fonte;
- dependências;
- bibliotecas;
- ferramentas;
- sistemas de build;
- pipelines;
- artefatos;
- registros;
- ambientes;
- fornecedores;
- serviços externos.

## Riscos

A cadeia pode ser comprometida por:

- dependência maliciosa;
- componente vulnerável;
- credencial comprometida;
- alteração indevida;
- pipeline comprometido;
- artefato adulterado;
- fornecedor comprometido.

## Controles

Dependendo do contexto, podem ser considerados:

- controle de acesso;
- revisão de alterações;
- proteção de branches;
- rastreabilidade;
- inventário de dependências;
- verificação de artefatos;
- isolamento;
- assinaturas;
- integridade;
- monitoramento.

## Princípio

Quanto maior a confiança depositada em um componente ou processo externo, maior deve ser a atenção sobre sua origem, integridade e comportamento.

## Evolução

A cadeia deve ser revisada quando forem introduzidos:

- novos fornecedores;
- novas dependências;
- novas ferramentas;
- novos pipelines;
- novos mecanismos de distribuição.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `dependency-management`
- `deployment`

### Agentes relacionados

- `security-engineer`
- `devops-engineer`

### Workflows relacionados

- `05-development`
- `07-delivery`