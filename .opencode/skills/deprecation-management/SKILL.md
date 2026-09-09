---
name: deprecation-management
description: Controla funcionalidades, interfaces, componentes e dependências que serão descontinuados, garantindo transição previsível e redução de impacto.
---

# Deprecation Management

## Objetivo

Planejar e executar descontinuação de elementos do produto sem gerar impactos inesperados.

## Princípio

Descontinuar algo é um processo de transição, não apenas sua remoção.

## Processo

1. Identificar o elemento.
2. Identificar consumidores.
3. Avaliar dependências.
4. Definir motivo.
5. Definir substituto quando necessário.
6. Comunicar a mudança.
7. Definir período de transição.
8. Monitorar utilização.
9. Remover quando apropriado.
10. Validar impacto após remoção.

## Aplicações

Pode envolver:

- funcionalidades;
- APIs;
- componentes;
- formatos;
- integrações;
- configurações;
- dependências;
- infraestrutura.

## Regras

- Não remover interfaces utilizadas sem avaliar impacto.
- Descontinuação deve possuir comunicação adequada quando houver consumidores.
- Períodos de transição devem ser proporcionais ao risco.
- Uso residual deve ser monitorado.
- Elementos críticos devem possuir estratégia de migração.

## Saída

Produzir:

- elemento descontinuado;
- motivo;
- consumidores;
- impacto;
- substituto;
- cronograma;
- comunicação;
- status de remoção.