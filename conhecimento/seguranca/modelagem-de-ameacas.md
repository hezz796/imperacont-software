---
title: Modelagem de Ameaças
description: Estrutura o entendimento de ameaças, ativos, superfícies de ataque, cenários e controles de segurança.
type: guide
status: active
scope: squad
tags:
  - seguranca
  - ameaças
  - threat-modeling
  - arquitetura
---

# Modelagem de Ameaças

## Objetivo

Modelagem de ameaças é uma forma estruturada de identificar como um sistema pode ser comprometido e quais controles podem reduzir os riscos identificados.

## Elementos

Uma análise pode considerar:

- ativos;
- usuários;
- atores maliciosos;
- componentes;
- fronteiras de confiança;
- fluxos de dados;
- interfaces;
- entradas;
- saídas;
- dependências;
- superfícies de ataque;
- ameaças;
- vulnerabilidades;
- controles;
- impactos.

## Processo conceitual

1. entender o contexto;
2. identificar ativos relevantes;
3. mapear componentes e fluxos;
4. identificar fronteiras de confiança;
5. identificar possíveis ameaças;
6. avaliar impacto e exposição;
7. identificar controles;
8. analisar riscos residuais;
9. registrar decisões;
10. revisar quando o sistema mudar.

## Fronteiras de confiança

Uma fronteira de confiança representa uma mudança relevante no nível de confiança entre entidades, componentes ou ambientes.

Exemplos conceituais:

- usuário → sistema;
- sistema → serviço externo;
- aplicação → banco de dados;
- ambiente interno → ambiente externo;
- serviço → serviço.

A existência de uma fronteira deve provocar avaliação explícita dos controles necessários.

## Modelagem não é previsão

Uma ameaça identificada não significa que o ataque ocorrerá.

A modelagem busca reduzir incerteza e antecipar cenários plausíveis.

## Evolução

O modelo deve ser revisitado quando houver mudanças significativas em:

- arquitetura;
- dados;
- integrações;
- usuários;
- permissões;
- exposição;
- infraestrutura;
- dependências;
- requisitos.

---

## Relações na Squad

### Skills relacionadas

- `security-design`
- `security-testing`
- `architecture-design`

### Agentes relacionados

- `security-engineer`

### Workflows relacionados

- `04-architecture`
- `06-quality`