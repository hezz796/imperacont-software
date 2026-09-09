---
name: reliability-testing
description: Avalia a capacidade do sistema de manter comportamento correto, recuperar-se de falhas e operar de forma consistente.
---

# Reliability Testing

## Objetivo

Verificar o comportamento do sistema diante de operação prolongada, falhas e condições adversas.

## Princípio

Confiabilidade envolve não apenas evitar falhas, mas também detectar, conter e recuperar-se delas adequadamente.

## Processo

1. Identificar cenários críticos.
2. Identificar modos de falha.
3. Definir condições de teste.
4. Simular falhas controladas quando apropriado.
5. Observar comportamento.
6. Verificar recuperação.
7. Verificar consistência dos dados.
8. Avaliar impacto.
9. Registrar resultados.

## Cenários

Quando aplicável:

- indisponibilidade de dependências;
- perda de comunicação;
- reinicialização;
- falha parcial;
- sobrecarga;
- interrupções;
- repetição de operações;
- recuperação após erro.

## Regras

- Testes destrutivos devem ser controlados.
- Não provocar indisponibilidade fora do ambiente autorizado.
- Recuperação deve ser verificável.
- Dados não devem ser comprometidos deliberadamente fora de ambientes controlados.

## Saída

Produzir:

- cenário de falha;
- comportamento observado;
- recuperação;
- impacto;
- evidências;
- riscos remanescentes.