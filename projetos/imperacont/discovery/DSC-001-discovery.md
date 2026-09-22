---
title: Discovery
description: Discovery do produto de software contábil para escritório de contabilidade (ImperaCont — nome provisório).
type: discovery
status: active
scope: project
version: 1.4
---

# Discovery

> **Status: v1.4** — discovery concluída com condições; adendo de acesso (dec-002) aplicado em 2026-09-22.

## 1. Identificação

- **ID:** DSC-001
- **Projeto:** imperacont-software (nome provisório do repositório)
- **Produto:** Software contábil para escritório de contabilidade — nome provisório "ImperaCont"
- **Responsável:** Squad Lead (squad), solicitante (fonte primária de evidência)
- **Data de início:** 2026-09-22
- **Data de conclusão:** 2026-09-22 (rodada 1 — pendências abertas, ver §21)
- **Versão:** 1.3
- **Status:** Aprovado com condições

---

## 2. Objetivo da discovery

Compreender, antes de qualquer definição de produto ou tecnologia:

1. qual problema real o software contábil deve resolver;
2. quem são os usuários e o que eles precisam;
3. qual o escopo essencial frente a um escopo desejado ainda não priorizado;
4. quais riscos e restrições condicionam a solução;
5. que incertezas permanecem abertas e precisam ser resolvidas ou aceitas explicitamente.

---

## 3. Perguntas principais

- Qual operação contábil o escritório precisa executar e com que qualidade?
- Quem usa o sistema, em que papel, e com que frequência?
- Quais dores são críticas (resolver primeiro) e quais são secundárias?
- O escritório é um *greenfield* total ou existe prática não documentada?
- Desktop Windows é compatível com a necessidade de acesso dos clientes?
- Qual a menor versão que gera valor real sem estourar orçamento/restrições?

---

## 4. Contexto

### Contexto do negócio

- Escritório de contabilidade **único** (uso interno inicial; **sem venda** do software a terceiros na fase inicial).
- Porte: **pequeno — menos de ~50 empresas/clientes atendidos**.
- Jurisdição: **Brasil**, regimes federais (Simples Nacional e/ou Lucro Presumido/Real).
- Fonte da evidência nesta discovery: **declarações do próprio solicitante** (entrevista estruturada, 4 rodadas, 2026-09-22). Não houve observação direta de operação — ver §9.

### Contexto operacional

- O solicitante declarou originalmente **"nenhum (processo a criar)"** como forma atual de trabalho — interpretado como **ausência de ferramenta estruturada**, não ausência de operação. Rodada seguinte (PEN-002) confirmou: **o escritório já opera com clientes**, execução **mista** (sócio + auxiliares), e documentos chegam **via WhatsApp/Telegram** (EVD-011…013).
- Não há software contábil nem planilha estruturada — a operação é informal. O software **estruturaria o processo existente**, não o criaria do zero (reduz RSK-003; ver Descoberta 4).
- Operações pretendidas para o produto (marcadas como desejadas): escrituração contábil, financeiro dos clientes, notas fiscais, obrigações acessórias.
- Operações **não** marcadas: departamento pessoal (folha) e gestão/controle operacional (painéis/indicadores).

### Contexto dos usuários

Todos os cinco perfis foram marcados como usuários do software:

| Perfil | Uso esperado declarado |
|---|---|
| Contador(es) titular(es) | Conferência, revisão, relatórios, assinatura técnica |
| Auxiliares/estagiários | Lançamentos, conciliações, digitação (alto volume) |
| Atendimento/administrativo | Recebimento de docs, pendências, contato com clientes |
| Sócio(s)/gestor(es) | Visão financeira, indicadores, capacidade |
| **Clientes do escritório** | Envio de documentos/consulta (uso externo) |

### Contexto existente

- Software **não existe**. Código, banco, processos e documentação partem do zero.
- Restrições declaradas: **orçamento limitado** e **ambiente restrito** (significado exato a confirmar — INC-004).
- Acesso declarado para a 1ª versão: **Desktop Windows**.

---

## 5. Problema investigado

### Problema inicial (declaração do solicitante)

"Criar um software contábil" para um escritório de contabilidade.

### Problemas relacionados declarados (6 dores, sem priorização)

