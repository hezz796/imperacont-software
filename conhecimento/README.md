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

- instruções operacionais que pertencem a uma skill;
- processos completos que pertencem a workflows;
- comandos de usuário;
- código de aplicação;
- dados específicos de clientes ou projetos;
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