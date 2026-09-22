---
id: dec-004
type: decision
title: Direção arquitetural do MVP do ImperaCont — web local + SQLite WAL centralizado + monolítico + sem integrações + backup consistente
status: draft
confidence: medium
created: 2026-09-22
source: workflow 04 (ARC-001 v1.1) e revisão independente do reviewer (2026-09-22)
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
5. **Concorrência com WAL + transações curtas + busy timeout + controle otimista** (`version`/`updated_at`, `WHERE version = ?`, `BEGIN IMMEDIATE`, lote com transação curta por item) — especificação obrigatória antes dos módulos de escrita.
6. **Backup = cópia consistente do banco (VACUUM INTO/snapshot) + cópia de anexos (gravação atômica) + validação semanal com restauração testada, incluindo 1 anexo**, em alvo independente do PC-base.
7. **Transporte/segurança:** decisão explícita obrigatória antes do incremento de autenticação — HTTP em LAN confiável assumido (sem cookie `Secure`) com controles compensatórios, ou TLS self-signed com `Secure`.

## Contexto

- Restrições: on-premise, 2 estações simultâneas, dev único com programação básica, orçamento limitado (ctx-002, REQ-001 RNF-002/009).
- Aprendizado central: **SQLite em arquivo de rede (NFS/share) corrompe banco** — por isso o **banco fica centralizado no servidor (aplicação no PC-base)** e as estações acessam via aplicação web local (ADR-001/002 do ARC-001).
- Direções provisórias do solicitante (RESUMO-001 A–F) embasam o comportamento, mas permanecem em validação (dec-003 em draft/media).

## Consequências

- **Linguagem recomendada:** Python (Flask ou Django) por simplicidade e templates server-side; a confirmação final com o dev único é pendência obrigatória (PEN-ARC-001) — sem evidência de preferência do dev até 2026-09-22.
- Front-end: templates server-side (sem SPA no MVP).
- Testes de concorrência exigem ambiente de homologação com 2 estações (PEN-ARC-004).
- Produção depende de modelo de acesso/infra final (PEN-ARC-003) e procedimento de backup/restauração padronizado (PEN-ARC-005).
- **Status draft:** decisões tecnológicas finais só serão `active` após confirmação da stack (PEN-ARC-001) e validação em homologação (PEN-ARC-004). A direção arquitetural (web local + SQLite WAL + monolítica) está validada por revisão independente (ARC-001 gate APROVADO COM PENDÊNCIAS CONTROLADAS).

## Alternativas não escolhidas

- Desktop puro single-machine — contradiz multi-estação (dec-002).
- Banco em arquivo de rede — risco de corrupção (aprendizado técnico; rejeitada na arquitetura).
- Microsserviços/Eventos/BFF — desproporcional ao porte.
- SPA com REST + API externa — complexidade desnecessária no MVP; templates server-side preferidos.

## Rastreabilidade

- `projetos/imperacont/architecture/ARC-001-architecture.md` v1.1 (ADR-001…010, §17)
- `projetos/imperacont/product/REQ-001-requirements-mvp.md` v1.3 (RNF-002/003/006/009)
- `memoria/decisoes/dec-002-acesso-multi-estacao.md`, `memoria/decisoes/dec-003-direcoes-provisorias-resumo-001.md`
- `memoria/contexto/ctx-002-imperacont-restricoes.md`