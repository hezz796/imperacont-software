---
name: data-modeling
description: Define modelos de dados coerentes com o domínio, requisitos, integridade, segurança, desempenho e evolução da solução.
---

# Data Modeling

## Objetivo

Projetar a representação e o ciclo de vida dos dados necessários ao produto.

## Princípio

O modelo de dados deve derivar das necessidades do domínio e dos requisitos, e não determinar o domínio prematuramente.

## Entradas

Considerar:

- domínio;
- requisitos;
- regras de negócio;
- fluxos;
- integrações;
- consultas;
- relatórios;
- segurança;
- retenção;
- requisitos de desempenho.

## Elementos

Identificar:

- dados;
- entidades;
- atributos;
- relações;
- identificadores;
- cardinalidade;
- integridade;
- estados;
- histórico;
- metadados.

## Integridade

Definir, quando necessário:

- unicidade;
- obrigatoriedade;
- referências;
- invariantes;
- validações;
- consistência transacional.

## Ciclo de vida

Considerar:

- criação;
- atualização;
- consulta;
- arquivamento;
- retenção;
- eliminação;
- recuperação.

## Segurança

Avaliar:

- classificação;
- acesso;
- minimização;
- criptografia, quando aplicável;
- auditoria;
- retenção;
- exposição.

## Evolução

Planejar mudanças de modelo considerando:

- compatibilidade;
- migrações;
- dados existentes;
- rollback;
- versionamento;
- impacto em consumidores.

## Desempenho

Considerar somente quando houver necessidade:

- volume;
- frequência;
- padrão de acesso;
- consultas;
- concorrência;
- latência.

Não otimizar prematuramente.

## Tecnologia

A escolha do mecanismo de persistência deve ser consequência dos requisitos.

Não assumir banco relacional, documental, chave-valor ou outro modelo sem justificativa.

## Saída esperada

Produzir:

1. modelo conceitual;
2. modelo lógico;
3. dados;
4. relações;
5. regras de integridade;
6. ciclo de vida;
7. segurança;
8. requisitos de desempenho;
9. estratégia de evolução;
10. decisões de persistência.