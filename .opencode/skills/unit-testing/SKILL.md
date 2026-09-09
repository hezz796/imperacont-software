---
name: unit-testing
description: Orienta testes de unidades isoladas de comportamento, preservando feedback rápido e verificável durante o desenvolvimento.
---

# Unit Testing

## Objetivo

Verificar comportamentos de pequenas unidades do software de maneira rápida, determinística e isolada quando apropriado.

## Princípio

O teste deve validar comportamento relevante da unidade sem depender desnecessariamente de componentes externos.

## Processo

1. Identificar a unidade.
2. Identificar seu comportamento esperado.
3. Definir entradas.
4. Definir resultados esperados.
5. Cobrir condições relevantes.
6. Isolar dependências quando necessário.
7. Executar o teste.
8. Investigar falhas.
9. Manter os testes atualizados.

## Regras

- Testes devem ser claros e determinísticos.
- Evitar dependências externas desnecessárias.
- Evitar testes excessivamente acoplados à implementação interna.
- Cobrir casos positivos e negativos relevantes.
- Testes não devem esconder defeitos por meio de simulações inadequadas.
- A velocidade do feedback é uma característica importante.

## Saída

Produzir ou manter:

- testes unitários;
- dados de teste;
- resultados;
- evidências de falhas;
- cobertura relevante quando aplicável.