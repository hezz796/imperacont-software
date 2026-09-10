---
title: Memória Persistente da Squad
description: Define a finalidade, estrutura, governança, consulta, atualização e evolução da memória persistente da software squad.
type: guide
status: active
scope: squad
---

# Memória Persistente da Squad

## 1. Finalidade

A memória persistente registra informações relevantes que precisam permanecer disponíveis para a squad além do contexto temporário de uma conversa ou execução.

A memória existe para preservar:

- decisões;
- aprendizados;
- contexto relevante;
- riscos persistentes;
- problemas recorrentes;
- eventos históricos relevantes.

A memória não tem como objetivo armazenar todo o histórico de execução.

Sua finalidade é preservar informações capazes de influenciar decisões futuras.

---

## 2. Princípio fundamental

> Memorizar não é armazenar tudo. É preservar aquilo que muda decisões futuras.

Uma informação deve ser registrada na memória quando sua ausência puder levar a:

- repetição de erro;
- repetição de trabalho;
- perda de contexto;
- decisão inconsistente;
- violação de decisão anterior;
- desconhecimento de risco relevante;
- perda de aprendizado importante.

---

## 3. Memória versus conhecimento

Memória e conhecimento são complementares, mas não são a mesma coisa.

### Memória

Representa experiência contextual da squad.

Responde principalmente:

> O que aconteceu?
>
> O que decidimos?
>
> O que aprendemos?
>
> Que riscos ou problemas já encontramos?

### Conhecimento

Representa conhecimento generalizado e reutilizável.

Responde principalmente:

> O que sabemos?
>
> Quais princípios utilizamos?
>
> Quais padrões conhecemos?
>
> Como devemos raciocinar sobre determinado problema?

### Regra

Memória preserva experiência.

Conhecimento preserva conhecimento generalizado.

---

## 4. Memória versus documentação do projeto

A documentação de projeto registra o estado e os artefatos necessários para trabalhar em determinado projeto.

A memória registra informações selecionadas que precisam continuar influenciando trabalhos futuros.

Portanto:

```text
DOCUMENTAÇÃO
=
o que o projeto precisa registrar

MEMÓRIA
=
o que a squad precisa lembrar
```

Nem todo documento de projeto precisa ser copiado para a memória.

---

## 5. Distinção entre memória, conhecimento, artefato e evidência

Para evitar contaminação entre camadas, a squad distingue formalmente:

### Conhecimento

Informação generalizável e reutilizável, mantida na Base de Conhecimento.

### Memória

Informação persistente da experiência da squad que pode alterar decisões futuras.

### Artefato

Registro produzido durante uma execução.

Exemplos: relatórios, evidências de teste, documentos de fase.

### Evidência

Informação que sustenta uma conclusão, decisão ou aprendizado.

### Regra

Uma informação pode transitar entre camadas, mas não deve ser tratada como pertencente a uma camada errada.

Memória não é conhecimento.

Artefato não é memória.

Evidência não é memória por si só; ela sustenta memórias.

---

## 6. Categorias

A memória é organizada nas seguintes categorias:

```text
memoria/
├── decisoes/
├── aprendizados/
├── contexto/
├── riscos/
├── problemas/
└── historico/
```

Cada categoria corresponde a um tipo de memória, identificado no campo `type` dos registros:

```text
decisoes/          →  decision
aprendizados/      →  learning
contexto/          →  context
riscos/            →  risk
problemas/         →  problem
historico/         →  historical-event
```

### decisoes/

Registra decisões relevantes que devem continuar conhecidas.

Exemplos:

- decisões de produto;
- decisões arquiteturais;
- decisões técnicas;
- decisões de processo;
- decisões operacionais.

### aprendizados/

Registra aprendizados derivados de experiência, evidência, resultados, incidentes, testes ou evolução do produto.

### contexto/

Registra informações persistentes necessárias para compreender o contexto da squad ou de iniciativas em andamento.

### riscos/

Registra riscos relevantes que continuam ativos ou que precisam ser lembrados em decisões futuras.

### problemas/

Registra problemas recorrentes ou estruturalmente relevantes.

Um defeito isolado normalmente não deve ser transformado em memória permanente.

### historico/

Registra eventos relevantes para reconstrução da evolução da squad ou de decisões importantes.

Não deve funcionar como log operacional detalhado.

---

## 7. O que deve ser memorizado

Uma informação deve ser candidata à memória quando apresentar pelo menos uma das características abaixo:

- possui impacto sobre decisões futuras;
- representa uma decisão relevante;
- evita repetição de erro;
- representa aprendizado importante;
- registra uma restrição persistente;
- registra um risco relevante;
- representa um problema recorrente;
- explica uma mudança significativa;
- registra uma condição que poderá exigir revisão futura.

---

## 8. O que não deve ser memorizado

Não registrar automaticamente:

- mensagens completas de conversas;
- prompts;
- respostas comuns;
- logs de execução;
- ações triviais;
- arquivos inteiros já documentados em outro local;
- informações temporárias sem impacto futuro;
- hipóteses descartadas sem valor histórico;
- detalhes que não influenciem decisões futuras.

A memória deve permanecer pequena o suficiente para ser útil.

---

## 9. Governança

A memória não deve ser alterada indiscriminadamente por qualquer agente.

Um agente pode identificar uma informação candidata à memória e propor seu registro.

A decisão de registrar, atualizar ou promover uma memória deve considerar:

- relevância;
- evidência;
- impacto;
- permanência;
- contexto;
- confiança;
- possibilidade de obsolescência.

O Squad Lead é responsável pela coordenação da memória da squad.

Revisões independentes podem ser realizadas pelo Reviewer quando a informação possuir impacto significativo.

---

## 10. Regra de escrita

O fluxo recomendado é:

```text
AGENTE
  ↓
identifica possível memória
  ↓
registra ou propõe a informação
  ↓
avalia relevância e evidência
  ↓
SQUAD LEAD
  ↓
aprova, rejeita ou solicita revisão
  ↓
MEMÓRIA PERSISTENTE
```

Informações críticas podem exigir revisão independente antes de serem consideradas consolidadas.

O que um agente identifica durante uma execução é tratado como **memória candidata**, não como memória persistente.

A autoridade final para persistir ou não persistir uma memória cabe ao Squad Lead, sob a governança da squad.

A existência de evidência não gera, por si só, autorização automática de gravação.

---

## 11. Ciclo da memória

Toda memória segue um ciclo:

```text
RESULTADO
    ↓
EVIDÊNCIA
    ↓
AVALIAÇÃO
    ↓
CANDIDATO À MEMÓRIA
    ↓
REVISÃO
    ↓
MEMÓRIA PERSISTENTE
```

Nem todo resultado gera memória.

Nem toda evidência gera memória.

Nem todo aprendizado precisa ser persistido.

O ciclo deixa explícito que a persistência só ocorre após avaliação e revisão.

---

## 12. Regra de leitura

A memória deve ser consultada de forma contextual.

Não é necessário carregar toda a memória em toda execução.

Antes de uma decisão ou trabalho relevante, o agente deve verificar se existem memórias relacionadas ao:

- projeto;
- domínio;
- problema;
- decisão;
- risco;
- componente;
- usuário;
- incidente;
- aprendizado;
- contexto da tarefa.

A consulta deve ser orientada pela relevância.

---

## 13. Confiança

Memórias devem indicar o nível de confiança apropriado.

Valores permitidos:

```text
low
medium
high
```

### low

Informação ainda pouco comprovada.

### medium

Informação sustentada por alguma evidência ou experiência recorrente.

### high

Informação formalmente validada, aprovada ou sustentada por evidência forte.

A confiança não representa certeza absoluta.

Ela representa a força da evidência disponível no momento do registro.

---

## 14. Status

Os registros podem possuir os seguintes estados:

```text
draft
active
superseded
deprecated
archived
```

### draft

Registro ainda não consolidado.

### active

Registro atualmente válido.

### superseded

Registro substituído por outro entendimento ou decisão.

### deprecated

Registro que não deve mais orientar novas decisões, mas permanece relevante.

### archived

Registro preservado principalmente para histórico.

---

## 15. Atualização da memória

A memória deve evoluir quando novas evidências alterarem seu significado.

Não apagar automaticamente uma memória histórica.

Quando uma decisão for substituída:

```text
memória antiga
    ↓
status: superseded
    ↓
nova decisão
    ↓
status: active
```

Sempre que possível, registrar a relação entre a memória anterior e a nova.

---

## 16. Memória não é autoridade absoluta

Uma memória não deve ser tratada como verdade permanente apenas porque está registrada.

Ao consultar uma memória, o agente deve considerar:

- status;
- data;
- contexto;
- confiança;
- evidências;
- decisões posteriores;
- possibilidade de obsolescência.

Uma memória antiga pode ter sido válida no passado e não ser válida atualmente.

Quando houver conflito entre uma memória e evidência atual:

```text
EVIDÊNCIA ATUAL
    ↓
AVALIAÇÃO
    ↓
REVISÃO DA MEMÓRIA
```

Não tratar memória antiga como verdade imutável.

---

## 17. Memória e conhecimento

Um aprendizado específico pode eventualmente ser promovido para a base de conhecimento.

Fluxo:

```text
EXPERIÊNCIA
    ↓
MEMÓRIA
    ↓
APRENDIZADO RECORRENTE
    ↓
GENERALIZAÇÃO
    ↓
CONHECIMENTO
```

A promoção deve ocorrer somente quando houver evidência suficiente para transformar uma experiência contextual em conhecimento reutilizável.

