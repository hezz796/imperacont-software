---
name: quality-gates
description: Define critérios objetivos de qualidade para permitir avanço entre etapas do ciclo de desenvolvimento.
---

# Quality Gates

## Objetivo

Estabelecer condições objetivas para determinar se um produto ou mudança pode avançar para a próxima etapa.

## Princípio

Quality gates devem reduzir risco e aumentar confiança, não criar burocracia sem valor.

## Processo

1. Identificar o objetivo da etapa.
2. Identificar riscos relevantes.
3. Definir evidências necessárias.
4. Definir critérios de aprovação.
5. Avaliar resultados.
6. Registrar pendências.
7. Decidir avanço, bloqueio ou avanço condicionado.
8. Revisar os critérios conforme o contexto.

## Exemplos de critérios

Podem incluir:

- requisitos críticos verificados;
- testes críticos aprovados;
- defeitos bloqueadores resolvidos;
- riscos conhecidos avaliados;
- controles de segurança verificados;
- documentação essencial disponível;
- critérios de aceitação atendidos;
- observabilidade adequada;
- plano de rollback disponível quando necessário.

## Regras

- Gates devem ser proporcionais ao risco.
- Critérios devem ser verificáveis.
- Não criar critérios arbitrários.
- Pendências devem possuir impacto conhecido.
- Exceções devem ser explícitas e justificadas.
- Um gate não substitui julgamento técnico.

## Decisões

Um gate pode resultar em:

- **Aprovado**
- **Aprovado com ressalvas**
- **Bloqueado**
- **Requer nova avaliação**

## Saída

Produzir:

- critérios;
- evidências;
- resultados;
- pendências;
- riscos;
- decisão;
- justificativa.