1. Erros / ausência de validação
2. Comunicação com clientes
3. Retrabalho / manualidade
4. Fechamento / confecção (balancetes, fechamento do mês)
5. Obrigações / prazos
6. Gestão dos clientes (pendências, visão por cliente)

### Problema reformulado após investigação

> Um escritório de contabilidade pequeno (<50 clientes), que **já opera com clientes** de forma mista (sócio + auxiliares) e **sem ferramenta estruturada** (documentos via WhatsApp/Telegram), precisa operar — para seus clientes — escrituração, financeiro, notas fiscais e obrigações acessórias, sem cometer erros, sem perder prazos, com visibilidade de pendências e com troca eficiente de informações com os clientes; tudo isso sob orçamento limitado, ambiente restrito e capacidade de desenvolvimento básica (desenvolvedor único).

**Atenção:** o problema foi construído a partir de **auto-relato único** do solicitante. Ele já opera com clientes, mas a dinâmica real de trabalho com auxiliares e contadores ainda precisa ser validada com os demais usuários antes de Development (RSK-006, PEN-007). A rotina informal via WhatsApp/Telegram é evidência direta da dor de comunicação (EVD-013).

---

## 6. Usuários e stakeholders

| Perfil | Necessidade | Comportamento | Problemas | Evidência |
|---|---|---|---|---|
| Contador titular | Conferir e assinar com segurança | Revisão pontual, alta exigência de exatidão | Erros passariam despercebidos sem validação | Auto-relato (EVD-003) |
| Auxiliar/estagiário | Digitar lançamentos e conciliar com rapidez | Alto volume repetitivo | Retrabalho e erro manual | Auto-relato (EVD-003) |
| Atendimento | Saber quem está pendente e cobrar cliente | Acompanhamento diário | Falta de visão por cliente | Auto-relato (EVD-003) |
| Sócio/gestor | Visão de capacidade e financeiro | Consulta eventual | Não há indicadores | Auto-relato (EVD-003) |
| Cliente do escritório | Enviar documentos e acompanhar situação | Uso eventual, não especializado | Comunicação lenta com o escritório (canal a ser confirmado) | Auto-relato (EVD-003); **não validado com clientes reais** |

---

## 7. Métodos utilizados

| Método | Objetivo | Participantes/Fonte | Resultado |
|---|---|---|---|
| Entrevista estruturada (4 rodadas de questionário) | Levantar contexto, dores, usuários, operações, restrições e modelo de acesso | Solicitante (fonte única) | Base desta discovery |
| Análise documental | Verificar memória e artefatos existentes | Repositório (memoria/, conhecimento/) | Sem memória anterior; sem artefatos de projeto |

**Métodos não executados (lacuna declarada):** observação de operação, entrevistas com contadores/auxiliares/clientes reais, análise de dados de trabalho, benchmarking de softwares do setor.

---

## 8. Evidências

