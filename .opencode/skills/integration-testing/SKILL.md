---
name: integration-testing
description: Verifica a interação entre componentes, serviços, módulos, sistemas externos e mecanismos de persistência.
---

# Integration Testing

## Objetivo

Verificar se componentes integrados funcionam corretamente nas fronteiras entre eles.

## Princípio

Integrações devem ser verificadas onde contratos, transformação de dados, comunicação ou dependências podem introduzir riscos.

## Processo

1. Identificar as fronteiras de integração.
2. Identificar contratos.
3. Identificar dependências.
4. Definir cenários.
5. Preparar ambiente e dados.
6. Executar integrações.
7. Validar entradas e saídas.
8. Verificar erros e indisponibilidade.
9. Analisar falhas.
10. Registrar evidências.

## Pontos de atenção

- contratos;
- formatos de dados;
- autenticação;
- autorização;
- timeouts;
- indisponibilidade;
- duplicidade;
- idempotência;
- transações;
- consistência;
- compatibilidade.

## Regras

- Não assumir que unidades corretas garantem integração correta.
- Testar fronteiras de maior risco.
- Diferenciar falha de aplicação de falha de dependência.
- Evitar dependências instáveis quando não forem necessárias ao cenário.

## Saída

Produzir:

- cenários de integração;
- resultados;
- falhas;
- evidências;
- riscos identificados;
- pendências de correção.