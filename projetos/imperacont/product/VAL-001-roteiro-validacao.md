---
title: Roteiro de validação de UX — sessão com auxiliares e 1 cliente
description: Roteiro estruturado da sessão de validação de wireframes (PEN-PB-003) usando WIRE-001 v1.1. Objetivo: validar fluxos e navegação com usuários reais antes de fechar telas (condição do gate de UX).
type: test-guide
status: reviewed
scope: project
version: 1.1
project: imperacont-software
---

> **Nota de governança (Squad Lead):** roteiro produzido em 2026-09-22 pelo Squad Lead (ux-researcher/ux-designer indisponíveis — apd-002). Baseado em UX-001 v1.1 (hipóteses HYP-UX-001…004), WIRE-001 v1.1 e PEN-CONTADOR-001 (Q25–Q27). **Material para conduzir a validação com usuários reais — não substitui a presença do usuário.**

# Roteiro de validação — VAL-001 (PEN-PB-003)

## 1. Objetivos da sessão

1. Validar **navegação centrada em cliente** (HYP-UX-001).
2. Validar **fluxo de lançamento** com validação na confirmação (HYP-UX-002) e obter **sinal preliminar** de aceitação da política de sinalização (HYP-UX-003 — ver nota abaixo).
3. Validar **visão de pendências por cliente** (HYP-UX-004).
4. Descobrir **problemas não previstos** de fluxo/terminologia.
5. Coletar insumos para PEN-UX-002 (linguagem/mensagens) e PEN-UX-006 (aceitação do re-cadastro de documentos).

> **Nota — evidência de HYP-UX-003 (P-B1):** conforme UX-001 §13, a validação definitiva de HYP-UX-003 (retrabalho e segurança da política de sinalização) é **observar uso real pós-MVP + conferência do contador**. Sessão de wireframe só coleta **sinal preliminar de aceitação**; não pode ser declarada "apoiada" aqui. Aplicar o mesmo cuidado a HYP-UX-002 (em menor grau): retrabalho e confiança só se observam em uso real — a sessão valida compreensão do fluxo, não comportamento futuro.

**Não é objetivo:** fechar telas definitivas (isso ocorre só após esta e outras sessões); testar visual/estética (wireframes são ASCII); validar regras contábeis (isso é PEN-PB-002).

## 2. Participantes

| Perfil | Quantidade recomendada | Observação |
|---|---|---|
| Auxiliar/estagiário (usuário frequente) | 2–3 | Principal público; lança diariamente |
| Contador titular (solicitante) | 1 | Observador + feedback no final (evita dominar) |
| Atendimento/administrativo | 1–2 (se existir) | Valida visão de pendências/documentos |
| Cliente real (uso assistido) | 1 (opcional) | Fluxo assistido pós-MVP — perfil simples |

**Condições:** sessão individual por participante (evita contaminação); duração 30–60 min; gravação (se consentida) ou anotações estruturadas; ambiente tranquilo. **Modo de resposta:** o participante fala em voz alta ("pensar em voz alta") e aponta/indica na folha; o facilitador anota. Não há interação em tela nesta fase (wireframe em papel/tela única, estático).

> **Material — versão limpa (P-B3):** usar **exclusivamente** o `WIRE-001c-wireframes-sessao.md` (v1.0-clean) para impressão/visualização, em que os códigos internos (RN/UC/CA), anotações de regras e blocos "Para o facilitador" foram removidos. **Não** usar o WIRE-001 v1.1 como material de sessão.

## 3. Preparação

- Material: `WIRE-001c-wireframes-sessao.md` (versão limpa) impresso ou em tela (1 cópia por participante), caneta, bloco de anotações.
- Não mostrar anotações de regras (RN/UC/CA) — usar versão "limpa" (remover códigos dos frames).
- Preparar cenários realistas (usar nomes fictícios ou cliente real consentido).
- Consentimento: explicar que é teste de ideia, não avaliação da pessoa.

## 4. Estrutura da sessão

