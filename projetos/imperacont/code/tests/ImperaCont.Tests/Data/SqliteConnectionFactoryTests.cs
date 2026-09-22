using ImperaCont.Web.Data;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;

namespace ImperaCont.Tests.Data;

/// <summary>
/// Testes do bootstrap da camada de dados (IN-00): configuração SQLite em modo WAL
/// com busy_timeout aplicado e defaults da configuração.
/// </summary>
public class SqliteConnectionFactoryTests
{
    [Fact]
    public void SqliteOptions_has_local_default_connection_string_and_busy_timeout()
    {
        var options = new SqliteOptions();

        Assert.Equal("Data Source=imperacont.db", options.ConnectionString);
        Assert.Equal(5000, options.BusyTimeoutMs);
    }

    [Fact]
    public async Task OpenAsync_opens_wal_with_configured_busy_timeout()
    {
        var dbPath = Path.Combine(Path.GetTempPath(), $"imperacont-wal-{Guid.NewGuid():N}.db");
        try
        {
            var factory = new SqliteConnectionFactory(
                Options.Create(new SqliteOptions
                {
                    ConnectionString = $"Data Source={dbPath}",
                    BusyTimeoutMs = 4321
                }));

            await using var connection = await factory.OpenAsync();

            await using var modeCommand = connection.CreateCommand();
            modeCommand.CommandText = "PRAGMA journal_mode;";
            var journalMode = (await modeCommand.ExecuteScalarAsync())?.ToString();

            await using var timeoutCommand = connection.CreateCommand();
            timeoutCommand.CommandText = "PRAGMA busy_timeout;";
            var busyTimeout = Convert.ToInt64(await timeoutCommand.ExecuteScalarAsync());

            Assert.Equal("wal", journalMode, ignoreCase: true);
            Assert.Equal(4321, busyTimeout);
        }
        finally
        {
            // Fecha conexões no pool antes de remover os arquivos temporários do teste.
            SqliteConnection.ClearAllPools();
            foreach (var file in new[] { dbPath, dbPath + "-wal", dbPath + "-shm" })
            {
                if (File.Exists(file))
                {
                    try { File.Delete(file); }
                    catch (IOException)
                    {
                        // Arquivo ainda em uso pelo pool; limpeza não deve falhar o teste.
                    }
                }
            }
        }
    }
}