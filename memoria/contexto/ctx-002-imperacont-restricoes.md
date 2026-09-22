---
id: ctx-002
type: context
title: Restrições declaradas do imperacont-software (orçamento, ambiente, acesso)
status: active
confidence: medium
created: 2026-09-22
source: discovery DSC-001, entrevista estruturada com o solicitante
project: imperacont-software
---

# Restrições declaradas

## Informação

Restrições declaradas pelo solicitante para o software contábil ImperaCont:

- **Orçamento limitado.**
- **Ambiente:** servidor próprio (**on-premise**) — **sem bloqueio técnico real** esclarecido (INC-004, EVD-018): inicialmente declarado como "ambiente restrito", esclarecido como receio de custo/nuvem, não bloqueio de política de TI. A decisão de expor acesso web a clientes (PEN-003) será avaliada na Arquitetura por risco de exposição pública.
- **Acesso na 1ª versão:** Desktop Windows (em avaliação frente à necessidade de acesso dos clientes — PEN-003/HYP-004). **Atualização 2026-09-22 (decisão do solicitante):** o sistema **deve ser compartilhado com outro PC/notebook do escritório** (acesso multi-estação interna) — ver `memoria/decisoes/dec-002`. Acesso externo de clientes permanece fora do MVP (uso assistido).
- **Capacidade de desenvolvimento:** desenvolvedor único — o próprio solicitante — com **programação básica**, tempo reservado e **sem prazo rígido** (EVD-016, EVD-017). Restrição forte de complexidade para a 1ª versão.

## Tensão conhecida

Desktop Windows (uso interno) **conflita** com a necessidade declarada de clientes do escritório acessarem/comunicarem (HYP-004, RSK-002).

**Situação em 2026-09-22:** a tensão foi **parcialmente resolvida** — o acesso **interno** passa a ser multi-estação (compartilhado em outro PC/notebook, `dec-002`). Permanece em aberto o acesso **externo** de clientes (adiado para pós-MVP; uso assistido no MVP). Confirmar detalhes em PEN-PB-006 antes de Arquitetura.

## Origem

- Auto-relato do solicitante (fonte única), 2026-09-22.

## Uso em decisões futuras

- Condiciona a escolha de stack e arquitetura (tendenciando para solução simples, on-premise, baixo custo operacional — HYP-005, ainda não confirmada).
- Incerteza sobre "ambiente restrito" deve ser resolvida antes de Arquitetura.

## Revisões

- Nenhuma até o momento.