| ID | Evidência | Fonte | Data | Confiabilidade | Observação |
|---|---|---|---|---|---|
| EVD-001 | Usuário-alvo é escritório de contabilidade | Solicitante | 2026-09-22 | medium | Auto-relato coerente com o pedido |
| EVD-002 | Uso interno inicial, sem venda do software | Solicitante | 2026-09-22 | medium | Restringe requisitos de multi-tenant/licenciamento |
| EVD-003 | Todos os 5 perfis de usuário, incluindo clientes externos | Solicitante | 2026-09-22 | medium | Escopo de usuários amplo demais para 1ª versão? (HIP-004) |
| EVD-004 | 6 dores marcadas, todas, sem priorização | Solicitante | 2026-09-22 | low (como prioridade) | Fato: foram marcadas. Não é evidência de igualdade de criticidade |
| EVD-005 | Processo a criar (greenfield total) | Solicitante | 2026-09-22 | medium | Contrasta com <50 clientes atendidos — ver INC-002 |
| EVD-006 | Operações desejadas: escrituração, financeiro, NF, obrigações | Solicitante | 2026-09-22 | medium | 4 frentes complexas; sem prioridade entre elas |
| EVD-007 | Brasil, regimes federais | Solicitante | 2026-09-22 | medium | Define regras de validação/obrigações |
| EVD-008 | Restrições: orçamento limitado + ambiente restrito | Solicitante | 2026-09-22 | medium | "Ambiente restrito" não detalhado — INC-004 |
| EVD-009 | Acesso 1ª versão: Desktop Windows | Solicitante | 2026-09-22 | medium | **Conflita** com EVD-003 (clientes externos) e EVD-004 (comunicação) — ver RSK-002. **Superada em parte por decisão dec-002** (acesso interno multi-estação definido; ver §9.1) |
| EVD-010 | Escopo da 1ª versão: indefinido, delegado à squad | Solicitante | 2026-09-22 | medium | Priorização é tarefa desta squad (Product Definition) |
| EVD-011 | O escritório **já opera** atendendo clientes hoje (não está iniciando) | Solicitante | 2026-09-22 | medium | Esclarece INC-002: há operação real |
| EVD-012 | Execução atual é **mista** (sócio + auxiliares) | Solicitante | 2026-09-22 | medium | Lançamentos/conciliações já ocorrem manualmente |
| EVD-013 | Documentos dos clientes chegam **via WhatsApp/Telegram** | Solicitante | 2026-09-22 | medium | Define a dor de comunicação e a jornada de entrada de documentos |
| EVD-014 | Sucesso nos primeiros 6 meses = **menos erros/retrabalho** e **prazos cumpridos** | Solicitante | 2026-09-22 | medium | Primeira métrica de resultado declarada (fecha parcialmente INC-008) |
| EVD-015 | Volume operacional **baixo** (~até 30 lançamentos/mês por cliente médio) | Solicitante | 2026-09-22 | medium | Dado quantitativo inicial para dimensionar MVP |
| EVD-016 | Desenvolvedor será o **próprio solicitante**, com **programação básica** | Solicitante | 2026-09-22 | medium | Define perfil de capacidade (PEN-004 resolvida) |
| EVD-017 | Dedicação com tempo reservado, **sem prazo rígido**; stack fica a cargo da squad na Arquitetura | Solicitante | 2026-09-22 | medium | Alivia pressão de prazo, mas mantém restrição de capacidade |
| EVD-018 | "Ambiente restrito" = **servidor próprio (on-premise)**, **sem bloqueio técnico real** — era receio de custo/nuvem | Solicitante | 2026-09-22 | medium | Suaviza a restrição; não havia política de TI ou bloqueio de internet declarados |

---

## 9. Observações

Fatos observados, sem conclusão:

- O solicitante marcou **simultaneamente** "desktop Windows" como acesso da 1ª versão e "clientes do escritório" como usuários.
- O solicitante marcou **todas** as 6 dores oferecidas na mesma resposta.
- O solicitante declarou **"processo a criar"** na rodada 1, mas na rodada PEN-002 confirmou **operação ativa com clientes**, execução mista e entrada de documentos via **WhatsApp/Telegram** (EVD-011…013).
- Não houve, até aqui, contato com nenhum usuário final real (auxiliar, atendimento, contador ou cliente) além do solicitante.
- "Gestão dos clientes" foi marcada como dor, mas "gestão/controle operacional" (painéis/indicadores) **não** foi marcada como operação desejada.

### 9.1 Adendo de acesso (2026-09-22, decisão dec-002)

Após a conclusão do Product Brief (PB-001 v1.1), o solicitante esclareceu o modelo de acesso da 1ª versão:

- **O sistema deve ser compartilhado com outro PC ou notebook do escritório** — acesso **interno multi-estação** (decisão `memoria/decisoes/dec-002`).
- O **modelo de implementação** (desktop + banco compartilhado, servidor na rede local, ou web local) fica **em aberto para a Arquitetura**, dentro da restrição on-premise.
- O **acesso externo de clientes permanece fora do MVP 1** (uso assistido; portal adiado).

Isso **supera parcialmente** EVD-009 e **reduz o escopo de PEN-003** ao caso externo (cliente). Ver RSK-002/RSK-009 atualizadas em §13.

---

## 10. Interpretações

Interpretações da squad (não são fatos):

