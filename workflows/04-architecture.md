---
name: architecture
description: Define a arquitetura da solução a partir dos requisitos, experiência, restrições, riscos e atributos de qualidade.
version: 1
---

# Workflow: Architecture

## Objetivo

Definir uma arquitetura capaz de atender aos requisitos e atributos de qualidade sem antecipar tecnologias sem justificativa.

## Princípio

Arquitetura deve responder às necessidades do produto antes de escolher ferramentas específicas.

## Entrada

- requisitos;
- user stories;
- critérios de aceitação;
- UX;
- restrições;
- riscos;
- atributos de qualidade.

## Agente principal

`@solution-architect`

## Agentes participantes

- `@data-engineer`
- `@security-engineer`
- `@devops-engineer`
- `@business-analyst`
- `@reviewer`

## Skills

- `architecture-design`
- `domain-modeling`
- `data-modeling`
- `api-design`
- `integration-design`
- `security-design`
- `technical-decisions`
- `technical-debt-management`

## Etapas

### 1. Contexto arquitetural

Identificar:

- fronteiras;
- atores;
- sistemas externos;
- dependências;
- restrições.

### 2. Domínio

Definir:

- conceitos;
- responsabilidades;
- relações;
- regras relevantes.

### 3. Estrutura

Definir:

- componentes;
- responsabilidades;
- interfaces;
- dependências;
- fluxos.

### 4. Dados

Definir:

- entidades;
- persistência;
- consistência;
- ciclo de vida;
- integração de dados.

### 5. Integrações

Definir:

- contratos;
- comunicação;
- erros;
- autenticação;
- autorização;
- resiliência.

### 6. Segurança

Avaliar:

- ameaças;
- ativos;
- controles;
- exposição;
- proteção de dados.

### 7. Operação

Considerar:

- ambientes;
- implantação;
- observabilidade;
- recuperação;
- escalabilidade.

### 8. Decisões técnicas

Registrar decisões relevantes e suas justificativas.

### 9. Review

`@reviewer` avalia:

- coerência;
- riscos;
- complexidade;
- segurança;
- escalabilidade;
- operabilidade;
- aderência aos requisitos.

## Gate

Avançar quando:

- arquitetura estiver documentada;
- fronteiras estiverem claras;
- decisões relevantes estiverem justificadas;
- riscos críticos estiverem tratados;
- requisitos essenciais possuírem caminho arquitetural.

## Saída

Produzir:

- arquitetura;
- modelo de domínio;
- modelo de dados;
- contratos;
- integrações;
- decisões técnicas;
- riscos;
- requisitos operacionais;
- requisitos de segurança.

## Decisão

- `APROVADO PARA PLANEJAMENTO`
- `REQUER REVISÃO`
- `REQUER REDEFINIÇÃO DE ESCOPO`