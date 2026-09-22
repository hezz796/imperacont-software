---
id: dec-002
type: decision
title: Acesso compartilhado multi-estação (acesso interno do ImperaCont na 1ª versão)
status: active
confidence: high
created: 2026-09-22
source: solicitação do usuário em resposta ao gate do PB-001 (PEN-PB-006)
project: imperacont-software
review_required: true
---

# Acesso compartilhado multi-estação — ImperaCont (1ª versão)

## Decisão

Na 1ª versão, o sistema **deve ser compartilhado com outro PC ou notebook** dentro do escritório — ou seja, o acesso é **multi-estação interno**: mais de uma máquina do escritório pode usar o mesmo sistema/dados.

- **Dentro:** acesso de múltiplos PCs/notebooks do escritório (uso interno compartilhado).
- **Fora do MVP:** acesso externo de clientes / nuvem / portal (adiado — uso assistido no MVP).

## Contexto

- O solicitante declarou anteriormente "Desktop Windows" como acesso da 1ª versão (EVD-009), o que criava tensão com a necessidade de clientes e de várias pessoas usarem o sistema (RSK-001).
- Em 2026-09-22, ao responder sobre o gate do PB-001, o solicitante esclareceu: *"Dentro dos pontos discutidos, o sistema deve ser compartilhado com outro PC ou notebook"*.

## Consequências / implicações para Arquitetura

- A escolha **desktop puro single-machine fica descartada** como única forma de entrega.
- Implica **dados centralizados/acessíveis por outra máquina** (ex.: banco em máquina-servidor + clientes na rede, ou aplicação web local acessível na rede interna).
- **Não** implica acesso externo/nuvem no MVP.
- Reduz a tensão RSK-001 para o caso externo (cliente), que permanece adiado.
- Ainda **não confirmado**: se o acesso é simultâneo/conc/concorrente, quais máquinas, e se há necessidade de permissões por usuário — a detalhar em PEN-PB-006 antes de Arquitetura.

## Alternativas não escolhidas (nesta etapa)

- Acesso externo/portal do cliente no MVP — mantido fora (DEC-MVP-002).
- Instalação independente em cada PC sem compartilhamento de dados — **contradiz** a decisão do solicitante (requer compartilhamento).

## Estado

- **Em revisão** — candidata a confirmação após revisão independente e detalhamento em PEN-PB-006 (Arquitetura).
- Evidência: auto-relato do solicitante (fonte única), 2026-09-22.

## Rastreabilidade

- `projetos/imperacont/product/PB-001-product-brief.md` (§10.1, §12.2, RSK-PB-009, PEN-PB-006)
- `memoria/contexto/ctx-002-imperacont-restricoes.md`
- `memoria/riscos/rsk-001-desktop-vs-clientes-externos.md`
- `projetos/imperacont/discovery/DSC-001-discovery.md` (EVD-009, PEN-003) — a atualizar na próxima revisão da discovery