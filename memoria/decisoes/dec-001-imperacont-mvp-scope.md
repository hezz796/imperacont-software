---
id: dec-001
type: decision
title: Escopo do MVP 1 do ImperaCont (núcleo + fora do escopo)
status: active
confidence: high
created: 2026-09-22
source: discovery DSC-001 (PEN-001) + Product Brief PB-001 (DEC-MVP-001/002/003) + benchmark PEN-008
project: imperacont-software
review_required: true
---

# Escopo do MVP 1 — ImperaCont

## Decisão

**Dentro do núcleo do MVP 1:**
1. Validação de lançamentos (sinalização de inconsistências: débito/crédito, duplicidade, data/período, campos obrigatórios).
2. Controle de prazos/obrigações por cliente (calendário, alertas, status).
3. Gestão de clientes/pendências (visão de quem está atrasado/incompleto).
4. Registro mínimo de documentos por cliente (apoio à pendência) — não sofisticado.

**Fora do MVP 1 (evoluir depois):**
- Escrituração contábil formal (razão, balancete, plano de contas completo).
- Notas fiscais (NF-e/NFS-e).
- SPED/ECD/ECF e obrigações dependentes de dados formais.
- Folha de pagamento/DP.
- Portal/área do cliente (acesso externo) — clientes atendidos via uso assistido no MVP.
- Financeiro básico (P/AP, conciliação OFX) — não priorizado como núcleo; não entra sem nova decisão.

## Contexto

- Escritório <50 clientes, Brasil, regimes federais.
- Restrições: on-premise, orçamento limitado, dev único com programação básica, sem prazo rígido.
- Sucesso declarado (EVD-014): menos erros/retrabalho + prazos cumpridos.

## Justificativa

- Alinhado às evidências (EVD-014: sucesso = erros/prazos) e ao benchmark (BE-01: "análise crítica de lançamentos" é padrão; BE-03: controle de prazos é padrão via módulo dedicado; BE-02: suites completas são caras/complexas).
- Escrituração formal, NF-e e SPED têm complexidade regulatória/técnica desproporcional para dev único (RSK-001/RSK-008).

## Consequências

- Aceitar que, no MVP, o escritório usará o sistema para gestão/validação, não como sistema contábil formal de escrituração.
- O módulo de obrigações/alertas precisa ser confiável (risco de alerta incorreto).
- Portal do cliente pode ser revisitado como evolução (HYP-004 adiada).
- Financeiro básico e entrada de documentos sofisticada permanecem fora sem nova decisão.

## Alternativas rejeitadas

- MVP com escrituração formal: complexidade/regulação altas para dev único.
- Comprar suite do mercado: assinatura recorrente, nuvem de terceiros, custo.
- MVP só com entrada de documentos/comunicação: menos alinhado ao "sucesso" declarado (erros/prazos).

## Estado

- **Em revisão** — candidata a confirmação após revisão independente do Product Brief.
- Origem: auto-relato do solicitante + evidência de benchmark. Nenhuma validação com usuários finais (auxiliares/clientes) ainda — ver PEN-PB-003.

## Rastreabilidade

- `projetos/imperacont/discovery/DSC-001-discovery.md` (PEN-001)
- `projetos/imperacont/discovery/PEN-008-benchmark.md`
- `projetos/imperacont/product/PB-001-product-brief.md` (DEC-MVP-001/002/003)