### Fase 0 — Abertura (5 min)
- Explicar o objetivo: "estamos criando uma ferramenta para o escritório; queremos saber se ela faria sentido para você".
- Deixar claro: não há resposta errada; críticas ajudam.
- Pedir permissão para anotar/gravar.

### Fase 1 — Contexto e rotina (10 min)
Perguntas:
1. Como você lança movimentações hoje? (papel, planilha, WhatsApp?)
2. O que mais te atrapalha ou gera retrabalho?
3. Como você sabe se uma obrigação/pendência de cliente está atrasada?
4. Quanto tempo por dia você gasta nesses controles?

**Critério de sucesso:** conseguir descrever a rotina atual (elementos de erro/retrabalho mencionados — alinhado a EVD-014).

### Fase 2 — Navegação (WF-002/WF-008) (10 min)
- Mostrar WF-002 (menu) e WF-008 (detalhe do cliente).
- Tarefa: "Você precisa saber se o cliente ABC tem pendência. Onde você olharia?"
- Perguntas:
  1. Esse menu faz sentido? O que está faltando/sobrando?
  2. Começando pelo cliente, você acha o que precisa?
  3. **Preferência (padrão):** "Em comparação com o que você usa hoje, isso te ajudaria a achar o que precisa mais rápido? Mais fácil ou mais difícil?"
  4. **Consulta sócio (P-B4 / PEN-UX-003):** "Se o sócio do escritório quisesse consultar os prazos de um cliente sem mexer em nada, o que ele precisaria ver?" — registrar resposta como insumo para PEN-UX-003 (não fecha nesta sessão).

**Critério de sucesso:** o participante encontra a área de pendências sem ajuda (HYP-UX-001 apoiada).

### Fase 3 — Lançamento (WF-003, WF-004 opcional) (15 min) — fluxo mais crítico
- Tarefa: "Cadastre um lançamento de R$ 500,00 para o cliente ABC."
- Após concluir, mostrar estados de erro:
  - **Obrigatórios ausentes** (tentar salvar sem cliente): a mensagem é clara?
  - **Duplicidade** (lançar mesmo valor 2x): o que você faria? "Corrigir" ou "Manter mesmo assim" faz sentido?
  - **Período inconsistente** (data fora do período): entendeu o que aconteceu?
- Perguntas:
  1. Esse fluxo é mais fácil ou mais difícil que o atual?
  2. Você confiaria no sistema ao lançar? O que falta para confiar (HYP-UX-002)?
  3. **Preferência (padrão):** "Você usaria esse fluxo no dia a dia? Em comparação com o atual, qual prefere?"

> **Nota (P-B5):** WF-004 (conferência, perfil contador) é **opcional** nesta sessão com auxiliares; usar só se o participante for o contador ou se houver tempo e interesse. A Fase 3 com auxiliares foca em lançar e entender mensagens.

**Critério de sucesso:** participante completa a tarefa sem instruções; mensagens compreendidas; **sinal preliminar** positivo sobre o fluxo (evidência da sessão — retrabalho real só em uso pós-MVP).

### Fase 4 — Obrigações e pendências (WF-005/WF-006) (10 min)
- Tarefa: "Que clientes estão com obrigação atrasada?" (usar WF-005) e "Qual cliente tem pendência?" (WF-006).
- Perguntas:
  1. O que chama sua atenção nessa linha? (forma aberta — identificar sozinho o que comunica risco)
  2. Marcar "entregue" parece simples?
  3. "Essa lista substitui o que você acompanha por WhatsApp?" (registrar resposta literal)
  4. **Preferência (padrão):** "Em comparação com o controle atual, isso seria mais confiável ou menos?"

**Critério de sucesso:** participante identifica atrasados e compreende os estados (RV-006/RV-007 claros).

### Fase 5 — Documentos (WF-007) (5 min)
- Tarefa: "Registre um documento recebido para o cliente ABC" (sem pendência prévia).
- Pergunta: "Criar pendência a partir do documento" faz sentido? Re-cadastrar manualmente é aceitável? (PEN-UX-006)

**Critério de sucesso:** participante registra o documento e dá feedback sobre a aceitação do re-cadastro.

