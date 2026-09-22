namespace ImperaCont.Web.Data;

/// <summary>
/// Configurações da base SQLite (seção "Database" do appsettings.json).
/// O caminho do arquivo é definido pela connection string e pode ser
/// sobrescrito por configuração (ex.: variável de ambiente Database__ConnectionString).
/// </summary>
public sealed class SqliteOptions
{
    public const string SectionName = "Database";

    /// <summary>
    /// Connection string SQLite. Default: arquivo local "imperacont.db"
    /// criado no diretório de conteúdo da aplicação (bootstrap).
    /// </summary>
    public string ConnectionString { get; set; } = "Data Source=imperacont.db";

    /// <summary>
    /// PRAGMA busy_timeout em milissegundos: tempo que a conexão aguarda
    /// quando há contenda de escrita antes de reportar SQLITE_BUSY (ADR-003).
    /// </summary>
    public int BusyTimeoutMs { get; set; } = 5000;
}