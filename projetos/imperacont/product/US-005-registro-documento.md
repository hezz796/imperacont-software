---
title: User Story
type: user-story
status: draft
scope: project
version: 1
---

# US-005 — Registrar documento vinculado a pendência

## 1. Identificação

- **ID:** US-005
- **Título:** Equipe registra documento recebido vinculado a cliente/pendência
- **Épico:** Gestão de clientes e pendências
- **Feature:** Entrada de documentos em forma mínima (núcleo MVP — desvio justificado da PEN-001)
- **Produto:** ImperaCont
- **Status:** Draft
- **Prioridade:** Média
- **Responsável:** Business Analyst (a confirmar com contador)

---

## 2. História

> Como **equipe do escritório**, quero **registrar de forma simples um documento recebido de um cliente e vinculá-lo a uma pendência ou obrigação**, para **saber o que já chegou e o que ainda falta**.

---

## 3. Contexto

Dores 2 (comunicação) e 6 (pendências), tratadas em forma mínima (desvio justificado da PEN-001 — custo baixo, apoio à pendência, sem portal). Não substitui um fluxo de documentos sofisticado (fora do escopo). Documentos continuam chegando via WhatsApp/Telegram (EVD-013); o registro é no sistema.

---

## 4. Valor

### Valor para o usuário
Visão de "o que recebi" por cliente sem depender de WhatsApp.

### Valor para o negócio
Menos clientes incompletos; melhora visão de pendência.

### Resultado esperado
Documentos rastreáveis por cliente/pendência na visão de pendências.

---

## 5. Critérios de aceitação

### CA-001 — Registro mínimo

**Dado que** um cliente existe,
**Quando** registro um documento (descrição e/ou arquivo anexo) e situação,
**Então** o documento fica vinculado ao cliente, com autor, data e situação.

### CA-002 — Vínculo a pendência

**Dado que** registro um documento sem vínculo,
**Quando** existe uma pendência/obrigação associada a esse cliente,
**Então** posso vincular o documento à pendência existente (vínculo opcional); se a pendência ainda não existe, ela pode ser criada a partir do documento, refletindo a situação do documento.

### CA-003 — Situação atualizável

**Dado que** o documento foi registrado como pendente,
**Quando** recebo o documento e atualizo a situação para "recebido",
**Então** o status muda e a auditoria registra autor/data.

---

## 6. Regras de negócio

- RN-008 — Situação (recebido/pendente); vínculo a cliente/pendência/obrigação opcional.

---

## 7. Fluxo esperado

1. Seleciona cliente.
2. Registra descrição/arquivo + situação.
3. (Opcional) vincula a pendência/obrigação.
4. Salva.
5. Auditoria.

---

## 8. Cenários alternativos

- Documento recebido sem pendência associada (fica no cliente).
- Auxiliar registra, contador confere depois.

---

## 9. Exceções e erros

- Arquivo muito grande/duplicado → validação simples com mensagem (limite a definir).

---

## 10. Dependências

- RF-001 (cliente), RF-009 (pendência), RF-010 (documento).
- Limite de tamanho/tipos de anexo (decisão técnica de Arquitetura).

---

## 11. Fora do escopo

- Portal de envio pelo cliente; OCR/classificação automática; fluxo de aprovação sofisticado.

---

## 12. Evidências

| Evidência | Fonte | Data | Observação |
|---|---|---|---|
| EVD-013 | Solicitante | 2026-09-22 | Documentos via WhatsApp/Telegram |
| PEN-001 | Priorização | 2026-09-22 | Forma mínima (desvio registrado) |

---

## 13. Hipóteses

| Hipótese | Como validar | Status |
|---|---|---|
| Registro manual mínimo já alivia dor de pendência | Testar com atendimento (PEN-PB-003) | não testada |

---

## 14. Riscos

| Risco | Impacto | Mitigação |
|---|---|---|
| "Forma mínima" evolui para fluxo sofisticado (scope creep) | Baixo/médio | Manter critérios restritos; revisar em evolução |

---

## 15. Rastreabilidade

| Origem | Requisito | História | Design | Arquitetura | Implementação | Teste |
|---|---|---|---|---|---|---|
| PB-001 §11.1 + desvio PEN-001 | RF-010 | US-005 | UX-001 | TBD | TBD | Funcional |

---

## 16. Memória consultada

| ID | Memória | Influência |
|---|---|---|
| dec-001 | Escopo MVP | Forma mínima dentro; sofisticada fora |

---

## 17. Memória candidata

| Informação | Tipo | Motivo | Confiança |
|---|---|---|---|
| Forma mínima de documentos pode virar creep pós-MVP | risco | Acompanhar na evolução | medium |

---

## 18. Pronto para desenvolvimento

- [x] História compreendida.
- [x] Valor definido.
- [x] Critérios de aceitação definidos (provisórios).
- [x] Regras de negócio identificadas (simples).
- [x] Dependências identificadas.
- [x] Riscos conhecidos.
- [ ] Design necessário disponível.
- [ ] Arquitetura necessária disponível.
- [ ] Testabilidade confirmada (limite de anexo a definir).

### Resultado

- [ ] Pronta.
- [x] Pronta com ressalvas.
- [ ] Necessita refinamento.
- [ ] Bloqueada.

---

## 19. Resultado da implementação

**Implementação realizada:** (vazio)

**Arquivos/componentes afetados:** (vazio)

**Testes associados:** (vazio)

**Observações:** Depende de decisão de Arquitetura (armazenamento de anexos).

---

## 20. Referências

- `projetos/imperacont/product/REQ-001-requirements-mvp.md`
- `projetos/imperacont/product/PEN-001-priorizacao.md`

---

## 21. Histórico

| Versão | Data | Alteração | Responsável |
|---|---|---|---|
| 1.0 | 2026-09-22 | Criação | Squad Lead (subagente BA indisponível) |