---
title: Registro da priorização PEN-001 — núcleo do MVP ImperaCont
type: artefato
status: active
scope: project
project: imperacont-software
version: 1
created: 2026-09-22
---

# Registro da priorização (PEN-001)

## Identificação

- **ID:** PEN-001 (registro de sessão)
- **Data:** 2026-09-22
- **Participantes:** solicitante (dono do escritório) + Squad Lead (facilitação)
- **Insumos:** 6 dores do discovery (DSC-001), critério de sucesso declarado (EVD-014), benchmark (PEN-008), restrições de capacidade (EVD-016/017)

## Critérios utilizados

1. Alinhamento com o resultado declarado (menos erros/retrabalho + prazos cumpridos — EVD-014);
2. Evidência de mercado (o que é padrão/diferencial — PEN-008);
3. Proporcionalidade à capacidade de desenvolvimento (dev único, programação básica);
4. Risco regulatório/técnico (evitar frentes de alta complexidade normativa no MVP).

## Resultado por dor

| # | Dor | Resultado | Justificativa resumida |
|---|---|---|---|
| 1 | Erros / ausência de validação | **NÚCLEO MVP** | Alinha com EVD-014; padrão de mercado (BE-01) |
| 5 | Obrigações / prazos | **NÚCLEO MVP** | Alinha com EVD-014; padrão via módulo dedicado sem exigir SPED (BE-03) |
| 6 | Gestão dos clientes (pendências) | **NÚCLEO MVP** | Visibilidade operacional; baixa complexidade; alinha com operação mista atual |
| 3 | Retrabalho / manualidade | **Atendida indiretamente** | Reduzida por 1 e 6; não exige frente própria |
| 4 | Fechamento / confecção | **FORA do MVP 1** | Depende de escrituração formal/balancete (fora do escopo por complexidade) |
| 2 | Comunicação com clientes | **FORA do núcleo (parcial)** | Portal do cliente adiado; entrada de documentos na forma mínima (desvio justificado, ver abaixo) |

## Frentes operacionais — decisão

| Frente | Decisão |
|---|---|
| Validação de lançamentos | **Núcleo MVP** |
| Controle de prazos/obrigações | **Núcleo MVP** |
| Gestão de clientes/pendências | **Núcleo MVP** |
| Escrituração contábil formal | Fora do MVP 1 |
| Notas fiscais (NF-e/NFS-e) | Fora do MVP 1 |
| SPED/obrigações completas | Fora do MVP 1 |
| Folha de pagamento/DP | Fora do MVP 1 |
| Portal do cliente | Fora do MVP 1 (adiado) |
| Financeiro básico (P/AP, OFX) | Não priorizado como núcleo; fora do MVP 1 sem nova decisão |
| Entrada de documentos (forma mínima) | **Dentro do MVP 1** — desvio justificado da PEN-001 |

## Desvio registrado (requisito de revisão P1)

A entrada de documentos **não foi marcada** pelo solicitante como núcleo na sessão PEN-001. A forma **mínima** (anexo por cliente ligado a pendência) foi mantida **dentro** do MVP 1 por: (a) baixo custo técnico relativo; (b) apoio direto à dor 6 (pendências), que é núcleo; (c) alívio imediato da dor 2 sem construir portal. A versão sofisticada (fluxo/área do cliente) permanece fora. Este desvio é explícito e auditável.

## Limitações

- Fonte única (solicitante); auxiliares e contador **não participaram** (validação pendente — PEN-PB-003).
- Ranking por critérios qualitativos, não por esforço estimado.
- HYP-001 (dores com pesos diferentes) é **fechada por decisão**, não por evidência de campo — confirmar ou refazer com usuários reais antes de Development.

## Rastreabilidade

- `projetos/imperacont/discovery/DSC-001-discovery.md` (PEN-001)
- `projetos/imperacont/discovery/PEN-008-benchmark.md`
- `projetos/imperacont/product/PB-001-product-brief.md` (DEC-MVP-001/002/003)
- `memoria/decisoes/dec-001-imperacont-mvp-scope.md`