- A marcação simultânea de todas as dores indica **falta de prioridade conhecida**, não seis dores de igual peso. O solicitante explicitou "decidir com a squad".
- A rotina informal via **WhatsApp/Telegram** (EVD-013) é evidência concreta da dor de **comunicação/desorganização de entrada de documentos** — reforça a relevância de um fluxo estruturado de recebimento.
- Os critérios de sucesso declarados (menos erros/retrabalho + prazos cumpridos, EVD-014) convergem com as dores 1 e 5 e reforçam HYP-002 **como candidata**, ainda a validar (todas as dores foram marcadas juntas).
- Desktop Windows como escolha 1ª versão é coerente com **tradição do setor contábil** e com **ambiente restrito**, mas é **incoerente com uso externo pelos clientes** sem uma segunda via de acesso (web/portal/e-mail assistido).
- Escopo desejado (4 frentes complexas: escrituração + financeiro + NF + obrigações) é **desproporcional** à capacidade de desenvolvimento básica (EVD-016) — exige corte de escopo obrigatório na definição do MVP. O desenvolvedor único com programação básica é uma **restrição forte** à complexidade da 1ª versão.
- O solicitante é a única fonte e é simultaneamente dono do escritório; isso **não** reduz por si só o viés de auto-relato (dono tem incentivos próprios de apresentação) — a validação com os demais perfis continua obrigatória (RSK-006).

---

## 11. Oportunidades

| ID | Oportunidade | Evidência | Potencial | Incerteza |
|---|---|---|---|---|
| OPP-001 | Estruturar um processo já existente e informal (não criar do zero) — há operação real para ancorar requisitos | EVD-011, EVD-012, EVD-013 | Alto — capacidade de validar requisitos na operação real | Baixa |
| OPP-002 | Regras de validação contábil/prazos como diferencial central (dor 1 e 5; sucesso declarado em EVD-014) | EVD-004, EVD-006, EVD-007, EVD-014 | Alto — ataca erro e prazo, os riscos mais caros do setor | Média — prioridade relativa não confirmada |
| OPP-003 | Base sólida para evoluir de ferramenta interna a produto (sem pressa) | EVD-002 | Médio — opcional, fora do escopo atual | Alta |

---

## 12. Hipóteses

| ID | Hipótese | Evidência | Método de validação | Resultado | Status |
|---|---|---|---|---|---|
| HYP-001 | As 6 dores têm pesos muito diferentes; 2–3 concentram o valor real | EVD-004, EVD-010 | Sessão de priorização com o solicitante/contador | — | aberta |
| HYP-002 | Validação automática + controle de prazos é o núcleo de valor do MVP | EVD-004, EVD-006 | Protótipo/teste com usuário real | — | aberta |
| HYP-003 | Escrituração completa é necessária na 1ª versão ou basta módulo parcial | EVD-006 | Entrevista com contador titular | — | aberta |
| HYP-004 | Clientes externos podem ser atendidos sem acesso direto ao desktop (portal web mínimo, ou fluxo assistido pelo atendimento) | EVD-003 vs EVD-009 | Decisão arquitetural guiada por jornada do cliente | — | aberta |
| HYP-005 | Desktop Windows + ambiente restrito + orçamento limitado apontam para stack simples, on-premise, de baixo custo operacional | EVD-008, EVD-009 | Trade-off analysis na Arquitetura | — | aberta |
| HYP-006 | O escritório possui rotina prática real (informal) além do inicialmente declarado | EVD-011, EVD-012, EVD-013 | Entrevista com contador/auxiliar | Confirmado parcialmente (operação ativa, mista, via WhatsApp/Telegram) | validada (parcial) |

---

## 13. Riscos

