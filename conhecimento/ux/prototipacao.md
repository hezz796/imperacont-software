---
title: Prototipação
description: Fundamentos para utilizar protótipos como instrumento de exploração, comunicação, avaliação e validação de experiências antes da implementação.
type: guide
status: active
scope: squad
tags:
  - ux
  - prototipacao
  - prototipo
  - validacao
---

# Prototipação

## Conceito

Um protótipo é uma representação parcial, simplificada ou provisória de um produto, fluxo, interação ou experiência, criada para investigar uma questão específica antes da implementação completa.

Prototipação é a prática de construir essas representações de forma intencional, orientada por uma pergunta que precisa ser respondida.

Um protótipo existe para reduzir incerteza. Não existe para substituir o produto.

## Relação com hipótese e evidência

Um protótipo é um instrumento de investigação. Sua construção deve estar conectada a uma hipótese que precisa de evidência.

```text
HIPÓTESE
    ↓
PROTO TIPO
    ↓
OBSERVAÇÃO
    ↓
EVIDÊNCIA
    ↓
APRENDIZADO
```

O aprendizado obtido pode confirmar, contradizer ou reformular a hipótese original. Em qualquer caso, o resultado é útil.

## Finalidades

Protótipos podem ser utilizados para:

- explorar alternativas de solução;
- tornar uma ideia observável e avaliável;
- comunicar uma proposta a participantes;
- avaliar fluxos de navegação e tarefa;
- avaliar comportamentos de interação;
- identificar problemas de usabilidade antes da implementação;
- validar hipóteses de experiência;
- reduzir incerteza antes de investir em desenvolvimento;
- testar pressupostos sobre o comportamento do usuário;
- sustentar decisões de design com evidência em vez de opinião.

## Fidelidade

Fidelidade representa o grau de detalhe, realismo e acabamento de um protótipo em relação ao produto pretendido.

### Baixa fidelidade

Representações esquemáticas, rascunhos, wireframes simples ou arranjos conceptuais.

Servem para:

- explorar estrutura;
- questionar premissas;
- comunicar conceitos;
- testar fluxos básicos.

### Média fidelidade

Representações com estrutura, navegação e comportamento mais definidos, sem necessariamente possuir design visual final.

Servem para:

- avaliar interação;
- testar navegabilidade;
- identificar problemas de compreensão;
- validar sequência de etapas.

### Alta fidelidade

Representações com aparência visual próxima do produto final, incluindo estilos, tipografia, cores, animações e respostas contextuais.

Servem para:

- testar percepção visual e de marca;
- avaliar sensação de uso;
- apresentar propostas a stakeholders;
- validar decisões de interação refinadas.

### Escolha da fidelidade

A fidelidade deve ser escolhida conforme a pergunta que precisa ser respondida, e não conforme o nível de acabamento desejado.

Uma pergunta estrutural pode ser respondida com baixa fidelidade.

Uma pergunta sobre percepção ou sensação pode exigir alta fidelidade.

Aumentar a fidelidade sem aumentar a capacidade de resposta da pergunta é desperdício de esforço.

## Tipos de prototipação

Protótipos podem ser classificados conforme sua finalidade principal.

### Protótipo exploratório

Utilizado no início da investigação, quando o problema ainda não está completamente definido ou quando múltiplas alternativas precisam ser comparadas.

### Protótipo de fluxo

Focado em representar a sequência de etapas, navegação e transições entre telas ou estados.

### Protótipo de interação

Focado em representar comportamentos específicos: como o sistema responde a ações, quais estados são possíveis, como erros são tratados.

### Protótipo de validação

Construído para testar uma hipótese específica com usuários ou stakeholders, obtendo evidência sobre uma decisão importante.

### Protótipo de comunicação

Utilizado para alinhar compreensão entre participantes, tornando concreta uma proposta que seria difícil de descrever apenas por texto.

Essas categorias não são mutuamente exclusivas. Um único protótipo pode cumprir mais de uma finalidade.

## Protótipo e produto

Devem ser distinguidos:

- protótipo;
- solução;
- produto;
- implementação.

Um protótipo representa uma intenção de experiência. Não representa necessariamente:

- uma solução tecnicamente viável;
- uma implementação completa;
- um sistema compatível com restrições de produção;
- um comportamento idêntico ao do produto final.

A confusão entre protótipo e produto pode gerar expectativas incorretas, decisões baseadas em limitações artificiais ou pressão por implementar algo que ainda não foi suficientemente investigado.

## Validação

A relação entre protótipo e validação segue o ciclo:

```text
HIPÓTESE
    ↓
PROTO TIPO
    ↓
OBSERVAÇÃO
    ↓
EVIDÊNCIA
    ↓
APRENDIZADO
```

Um protótipo pode reduzir incerteza sobre determinados aspectos da experiência.

Entretanto, um protótipo pode não representar:

- comportamento real em produção;
- cenários extremos;
- limitações técnicas;
- dependências externas;
- volume de dados real;
- simultaneidade de uso;
- consequences de uso prolongado.

A validação obtida por protótipo deve ser interpretada com atenção ao que ela efetivamente demonstra e ao que permanece como hipótese.

## Escolha da fidelidade

A decisão sobre que fidelidade utilizar deve considerar:

- objetivo da prototipação;
- pergunta que precisa ser respondida;
- risco associado à decisão;
- estágio da descoberta e do produto;
- tipo de interação que precisa ser avaliada;
- necessidade de comunicação com participantes;
- custo de produção do protótipo;
- tempo disponível;
- capacidade de iteração rápida.

Quanto mais cedo no ciclo e mais estrutural a pergunta, menor tende a ser a fidelidade necessária.

Quanto mais refinada a decisão e mais dependente da percepção visual ou sensorial, maior tende a ser a fidelidade necessária.

## Limitações

Protótipos possuem limitações que devem ser compreendidas:

- podem induzir conclusões incorretas quando questionados de forma inadequada;
- podem ocultar limitações técnicas que só aparecem na implementação;
- podem representar somente parte da experiência, ignorando contextos reais;
- podem criar falsa sensação de validação quando testados com condições não representativas;
- podem não representar comportamento real em produção, incluindo latência, falhas, volume e concorrência;
- podem gerar expectativa de que o produto final será idêntico ao protótipo.

Conhecer essas limitações não invalida a prototipação. Torna-a mais eficaz.

## Princípios

- prototipe para reduzir incerteza, não para produzir artefatos;
- escolha a menor fidelidade capaz de responder à pergunta relevante;
- não confunda aparência com validação;
- valide a hipótese que mais impacta a decisão;
- aumente a fidelidade apenas quando a pergunta exigir;
- descarte ou altere protótipos quando as evidências contradizerem a hipótese;
- registre o que foi aprendido, mesmo quando o resultado for negativo;
- um protótipo descartado que produziu aprendizado não é um protótipo desperdiçado.

## Resultado esperado

A prototipação deve permitir que a squad tome decisões de experiência com maior clareza, menor custo de erro e evidência mais concreta do que seria possível apenas com descrições textuais ou discussões abstratas.

---

## Relações na Squad

### Skills relacionadas

- `prototyping`
- `interaction-design`
- `ux-research`
- `hypothesis-validation`

### Agentes relacionados

- `ux-designer`
- `ux-researcher`

### Workflows relacionados

- `01-discovery`
- `03-ux-design`
