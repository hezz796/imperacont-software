---
title: Wireframes de baixa fidelidade — MVP 1
description: Wireframes ASCII exploratórios das áreas validáveis do MVP 1 (navegação, lançamento, conferência, obrigações, pendências, documento, login). Para validação com auxiliares e 1 cliente (PEN-PB-003) — NÃO são telas finais.
type: prototype
status: reviewed
scope: project
version: 1.1
project: imperacont-software
---

> **Nota de governança (Squad Lead):** wireframes de baixa fidelidade produzidos pelo Squad Lead em 2026-09-22 após indisponibilidade do `ux-designer` (apd-002). Baseados no UX-001 v1.1 (correções P1–P10 incorporadas) e REQ-001 v1.1. **Finalidade: material para validação com auxiliares e 1 cliente (PEN-PB-003). Não representam telas aprovadas.** Revisão independente encaminhada ao `reviewer`.

# Wireframes MVP 1 — ImperaCont

## 1. Como usar

- Objetivo: **validar fluxos e navegação**, não visual final.
- Mostrar ao usuário: começar pelo **fluxo de lançamento** (tarefa mais frequente), depois **pendências por cliente** e **obrigações**.
- Perguntas de validação sugeridas em cada wireframe (o que falta? o que confunde?).
- Nada aqui é decisão de implementação (layout real pode mudar na Arquitetura).

> **Material de sessão (P-B3):** para mostrar a usuários, usar **exclusivamente** o `WIRE-001c-wireframes-sessao.md` (versão limpa, sem códigos RN/UC/CA e sem anotações internas). Este arquivo (WIRE-001) é a referência técnica com rastreabilidade.

---

## 2. WF-001 — Login

```
┌──────────────────────────────────────────────┐
│  ImperaCont                        [Ajuda]   │
│                                              │
│         ┌──────────────────────────┐         │
│         │  Usuário                 │         │
│         └──────────────────────────┘         │
│         ┌──────────────────────────┐         │
│         │  Senha      ••••••••     │         │
│         └──────────────────────────┘         │
│                                              │
│                  [ Entrar ]                  │
│                                              │
│  Mensagem de erro p/ credenciais:            │
│  "Usuário ou senha inválidos."               │
└──────────────────────────────────────────────┘
```

Validação: o que espera ver depois de entrar? (→ menu principal WF-002)

---

## 3. WF-002 — Navegação principal (menu lateral)

```
┌───────────┬──────────────────────────────────────────────┐
│ MENU      │  PAINEL (área do perfil)                      │
│           │                                               │
│ ▸ Clientes│  Bem-vindo, Nome      [Perfil: Auxiliar]      │
│ ▸ Lançam. │                                               │
│ ▸ Obrig.  │  Resumo de hoje:                              │
│ ▸ Pending.│   • Obrigações a vencer (7d): 3               │
│ ▸ Docs    │   • Clientes com pendência ativa: 5           │
│           │                                               │
│ (menu      │  (conteúdo por perfil — RNF-003/004; itens   │
│  Config    │   de Config são condicionados pelo perfil e  │
│  exibido   │   ficam ocultos para Auxiliar)               │
│  conforme  │                                               │
│  perfil)   │                                               │
│           │                                               │
│ [Sair]    │                                               │
└───────────┴──────────────────────────────────────────────┘
```

Validação:
- O que você mais usa no dia? (ordenar menu conforme resposta)
- Faz sentido partir de "Cliente" para ver tudo (prazos, lançamentos, pendências)?
- Nota para o facilitador: menu Config (Usuários/Clientes/Backup) só aparece para perfis autorizados (RNF-003/004); na visão do auxiliar deve estar oculto.

---

## 4. WF-003 — Novo lançamento (núcleo US-001)

```
┌───────────────────────────────────────────────────────────┐
│ Lançamentos → Novo lançamento                    [ Voltar ]│
│                                                           │
│ Cliente*   [ Empresa ABC (busca/autocomplete) ]           │
│ Período    [ 06/2026 (opcional — usado p/ validação de    │
│              período conforme RN-004) ]                   │
│ Data*      [ 10/06/2026              ]                    │
│ Valor*     [ R$ 1.000,00            ]                    │
│ Natureza*  ( ) Débito   ( ) Crédito                       │
│ Descrição  [ Pagamento mensal                             │
│             ................................... ]         │
│                                                           │
│     [ SALVAR LANÇAMENTO ]                                 │
│                                                           │
│ ► Validação no momento da confirmação (UC-001):           │
│   ⚠ Obrigatórios ausentes: "Campos obrigatórios: Cliente, │
│     Data, Valor. Preencha para salvar." [OK] → BLOQUEIA   │
│     gravação listando os campos (RN-001/US-001 CA-002)    │
│   ✓ Dados gravados com status "pendente de conferência".  │
│   ⚠ Duplicidade: "Já existe lançamento parecido?" →       │
│     [Corrigir]  [Manter mesmo assim]  (exige confirmação  │
│     antes de gravar — CA-003; "Manter mesmo assim" grava  │
│     sinalizado e fica para conferência — RN-005)          │
└───────────────────────────────────────────────────────────┘
```

