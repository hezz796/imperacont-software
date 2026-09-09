---
name: coding-standards
description: Define e aplica princípios de qualidade, consistência, legibilidade e manutenção do código sem depender de uma linguagem específica.
---

# Coding Standards

## Objetivo

Estabelecer critérios gerais para produção de código consistente, compreensível e sustentável.

## Princípio

Padrões devem facilitar manutenção e colaboração.

Não aplicar regras mecânicas que aumentem complexidade sem benefício.

## Legibilidade

Priorizar:

- nomes claros;
- funções compreensíveis;
- estruturas simples;
- responsabilidades bem delimitadas;
- fluxo fácil de acompanhar.

## Responsabilidade

Cada componente deve possuir responsabilidade coerente.

Evitar componentes que:

- façam coisas não relacionadas;
- concentrem lógica excessiva;
- dependam de muitos detalhes externos.

## Duplicação

Eliminar duplicação quando:

- o comportamento realmente representa o mesmo conceito;
- a abstração for estável;
- a reutilização reduzir complexidade.

Não criar abstrações apenas para remover algumas linhas semelhantes.

## Complexidade

Questionar:

- condicionais excessivamente complexas;
- aninhamento profundo;
- abstrações desnecessárias;
- dependências circulares;
- estado global inadequado.

## Nomenclatura

Manter consistência com:

- domínio;
- requisitos;
- APIs;
- arquitetura;
- convenções do projeto.

## Tratamento de erros

Erros devem ser:

- tratados conscientemente;
- preservados quando precisam ser propagados;
- registrados quando necessário;
- apresentados adequadamente ao consumidor.

Evitar ignorar erros silenciosamente.

## Comentários

Comentários devem explicar:

- motivo;
- restrição;
- decisão;
- comportamento não óbvio.

Não utilizar comentários para repetir literalmente o código.

## Dependências

Evitar dependências desnecessárias.

Antes de introduzir uma biblioteca ou componente externo, considerar:

- necessidade;
- maturidade;
- segurança;
- manutenção;
- licença;
- custo;
- alternativas.

## Saída esperada

Produzir código que:

1. seja compreensível;
2. siga padrões do projeto;
3. minimize complexidade;
4. mantenha responsabilidades claras;
5. seja testável;
6. seja sustentável.