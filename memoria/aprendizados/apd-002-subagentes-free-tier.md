---
id: apd-002
type: learning
title: Subagentes especializados indisponíveis por limite do provedor (free tier OpenCode)
status: active
confidence: high
created: 2026-09-22
source: execução do workflow 02 (tentativas 2026-09-22)
project: imperacont-software
---

# Subagentes especializados indisponíveis (free tier)

## Aprendizado

Em 2026-09-22, tentativas de delegação a subagentes especializados falharam repetidamente com:

> "Error from provider (Console): OpenCode's free tier can only be used from within OpenCode"

- Falhas observadas até 2026-09-22: `product-strategist` (1×), `business-analyst` (2×), `ux-researcher` (1×) e `ux-designer` (1×).
- Funcionou neste mesmo dia: `reviewer` (5 execuções completas com sucesso — REQ/US, UX-001, PEN-CONTADOR, WIRE, RESUMO/VAL).
- Não é falha isolada de sintaxe/prompt: é limitação do provedor/modelo dos agentes especializados.

## Decisão de processo adotada

- Quando o subagente especializado falhar por indisponibilidade de provedor, o **Squad Lead pode executar a etapa com ressalva explícita**, registrando no artefato (header/nota) que a análise especializada foi tentada e indisponível.
- **Plano B obrigatório:** solicitar `reviewer` (que funciona) para revisão independente, e marcar pendência explícita de refinamento com o especialista humano/quando a ferramenta estiver disponível.
- Não repetir tentativa automática múltiplas vezes (duas tentativas foram suficientes para confirmação).

## Riscos conhecidos

- Viés de confirmação do Squad Lead ao executar etapa de especialista (mitigado por revisão independente).
- Artefatos produzidos pelo Squad Lead em lugar de especialista devem declarar essa origem e fragilidade (feito em REQ-001 §header).

## Origem

- Execução do workflow 02 no projeto imperacont-software, 2026-09-22.

## Rastreabilidade

- `projetos/imperacont/product/REQ-001-requirements-mvp.md` (§header)
- `projetos/imperacont/product/UX-001-ux-design.md`, `WIRE-001-wireframes-mvp.md`, `RESUMO-001-perguntas-urgentes.md`, `VAL-001-roteiro-validacao.md` (§headers — nota de governança)
- Execução: tentativas task `business-analyst`, `product-strategist`, `ux-researcher`, `ux-designer` (falha), `reviewer` (sucesso 5×)