| ID | Risco | Probabilidade | Impacto | Mitigação |
|---|---|---|---|---|
| RSK-001 | Escopo amplo demais (4 frentes) × orçamento limitado → sistema nunca fica pronto ou fica raso | Alta | Alto | Corte agressivo de MVP; priorizar por valor/risco |
| RSK-002 | Desktop Windows incompatível com necessidade real de clientes externos → retrabalho ou reescrita | Média | Alto | **Atualizado (dec-002):** acesso interno multi-estação definido; acesso externo de clientes **aceito como adiado** no MVP 1 (uso assistido). Confirmar detalhes em PEN-PB-006 antes de Arquitetura |
| RSK-003 | "Processo a criar" → requisitos instáveis, mudanças constantes durante o desenvolvimento | Alta | Alto | Entregas incrementais; validação frequente com usuário real |
| RSK-004 | Erros contábeis/fiscais gerados ou não detectados pelo sistema → passivo técnico/contábil para o contador titular | Alta | Muito alto | Auditoria de cálculo, trilha de auditoria, validações independentes + especialista de domínio contábil/fiscal para validar regras (ver RSK-008) |
| RSK-005 | Dados de clientes (pessoas jurídicas, movimentações financeiras) em ambiente restrito mal protegido; risco adicional de sigilo profissional contábil (CRC) e LGPD | Média | Alto | Modelagem de ameaças desde o Design de Segurança; princípio do menor privilégio; trilha de auditoria; classificação de dados |
| RSK-006 | Evidência de fonte única (solicitante) → produto construído sobre suposições não validadas com usuários reais | Alta | Alto | Entrevistar contador, auxiliar e 1–2 clientes antes do Product Definition completo |
| RSK-007 | Obrigações acessórias/fiscais mudam por norma → sistema desatualizado | Alta | Médio | Design de configuração/regras atualizáveis; escopo de obrigações limitado e explicitado |
| RSK-008 | Ausência de especialista de domínio contábil/fiscal para validar regras (ECD, ECF, SPED, DCTFWeb, NFS-e) → risco de regra incorreta não detectada | Alta | Muito alto | Validar HC da squad para domínio contábil; contar com contador titular como autoridade de domínio; revisões independentes de regra de negócio |
| RSK-009 | Multi-estação sem redundância/backup → perda de continuidade/dados do escritório | Média | Alto | **Atualizado (dec-002):** como o acesso passa a ser multi-estação, mitigar com backup automático e testado, exportação periódica, plano de recuperação e repositório central (decisão de Arquitetura) |

---

## 14. Incertezas

- **INC-001 — Escopo da 1ª versão:** indefinido; delegado à squad (EVD-010). Depende de HYP-001/HYP-003.
- **INC-002 — Como o escritório atende hoje <50 clientes sem ferramenta?** **Esclarecida (parcial):** o escritório **já opera**, execução mista (sócio + auxiliares), documentos via WhatsApp/Telegram (EVD-011…013). Resta entender rotina detalhada e regras de trabalho com auxiliares (PEN-007).
- **INC-003 — Prioridade entre as 6 dores:** não estabelecida (HYP-001).
- **INC-004 — Significado exato de "ambiente restrito":** **Esclarecida:** servidor próprio (on-premise), **sem bloqueio técnico real** — era receio de custo/nuvem (EVD-018). A decisão de expor/acessar fora do escritório (ex.: portal web dos clientes) será avaliada na Arquitetura com base em risco de exposição em endereço público (ver PEN-003).
- **INC-005 — Gestão dos clientes:** dor marcada, mas operação "painéis/indicadores" não marcada. É fim ou meio?
- **INC-006 — Capacidade de desenvolvimento:** **Esclarecida:** desenvolvedor será o próprio solicitante, programação básica, com tempo reservado e sem prazo rígido (EVD-016, EVD-017). Consequência: **restrição forte de complexidade** para a 1ª versão.
- **INC-007 — Regimes e obrigações específicas:** quais obrigações acessórias exatamente (ECD, ECF, DCTFWeb, SPED fiscal, NFS-e municipal…)? Define o sub-escopo de "obrigações".
- **INC-008 — Objetivo/métrica de sucesso e volumes:** **Esclarecida (base suficiente):** sucesso = menos erros/retrabalho + prazos cumpridos; volume baixo (até ~30 lançamentos/mês por cliente) (EVD-014, EVD-015). Métricas quantitativas finais a refinar na Product Definition.

---

## 15. Descobertas principais

### Descoberta 1 — O pedido é uma ferramenta interna, não um produto comercial
Sem venda inicial, não há necessidade (na 1ª versão) de multi-tenant, billing, onboarding de terceiros ou marketplace. Isso **reduz** o escopo técnico inicial e deve ser preservado como restrição de escopo.

### Descoberta 2 — O escopo desejado é maior do que a capacidade declarada
Quatro frentes complexas + 5 perfis de usuário + todas as dores, sob orçamento limitado. **A priorização não é opcional: é condição de viabilidade.**

### Descoberta 3 — Existe uma contradição estrutural não resolvida
Desktop Windows (interno) × clientes externos × comunicação com clientes. Essa tensão precisa ser resolvida como decisão de experiência/arquitetura **antes** da Arquitetura (HYP-004).