---

## 18. Memória e projetos

Projetos podem produzir memórias específicas.

O fluxo esperado é:

```text
PROJETO
   ↓
experiência
   ↓
decisão / risco / problema / aprendizado
   ↓
memória
   ↓
uso em decisões futuras
```

A memória não deve substituir os artefatos do projeto.

---

## 19. Rastreabilidade

Sempre que possível, um registro de memória deve indicar sua origem.

As fontes podem incluir:

- projeto;
- decisão;
- requisito;
- incidente;
- teste;
- release;
- análise;
- evidência;
- revisão;
- documento.

A memória deve permitir responder:

> De onde veio esta informação?

---

## 20. Memória e evidência

Toda memória relevante deve, quando possível, apontar para a evidência que a sustenta.

A evidência pode ser:

- artefato;
- resultado de teste;
- decisão registrada;
- ocorrência;
- análise;
- documentação;
- histórico;
- resultado observado;
- revisão independente.

Não inventar evidência.

Quando a evidência não estiver disponível ou não for verificável, isso deve ser explicitamente indicado na memória.

---

## 21. Memória e artefatos

Artefato não é memória.

Um relatório pode documentar uma execução completa sem representar algo que deva ser lembrado permanentemente.

Um artefato pode:

- servir como evidência;
- originar uma memória;
- permanecer apenas como registro histórico;
- não gerar memória alguma.

Não promover automaticamente artefatos para memória.

---

## 22. Output e artefatos

A pasta `output/` é o espaço para resultados e artefatos produzidos pela execução.

A presença de um arquivo em `output/` não significa que ele seja memória.

A presença de uma informação em um relatório não significa que ela deva ser persistida.

Quando um artefato contiver informação potencialmente relevante para o futuro:

```text
ARTEFATO
    ↓
EVIDÊNCIA
    ↓
AVALIAÇÃO
    ↓
CANDIDATO À MEMÓRIA
```

---

## 23. Critério de qualidade

Uma memória de qualidade deve ser:

- relevante;
- compreensível;
- rastreável;
- contextualizada;
- suficientemente objetiva;
- atualizável;
- identificável;
- recuperável;
- proporcional à importância da informação.

Evitar registros vagos como:

> "Tivemos problemas nesse projeto."

Preferir:

> "A integração X apresentou falhas recorrentes por timeout. A decisão adotada foi estabelecer timeout explícito e mecanismo de retry controlado."

---

## 24. Regra contra contaminação

Uma hipótese, sugestão ou inferência não deve ser registrada como fato consolidado.

Distinguir claramente:

```text
FATO
HIPÓTESE
DECISÃO
APRENDIZADO
RISCO
PROBLEMA
ARTEFATO
EVIDÊNCIA
OPINIÃO
```

Quando houver incerteza, ela deve ser explicitamente registrada.

---

## 25. Regra de revisão

Memórias relevantes devem ser revisadas quando:

- surgir nova evidência;
- uma decisão relacionada mudar;
- o contexto mudar;
- o risco mudar;
- houver contradição;
- a informação se tornar obsoleta;
- uma nova experiência questionar o aprendizado.

---

## 26. Governança de escopo

Nenhum agente deve ampliar espontaneamente o escopo de uma execução para modificar conhecimento, memória, output, agentes, skills, workflows ou templates quando essas áreas não estiverem autorizadas no escopo da atividade.

Se uma necessidade surgir fora do escopo:

1. identificar a necessidade;
2. registrar como recomendação;
3. solicitar autorização apropriada;
4. somente então executar a alteração.

A ampliação silenciosa de escopo compromete a rastreabilidade e a confiança na governança.

---

## 27. Ocorrências de desvio

Um desvio de escopo deve ser tratado como informação de governança.

Ele não deve automaticamente ser:

- apagado;
- transformado em conhecimento;
- transformado em memória;
- considerado falha técnica isolada.

Deve primeiro ser avaliado:

```text
DESVIO
    ↓
REGISTRO
    ↓
AVALIAÇÃO
    ↓
APRENDIZADO DE GOVERNANÇA, SE RELEVANTE
```

O desvio pode ser tratado, em etapa própria, como base para aprimoramento da governança, sem que isso signifique aprovação retrospectiva da ampliação de escopo.

---

## 28. Objetivo final

A memória deve permitir que a squad:

```text
não comece do zero
        ↓
recupere contexto relevante
        ↓
evite erros conhecidos
        ↓
preserve decisões
        ↓
aprenda com experiências
        ↓
melhore decisões futuras
```

O objetivo não é criar uma coleção crescente de arquivos.

O objetivo é construir uma squad capaz de aprender ao longo do tempo.

---

## 29. Regra de ouro

> Toda memória deve responder claramente:
>
> **"Por que vale a pena lembrar disso?"**