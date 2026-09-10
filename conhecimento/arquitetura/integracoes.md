---
title: Integrações
description: Fundamentos para projetar relações entre sistemas, serviços, organizações e fontes externas de informação.
type: guide
status: active
scope: squad
tags:
  - arquitetura
  - integracao
  - sistemas-externos
---

# Integrações

## Conceito

Integração representa a comunicação ou troca de informações entre partes que possuem fronteiras distintas.

## Dependências externas

Integrações introduzem dependências que podem estar fora do controle da equipe.

Devem ser considerados:

- disponibilidade;
- desempenho;
- limites;
- mudanças de contrato;
- falhas;
- segurança;
- custos.

## Sincronismo e assincronismo

Comunicações síncronas podem ser adequadas quando a resposta é necessária imediatamente.

Comunicações assíncronas podem ser adequadas quando:

- processamento pode ocorrer posteriormente;
- desacoplamento é importante;
- eventos precisam ser distribuídos;
- picos de carga precisam ser absorvidos.

Cada abordagem possui custos e riscos.

## Falhas

Uma integração deve considerar que sistemas externos podem:

- ficar indisponíveis;
- responder lentamente;
- retornar dados inválidos;
- mudar comportamento;
- exceder limites.

## Contratos

Integrações devem possuir contratos suficientemente claros para reduzir ambiguidades.

## Transformação

Quando dois sistemas possuem modelos diferentes, pode ser necessária uma transformação entre representações.

Essa transformação deve evitar contaminar desnecessariamente um domínio com conceitos externos.

## Observabilidade

Integrações relevantes devem permitir identificar:

- chamadas;
- resultados;
- falhas;
- latência;
- volume;
- correlação.

## Resiliência

Falhas externas não devem necessariamente derrubar todo o sistema.

O impacto deve ser analisado e, quando possível, isolado.

---

## Relações na Squad

### Skills relacionadas

- `integration-design`
- `api-design`
- `security-design`

### Agentes relacionados

- `solution-architect`

### Workflows relacionados

- `04-architecture`
- `05-development`