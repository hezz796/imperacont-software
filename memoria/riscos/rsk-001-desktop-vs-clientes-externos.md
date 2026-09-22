---
id: rsk-001
type: risk
title: Tensão entre Desktop Windows, clientes externos e comunicação com clientes (imperacont)
status: active
confidence: medium
created: 2026-09-22
source: discovery DSC-001 (EVD-003 vs EVD-009), revisão independente
project: imperacont-software
---

# Tensão Desktop × clientes externos × comunicação

## Risco

O solicitante declarou **Desktop Windows** como acesso da 1ª versão, mas também declarou **clientes do escritório** como usuários e **comunicação com clientes** como dor a resolver.

Essa combinação é estruturalmente incoerente sem uma segunda via de acesso dos clientes (portal web mínimo, fluxo assistido pelo atendimento, etc.). Se ignorada, pode gerar reescrita ou retrabalho na Arquitetura.

## Estado

- **Parcialmente aberto (atualizado 2026-09-22):** a hipótese HYP-004 foi **parcialmente resolvida** — acesso **interno** passa a ser multi-estação (compartilhar com outro PC/notebook, `dec-002`). **Acesso externo de clientes permanece adiado** no MVP (uso assistido, HYP-004 adiada).
- Mitigação: confirmar detalhes do modelo de acesso (PEN-PB-006) **antes** de Arquitetura; registrar como decisão explícita que cliente externo fica fora do MVP.

## Origem

- Auto-relato do solicitante (fonte única), 2026-09-22.
- Destaque do reviewer na revisão independente do DSC-001.

## Revisões

- Nenhuma até o momento.