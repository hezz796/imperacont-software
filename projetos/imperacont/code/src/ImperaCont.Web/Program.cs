using Dapper;
using ImperaCont.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Razor Pages (templates server-side; sem SPA no MVP — ADR-010/dec-004).
builder.Services.AddRazorPages();

// Configuração da base SQLite (seção "Database"; default local "imperacont.db").
builder.Services.AddOptions<SqliteOptions>()
    .Bind(builder.Configuration.GetSection(SqliteOptions.SectionName))
    .Validate(o => !string.IsNullOrWhiteSpace(o.ConnectionString),
        "Database:ConnectionString é obrigatória.");

builder.Services.AddSingleton<SqliteConnectionFactory>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseRouting();

// Sem autenticação no bootstrap (IN-01); middleware deixado pronto para o próximo incremento.
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

// Health base (gate IN-00): verifica que o SQLite abre em modo WAL e responde OK.
app.MapGet("/health", async (SqliteConnectionFactory factory, CancellationToken cancellationToken) =>
{
    try
    {
        await using var connection = await factory.OpenAsync(cancellationToken);

        var one = await connection.QueryFirstAsync<int>("SELECT 1;");
        var journalMode = await connection.QueryFirstAsync<string>("PRAGMA journal_mode;");

        return one == 1
            && string.Equals(journalMode, "wal", StringComparison.OrdinalIgnoreCase)
            ? Results.Text("OK", "text/plain")
            : Results.Text("ERROR", "text/plain", statusCode: StatusCodes.Status500InternalServerError);
    }
    catch (Exception ex)
    {
        return Results.Text($"ERROR: {ex.Message}", "text/plain", statusCode: StatusCodes.Status500InternalServerError);
    }
});

app.Run();