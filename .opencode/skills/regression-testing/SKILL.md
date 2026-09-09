---
name: regression-testing
description: Verifica se alterações introduziram defeitos em comportamentos anteriormente funcionais.
---

# Regression Testing

## Objetivo

Detectar impactos indesejados causados por mudanças no produto.

## Princípio

Toda mudança deve ser avaliada de acordo com seu potencial de impacto, e não necessariamente por meio da execução indiscriminada de todos os testes existentes.

## Processo

1. Identificar a mudança.
2. Identificar áreas afetadas.
3. Avaliar dependências.
4. Identificar testes relevantes.
5. Executar a regressão apropriada.
6. Analisar falhas.
7. Atualizar a suíte quando necessário.
8. Registrar evidências.

## Estratégias

Podem incluir:

- regressão completa;
- regressão seletiva;
- regressão baseada em risco;
- testes automatizados;
- testes exploratórios;
- testes de contratos;
- testes de fluxos críticos.

## Regras

- A suíte deve evoluir com o produto.
- Testes obsoletos devem ser revisados.
- Mudanças de alto impacto exigem maior abrangência.
- Regressão não deve ser utilizada como substituto de testes bem projetados.

## Saída

Produzir:

- escopo da regressão;
- testes executados;
- resultados;
- falhas;
- impacto identificado;
- decisão sobre liberação.