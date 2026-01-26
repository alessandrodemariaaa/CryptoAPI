var builder = WebApplication.CreateBuilder(args);

// Lägg till stöd för Controllers (så att ditt API hittar CryptoController)
builder.Services.AddControllers();

// Registrera din CryptoService så att den kan användas i projektet
builder.Services.AddScoped<CryptoApi.CryptoService>();

var app = builder.Build();

// Mappa kontrollerna så att dina endpoints (encrypt/decrypt) blir nåbara
app.MapControllers();

// Enkel hälsningsfras på startsidan så du ser att API:et lever
app.MapGet("/", () => "Crypto API is running! Use /crypto/encrypt/{text} to test.");

app.Run();