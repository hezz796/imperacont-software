---
title: Dependências
description: Princípios para seleção, utilização, atualização e remoção de dependências de software.
type: guide
status: active
scope: squad
tags:
  - dependencias
  - engenharia
  - seguranca
  - manutencao
---

# Dependências

## Princípio

Toda dependência introduzida em um sistema deve ser tratada como uma decisão que possui benefícios, custos e riscos.

## Avaliação

Quando relevante, considerar:

- necessidade real;
- maturidade;
- manutenção;
- compatibilidade;
- segurança;
- licença;
- estabilidade;
- comunidade ou suporte;
- custo;
- frequência de atualização;
- impacto no sistema;
- possibilidade de substituição.

## Dependência direta

Dependências que o sistema utiliza diretamente devem ser conhecidas e controladas.

Dependências transitivas também podem introduzir riscos.

## Atualização

Atualizações não devem ser realizadas de forma indiscriminada.

Devem considerar:

- motivo da atualização;
- mudanças relevantes;
- compatibilidade;
- vulnerabilidades;
- testes necessários;
- impacto operacional;
- possibilidade de rollback.

## Remoção

Dependências que deixaram de ser necessárias devem ser removidas quando isso reduzir complexidade ou risco sem causar efeitos indesejados.

## Resultado esperado

O conjunto de dependências deve permanecer pequeno o suficiente para ser administrável e grande o suficiente para atender às necessidades justificadas do sistema.

---

## Relações na Squad

### Skills relacionadas

- `dependency-management`
- `security-design`

### Agentes relacionados

- `software-engineer`
- `security-engineer`

### Workflows relacionados

- `05-development`
- `06-quality`