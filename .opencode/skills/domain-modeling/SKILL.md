---
name: domain-modeling
description: Modela conceitos, entidades, comportamentos, regras, eventos e fronteiras do domínio para orientar produto, arquitetura e implementação.
---

# Domain Modeling

## Objetivo

Representar o domínio do problema de forma que negócio, produto, arquitetura e desenvolvimento compartilhem uma compreensão consistente.

## Princípio

O modelo deve representar o domínio, não simplesmente a estrutura técnica do banco de dados.

## Conceitos

Identificar:

- conceitos;
- entidades;
- objetos de valor;
- relações;
- estados;
- eventos;
- comandos;
- políticas;
- regras;
- invariantes;
- agregações, quando úteis.

## Linguagem

Construir vocabulário comum.

Para cada termo importante:

- nome;
- significado;
- contexto;
- sinônimos;
- ambiguidades.

Evitar que a mesma palavra represente conceitos diferentes sem explicação.

## Regras de negócio

Identificar:

- condições;
- restrições;
- cálculos;
- transições;
- invariantes;
- exceções.

As regras devem permanecer independentes de detalhes de interface ou infraestrutura quando possível.

## Estados

Para entidades com ciclo de vida:

- definir estados;
- eventos;
- transições válidas;
- transições inválidas;
- condições;
- efeitos.

## Fronteiras de domínio

Quando o domínio for complexo, identificar limites entre áreas que possuem:

- responsabilidades diferentes;
- vocabulários diferentes;
- regras diferentes;
- ciclos de vida diferentes.

## Consistência

Verificar coerência entre:

`Domínio → Requisitos → Dados → API → Código → Testes`

## Complexidade

Não criar modelos excessivamente sofisticados para domínios simples.

Utilizar apenas abstrações que ajudem a resolver problemas reais.

## Saída esperada

Produzir:

1. glossário;
2. conceitos;
3. entidades;
4. relações;
5. regras;
6. estados;
7. eventos;
8. comandos;
9. invariantes;
10. fronteiras;
11. ambiguidades;
12. decisões.