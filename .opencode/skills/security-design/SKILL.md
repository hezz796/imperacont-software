---
name: security-design
description: Incorpora segurança à arquitetura e ao design considerando ameaças, ativos, controles, identidades, dados e riscos.
---

# Security Design

## Objetivo

Projetar controles de segurança proporcionais aos riscos do produto.

## Princípio

Segurança deve ser considerada desde a definição da solução.

Não deve ser tratada exclusivamente como uma inspeção realizada no final.

## Ativos

Identificar:

- dados;
- identidades;
- credenciais;
- operações;
- serviços;
- infraestrutura;
- integrações;
- informações de negócio.

## Ameaças

Avaliar:

- acesso não autorizado;
- alteração indevida;
- exposição;
- fraude;
- abuso;
- indisponibilidade;
- comprometimento de dependências;
- exploração de entradas.

## Modelagem de ameaças

Para riscos relevantes:

1. identificar ativo;
2. identificar ameaça;
3. identificar vetor;
4. estimar impacto;
5. estimar probabilidade;
6. definir controle;
7. verificar risco residual.

## Identidade

Definir, quando necessário:

- autenticação;
- autorização;
- papéis;
- permissões;
- sessões;
- recuperação;
- segregação de responsabilidades.

## Privilégio mínimo

Conceder somente as permissões necessárias para cada operação.

## Dados

Considerar:

- minimização;
- classificação;
- armazenamento;
- transmissão;
- acesso;
- retenção;
- eliminação;
- auditoria.

## Entradas

Toda entrada externa deve ser considerada não confiável até ser adequadamente validada.

## Segredos

Não armazenar segredos diretamente em:

- código;
- documentação pública;
- logs;
- arquivos versionados.

## Dependências

Avaliar riscos de:

- bibliotecas;
- serviços;
- fornecedores;
- componentes;
- integrações.

## Saída esperada

Produzir:

1. ativos;
2. ameaças;
3. riscos;
4. controles;
5. identidade;
6. autorização;
7. proteção de dados;
8. segurança de integrações;
9. requisitos de auditoria;
10. riscos residuais;
11. recomendações.