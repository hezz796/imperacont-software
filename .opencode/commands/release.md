---
description: Planeja, executa e acompanha uma release de software de maneira controlada e verificável.
agent: squad-lead
subtask: false
---

Execute o workflow de Delivery:

@workflows/07-delivery.md

Contexto da release:

$ARGUMENTS

Antes da implantação confirme:

- escopo;
- versão;
- artefatos;
- ambiente;
- qualidade;
- segurança;
- dependências;
- pré-condições;
- estratégia de recuperação;
- critérios de sucesso;
- observabilidade.

Durante a execução:

- mantenha rastreabilidade;
- valide cada etapa relevante;
- monitore sinais importantes;
- interrompa quando critérios de falha forem atingidos.

Após a implantação:

- execute validações;
- monitore o comportamento;
- registre resultados;
- determine estabilidade.

Se ocorrer falha relevante, priorize contenção e recuperação.

Ao final apresente:

- versão;
- mudanças;
- resultado;
- validações;
- métricas;
- incidentes;
- riscos;
- decisão sobre estabilidade.