### Descoberta 4 — Há operação real informal para validar (não é greenfield de operação)
O escritório **já opera** com clientes (EVD-011), mas sem ferramenta estruturada: execução mista (sócio + auxiliares) e documentos via WhatsApp/Telegram (EVD-012, EVD-013). Isso elimina o receio de "não há o que observar" — há rotina real para ancorar requisitos. Continua sendo *greenfield* apenas no aspecto **ferramenta/dados** (sem migração legada). A validação com usuários reais (não só o dono) permanece obrigatória (RSK-006, PEN-007).

### Descoberta 5 — Validação e prazos são os candidatos prováveis ao núcleo de valor
As dores 1 (erros) e 5 (prazos) são as de maior consequência típica no domínio contábil brasileiro e estão entre as marcadas pelo solicitante — **porém todas as dores foram marcadas juntas**, de modo que isso permanece uma **inferência de domínio da squad**, não uma prioridade evidenciada. Requer validação (HYP-001, HYP-002).

---

## 16. Conclusões

### O que sabemos (fatos declarados, confiança medium)

- Escritório único, <50 clientes, Brasil, regimes federais, uso interno inicial.
- O escritório **já opera** com clientes de forma mista (sócio + auxiliares), sem ferramenta estruturada; documentos chegam via WhatsApp/Telegram (EVD-011…013).
- Restrições declaradas: orçamento limitado, **on-premise sem bloqueio técnico real**, Desktop Windows na 1ª versão; desenvolvedor único com programação básica (EVD-016, EVD-018).
- Sucesso declarado: menos erros/retrabalho + prazos cumpridos; volume baixo (EVD-014, EVD-015).
- Escopo desejado: escrituração, financeiro, NF, obrigações — **sem prioridade**.
- 6 dores listadas — **sem prioridade**.
- 5 perfis de usuário, incluindo clientes externos.

### O que acreditamos (hipóteses)

- Validação + prazos concentram o valor do MVP (HYP-002, reforçada por EVD-014).
- Desktop × clientes externos é a contradição que bloqueia Arquitetura (HYP-004).
- Escopo atual precisa ser cortado para caber na capacidade de desenvolvimento básica (RSK-001, EVD-016).

### O que ainda não sabemos

- Prioridade real entre dores (HYP-001, INC-003).
- Se escrituração completa é necessária na 1ª versão (HYP-003).
- Rotina detalhada de trabalho com auxiliares/contador (INC-002 parcialmente resolvida; PEN-007).
- Quais obrigações acessórias específicas (INC-007).
- Exposição/aplicação web a clientes externos (PEN-003) — decisão em aberto sobre arquitetura de acesso.

---

## 17. Recomendação

- [ ] Prosseguir para definição do produto.
- [x] Prosseguir com condições (ver pendências §21).
- [ ] Realizar investigação adicional.
- [ ] Validar hipótese específica.
- [ ] Reformular problema.
- [ ] Não prosseguir.

### Justificativa

O problema está **suficientemente enquadrado** para entrar em Product Definition **com pendências controladas**:

- PEN-001: a Product Definition **inicia** pelas etapas que não dependem de priorização (visão, público, valor); a priorização de MVP (HYP-001/HYP-003) é **condição de conclusão**, mas pode ocorrer dentro do workflow 02.
- PEN-002 e PEN-004 foram **resolvidas** (EVD-011…017): há operação real, execução mista, entrada via WhatsApp/Telegram, sucesso = menos erros/prazos, volume baixo, desenvolvedor único com programação básica. Não impõem mais bloqueio à consolidação do problema.
- HYP-004 (desktop × clientes) precisa estar **resolvida ou explicitamente adiada** antes de Arquitetura (PEN-003).
- RSK-006 (fonte única) exige, no mínimo, uma validação com o contador titular antes de Development (PEN-007).
- RSK-008 (capacidade de domínio contábil/fiscal da squad) deve ser tratada antes da definição de regras de negócio contábil/fiscal (PEN-006).
- A capacidade de desenvolvimento básica (EVD-016) é **restrição adicional forte**: reforça o corte agressivo de MVP (RSK-001).

A evidência atual é **auto-relato de fonte única** — suficiente para enquadrar, **insuficiente** para validar. Por isso: aprovação condicional, não absoluta.

