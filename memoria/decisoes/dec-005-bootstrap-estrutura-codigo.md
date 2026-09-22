---
id: dec-005
type: decision
title: Estrutura física e convenções do bootstrap do ImperaCont (solução .NET, SQLite WAL, camada Data isolada)
status: active
confidence: high
created: 2026-09-22
source: execução do IN-00 (Workflow 05), verificação de gate independente (dotnet build/test verdes)
project: imperacont-software
---

# Estrutura física e convenções do bootstrap — ImperaCont

## Decisão

Após conclusão do IN-00 (bootstrap), a estrutura física e as convenções técnicas adotadas são:

1. **Código-fonte em `projetos/imperacont/code/`** (separado dos artefatos de processo `architecture/`, `discovery/`, `planning/`, `product/`), conforme esqueleto do PLN-001 §3:
   - `code/ImperaCont.sln` (formato `.sln` clássico — o template padrão do SDK 10 gera `.slnx`; recriado com `dotnet new sln --format sln`);
   - `code/src/ImperaCont.Web/` — ASP.NET Core Razor Pages (net10.0), com `Pages/`, `Models/`, `Data/`, `Services/` (subpastas por domínio), `Auth/`, `Backup/`, `Metrics/`, `Files/`;
   - `code/tests/ImperaCont.Tests/` — xUnit (net10.0), `ProjectReference` para o Web.
2. **Acesso a SQLite centralizado em `Data/`** (`SqliteConnectionFactory`, singleton via DI): único ponto de abertura de conexão (isola camada de dados para evolução a PostgreSQL — TD-001/RSK-ARC-001).
3. **PRAGMAs aplicados em toda abertura de conexão:**
   - `journal_mode=WAL` (ADR-002);
   - `busy_timeout` (default 5000 ms, configurável via `Database:BusyTimeoutMs`);
   - `foreign_keys=ON` (bônus de integridade para as tabelas de domínio; decisão explícita, não implícita).
4. **Connection string** padrão `Data Source=imperacont.db` em `appsettings.json` (`Database:ConnectionString`), sobrescrevível por env `Database__ConnectionString`.
5. **Sem TLS/HTS no pipeline** (template .NET 10 já não adiciona `UseHttpsRedirection`/HSTS) — coerente com transporte HTTP em LAN (EVD-019); `UseAuthorization()` mantido, sem efeito até IN-01.
6. **Sem EF Core no bootstrap** — `Microsoft.Data.Sqlite` 10.0.12 + Dapper 2.1.86 (ORM leve, conforme PLN-001 §1).
7. **Arquivos do banco (`*.db`, `*.db-wal`, `*.db-shm`) no `.gitignore`** — artefato local de execução, não versionado.

## Contexto

- IN-00 é o primeiro incremento do PLN-001 (Workflow 05); gate satisfeito: `dotnet build` e `dotnet test` verdes, smoke HTTP `/health` → 200.
- Objetivo da estrutura: fundação para os módulos C3/C5–C11 (IN-01+), com camada de dados desacoplada da lógica de negócio.

## Consequências

- Incrementos futuros (IN-01+) devem usar `SqliteConnectionFactory` para abrir conexões (garante WAL/busy_timeout/foreign_keys).
- Diretório do banco não é auto-criado no bootstrap — se um caminho configurado apontar para subpasta inexistente, a abertura falha (mitigação a definir em IN-02/IN-13 se necessário).
- Estrutura de pastas por domínio em `Services/` já pronta para os módulos C5–C9.

## Alternativas não escolhidas

- `.slnx` (formato padrão do SDK 10) — rejeitado em favor de `.sln` por compatibilidade/expectativa da estrutura exigida no PLN-001 §3.
- EF Core — rejeitado conforme plano (ORM leve Dapper no início).

## Rastreabilidade

- `projetos/imperacont/code/ImperaCont.sln` (estrutura real criada)
- `projetos/imperacont/planning/PLN-001-impl-plan.md` (§1, §3, IN-00)
- `projetos/imperacont/architecture/ARC-001-architecture.md` (ADR-002/003/010, DR-0012, EVD-019/020)
- `memoria/decisoes/dec-004-arquitetura-mvp-imperacont.md` (stack .NET 10 LTS)