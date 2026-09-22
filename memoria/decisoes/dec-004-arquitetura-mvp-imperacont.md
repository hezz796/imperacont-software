---
id: dec-004
type: decision
title: Direção arquitetural do MVP do ImperaCont — web local + SQLite WAL centralizado + monolítico + sem integrações + backup consistente
status: active
confidence: high
created: 2026-09-22
source: workflow 04 (ARC-001 v1.2), revisão independente do reviewer (2026-09-22) e confirmação do solicitante/dev único (stack/transporte)
project: imperacont-software
review_required: true
---

# Direção arquitetural do MVP — ImperaCont

## Decisão

Para o MVP 1 do ImperaCont, a direção arquitetural adotada é:

1. **Aplicação web local** (servidor no PC-base + browser nas 2 estações) — não desktop puro single-machine (coerente com dec-002).
2. **Banco SQLite em modo WAL centralizado no PC-base** — suficiente para 2–3 estações simultâneas; ponto de evolução natural para um banco servidor (Postgres) se crescer além disso.
3. **Arquitetura monolítica** (aplicação única com módulos/domínios) — proporcional ao porte; sem microsserviços.
4. **Sem integrações externas no MVP** (sem nuvem, sem SaaS, sem sistemas fiscais) — mitigação de risco e de escopo.
5. **Concorrência com WAL + transações curtas + busy timeout + controle otimista** (`version`/`updated_at`, `WHERE version = ?`, `BEGIN IMMEDIATE`, lote com transação curta por item) — especificação obrigatória antes dos módulos de escrita (PEN-ARC-010; detalhado no ARC-001).
6. **Backup = cópia consistente do banco (VACUUM INTO/snapshot) + cópia de anexos (gravação atômica) + validação semanal com restauração testada, incluindo 1 anexo**, em alvo independente do PC-base.
7. **Stack confirmada (2026-09-22): C#/.NET — ASP.NET Core com Razor Pages** (fluência mais forte do dev único; nativo Windows on-premise; segurança padrão forte; templates server-side).
8. **Transporte confirmado (2026-09-22): HTTP em LAN interna confiável** — cookie sem `Secure`, com `HttpOnly` + `SameSite`, e controles compensatórios (ACL do SO, acesso físico, rede interna dedicada); revisar — adotando TLS self-signed — se houver Wi-Fi aberto/compartilhado.

## Contexto

- Restrições: on-premise, 2 estações simultâneas, dev único com programação básica, orçamento limitado (ctx-002, REQ-001 RNF-002/009).
- Aprendizado central: **SQLite em arquivo de rede (NFS/share) corrompe banco** — por isso o **banco fica centralizado no servidor (aplicação no PC-base)** e as estações acessam via aplicação web local (ADR-001/002 do ARC-001).
- Direções provisórias do solicitante (RESUMO-001 A–F) embasam o comportamento; golden cases e catálogo de obrigações foram **confirmados** em 2026-09-22 (PEN-CONTADOR-001 §10-A). Validação externa com auxiliares/cliente (PEN-PB-003) segue pendente.

## Consequências

- Front-end: templates server-side (Razor Pages, sem SPA no MVP).
- Backend: ASP.NET Core com Razor Pages; SQLite via Microsoft.Data.Sqlite; autenticação/anti-forgery nativos do framework (P-ARC-005/006).
- Testes de concorrência exigem ambiente de homologação com 2 estações (PEN-ARC-004).
- Produção depende de modelo de acesso/infra final (PEN-ARC-003) e procedimento de backup/restauração padronizado (PEN-ARC-005).
- **Status active:** decisão arquitetural validada por revisão independente (ARC-001 gate APROVADO COM PENDÊNCIAS CONTROLADAS) e stack/transporte confirmados pelo dev único; itens restantes são confirmação de infra/backup para produção (PEN-ARC-003/005).

## Alternativas não escolhidas

- Desktop puro single-machine — contradiz multi-estação (dec-002).
- Banco em arquivo de rede — risco de corrupção (aprendizado técnico; rejeitada na arquitetura).
- Microsserviços/Eventos/BFF — desproporcional ao porte.
- SPA com REST + API externa — complexidade desnecessária no MVP; templates server-side preferidos.
- Stack Python (Flask/Django), Node.js — avaliadas como alternativas; **C#/.NET confirmado por fluência do dev**.

## Rastreabilidade

- `projetos/imperacont/architecture/ARC-001-architecture.md` v1.2 (ADR-001…010, §13/§17/§18)
- `projetos/imperacont/product/REQ-001-requirements-mvp.md` v1.4 (RNF-002/003/006/009)
- `projetos/imperacont/product/PEN-CONTADOR-001-perguntas.md` §10-A (golden cases/catálogo confirmados)
- `memoria/decisoes/dec-002-acesso-multi-estacao.md`, `memoria/decisoes/dec-003-direcoes-provisorias-resumo-001.md`
- `memoria/contexto/ctx-002-imperacont-restricoes.md`