---

## 18. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| — | Nenhuma (memoria/ vazia) | Primeira discovery do repositório |

---

## 19. Memórias candidatas

| Informação | Tipo | Evidência | Confiança | Motivo |
|---|---|---|---|---|
| Contexto do produto: escritório único, <50 clientes, Brasil, uso interno inicial, sem venda | contexto persistente | EVD-001, EVD-002 | medium | Condiciona todas as decisões futuras de escopo |
| Contexto operacional: já opera com clientes, documentação via WhatsApp/Telegram, execução mista | contexto persistente | EVD-011, EVD-012, EVD-013 | medium | Condiciona UX e fluxo de entrada de documentos |
| Restrições: orçamento limitado, ambiente restrito, Desktop Windows 1ª versão, desenvolvedor único com programação básica | contexto persistente / restrição | EVD-008, EVD-009, EVD-016 | medium | Condiciona Arquitetura, stack e corte de MVP |
| Risco: tensão Desktop × clientes externos × comunicação | risco | EVD-003 vs EVD-009 | medium | Precisa ser resolvido antes de Arquitetura |
| Risco: escopo amplo × capacidade de desenvolvimento | risco | EVD-004, EVD-006, EVD-016 | medium | Viabilidade do MVP depende disso |
| Aprendizado: evidência de fonte única (solicitante) sem validação com usuários reais | incerteza persistente | §7, §8 | high (como fato sobre o estado da discovery) | Próximos estágios precisam ampliar fontes |
| Objetivo de resultado declarado: menos erros/retrabalho + prazos cumpridos | contexto persistente (métrica inicial) | EVD-014 | medium | Norte para métricas do MVP |

**Não registradas (rejeitadas como memória):** as 6 dores como prioridade (não priorizadas); "desktop é a escolha certa" (decisão ainda tensionada por HYP-004); escopo desejado como escopo aprovado (depende de MVP).

---

## 20. Rastreabilidade

| Pergunta | Evidência | Hipótese | Descoberta | Decisão | Próximo artefato |
|---|---|---|---|---|---|
| Para quem é o software? | EVD-001, EVD-002 | — | Descoberta 1 | — | Product Brief |
| O que precisa resolver? | EVD-004, EVD-006 | HYP-001, HYP-002 | Descobertas 2 e 5 | Priorização pendente | MVP scoping (Product Definition) |
| Como será acessado? | EVD-003 vs EVD-009 | HYP-004 | Descoberta 3 | **Parcialmente resolvido (dec-002):** acesso interno multi-estação definido; cliente externo adiado (uso assistido). Modelo de implementação em aberto p/ Arquitetura | Decisão de experiência/arquitetura (PEN-PB-006) |
| Restrições? | EVD-008, EVD-009 | HYP-005 | Descobertas 1 e 2 | — | Arquitetura |

---

## 21. Pendências

| ID | Pendência | Responsável | Prioridade | Próxima ação | Status |
|---|---|---|---|---|---|
| PEN-001 | Priorizar as 6 dores e definir MVP (HYP-001, HYP-002, HYP-003) | Squad + solicitante | — | Resolvida via sessão de priorização: núcleo MVP = validação de lançamentos, controle de prazos/obrigações, gestão de clientes/pendências; escrituração formal, NF-e, SPED completo, folha/DP e portal do cliente **fora** do MVP 1. Entrada de documentos e financeiro básico não foram priorizados como núcleo (revisitar como evolução) | **resolvida** |
| PEN-002 | Esclarecer INC-002 (rotina real) e INC-008 (objetivo mensurável/volumes) | Solicitante | — | Resolvida via rodada de entrevista (EVD-011…015) | **resolvida** |
| PEN-003 | Resolver HYP-004: modelo de acesso. **Atualizado (dec-002):** acesso interno multi-estação **definido** (compartilhar com outro PC/notebook); **permanece aberto** o modelo de implementação (Arquitetura) e o caso externo cliente (adiado — uso assistido) | Squad (UX + Arquitetura) | **Alta — antes de Arquitetura (confirmar detalhes)** | Jornada do cliente (uso assistido) + decisão explícita de modelo de implementação | parcialmente resolvida |
| PEN-004 | Esclarecer INC-006: quem desenvolve, com que capacidade | Solicitante | — | Resolvida via rodada de entrevista (EVD-016, EVD-017) | **resolvida** |
| PEN-005 | Esclarecer INC-004: significado de "ambiente restrito" | Solicitante | — | Resolvida via pergunta direta (EVD-018: on-premise, sem bloqueio real) | **resolvida** |
| PEN-006 | Esclarecer INC-007: obrigações acessórias específicas da 1ª versão e validar capacidade de domínio (RSK-008) | Contador titular | Média — antes de requisitos detalhados | Entrevista com contador | aberta |
| PEN-007 | Validar pressupostos com ao menos 1 contador e 1 auxiliar (mitigar RSK-006) | Squad (UX Research) | Média — antes de Development | Entrevistas | aberta |
| PEN-008 | Levantamento rápido de referências/softwares do setor (Domínio, Contmatic, Mastermais etc.) e suas capacidades, para alimentar corte de escopo e evitar "inventar o processo" | Squad (UX Research + Product) | — | Benchmark concluído (artefato `projetos/imperacont/discovery/PEN-008-benchmark.md`); recomenda valid. lançamentos + prazos + gestão como núcleo e excluir NF-e/SPED/DP do MVP 1 (base para a decisão PEN-001) | **resolvida** |

