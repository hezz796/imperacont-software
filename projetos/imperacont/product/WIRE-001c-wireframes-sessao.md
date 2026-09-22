---
title: Wireframes de baixa fidelidade — versão limpa para sessão de validação
description: Cópia dos wireframes do MVP 1 SEM códigos internos (RN/UC/CA), anotações de regras e blocos "para o facilitador". ÚNICO material a mostrar aos participantes na sessão de validação (VAL-001 §3 / WIRE-001 P-B3). Não substitui WIRE-001 v1.1 (referência técnica).
type: prototype
status: draft
scope: project
version: 1.0
project: imperacont-software
---

# Wireframes — Sessão de validação (ImperaCont MVP 1)

> **Uso exclusivo como material de sessão (VAL-001).** Não contém regras internas; apenas os fluxos a mostrar ao participante. Data: ______ Participante: ______

---

## 1. Entrada (WF-001)

```
┌──────────────────────────────────────────────┐
│  ImperaCont                        [Ajuda]   │
│                                              │
│         ┌──────────────────────────┐         │
│         │  Usuário                 │         │
│         └──────────────────────────┘         │
│         ┌──────────────────────────┐         │
│         │  Senha                   │         │
│         └──────────────────────────┘         │
│                                              │
│                  [ Entrar ]                  │
└──────────────────────────────────────────────┘
```

---

## 2. Tela inicial (WF-002)

```
┌───────────┬──────────────────────────────────────────────┐
│ MENU      │  PAINEL                                       │
│           │                                               │
│ ▸ Clientes│  Bem-vindo, [Nome]                            │
│ ▸ Lançamentos│                                            │
│ ▸ Obrigações│  Resumo de hoje:                            │
│ ▸ Pendências│    • Obrigações a vencer (7 dias): 3        │
│ ▸ Documentos│    • Clientes com pendência ativa: 5        │
│           │                                               │
│ [Sair]    │                                               │
└───────────┴──────────────────────────────────────────────┘
```

---

## 3. Novo lançamento (WF-003)

```
┌───────────────────────────────────────────────────────────┐
│ Lançamentos → Novo lançamento                    [ Voltar ]│
│                                                           │
│ Cliente     [ Empresa ABC (busca) ]                       │
│ Período     [ 06/2026 (opcional) ]                        │
│ Data        [ 10/06/2026 ]                                │
│ Valor       [ R$ 1.000,00 ]                               │
│ Natureza    ( ) Débito   ( ) Crédito                      │
│ Descrição   [ Pagamento mensal                            │
│              ................................... ]        │
│                                                           │
│     [ SALVAR LANÇAMENTO ]                                 │
└───────────────────────────────────────────────────────────┘

[Estado A — campos obrigatórios] 
"Campos obrigatórios: Cliente, Data, Valor. Preencha para salvar."

[Estado B — possível lançamento parecido]
"Já existe lançamento parecido."
[ Corrigir ]  [ Manter mesmo assim ]
```

---

## 4. Conferência (WF-004) — só se participante for o contador

```
┌───────────────────────────────────────────────────────────┐
│ Lançamentos → Conferência (pendentes)                     │
│                                                           │
│ [ ] Cliente     Data       Valor    Nat.   Aviso          │
│ [ ] Empresa ABC 10/06     1.000,00  DB    —               │
│ [ ] Empresa XY  08/06     2.500,00  CR    duplicidade?    │
│ [ ] Empresa Z   07/06       500,00  DB    período?        │
│                                                           │
│ Ações:  [ Conferir selecionados ]  [ Detalhe ]            │
│ Detalhe: "Aviso: possível duplicidade. Confirma ou        │
│ corrige?"                                                 │
└───────────────────────────────────────────────────────────┘
```

---

## 5. Obrigações e prazos (WF-005)

```
┌───────────────────────────────────────────────────────────┐
│ Obrigações — próximos vencimentos                         │
│ Filtros: [Cliente] [Status] [Período]                     │
│                                                           │
│ Cliente       Obrigação     Vencimento   Status     Entrega│
│ Empresa ABC   DCTF Web      30/06/2026   a vencer   [ ]   │
│ Empresa XY    IRPJ 3T       15/07/2026   a vencer   [ ]   │
│ Empresa Z     DAS           10/07/2026   atrasado   [ ]   │
│ Empresa W     Comp. anual   28/06/2026   entregue   [X]   │
│ Empresa V     Relatório X   (sem data)   pendência  [ ]   │
│                                                           │
│ [ Registrar entrega ]                                     │
└───────────────────────────────────────────────────────────┘
```

---

## 6. Pendências por cliente (WF-006)

```
┌───────────────────────────────────────────────────────────┐
│ Pendências por cliente                                    │
│ Filtros: [Só atrasados] [Cliente]                         │
│                                                           │
│ Cliente            Pendência             Status         Origem│
│ Empresa ABC        Documentos do mês     atrasado        au-│
│                     (vencimento de obrig.)  tomático      │
│ Empresa XY         DAS não enviado       em andamento    au-│
│                                                           │
│ Empresa Z          Comprovantes 06/2026  aberta          manual│
│                                                           │
│ [ Nova pendência ]  [ Atualizar status ]                  │
└───────────────────────────────────────────────────────────┘
```

---

## 7. Registrar documento (WF-007)

```
┌───────────────────────────────────────────────────────────┐
│ Cliente: Empresa ABC → Documentos → Novo documento        │
│                                                           │
│ Descrição  [ Comprovante de pagamento 06/2026 ]           │
│ Arquivo    [ Selecionar arquivo... ]                      │
│            (preencha descrição OU anexe arquivo)          │
│ Situação   ( ) Recebido   ( ) Pendente                    │
│ Vincular a [ Selecione pendência ou obrigação (opcional)  │
│             ... ]                                         │
│                                                           │
│ Se a pendência não existe:                                │
│ "Criar pendência a partir deste documento?"               │
│ [Criar] [Não]                                             │
│                                                           │
│     [ SALVAR ]                                            │
└───────────────────────────────────────────────────────────┘
```

---

## 8. Cliente (WF-008)

```
┌───────────────────────────────────────────────────────────┐
│ Cliente: Empresa ABC       CNPJ: 00.000.000/0001-00       │
│ Regime: Simples Nacional   Contato: fulano@abc.com        │
│                                                   [Editar]│
│ [Atrasado] [Pendência ativa]                              │
│                                                           │
│ [ Visão geral | Lançamentos | Obrigações | Pendências |   │
│   Documentos ]                                            │
│                                                           │
│ Visão geral: resumo de lançamentos no período, próximas   │
│ obrigações, pendências em aberto.                         │
└───────────────────────────────────────────────────────────┘
```

---

## 9. Novo cliente (WF-009)

```
┌───────────────────────────────────────────────────────────┐
│ Clientes → Novo cliente                          [ Voltar] │
│                                                           │
│ Razão social [ Empresa ABC ]                              │
│ CNPJ         [ 00.000.000/0001-00 ]                       │
│ Regime       [ Simples Nacional ▼ ]                       │
│ Contato      [ fulano@abc.com ]                           │
│                                                           │
│     [ SALVAR ]                                            │
└───────────────────────────────────────────────────────────┘

Primeiro uso (sem clientes):
"Cadastre o primeiro cliente para começar." [ Novo cliente ]
```

---

## 10. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Versão limpa (sem códigos RN/UC/CA e anotações de facilitador) gerada a partir do WIRE-001 v1.1 — material de sessão VAL-001 (P-B3) | Squad Lead (após revisão reviewer) |