> **Para o facilitador:** mostrar também o estado de erro de obrigatórios ausentes (acima) e perguntar se a mensagem é clara. Registros de regra (UC-001/CA-003/RN-006…) são anotações internas — **não** mostrar códigos ao usuário na sessão.

Validação:
- O que acharia difícil neste formulário? (campos demais? ordem?)
- A mensagem de duplicidade está clara o suficiente?

---

## 5. WF-004 — Conferência (perfil contador)

```
┌───────────────────────────────────────────────────────────┐
│ Lançamentos → Conferência (pendentes)                     │
│ Filtros: [Status: Pendente] [Cliente: Todos] [Período]    │
│                                                           │
│ [ ] Cliente      Data      Valor    Nat.  Sinalização     │
│ [ ] Empresa ABC  10/06   1.000,00  DB     —               │
│ [ ] Empresa XY   08/06   2.500,00  CR     duplicidade?    │
│ [ ] Empresa Z    07/06     500,00  DB     período?        │
│                                                           │
│ Ações:  [ Conferir selecionados ]  [ Detalhe ]            │
│ Detalhe sinalização: "Sinal: possível duplicidade.        │
│ Mantido pelo autor. Confirma ou corrige?"                 │
└───────────────────────────────────────────────────────────┘
```

Validação: como seria sua revisão ideal? Em lote ou um a um?

---

## 6. WF-005 — Obrigações e prazos (US-002/US-003)

```
┌───────────────────────────────────────────────────────────┐
│ Obrigações — próximos vencimentos                         │
│ Filtros: [Cliente] [Status] [Período]                     │
│                                                           │
│ Cliente       Obrigação     Vencimento   Status      Entrega│
│ Empresa ABC   DCTF Web      30/06/2026   a vencer    [ ]  │
│ Empresa XY    IRPJ 3T       15/07/2026   a vencer    [ ]  │
│ Empresa Z     DAS           10/07/2026   atrasado    [ ]  │
│ Empresa W     Comp. anual   28/06/2026   entregue    [X]  │
│ Empresa V     Relatório X   (sem data)  pendência   [ ]  │
│                                                           │
│ [ Registrar entrega ]                                     │
└───────────────────────────────────────────────────────────┘
```

> **Anotações para o facilitador (não mostrar ao usuário):** status automático conforme RN-006 (em dia / a vencer / atrasado / entregue). "Entregue" é estado — quando a entrega é marcada, o status passa a "entregue". Obrigação **sem vencimento** (exemplo "Relatório X") não gera status automático e vira pendência manual (UC-002 exceção). Alerta "a vencer" conforme parâmetro (PEN-PB-004). Checkbox = seleção para ação em lote; "Registrar entrega" aplica aos selecionados e grava autor/data.

Validação: que obrigações você controla? A visão por status está certa? A linha "atrasado" comunica o risco?

---

## 7. WF-006 — Pendências por cliente (US-004 / dor 6)

```
┌───────────────────────────────────────────────────────────┐
│ Pendências por cliente                                    │
│ Filtros: [Só atrasados] [Cliente]                         │
│                                                           │
│ Cliente            Pendência            Status       Origem  │
│ Empresa ABC        Documentos do mês    atrasado     deriv.  │
│ Empresa XY         DAS não enviado      em andamento manual │
│ Empresa Z          Comprovantes 06/2026  aberta      manual │
│                                                           │
│ [ Nova pendência ]  [ Atualizar status ]                  │
│ ► Status da pendência manual: aberta / em andamento /     │
│   resolvida (RN-007). "Atrasado" é CONDICAO derivada de   │
│   obrigação (RN-006), não status de pendência manual —    │
│   mostra a origem na coluna Origem. Registro de autor/    │
│   data em cada atualização (RN-007).                      │
└───────────────────────────────────────────────────────────┘
```

Validação: essa lista substitui o que você acompanhava por WhatsApp? O que falta?

---

## 8. WF-007 — Registrar documento mínimo (US-005)

```
┌───────────────────────────────────────────────────────────┐
│ Cliente: Empresa ABC → Documentos → Novo documento        │
│                                                           │
│ Descrição  [ Comprovante de pagamento 06/2026 ]           │
│ Arquivo    [ Selecionar arquivo... ]                      │
│            (preencha descrição OU anexe arquivo —         │
│             pelo menos um — CA-001)                       │
│ Situação*  ( ) Recebido   ( ) Pendente                    │
│ Vincular a [ Selecione pendência ou obrigação (opcional)  │
│             ... ]                                         │
│                                                           │
│ ► Se a pendência não existe: "Criar pendência a partir    │
│   deste documento?" [Criar] [Não]  (vínculo não bloqueia  │
│   o registro — RN-008/CA-002)                             │
│                                                           │
│     [ SALVAR ]                                            │
└───────────────────────────────────────────────────────────┘
```

Validação: registrar documento assim atende? O "vincular a pendência/obrigação" facilita ou complica?

---

## 9. WF-008 — Detalhe do cliente (abas — navegação centrada)

