---
name: api-design
description: Define interfaces de software consistentes, compreensíveis, seguras, versionáveis e adequadas às necessidades dos consumidores.
---

# API Design

## Objetivo

Projetar interfaces entre componentes, sistemas ou consumidores de maneira clara, estável e sustentável.

## Princípio

Uma API deve representar capacidades e contratos do domínio, não simplesmente expor a estrutura interna da implementação.

## Entradas

Considerar:

- casos de uso;
- requisitos;
- domínio;
- consumidores;
- integrações;
- segurança;
- dados;
- requisitos operacionais.

## Contrato

Definir:

- operações;
- entradas;
- saídas;
- erros;
- validações;
- estados;
- regras;
- limites;
- comportamento esperado.

## Consistência

Manter padrões para:

- nomenclatura;
- tipos;
- erros;
- paginação;
- filtros;
- ordenação;
- autenticação;
- versionamento.

## Erros

Os contratos devem permitir que consumidores compreendam:

- o que ocorreu;
- por que ocorreu;
- se a operação pode ser repetida;
- como corrigir quando aplicável.

## Idempotência

Quando operações puderem ser repetidas, avaliar necessidade de comportamento idempotente.

## Compatibilidade

Considerar:

- mudanças compatíveis;
- mudanças incompatíveis;
- versionamento;
- depreciação;
- migração de consumidores.

## Segurança

Considerar:

- autenticação;
- autorização;
- validação;
- limitação de uso;
- exposição de dados;
- auditoria.

## Tecnologia

Não assumir REST, GraphQL, RPC, eventos ou outro mecanismo sem avaliar o contexto.

## Saída esperada

Produzir:

1. consumidores;
2. capacidades expostas;
3. contratos;
4. entradas;
5. saídas;
6. erros;
7. segurança;
8. compatibilidade;
9. versionamento;
10. documentação necessária.