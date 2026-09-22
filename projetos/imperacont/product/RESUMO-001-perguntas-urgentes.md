---
title: Resumo executivo — perguntas urgentes ao contador (formato rápido)
description: Versão de 1 página do PEN-CONTADOR-001 para resposta rápida. Cada resposta destrava parte de Arquitetura ou Development; golden cases (Q6/Q12) já confirmados (seção G); validação externa e agendamento de UX (PEN-PB-003) permanecem pendentes.
type: dependencies
status: answered
scope: project
version: 1.3
project: imperacont-software
---

> Versão rápida de `PEN-CONTADOR-001-perguntas.md` (v1.1). Para detalhes/exemplos de golden cases, use o documento completo. Responda abaixo ou à parte; a squad aplica as respostas nas regras de negócio.

# Respostas urgentes — ImperaCont

**Data:** 2026-09-22 **Respondido por:** dono do escritório (com recomendações da squad; validação externa com contador/auxiliares ainda pendente — o que for derivado daqui é **decisão provisória**, não regra final)

## A. Modelo de lançamento (destrava RF-003/004 — Development)

**A1.** Modelo: **Unitário** (uma linha por movimento).

**A2.** Política por inconsistência:
- **A2a** Duplicidade suspeita: **C — Confirmar antes de gravar** (direção já em US-001/UX-001: avisa, pergunta; "manter mesmo assim" grava sinalizado p/ conferência).
- **A2b** Soma débito ≠ crédito: **não se aplica** (modelo unitário). Se um dia agrupado: B (bloquear).
- **A2c** Data fora do período: **C — Confirmar antes de gravar**.
- Outra regra: — (registrar quando conhecida).

**A3.** Duplicidade = **cliente + data + valor** (mesmo cliente, mesma data, mesmo valor).

**A4.** Período inconsistente = **data do lançamento ≠ período selecionado** (ex.: data 05/2026 lançada no período 06/2026).

**A5.** Conferência: **contador revisa lote** (revisa → marca conferido → corrige/devolve). Contador corrige após conferência (e autor até conferir — ver C1).

## B. Obrigações e prazos (destrava RF-006/007 — módulo prazos)

**B1.** **Catálogo configurável** de obrigações por regime/cliente, com lista inicial sugerida (DAS, DCTF Web, IRPJ, CSLL, PIS, COFINS) — registro de prazo/status, sem cálculo/envio.

**B2.** Alerta "a vencer": **7 dias** antes do vencimento (padrão configurável por obrigação).

**B3.** Estados: **em dia / a vencer / atrasado / entregue** + exceção: obrigação sem vencimento vira **pendência manual**.

**B4.** Registrar "entregue": **data + autor obrigatórios; anexo/comprovante opcional** no MVP.

**B5.** **Padrão por regime** (lista de obrigações do regime aplicada ao cadastrar o cliente, com ajuste por cliente se necessário). Responsável típico por entrega: **contador titular**.

## C. Edição/exclusão (destrava RF-012 — Development)

**C1.** **Autor até conferir; contador depois** (após conferido, apenas contador edita).

**C2.** Editar lançamento conferido **reabre a conferência** (volta a "pendente de conferência").

**C3.** **Cancelamento com motivo, só contador** (lançamento conferido não é excluído fisicamente; trilha preservada).

## D. Acesso e backup (destrava Arquitetura — PEN-PB-006)

**D1.** **2 estações** (PCs/notebooks).

**D1b.** **Sim — uso simultâneo** (auxiliar lança enquanto contador consulta) → exige banco de dados multiusuário.

**D2.** Dados em **PC-base (principal) + acesso via rede local** das outras estações. Liga/desliga: **contador titular**.

**D3.** **Backup automático diário** (dispositivo externo/pasta de rede) com **validação semanal pelo contador titular**.

## E. Perfis (PEN-UX-003/007)

**E1.** Sócio/gestor: **apenas leitura** (consulta).

**E2.** Matriz confirmada (X = pode):

| Ação | Auxiliar | Contador | Atendimento | Sócio |
|---|---|---|---|---|
| Lançar | X | X | X | |
| Conferir | | X | | |
| Cadastrar cliente | | X | | |
| Cadastrar usuário | | X | | |
| Ver pendências | X | X | X | X |
| Registrar documento | X | X | X | |
| Config. backup | | X | | |

## F. Métricas e validação

**F1.** Baseline: **medir a partir de agora** (sem números fiéis no mês atual).

**F2.** **Sim** — registrar manualmente por 1–2 semanas (erros na conferência, obrigações fora do prazo, saldo).

**F3.** **Re-cadastro no recebimento**: quem recebe (auxiliar/contador/atendimento) cadastra o documento na chegada; volume baixo; aceitável como entrada mínima pré-evolução.

**F4.** **2–3 internos (auxiliares/atendimento) + 1 cliente real** (uso assistido) na sessão de validação.

