---
title: Base de Conhecimento da Squad
description: Define a finalidade, organização, governança e uso da base de conhecimento da software squad.
type: guide
status: active
scope: squad
---

# Base de Conhecimento da Squad

A pasta `conhecimento/` contém referências utilizadas pela squad de desenvolvimento de software para orientar decisões, análises, projetos, engenharia, qualidade, segurança, operação e evolução.

Ela representa o conhecimento de referência da squad e não substitui agentes, workflows, skills, commands ou templates.

## 1. Objetivo

A base de conhecimento deve:

- preservar conhecimento reutilizável;
- estabelecer princípios e critérios;
- registrar padrões adotados;
- documentar conceitos importantes;
- apoiar decisões técnicas e de produto;
- reduzir decisões inconsistentes;
- fornecer referências para agentes e workflows;
- facilitar a evolução contínua da squad.

## 2. O que pertence ao conhecimento

Devem ser armazenados aqui conteúdos como:

- princípios;
- conceitos;
- critérios;
- boas práticas;
- padrões;
- referências;
- modelos conceituais;
- diretrizes;
- convenções;
- decisões que possuam valor reutilizável;
- conhecimentos técnicos e de produto que possam orientar diferentes projetos.

## 3. O que não pertence ao conhecimento

Não devem ser colocados aqui:

- execução de tarefas específicas;
- instruções operacionais que pertencem a uma skill;
- instruções destinadas a agentes;
- processos completos que pertencem a workflows;
- comandos de usuário;
- código de aplicação;
- configurações de ambientes ou de infraestrutura;
- estado transitório de projetos;
- dados específicos de clientes ou projetos;
- decisões específicas de um projeto;
- incidentes específicos;
- aprendizados exclusivamente circunstanciais;
- artefatos temporários;
- logs de execução;
- resultados transitórios;
- credenciais ou segredos.

## 4. Conhecimento não é instrução operacional

Conhecimento explica ou estabelece uma referência.

Uma `skill` explica como executar uma competência.

Um `workflow` define uma sequência de trabalho.

Um `agent` define responsabilidade e comportamento.

Um `command` fornece uma interface de execução.

Portanto:

```text
CONHECIMENTO
    ↓
referência

SKILL
    ↓
competência operacional

WORKFLOW
    ↓
processo

AGENT
    ↓
responsabilidade

COMMAND
    ↓
interface de execução
```

## 5. Organização

A base está organizada por domínio:

- `principios/`
- `engenharia/`
- `produto/`
- `ux/`
- `arquitetura/`
- `qualidade/`
- `seguranca/`
- `devops/`
- `dados/`
- `processos/`
- `padroes/`
- `modelos/`

## 6. Requisitos para novos documentos

Todo documento de conhecimento deve:

1. possuir propósito claro;
2. possuir escopo definido;
3. evitar ambiguidades desnecessárias;
4. distinguir fato, recomendação, hipótese e opinião;
5. registrar fontes quando aplicável;
6. evitar dependência desnecessária de uma tecnologia;
7. ser reutilizável quando o conteúdo for apresentado como conhecimento da squad;
8. ser atualizado quando perder validade;
9. evitar duplicação de conteúdo existente;
10. permanecer coerente com os demais documentos da base.

## 7. Frontmatter

Os documentos de conhecimento utilizam um frontmatter próprio da squad.

Esse frontmatter é uma convenção de organização da base de conhecimento e não deve ser confundido com o frontmatter nativo dos agentes, commands ou skills do OpenCode.

Formato mínimo:

```yaml
---
title: Título do conhecimento
description: Descrição objetiva
type: guide
status: active
scope: squad
---
```

Quando necessário, podem ser acrescentados:

```yaml
source:
updated:
tags:
```

## 8. Status

Os documentos podem utilizar os seguintes estados:

- `draft` — conteúdo em elaboração;
- `active` — conteúdo atualmente válido;
- `deprecated` — conteúdo mantido por compatibilidade, mas não recomendado;
- `archived` — conteúdo histórico.

## 9. Fontes e evidências

Quando o conhecimento depender de uma fonte externa, normativa, técnica ou científica relevante, a fonte deve ser identificada.

Sempre que possível, deve-se distinguir:

