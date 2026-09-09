---
name: environment-management
description: Organiza ambientes de desenvolvimento, teste, homologação e produção de forma consistente, segura e rastreável.
---

# Environment Management

## Objetivo

Garantir que os ambientes necessários ao ciclo de desenvolvimento sejam identificados, configurados e controlados adequadamente.

## Princípio

Ambientes devem ser suficientemente consistentes para produzir resultados confiáveis, sem ignorar suas diferenças legítimas.

## Processo

1. Identificar ambientes necessários.
2. Definir finalidade de cada ambiente.
3. Identificar configurações específicas.
4. Controlar dependências.
5. Controlar acesso.
6. Validar configuração.
7. Monitorar alterações.
8. Documentar diferenças relevantes.

## Regras

- Segredos não devem ser armazenados de forma inadequada.
- Dados reais devem ser protegidos conforme seu nível de sensibilidade.
- Diferenças entre ambientes devem ser conhecidas.
- Configurações críticas devem ser rastreáveis.
- Alterações manuais devem ser controladas quando representarem risco.

## Ambientes possíveis

Conforme o produto:

- desenvolvimento;
- integração;
- teste;
- homologação;
- staging;
- produção;
- recuperação.

## Saída

Produzir:

- inventário de ambientes;
- finalidade;
- configuração;
- dependências;
- controles de acesso;
- diferenças conhecidas;
- procedimentos relevantes.