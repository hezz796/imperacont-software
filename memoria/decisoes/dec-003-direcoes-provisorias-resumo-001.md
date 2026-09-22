---
id: dec-003
type: decision
title: Direções provisórias de regras do MVP 1 respondidas pelo solicitante (RESUMO-001 A–F)
status: draft
confidence: medium
created: 2026-09-22
source: projeto imperacont-software — resposta do solicitante ao RESUMO-001 (questionário A–F), 2026-09-22
project: imperacont-software
---

# Direções provisórias de regras do MVP 1 (RESUMO-001 A–F)

## Decisões provisórias

O solicitante respondeu as seções A–F do `RESUMO-001` (v1.2) usando recomendações da squad. As direções foram aplicadas em REQ-001 v1.2 e US como **provisórias**:

- **Modelo de lançamento:** unitário (balanceamento N/A no MVP; se agrupado no futuro, bloquear).
- **Política de inconsistência:** duplicidade e período = **C (confirmar antes de gravar)** — avisa, pergunta; "manter mesmo assim" grava sinalizado p/ conferência; campos obrigatórios = bloqueio (RN-001).
- **Duplicidade:** cliente + data + valor.
- **Período inconsistente:** data do lançamento ≠ período selecionado.
- **Conferência:** contador revisa em lote (revisa → marca conferido → corrige/devolve).
- **Obrigações:** catálogo configurável + padrão por regime (ajuste por cliente); responsável típico = contador titular; alerta "a vencer" = 7 dias (configurável); entrega = data + autor (anexo opcional); obrigação sem vencimento → pendência manual.
- **Edição/exclusão (RF-012):** autor até conferir; contador depois; edição de conferido reabre conferência; exclusão de conferido = cancelamento com motivo, só contador.
- **Acesso:** 2 estações, uso simultâneo, PC-base + rede local, backup automático diário + validação semanal. Alimenta PEN-PB-006 (Arquitetura).
- **Perfis:** sócio somente leitura; matriz perfil→ação confirmada (RESUMO-001 E2 / REQ-001 UC-005).
- **Métricas/validação:** baseline a medir a partir de agora (1–2 semanas); re-cadastro de documentos no recebimento; 2–3 internos + 1 cliente na validação (PEN-PB-003).

## Natureza

- São **direções provisórias** do solicitante, com recomendação da squad — aplicadas para destravar parcialmente requisitos/Arquitetura.
- **Ainda aguardam validação externa** com o contador titular e auxiliares (PEN-PB-002/003) e **golden cases (Q6/Q12 do PEN-CONTADOR-001)** antes de Development.

## Rastreabilidade

- `projetos/imperacont/product/RESUMO-001-perguntas-urgentes.md` v1.2 (preenchido)
- `projetos/imperacont/product/REQ-001-requirements-mvp.md` v1.2 (RF-003…007/012, RN-002…006, UC-005, DEC-REQ-002/003)
- `projetos/imperacont/product/US-001-lancamento-validacao.md`, `US-003-controle-obrigacoes-prazos.md`

## Próximo passo

Quando o contador confirmar ou ajustar, e os golden cases (Q6/Q12) forem preenchidos: promover esta memória para `active`/`superseded` e destravar Development.