---

## 22. Gate de Discovery

### Checklist

- [x] Objetivo da discovery está claro.
- [x] Perguntas principais foram investigadas (rodada 1 + rodada PEN-002/PEN-004).
- [x] Problema foi analisado e reformulado.
- [x] Usuários foram considerados (auto-relato; falta validação externa → PEN-007).
- [x] Evidências foram registradas (EVD-001…017, fonte única, confiança explicitada).
- [x] Observações foram separadas de interpretações (§9 vs §10).
- [x] Hipóteses foram explicitadas (HYP-001…006; HYP-006 parcialmente validada).
- [x] Oportunidades foram identificadas (OPP-001…003).
- [x] Riscos foram avaliados (RSK-001…009).
- [x] Incertezas permanecem explícitas (INC-001…008; INC-002/006/008 esclarecidas).
- [x] Recomendação foi fundamentada (§17).
- [x] Rastreabilidade foi estabelecida (§20).

### Resultado (após revisão independente e resolução de pendências)

- [x] Discovery concluída (rodada 1 + resolução PEN-002/PEN-004).
- [x] Prosseguir com condições → pendências restantes PEN-001, PEN-003, PEN-005…008 (§21).
- [ ] Prosseguir sem condições.
- [ ] Investigar novamente.
- [ ] Encerrar sem prosseguir.

### Justificativa

O bloqueio de entrada imposto por PEN-002/PEN-004 foi **removido**: a rodada de entrevista confirmou operação real e capacidade de desenvolvimento (EVD-011…017), suficientes para consolidar o problema na Product Definition. Permanecem condições controladas: PEN-001 (priorização de MVP, condição de conclusão da PD), PEN-003 (desktop × clientes, antes de Arquitetura), PEN-005/006/007/008 (entradas complementares). Ver §17.

---

## 23. Referências

- `workflows/01-discovery.md`
- `templates/discovery.md`
- Entrevista estruturada com o solicitante, 2026-09-22 (rodada 1: 4 blocos via questionário)
- Entrevista estruturada com o solicitante, 2026-09-22 (rodada PEN-002/PEN-004: 10 respostas via questionário)

---

## 24. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação — consolidação da rodada 1 de discovery | Squad Lead |
| 1.1 | 2026-09-22 | Incorporação das correções da revisão independente (P1–P10) | Squad Lead |
| 1.2 | 2026-09-22 | Resolução PEN-002/PEN-004; novas evidências EVD-011…017; atualização de contexto, hipóteses, incertezas, pendências e gate | Squad Lead |
| 1.4 | 2026-09-22 | Adendo de acesso (dec-002): EVD-009 superada em parte; RSK-002/RSK-009 atualizados; PEN-003 parcialmente resolvida; §9.1 criado — sincronia com PB-001 v1.1 | Squad Lead |
| 1.3 | 2026-09-22 | Resolução PEN-005 (EVD-018: on-premise, sem bloqueio real); atualização de incertezas, conclusões e pendências | Squad Lead |