### Fase 6 — Fechamento (5 min)
- "O que está faltando? O que te faria não usar?"
- "Se pudesse mudar uma coisa, o que seria?"
- Priorize: quais 3 itens o sistema deve ter PRIMEIRO?

## 5. Registro e critérios de decisão

| Observação | Como registrar | Uso |
|---|---|---|
| Fricção (dúvida/erro) | Anotar etapa + fala | Revisar fluxo |
| Terminologia confusa | Anotar termo usado pelo usuário | Revisar labels (PEN-UX-002) |
| Tarefa concluída sem ajuda | Marcar "OK" | Hipótese apoiada |
| Nova necessidade | Anotar texto literal | Avaliar escopo futuro (não vira requisito automático) |

**Regras da squad (importante):**
- **1 fricção observada** em fluxo crítico → revisar wireframe antes de fechar.
- **2+ participantes** com mesma dificuldade → problema estrutural de UX.
- **Feedback de funcionalidade nova** → registrar como oportunidade, **não** adicionar ao MVP sem decisão.
- **Mínimo de participantes por hipótese (P-B2):** "apoiada" exige **≥3 participantes válidos** completando a tarefa sem ajuda E relatando preferência ao método atual. Com apenas **2 participantes**, registrar como **"sinal favorável"** (não "apoiada"). Hipóteses sem preferência explícita não podem ser declaradas apoiadas só pela conclusão da tarefa.
- **Códigos de participante (P-B2):** anotar como PC1, PC2… (não usar nomes) para permitir contar "1 fricção / 2+ participantes" sem quebrar anonimato.
- **Evidência preliminar (P-B1):** HYP-UX-002/003 concluídas como "apoiadas" exigem observação de uso real pós-MVP; nesta sessão registrar HYP-UX-002/003 como **sinal/favorável ou inconclusiva — nunca "apoiada"**.

## 6. Entregáveis da sessão

1. Notas por participante (anônimas — códigos PC1, PC2…).
2. Tabela de comprovantes por hipótese (HYP-UX-001…004: apoiada / sinal favorável / não apoiada / inconclusiva).
3. **HYP-UX-003 em separado:** registrar como "sinal preliminar — validação definitiva pós-MVP (uso real + conferência do contador)", nunca "apoiada" (P-B1).
4. Registro da consulta PEN-UX-003 (perfil sócio) e status: "coletado, permanece pendente de decisão/iteração" (P-B4).
5. Lista de problemas de UX encontrados (UX-PROB novos) com severidade.
6. Lista de oportunidades (fora do escopo atual).
7. Recomendação: revisar wireframes (quais?) ou avançar para consolidação do UX.

## 7. Rastreabilidade

| Fase | Wireframe | Hipótese | Pendência alimentada |
|---|---|---|---|
| 2 | WF-002/WF-008 | HYP-UX-001 (2) | PEN-UX-001; consulta PEN-UX-003 (P-B4) |
| 2 | WF-002/WF-008 | PEN-UX-003 (consulta sócio) | PEN-UX-003 (permanece pendente) |
| 3 | WF-003 (WF-004 opcional) | HYP-UX-002 (sinal preliminar); HYP-UX-003 (sinal preliminar — pós-MVP) | PEN-UX-001/002 |
| 4 | WF-005/WF-006 | HYP-UX-004 | PEN-UX-001 |
| 5 | WF-007 | — | PEN-UX-006 |
| 6 | — | — | Backlog futuro |

## 8. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Roteiro de validação baseado em UX-001/WIRE-001 (PEN-PB-003) | Squad Lead (ux-researcher indisponível — apd-002) |
| 1.1 | 2026-09-22 | Correções P-B1…P-B5 da revisão independente: HYP-UX-003 reclassificada como sinal preliminar/pós-MVP (P-B1), critérios mínimos de participantes, códigos PC e perguntas-padrão de preferência (P-B2), material = versão limpa WIRE-001c (P-B3), consulta sócio PEN-UX-003 (P-B4), modo de resposta e WF-004 opcional (P-B5) | Squad Lead (após revisão reviewer) |