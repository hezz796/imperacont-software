---
name: rollback-and-recovery
description: Define estratégias para reverter ou recuperar mudanças quando uma implantação ou alteração produzir resultados inadequados.
---

# Rollback and Recovery

## Objetivo

Permitir recuperação segura diante de falhas introduzidas por mudanças ou implantações.

## Princípio

Recuperação deve ser planejada antes da mudança quando o impacto potencial justificar essa precaução.

## Processo

1. Identificar condições de falha.
2. Definir critérios para interrupção.
3. Identificar mecanismo de recuperação.
4. Avaliar impacto da reversão.
5. Executar recuperação controlada.
6. Validar o estado recuperado.
7. Investigar causa.
8. Registrar o incidente.
9. Planejar nova tentativa quando apropriado.

## Estratégias

Podem incluir:

- rollback da versão;
- restauração;
- feature flag;
- desativação controlada;
- correção emergencial;
- failover;
- recuperação de dados.

## Regras

- Rollback não deve ser considerado automaticamente seguro.
- Alterações de dados podem não ser reversíveis.
- Dependências externas devem ser consideradas.
- Critérios para acionamento devem ser claros.
- Recuperação deve ser validada.

## Saída

Produzir:

- condição de acionamento;
- estratégia;
- passos;
- impacto;
- validação;
- resultado;
- causa identificada;
- ações posteriores.