---
name: integration-design
description: Projeta integrações entre sistemas, componentes e serviços considerando contratos, confiabilidade, falhas, segurança, consistência e evolução.
---

# Integration Design

## Objetivo

Definir como diferentes sistemas ou componentes irão trocar informações e colaborar.

## Princípio

Integração é uma fronteira de responsabilidade.

Ela deve possuir contrato, comportamento esperado e tratamento explícito de falhas.

## Identificação

Para cada integração identificar:

- origem;
- destino;
- objetivo;
- dados;
- frequência;
- direção;
- protocolo ou mecanismo;
- dependências;
- criticidade.

## Padrões

Avaliar, conforme contexto:

- chamada síncrona;
- processamento assíncrono;
- eventos;
- filas;
- arquivos;
- sincronização periódica;
- outros mecanismos apropriados.

Não escolher um padrão por preferência tecnológica.

## Falhas

Considerar:

- timeout;
- indisponibilidade;
- duplicidade;
- perda;
- atraso;
- resposta inválida;
- mudança de contrato;
- inconsistência.

## Resiliência

Quando necessário, definir:

- retry;
- backoff;
- timeout;
- circuit breaker;
- fallback;
- dead-letter;
- compensação.

Esses mecanismos devem ser utilizados quando justificáveis, evitando complexidade desnecessária.

## Consistência

Determinar:

- consistência necessária;
- origem de verdade;
- sincronização;
- reconciliação;
- tratamento de divergências.

## Segurança

Considerar:

- autenticação;
- autorização;
- proteção de transporte;
- exposição mínima;
- segredos;
- auditoria.

## Evolução

Documentar:

- contratos;
- versões;
- compatibilidade;
- depreciação;
- responsabilidades.

## Saída esperada

Produzir:

1. mapa de integrações;
2. contratos;
3. fluxos;
4. dependências;
5. falhas;
6. resiliência;
7. consistência;
8. segurança;
9. evolução;
10. decisões.