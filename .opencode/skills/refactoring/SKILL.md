---
name: refactoring
description: Orienta a melhoria estrutural do código preservando comportamento e reduzindo complexidade, duplicação e acoplamento.
---

# Refactoring

## Objetivo

Melhorar a estrutura interna do software sem alterar seu comportamento pretendido.

## Princípio

Refatoração deve possuir objetivo claro.

Não refatorar apenas porque o código poderia ser diferente.

## Antes da mudança

Identificar:

- comportamento atual;
- testes existentes;
- dependências;
- consumidores;
- riscos;
- motivo da refatoração.

## Garantia de comportamento

Sempre que possível:

1. estabelecer comportamento esperado;
2. executar testes existentes;
3. realizar mudança;
4. executar novamente;
5. comparar resultados.

## Motivos legítimos

Refatorar para:

- reduzir duplicação;
- reduzir complexidade;
- melhorar coesão;
- reduzir acoplamento;
- facilitar testes;
- melhorar manutenção;
- preparar evolução conhecida;
- corrigir estrutura inadequada.

## Escopo

Evitar misturar:

- refatoração;
- nova funcionalidade;
- mudança arquitetural;
- correção não relacionada.

Quando for necessário combinar mudanças, deixar o impacto explícito.

## Grandes refatorações

Para mudanças maiores:

1. dividir em etapas;
2. manter comportamento verificável;
3. reduzir risco;
4. revisar cada etapa.

## Arquitetura

Se a refatoração revelar que a arquitetura precisa mudar:

- não mascarar a mudança como simples refatoração;
- registrar a questão arquitetural;
- avaliar impacto.

## Saída esperada

Produzir:

1. objetivo;
2. estado anterior;
3. mudanças;
4. comportamento preservado;
5. testes;
6. riscos;
7. débitos técnicos resolvidos;
8. débitos eventualmente criados.