using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;

namespace ImperaCont.Web.Data;

/// <summary>
/// Abre conexões SQLite já configuradas para o modo WAL com busy_timeout
/// (ADR-002/ADR-003, dec-004). Os PRAGMAs são reaplicados a cada conexão porque
/// busy_timeout é por conexão e journal_mode=WAL é persistido no arquivo do banco.
/// </summary>
public sealed class SqliteConnectionFactory
{
    private readonly SqliteOptions _options;

    public SqliteConnectionFactory(IOptions<SqliteOptions> options)
        => _options = options.Value;

    public SqliteConnection CreateConnection()
        => new(_options.ConnectionString);

    public async Task<SqliteConnection> OpenAsync(CancellationToken cancellationToken = default)
    {
        var connection = CreateConnection();
        try
        {
            await connection.OpenAsync(cancellationToken);

            // Modo WAL: leitura durante escrita e escrita serializada (ADR-002).
            // journal_mode retorna uma linha ("wal"); ExecuteScalar descarta o resultado.
            await using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA journal_mode=WAL;";
                await command.ExecuteScalarAsync(cancellationToken);
            }

            // busy_timeout: evita SQLITE_BUSY imediato em contenda de escrita (ADR-003).
            await using (var command = connection.CreateCommand())
            {
                command.CommandText = $"PRAGMA busy_timeout = {_options.BusyTimeoutMs};";
                await command.ExecuteNonQueryAsync(cancellationToken);
            }

            // Chaves estrangeiras ON: prepara a integridade das tabelas de domínio (IN-02+).
            await using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA foreign_keys = ON;";
                await command.ExecuteNonQueryAsync(cancellationToken);
            }

            return connection;
        }
        catch
        {
            await connection.DisposeAsync();
            throw;
        }
    }
}