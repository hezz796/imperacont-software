---
name: dependency-management
description: Gerencia dependências de software considerando necessidade, compatibilidade, segurança, manutenção, licenciamento e impacto operacional.
---

# Dependency Management

## Objetivo

Controlar dependências externas e internas de maneira consciente e sustentável.

## Princípio

Toda dependência introduz custo, risco ou responsabilidade.

Não adicionar uma dependência apenas porque ela simplifica uma pequena tarefa.

## Avaliação

Antes de adicionar:

- necessidade;
- alternativas;
- maturidade;
- manutenção;
- compatibilidade;
- segurança;
- licença;
- tamanho;
- impacto operacional;
- comunidade ou suporte;
- risco de abandono.

## Versionamento

Definir estratégia adequada para:

- versões;
- atualizações;
- compatibilidade;
- mudanças incompatíveis;
- bloqueio de versões quando necessário.

## Atualizações

Avaliar:

- correções de segurança;
- correções de defeitos;
- novas funcionalidades;
- breaking changes;
- impacto nos testes.

## Segurança

Monitorar riscos conhecidos quando houver mecanismos disponíveis.

Não assumir que uma dependência é segura apenas porque é popular.

## Remoção

Remover dependências:

- não utilizadas;
- redundantes;
- substituídas;
- excessivamente arriscadas;
- cujo custo não seja justificável.

## Licenciamento

Quando relevante, verificar compatibilidade das licenças com o produto e sua distribuição.

## Saída esperada

Produzir:

1. dependências;
2. justificativa;
3. versões;
4. riscos;
5. estratégia de atualização;
6. problemas identificados;
7. dependências candidatas à remoção.