---
title: Manutenibilidade
description: Princípios para manter o software compreensível e modificável ao longo de seu ciclo de vida.
type: guide
status: active
scope: squad
tags:
  - manutencao
  - engenharia
  - qualidade
---

# Manutenibilidade

## Princípio

Software deve ser construído considerando que será lido, diagnosticado, corrigido e modificado diversas vezes durante seu ciclo de vida.

## Características

A manutenibilidade pode ser favorecida por:

- código compreensível;
- responsabilidades claras;
- baixo acoplamento desnecessário;
- testes adequados;
- dependências controladas;
- documentação útil;
- observabilidade;
- tratamento de erros consistente;
- mudanças pequenas;
- arquitetura coerente.

## Código para leitura

A compreensão do código é uma preocupação de engenharia.

Nomes, estruturas, interfaces e fluxos devem reduzir o esforço necessário para entender o comportamento.

## Custo de mudança

Ao avaliar uma solução, considerar não apenas o custo de implementá-la agora, mas também:

```text
CUSTO DE IMPLEMENTAÇÃO
+
CUSTO DE COMPREENSÃO
+
CUSTO DE TESTE
+
CUSTO DE OPERAÇÃO
+
CUSTO DE MUDANÇA
```

## Resultado esperado

O software deve permanecer suficientemente compreensível e modificável à medida que evolui.

---

## Relações na Squad

### Skills relacionadas

- `coding-standards`
- `refactoring`
- `maintenance-strategy`
- `technical-debt-management`

### Agentes relacionados

- `software-engineer`

### Workflows relacionados

- `05-development`
- `08-evolution`