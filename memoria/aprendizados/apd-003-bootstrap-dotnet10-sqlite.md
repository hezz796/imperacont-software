---
id: apd-003
type: learning
title: Pegadinhas técnicas do bootstrap .NET 10 + SQLite (Dapper/Sqlite — ImperaCont IN-00)
status: active
confidence: high
created: 2026-09-22
source: execução do IN-00 (bootstrap), verificação de gate (build/test/smoke)
project: imperacont-software
---

# Pegadinhas técnicas — .NET 10 + Microsoft.Data.Sqlite + Dapper

## Aprendizado

Durante o bootstrap do ImperaCont (IN-00), foram observadas limitações/fatos técnicos que impactam as decisões de implementação futura:

1. **`dotnet new sln` no SDK 10 gera `.slnx` por padrão** — para gerar `.sln` clássico, usar `dotnet new sln --format sln`. A squad registrada aqui para não surpreender nos próximos projetos.
2. **Dapper 2.1.86: `QueryFirstAsync`/`QueryAsync` não aceitam `CancellationToken` em todos os overloads (erro CS1739 em chamadas triviais)** — a camada de dados (IN-02+) deve abrir com `OpenAsync(ct)` e passar `ct` apenas onde o overload existir; não assumir suporte universal a token no Dapper.
3. **`Microsoft.Data.Sqlite` 10.x não expõe `ExecuteScalarAsync` em `SqliteConnection`** — para executar escalar assíncrono, usar ADO.NET puro via `DbCommand.ExecuteScalarAsync` (foi a solução usada no teste).
4. **PRAGMA `foreign_keys=ON` adicional** (além de WAL/busy_timeout) aplicado em toda abertura — decidido no IN-00, deve ser mantido (ver dec-005).
5. **Transiente na 1ª restauração de pacote `SQLitePCLRaw.lib.e_sqlite3`**: houve falha de download ("decryption operation failed") resolvida no retry automático — não é erro estrutural do projeto.
6. **Smoke test HTTP via `dotnet run --project src/ImperaCont.Web`** — funcionou em `http://127.0.0.1:PORT`; `/health` responde 200 text/plain; processo encerrado com `taskkill /PID ... /T /F` (evitar processo órfão da nt).

## Decisão de processo adotada

- Para a camada de dados real (IN-02+), planejar testes de integração usando os padrões ADO.NET puros onde o Dapper/sqlite não oferecer overload com token; registrar explicitamente os cenários em que o token não é propagado.
- Incluir sempre `--nologo -v q` e capturar portas para smoke tests, encerrando processos a cada execução.

## Riscos conhecidos

- Uso inconsistente de `CancellationToken` na camada Dapper → deadlocks/falsos positivos em testes. Mitigação: centralizar acesso em `Data/SqliteConnectionFactory` (dec-005) e revisar cada incremento de escrita.
- Dependência do transiente do SQLitePCLRaw na primeira restauração em máquina limpa (re-tentar automaticamente se ocorrer).

## Origem

- Execução do IN-00 no projeto imperacont-software, 2026-09-22; relatório do software-engineer e verificação independente do Squad Lead.

## Rastreabilidade

- `projetos/imperacont/code/` (solução criada)
- `projetos/imperacont/code/tests/ImperaCont.Tests/Data/SqliteConnectionFactoryTests.cs`
- `memoria/decisoes/dec-005-bootstrap-estrutura-codigo.md`
- `projetos/imperacont/planning/PLN-001-impl-plan.md` (IN-00)