```
┌───────────────────────────────────────────────────────────┐
│ Cliente: Empresa ABC          CNPJ: 00.000.000/0001-00    │
│ Regime: Simples Nacional   Contato: fulano@abc.com        │
│                                                   [Editar]│
│ Badges: [Atrasado] [Pendência ativa]                       │
│                                                           │
│ [ Visão geral | Lançamentos | Obrigações | Pendências |   │
│   Documentos ]                                            │
│                                                           │
│ Visão geral: resumo de lançamentos no período, próximas    │
│ obrigações, pendências em aberto.                         │
└───────────────────────────────────────────────────────────┘
```

Validação: começando pelo cliente, você encontra o que precisa?

---

## 9a. WF-009 — Cadastro de cliente (RF-001) + estado vazio

```
┌───────────────────────────────────────────────────────────┐
│ Clientes → Novo cliente                          [ Voltar ]│
│                                                           │
│ Razão social* [ Empresa ABC                                │
│ CNPJ*         [ 00.000.000/0001-00      ] (único)         │
│ Regime*       [ Simples Nacional        ▼ ]               │
│ Contato       [ fulano@abc.com          ]                 │
│                                                           │
│     [ SALVAR ]                                            │
└───────────────────────────────────────────────────────────┘
Estado vazio (primeiro uso):                              │
│ "Cadastre o primeiro cliente para começar." [Novo cliente]│
```

Validação: um formulário curto assim atende ao cadastro inicial? E migrar a planilha atual? (sem importação no MVP — cadastro manual guiado)

---

## 10. Estados de erro e vazios (à validar com usuários)

- Campos obrigatórios ausentes no lançamento → **bloqueio** com lista dos campos (WF-003; RN-001/US-001 CA-002).
- Lista vazia de pendências: "Nenhuma pendência para este cliente." (estado positivo).
- Sem lançamentos no período: "Nenhum lançamento neste período."
- Sem clientes cadastrados: "Cadastre o primeiro cliente para começar." (WF-009).
- Falha de conexão: "Não foi possível salvar. Verifique a conexão e tente novamente." (sem gravação parcial).
- Acesso negado por perfil: "Ação não permitida para seu perfil."
- **Concorrência (PEN-UX-005):** com 2 estações, aviso de dado obsoleto ("Este lançamento foi alterado por outro usuário. Recarregar?"). Esboçar na validação multi-estação.

---

## 11. Pendências associadas

Consultar UX-001 §22 (PEN-UX-001…007). Estes wireframes destinam-se a validar **parcialmente**:
- PEN-UX-001 (navegação/lançamento/pendências/documento) — coberto (WF-002…008).
- PEN-UX-003 (perfil sócio/gestor — somente leitura) — **parcial:** não há variante de navegação de sócio; adicionar callout de consulta na validação ou nova iteração antes de fechar.
- PEN-UX-005 (concorrência) — **parcial:** aviso de dado obsoleto esboçado em §10; validar com 2 estações.
- PEN-UX-006 (aceitação do re-cadastro manual de documentos) — coberto pela pergunta de validação do WF-007.
- PEN-UX-007 (matriz perfil→área) — **condição:** não finalizar os wireframes de perfis/documentos antes de PEN-UX-007 (Q24 em PEN-CONTADOR-001); este documento é rascunho para a validação.

## 12. Rastreabilidade

| Wireframe | Origem | Requisito/Regra | Fluxo UX-001 |
|---|---|---|---|
| WF-001 | UC-005 | RF-002, RNF-003 | Autenticação |
| WF-002/008 | UX-001 §9 (nav. centrada em cliente) | RF-001/008 | Arquitetura da informação |
| WF-003 | UC-001, US-001 | RF-003/004, RN-001…005 | Fluxo principal |
| WF-004 | UC-001 (conferência) | RF-005, RN-005 | Conferência |
| WF-005 | UC-002, US-002/003 | RF-006/007, RN-006 | Jornada obrigações |
| WF-006 | UC-003, US-004 | RF-008/009, RN-007 | Jornada pendências |
| WF-007 | UC-004, US-005 | RF-010, RN-008 | Jornada documento |
| WF-008 | UX-001 §9 | RF-001 | Detalhe cliente |
| WF-009 | RF-001, UX-001 §15 | RF-001 | Cadastro/estado vazio |

## 13. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação de wireframes de baixa fidelidade (8 telas ASCII) para validação PEN-PB-003 | Squad Lead (ux-designer indisponível — apd-002) |
| 1.1 | 2026-09-22 | Correções P-B1…P-B12 da revisão independente: erro obrigatórios em WF-003 (P-B1), anotações fora dos quadros (P-B2), WF-005 atrasado/entregue + sem vencimento neutro (P-B3/P-B11), WF-006 status vs condição derivada (P-B4), WF-007 descrição OU arquivo (P-B5), período opcional (P-B6), perfil sócio/§11 (P-B7), aviso concorrência §10 (P-B8), menu Config condicionado (P-B9), WF-009 cadastro/estado vazio (P-B10), desfecho manter duplicidade (P-B12) | Squad Lead (após revisão reviewer) |