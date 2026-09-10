---
name: delivery
description: Planeja, executa e monitora a liberação do produto, incluindo ambientes, deployment, recuperação e observação pós-release.
version: 1
---

# Workflow: Delivery

## Objetivo

Realizar a liberação do produto de maneira controlada, observável e recuperável.

---

## Entrada

Utilizar:

- resultado da qualidade;
- versão;
- mudanças;
- plano de release;
- ambiente;
- plano de deployment;
- plano de rollback;
- critérios de validação;
- riscos;
- métricas;
- dependências.

---

## Memória

Antes da release, consultar:

```text
memoria/decisoes/
memoria/riscos/
memoria/problemas/
memoria/aprendizados/
memoria/historico/
```

Priorizar:

- incidentes anteriores;
- problemas de deployment;
- riscos operacionais;
- decisões de release;
- aprendizados de operação;
- restrições de ambiente;
- eventos históricos relevantes.

---

## Etapas

### 1. Preflight

Verificar:

- versão;
- artefatos;
- dependências;
- ambiente;
- configuração;
- segurança;
- plano de recuperação.

### 2. Deployment

Executar conforme o plano aprovado.

### 3. Validação

Verificar:

- disponibilidade;
- funcionalidades críticas;
- integrações;
- métricas;
- erros;
- comportamento esperado.

### 4. Monitoramento

Observar o sistema após a liberação.

### 5. Recuperação

Quando necessário:

- interromper;
- rollback;
- restaurar;
- corrigir;
- validar novamente.

### 6. Estabilização

Confirmar estabilidade suficiente antes de considerar a release concluída.

---

## Memórias candidatas

Após a release, avaliar:

- decisão de release relevante;
- incidente significativo;
- risco operacional persistente;
- problema recorrente;
- aprendizado de deployment;
- aprendizado de recuperação;
- evento histórico importante.

Não registrar:

- logs operacionais comuns;
- métricas isoladas sem interpretação;
- eventos triviais;
- execução normal da release.

A memória deve registrar o significado relevante do evento, não simplesmente sua ocorrência técnica.

---

## Incidentes

Quando houver incidente relevante:

```text
INCIDENTE
   ↓
ANÁLISE
   ↓
IMPACTO
   ↓
CAUSA / HIPÓTESE
   ↓
AÇÃO
   ↓
APRENDIZADO
   ↓
CANDIDATA A MEMÓRIA
```

Não registrar uma causa como fato quando ela ainda for apenas hipótese.

---

## Gate

A release pode ser considerada concluída quando:

- deployment foi executado;
- validações foram realizadas;
- métricas relevantes estão aceitáveis;
- incidentes críticos estão resolvidos ou controlados;
- rollback permanece disponível quando necessário;
- riscos residuais estão conhecidos;
- estabilidade foi observada.

Resultado:

```text
RELEASE ESTÁVEL
RELEASE COM PENDÊNCIAS CONTROLADAS
ROLLBACK
BLOQUEADA
INCIDENTE EM TRATAMENTO
```

---

## Saída

Produzir:

- versão;
- mudanças;
- deployment;
- validações;
- métricas;
- incidentes;
- recuperação;
- riscos;
- estabilidade;
- aprendizados;
- candidatas a memória;
- resultado do gate.

---

## Próximo estado

Após estabilização:

```text
Delivery
    ↓
Evolution
```

Em caso de incidente:

```text
Delivery
    ↓
Incident Response
    ↓
Evolution
```

Quando uma correção for necessária antes da conclusão:

```text
Delivery
    ↓
Development
    ↓
Quality
    ↓
Delivery
```