```text
FATO
↓
EVIDÊNCIA
↓
INTERPRETAÇÃO
↓
RECOMENDAÇÃO
```

A squad não deve transformar uma opinião em regra sem justificativa.

## 10. Governança

Alterações relevantes na base de conhecimento devem ser revisadas quando puderem afetar:

- arquitetura;
- segurança;
- qualidade;
- processos;
- decisões de produto;
- padrões de desenvolvimento;
- operação;
- comportamento dos agentes.

Conhecimento desatualizado deve ser corrigido, marcado como `deprecated` ou arquivado.

## 11. Regra fundamental

A base de conhecimento deve ajudar a squad a tomar decisões melhores.

Ela não deve existir simplesmente para acumular documentos.

Todo conhecimento deve responder a pelo menos uma destas perguntas:

- Qual decisão ele ajuda a tomar?
- Qual problema ele ajuda a evitar?
- Qual competência ele ajuda a orientar?
- Qual padrão ele ajuda a preservar?
- Qual aprendizado ele ajuda a reutilizar?

## 12. Relações entre camadas

Conhecimento, skill, agent e workflow são camadas diferentes, com funções distintas.

### Skill ≠ conhecimento

Uma skill representa uma capacidade operacional.

Conhecimento representa a referência conceitual que sustenta essa capacidade.

Uma skill pode utilizar vários conhecimentos.

Um conhecimento pode sustentar várias skills.

Não existe obrigação de relação 1:1.

Não criar um arquivo de conhecimento apenas porque uma skill existe.

### Agent ≠ conhecimento

Um agent representa:

- responsabilidade;
- comportamento;
- autoridade;
- escopo de atuação.

Conhecimento representa referência conceitual.

Um agent pode utilizar vários conhecimentos.

Um conhecimento pode ser relevante para vários agents.

A presença de uma referência não significa que o agent seja obrigado a consultar o conhecimento em toda execução.

### Workflow ≠ conhecimento

Um workflow representa:

- sequência;
- processo;
- etapas;
- transições;
- gates.

Conhecimento representa fundamentos e referências.

Uma relação entre conhecimento e workflow significa suporte conceitual.

Não significa que o conhecimento contenha o procedimento operacional.

---

## 13. Governança das referências

A seção `## Relações na Squad` presente nos documentos de conhecimento é um mecanismo de rastreabilidade.

Uma referência deve existir somente quando houver relação semântica relevante.

Não utilizar referências para:

- completar estatísticas;
- preencher todos os campos;
- criar aparência de cobertura;
- satisfazer correspondência textual;
- relacionar automaticamente todos os agents;
- relacionar automaticamente todos os workflows.

É preferível uma referência ausente a uma referência artificial.

---

## 14. Matriz consolidada

A matriz consolidada no final deste README é:

- índice;
- mapa;
- instrumento de navegação;
- instrumento de auditoria.

Ela não é:

- autorização de execução;
- ordem de execução;
- workflow;
- lista obrigatória de delegação;
- contrato rígido entre camadas.

A matriz deve permanecer coerente com as referências individuais presentes nos documentos de conhecimento.

---

## 15. Contagem de referências

Rankings quantitativos de referências não são métricas oficiais da squad.

Uma contagem somente pode ser considerada indicador formal quando estiver claramente definido:

- o que constitui uma referência;
- como referências duplicadas são tratadas;
- como categorias diferentes são contabilizadas;
- como tabelas são contabilizadas;
- como referências em READMEs são tratadas;
- qual é a unidade de medida.

Até que essa metodologia exista, contagens de referências devem ser consideradas informação auxiliar, não métrica oficial.

A criação de uma metodologia de métricas é assunto de fase própria e não deve ser feita silenciosamente.

---

## Relações na Squad

Os conhecimentos desta base relacionam-se com skills, agentes e workflows da seguinte forma:

| Categoria | Skills relacionadas | Agentes relacionados | Workflows relacionados |
| --- | --- | --- | --- |
| `principios/` | `problem-framing`, `hypothesis-validation`, `technical-decisions`, `quality-gates`, `security-design`, `observability`, `learning-loop`, `continuous-improvement` | todos os agentes | todos os workflows |
| `engenharia/` | `implementation`, `refactoring`, `coding-standards`, `unit-testing`, `technical-debt-management`, `error-handling`, `dependency-management`, `version-control-and-change-management`, `api-design` | `software-engineer`, `solution-architect`, `data-engineer`, `test-engineer`, `security-engineer`, `devops-engineer` | `04-architecture`, `05-development`, `06-quality`, `07-delivery` |
| `produto/` | `product-discovery`, `product-definition`, `problem-framing`, `opportunity-analysis`, `hypothesis-validation`, `user-stories`, `requirements-engineering`, `product-metrics`, `product-analytics`, `backlog-management`, `evolution-prioritization`, `feedback-management`, `learning-loop` | `product-strategist`, `business-analyst`, `ux-researcher`, `squad-lead` | `01-discovery`, `02-product-definition`, `03-ux-design`, `08-evolution` |
| `ux/` | `ux-research`, `user-journeys`, `information-architecture`, `interaction-design`, `accessibility-design`, `design-system-thinking`, `prototyping`, `user-stories` | `ux-researcher`, `ux-designer`, `business-analyst`, `product-strategist` | `01-discovery`, `02-product-definition`, `03-ux-design` |
| `arquitetura/` | `architecture-design`, `domain-modeling`, `data-modeling`, `api-design`, `integration-design`, `security-design`, `technical-decisions`, `technical-debt-management` | `solution-architect`, `software-engineer`, `data-engineer`, `security-engineer`, `devops-engineer`, `reviewer` | `04-architecture`, `05-development`, `07-delivery`, `08-evolution` |
| `qualidade/` | `test-strategy`, `test-design`, `unit-testing`, `integration-testing`, `system-testing`, `acceptance-testing`, `regression-testing`, `performance-testing`, `reliability-testing`, `security-testing`, `quality-gates` | `test-engineer`, `security-engineer`, `reviewer`, `software-engineer`, `squad-lead` | `05-development`, `06-quality`, `07-delivery` |
| `seguranca/` | `security-design`, `security-testing`, `incident-response`, `dependency-management`, `configuration-management`, `logging-and-observability`, `technical-decisions` | `security-engineer`, `solution-architect`, `devops-engineer`, `software-engineer`, `data-engineer`, `reviewer` | todos os workflows |
| `devops/` | `environment-management`, `configuration-management`, `deployment`, `release-strategy`, `release-planning`, `rollback-and-recovery`, `observability`, `logging-and-observability`, `release-monitoring`, `incident-response`, `continuous-improvement` | `devops-engineer`, `security-engineer`, `software-engineer`, `solution-architect`, `squad-lead` | `05-development`, `06-quality`, `07-delivery`, `08-evolution` |
| `dados/` | `data-modeling`, `domain-modeling`, `architecture-design`, `integration-design`, `technical-decisions`, `quality-gates` | `data-engineer`, `solution-architect`, `software-engineer`, `security-engineer`, `devops-engineer` | `04-architecture`, `05-development`, `07-delivery`, `08-evolution` |
| `processos/` | `problem-framing`, `change-management`, `technical-decisions`, `quality-gates`, `root-cause-analysis`, `continuous-improvement`, `learning-loop`, `backlog-management`, `release-planning`, `version-control-and-change-management` | `squad-lead`, `reviewer`, `technical-writer` | todos os workflows |
| `padroes/` | `architecture-design`, `api-design`, `integration-design`, `implementation`, `technical-decisions`, `refactoring`, `deprecation-management`, `release-strategy`, `error-handling`, `reliability-testing`, `performance-testing`, `observability`, `logging-and-observability`, `technical-debt-management` | `solution-architect`, `software-engineer`, `devops-engineer`, `data-engineer`, `reviewer` | `04-architecture`, `05-development`, `07-delivery`, `08-evolution` |
| `modelos/` | `problem-framing`, `product-discovery`, `hypothesis-validation`, `ux-research`, `requirements-engineering`, `user-stories`, `technical-decisions`, `change-management`, `test-strategy`, `quality-gates`, `root-cause-analysis`, `learning-loop`, `feedback-management`, `post-release-analysis`, `evolution-prioritization` | todos os agentes | todos os workflows |