**F5.** **Sim — uso assistido**, cliente simples.

## G. Golden cases e stack (respostas complementares 2026-09-22)

**G1.** **Q6a — Duplicidade (RN-003):** confirmados 3 casos como padrão de teste — (1) mesmo cliente+data+valor lançado 2× no mesmo dia → confirmar antes de gravar; (2) mesmo cliente+data com valor diferente → **não** é duplicidade, grava normal; (3) mesmo cliente+valor em data diferente → **não** é duplicidade, grava normal.

**G2.** **Q6b — Período (RN-004):** confirmados 3 casos — (1) data 05/05/2026 em período 06/2026 → confirmar antes de gravar; (2) data 10/06/2026 em período 06/2026 → grava normal; (3) data 30/06/2026 em período 07/2026 → confirmar antes de gravar.

**G3.** **Q8 — Catálogo inicial de obrigações:** confirmada a lista sugerida (DAS mensal ~dia 20, DCTF Web mensal ~dia 25, IRPJ trimestral, CSLL trimestral, PIS e COFINS mensais ~dia 25) — registrado/controle de prazo, sem cálculo.

**G4.** **Q12 — Golden cases de obrigações/status (RN-006):** confirmados 4 casos — (1) hoje 10/06, vence 20/06 → **em dia**; (2) hoje 15/06, vence 20/06 → **a vencer** (alerta 7d); (3) hoje 21/06, venceu 20/06 sem entrega → **atrasado**; (4) hoje 21/06, venceu 20/06 e entregue 15/06 → **entregue** (não atrasado).

**G5.** **Stack (PEN-ARC-001):** confirmada **C#/.NET (ASP.NET Core com Razor Pages)** — fluência mais forte do dev único; **transporte: HTTP em LAN interna confiável** (cookie sem `Secure`, HttpOnly+SameSite, controles compensatórios). Decisões registradas no ARC-001 e memória.

> **Importante:** as regras RN-003/004/006 deixam de ser "direção provisória" para desenvolvimento (golden cases adotados como casos de teste padrão). A **validação externa** (contador colega/auxiliares — PEN-PB-003) e o **agendamento da sessão de UX** permanecem pendentes.

---

## O que NÃO é necessário responder agora
- Obrigações que dependam de escrituração formal/SPED/folha (fora do MVP 1).
- Importação de dados (não há no MVP).
- Portal do cliente (fora do MVP 1).

## Pós-resposta (o que acontece)
1. Squad aplica respostas em RN/RF (RN-002…004, RF-006/007/012, RNF-005).
2. Golden cases viram critérios de aceite/testes.
3. Arquitetura inicia (após D1–D3 e modelo de lançamento).
4. Sessão de validação com auxiliares (PEN-PB-003) usa WIRE-001 + roteiro VAL-001.

> **Importante:** este resumo cobre as respostas rápidas, mas **não substitui o PEN-CONTADOR-001 completo**. As perguntas **Q5 (definição de balanceamento, se modelo agrupado/misto), Q6 (golden cases de lançamentos) e Q12 (golden cases de obrigações/status)** permanecem obrigatórias e devem ser preenchidas no documento completo antes de considerar Development destravado (REQ-001 §20.2 — PEN-PB-002). **Atualização v1.3: Q6 e Q12 foram respondidos e registrados no PEN-CONTADOR-001 §10-A (seção G aqui); Q5 segue N/A (modelo unitário confirmado).**

## Histórico
| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Resumo executivo rápido das perguntas críticas (deriva de PEN-CONTADOR-001 v1.1) | Squad Lead |
| 1.1 | 2026-09-22 | Correções P-A1…P-A4 da revisão independente: nota explícita de que Q5/Q6/Q12 permanecem obrigatórias no documento completo (P-A1), separação de estações vs simultaneidade (P-A2), responsável por entrega em B5 (P-A3), instrução "deixe em branco" no modelo unitário (P-A4) | Squad Lead (após revisão reviewer) |
| 1.2 | 2026-09-22 | Preenchimento das respostas A–F pelo dono do escritório (com recomendações da squad). Decisões provisórias — validação externa com contador/auxiliares pendente; golden cases (Q6/Q12) e balanceamento (Q5) seguem obrigatórios no PEN-CONTADOR-001 antes de abrir Development | Squad Lead (aplicação das respostas) |
| 1.3 | 2026-09-22 | Seção G: golden cases Q6a/Q6b/Q12 confirmados (adotados como casos de teste padrão — detalhes no PEN-CONTADOR-001 §10-A), Q8 catálogo inicial confirmado, stack confirmada **C#/.NET (ASP.NET Core Razor Pages)** + transporte **HTTP em LAN interna**. Regras RN-003/004/006 deixam de ser provisórias para desenvolvimento; PEN-PB-003 (validação externa + agendamento UX) permanece pendente | Squad Lead (aplicação das respostas complementares) |