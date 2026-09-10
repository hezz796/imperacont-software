# Software Squad

Software squad agnóstica de tecnologia para descoberta, definição, design, arquitetura, desenvolvimento, qualidade, entrega e evolução de produtos digitais.

## Objetivo

Criar uma estrutura reutilizável para conduzir produtos de software de forma organizada, incremental, verificável e orientada por evidências.

A squad não parte da tecnologia.

Parte do problema.

## Ciclo de vida

```text
1. Discovery
2. Product Definition
3. UX / Design
4. Architecture
5. Development
6. Quality
7. Delivery
8. Evolution
```

O ciclo é contínuo:

```text
IDEIA
→ DISCOVERY
→ PRODUTO
→ UX
→ ARQUITETURA
→ DESENVOLVIMENTO
→ QUALIDADE
→ DELIVERY
→ EVOLUÇÃO
→ DISCOVERY
```

## Estrutura

```text
software-squad/
│
├── AGENTS.md
├── README.md
├── opencode.json
│
├── .opencode/
│   ├── agent/
│   ├── command/
│   └── skill/
│
├── workflows/
│
├── conhecimento/
│   ├── principios/
│   ├── engenharia/
│   ├── produto/
│   ├── ux/
│   ├── arquitetura/
│   ├── qualidade/
│   ├── seguranca/
│   ├── devops/
│   ├── dados/
│   ├── processos/
│   ├── padroes/
│   └── modelos/
│
├── projetos/
│
├── templates/
│
└── output/
```

## Camadas

### Agents

Representam responsabilidades especializadas.

```text
squad-lead
product-strategist
business-analyst
ux-researcher
ux-designer
solution-architect
software-engineer
test-engineer
security-engineer
devops-engineer
data-engineer
technical-writer
reviewer
```

### Commands

São os pontos de entrada para utilização da squad.

```text
brainstorm
discover
define-product
design
architect
plan
develop
test
review
release
evolve
```

### Skills

Representam competências especializadas utilizadas pelos agents.

### Workflows

Representam os principais fluxos do ciclo de desenvolvimento.

```text
01-discovery
02-product-definition
03-ux-design
04-architecture
05-development
06-quality
07-delivery
08-evolution
```

### Conhecimento

Representa a base conceitual reutilizável da squad.

### Templates

Fornecem estruturas para artefatos recorrentes.

### Projetos

Contêm o trabalho específico de cada produto.

### Output

Destina-se a resultados gerados pela squad que não pertençam diretamente à estrutura de um projeto.

## Fluxo conceitual

```text
USUÁRIO
   ↓
COMMAND
   ↓
SQUAD LEAD
   ↓
WORKFLOW
   ↓
AGENTS
   ↓
SKILLS
   ↓
CONHECIMENTO
   ↓
ARTEFATOS
   ↓
PRODUTO
```

## Tecnologia

A squad não impõe:

- linguagem;
- framework;
- banco de dados;
- provedor de nuvem;
- sistema operacional;
- ferramenta de CI/CD;
- arquitetura específica.

Essas decisões devem surgir das necessidades do produto, dos requisitos, dos riscos e das restrições.

## Princípios

Os principais princípios são:

- problema antes da solução;
- evidência antes da suposição;
- tecnologia como meio;
- simplicidade antes da complexidade;
- entrega incremental;
- decisão baseada em risco;
- qualidade por design;
- segurança por design;
- observabilidade por design;
- aprendizado contínuo.

## Uso

O usuário pode iniciar um trabalho por meio dos commands disponíveis.

Exemplos conceituais:

```text
/brainstorm <ideia ou oportunidade>

/discover <problema ou contexto>

/define-product <produto ou discovery>

/design <produto ou fluxo>

/architect <solução>

/plan <escopo>

/develop <mudança>

/test <escopo>

/review <artefato ou mudança>

/release <release>

/evolve <resultado, feedback ou aprendizado>
```

Os comandos devem ser utilizados conforme o estágio e a necessidade do trabalho.

## Filosofia

A squad deve evitar:

- implementar antes de compreender;
- adicionar complexidade sem necessidade;
- escolher tecnologia prematuramente;
- esconder incertezas;
- ignorar riscos;
- pular validações importantes;
- tratar feedback como requisito automático;
- confundir entrega técnica com resultado de produto.

O objetivo não é apenas produzir software.

É produzir **resultado de forma sustentável, verificável e evolutiva**.