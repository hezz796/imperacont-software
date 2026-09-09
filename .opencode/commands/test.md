---
description: Executa a estratégia de qualidade e testes adequada ao contexto informado.
agent: test-engineer
subtask: false
---

Execute o workflow de Quality:

@workflows/06-quality.md

Contexto:

$ARGUMENTS

Determine os níveis de teste apropriados com base em:

- risco;
- escopo;
- requisitos;
- alterações;
- critérios de aceitação;
- impacto.

Quando necessário, envolva:

- software-engineer;
- security-engineer;
- reviewer.

Não execute testes indiscriminadamente apenas para aumentar cobertura.

Priorize evidências relevantes.

Ao final apresente:

1. testes planejados;
2. testes executados;
3. resultados;
4. falhas;
5. severidade;
6. evidências;
7. riscos remanescentes;
8. decisão do quality gate.