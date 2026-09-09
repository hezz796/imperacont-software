---
name: error-handling
description: Define estratégias consistentes para prevenção, tratamento, propagação, comunicação e observação de erros de software.
---

# Error Handling

## Objetivo

Garantir que erros sejam tratados de maneira previsível, segura e útil.

## Princípio

Erro é parte do comportamento do sistema.

Não deve ser tratado como exceção exclusivamente técnica a ser escondida.

## Categorias

Distinguir, quando aplicável:

- erro de entrada;
- erro de validação;
- erro de autorização;
- erro de autenticação;
- erro de negócio;
- erro de dependência;
- erro de infraestrutura;
- erro inesperado.

## Tratamento

Para cada erro relevante definir:

- origem;
- significado;
- responsável pelo tratamento;
- resposta;
- possibilidade de recuperação;
- necessidade de registro.

## Propagação

Um erro deve ser propagado quando o componente atual não possuir contexto suficiente para resolvê-lo.

Evitar capturar erros apenas para descartá-los.

## Comunicação

Mensagens destinadas ao usuário devem:

- ser compreensíveis;
- não expor detalhes internos;
- indicar ação quando possível.

Mensagens técnicas devem conter informações suficientes para investigação sem expor dados indevidos.

## Recuperação

Quando possível considerar:

- retry;
- fallback;
- compensação;
- reprocessamento;
- rollback;
- correção manual.

Não aplicar retry indiscriminadamente.

## Logs

Registrar informações relevantes para diagnóstico:

- contexto;
- evento;
- identificador de correlação, quando disponível;
- erro;
- momento;
- componente.

Evitar registrar:

- senhas;
- tokens;
- segredos;
- dados desnecessários.

## Saída esperada

Produzir:

1. categorias;
2. regras;
3. comportamento;
4. recuperação;
5. mensagens;
6. logs;
7. métricas;
8. riscos;
9. cenários de falha.