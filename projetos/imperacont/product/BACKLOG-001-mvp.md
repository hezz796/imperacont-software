---
title: Backlog inicial MVP 1
type: backlog
status: draft
scope: project
version: 1.0
project: imperacont-software
created: 2026-09-22
---

# Backlog inicial — ImperaCont MVP 1

## Critérios de priorização

Valor (dor resolvida) + risco (consequência) + dependência + evidência. **Esforço técnico não é o único critério** (workflow 02 etapa 8).

| Prioridade | Faixa |
|---|---|
| P0 | Núcleo com maior consequência (erro/prazo/pendência) — começa aqui |
| P1 | Apoio ao núcleo (cadastros, segurança, documentos mínimos) |
| P2 | Métricas/observabilidade — não bloqueia uso mas viabiliza validação de valor |

## Itens

| ID | Item | Origem (RF/US) | Valor | Risco | Prioridade | Status |
|---|---|---|---|---|---|---|
| BL-001 | Cadastro e manutenção de clientes (empresas) | RF-001 | Alto (base) | Baixo | P1 | Não iniciado |
| BL-002 | Cadastro de usuários e perfis de acesso | RF-002, UC-005 | Alto | Alto (RGPD/RSK-PB-007) | P1 | Não iniciado |
| BL-003 | Lançamento de movimentação com validação (sinalização) | RF-003/004, UC-001, US-001 | Alto | Alto (RSK-PB-002) | **P0** | Não iniciado |
| BL-004 | Conferência/validação pelo contador | RF-005, US-001 | Alto | Alto | **P0** | Não iniciado |
| BL-005 | Cadastro de obrigações e prazos por cliente | RF-006, US-003 | Alto | Médio | **P0** | Não iniciado |
| BL-006 | Status automático de prazos + alertas | RF-007, RN-006, US-003 | Alto | Alto (RSK-PB-008) | **P0** | Não iniciado |
| BL-007 | Visão de pendências por cliente | RF-008, US-002/US-004 | Alto | Médio | **P0** | Não iniciado |
| BL-008 | Registro e atualização de pendências manuais | RF-009, US-004 | Alto | Baixo | P1 | Não iniciado |
| BL-009 | Registro mínimo de documentos (anexo/pendência) | RF-010, US-005 | Médio | Baixo | P1 | Não iniciado |
| BL-010 | Política de edição/exclusão de lançamentos | RF-012, PEN-REQ-002 | Médio | Alto | P1 | Depende do contador |
| BL-011 | Registro de dados para métricas (logs) | RF-011, RNF-007 | Médio | Baixo | P2 | Não iniciado |
| BL-012 | Backup automático e plano de recuperação | RNF-006 | Alto | Alto | P0/P1 (Arquitetura) | Não iniciado |
| BL-013 | Autenticação + autorização por perfil + auditoria | RNF-003/004 | Alto | Alto | P1 | Não iniciado |

## Ordem sugerida de evolução

1. **Núcleo (P0):** BL-003 → BL-004 → BL-005 → BL-006 → BL-007 (dependências: cadastros BL-001/002 e segurança BL-013 como pré-requisitos leves).
2. **Apoio (P1):** BL-001/002/008/009/010/013.
3. **Métricas (P2):** BL-011/012 (backup pode subir de prioridade com a Arquitetura).

## Pendências que condicionam o backlog

- PEN-PB-002 — golden cases de validação (bloqueia BL-003/004 em detalhe).
- PEN-PB-004 — obrigações específicas (BL-005/006).
- PEN-PB-003 — validação com auxiliares (bloqueia fechamento de UX de BL-003/007/008).
- PEN-PB-006 — modelo de acesso (bloqueia Arquitetura/solução técnica de BL-012/013).
- PEN-REQ-002 — política de edição/exclusão (BL-010).

## Rastreabilidade

| Item | Origem | Problema | Teste | Release |
|---|---|---|---|---|
| BL-001/002 | REQ-001 RF-001/002 | Dor 6/segurança | Funcional/segurança | MVP 1 |
| BL-003/004 | REQ-001 RF-003/004/005 | Dor 1 | Funcional + golden | MVP 1 |
| BL-005/006 | REQ-001 RF-006/007 | Dor 5 | Funcional + golden | MVP 1 |
| BL-007/008 | REQ-001 RF-008/009 | Dor 6 | Funcional | MVP 1 |
| BL-009 | REQ-001 RF-010 | Dor 2/6 mínimo | Funcional | MVP 1 |
| BL-010 | REQ-001 RF-012 | Risco contábil | Funcional/segurança | MVP 1 |
| BL-011 | REQ-001 RF-011 | Métricas | Logs | MVP 1 |
| BL-012/013 | REQ-001 RNF-003/006 | Perda/segurança | Recuperação/segurança | MVP 1 |

## Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação (etapa 8 workflow 02) | Squad Lead (BA indisponível; ver REQ-001 header) |