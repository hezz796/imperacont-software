---
title: Segurança desde o desenho
description: Segurança deve ser considerada desde a descoberta e arquitetura e permanecer presente durante todo o ciclo de vida.
type: principle
status: active
scope: squad
tags:
  - security
  - privacy
  - architecture
  - development
---

# Segurança desde o desenho

## Princípio

Segurança deve ser considerada desde as primeiras decisões do produto e da solução.

Não deve ser tratada exclusivamente como uma verificação realizada antes da release.

## Aplicação

A análise de segurança pode considerar:

- ativos;
- usuários;
- ameaças;
- vulnerabilidades;
- superfícies de ataque;
- autenticação;
- autorização;
- dados;
- dependências;
- integrações;
- infraestrutura;
- registros e observabilidade;
- recuperação de incidentes.

## Proporcionalidade

O nível de controle deve considerar:

```text
VALOR DOS ATIVOS
+
EXPOSIÇÃO
+
IMPACTO
+
AMEAÇAS
+
RISCO
```

## Resultado esperado

A segurança deve estar integrada ao produto, à arquitetura, à implementação, aos testes e à operação.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `security-testing`
- `architecture-design`

### Agentes relacionados

- `security-engineer`

### Workflows relacionados

- `01-discovery`
- `04-architecture`
- `05-development`
- `06-quality`