---
name: security-testing
description: Verifica controles de segurança, exposição a ameaças, proteção de dados e resistência a comportamentos maliciosos dentro de escopo autorizado.
---

# Security Testing

## Objetivo

Identificar vulnerabilidades e validar controles de segurança por meio de testes autorizados.

## Princípio

Segurança deve ser verificada continuamente e baseada em ameaças e riscos reais do produto.

## Processo

1. Identificar ativos.
2. Identificar ameaças.
3. Identificar controles.
4. Definir escopo autorizado.
5. Definir cenários de teste.
6. Executar verificações.
7. Avaliar evidências.
8. Classificar riscos.
9. Recomendar correções.
10. Revalidar correções.

## Abrangência

Quando aplicável:

- autenticação;
- autorização;
- gerenciamento de sessão;
- validação de entrada;
- proteção de dados;
- exposição de informações;
- configuração;
- dependências;
- APIs;
- interfaces;
- logs;
- controles de acesso.

## Regras

- Testes devem ocorrer somente dentro de escopo autorizado.
- Não executar ações destrutivas desnecessárias.
- Vulnerabilidades devem ser documentadas com evidências suficientes.
- Correções devem ser reavaliadas.
- Segurança deve considerar impacto e probabilidade.

## Saída

Produzir:

- escopo;
- ameaças avaliadas;
- testes realizados;
- vulnerabilidades;
- severidade;
- evidências;
- recomendações;
- status de correção.