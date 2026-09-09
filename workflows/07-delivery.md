---
name: delivery
description: Planeja, executa e monitora a liberação do produto, incluindo ambientes, deployment, recuperação e observação pós-release.
version: 1
---

# Workflow: Delivery

## Objetivo

Disponibilizar uma versão aprovada aos usuários de maneira controlada, observável e recuperável.

## Princípio

Uma implantação bem-sucedida tecnicamente não significa necessariamente uma release bem-sucedida para o usuário.

## Entrada

- release aprovada;
- artefatos;
- resultados de qualidade;
- riscos;
- plano de release.

## Agente principal

`@devops-engineer`

## Agentes participantes

- `@software-engineer`
- `@security-engineer`
- `@test-engineer`
- `@reviewer`

## Skills

- `release-strategy`
- `release-planning`
- `versioning`
- `environment-management`
- `deployment`
- `rollback-and-recovery`
- `change-management`
- `observability`
- `release-monitoring`
- `incident-response`

## Etapas

### 1. Preparação

Confirmar:

- versão;
- artefatos;
- ambiente;
- configuração;
- dependências;
- pré-condições.

### 2. Release planning

Confirmar:

- sequência;
- responsáveis;
- validações;
- contingências.

### 3. Deployment

Executar a implantação controlada.

### 4. Validação

Verificar:

- disponibilidade;
- fluxos críticos;
- integrações;
- dados;
- observabilidade.

### 5. Monitoramento

Acompanhar indicadores definidos.

### 6. Recuperação

Caso critérios de falha sejam atingidos:

- interromper;
- conter;
- recuperar;
- validar;
- registrar.

### 7. Review

Avaliar:

- execução;
- incidentes;
- desvios;
- evidências;
- riscos.

## Gate

A release pode ser considerada concluída quando:

- implantação ocorreu;
- validações foram executadas;
- indicadores estão dentro dos limites definidos;
- não existem falhas bloqueadoras;
- recuperação está disponível quando necessária;
- resultado foi registrado.

## Saída

Produzir:

- release;
- versão;
- deployment;
- evidências;
- métricas;
- incidentes;
- decisão de estabilidade.

## Decisão

- `RELEASE ESTÁVEL`
- `MONITORAMENTO CONTINUADO`
- `INTERVENÇÃO NECESSÁRIA`
- `ROLLBACK / RECUPERAÇÃO`