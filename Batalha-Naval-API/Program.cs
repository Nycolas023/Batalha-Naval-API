using Batalha_Naval_API.Services;
using Supabase;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Carrega configurações do appsettings.json
var supabaseUrl = builder.Configuration["Supabase:Url"];
var supabaseKey = builder.Configuration["Supabase:Key"]; // ← usa a chave correta ("Key")

var options = new SupabaseOptions
{
    AutoConnectRealtime = true
};

// Inicializa o cliente Supabase (se necessário em algum ponto do projeto)
var supabaseClient = new Client(supabaseUrl, supabaseKey, options);
await supabaseClient.InitializeAsync();

// Adiciona controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Configura o HttpClient com headers padrão para o Supabase
builder.Services.AddHttpClient<UsuarioService>((client) =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddHttpClient<BombService>((client) =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddHttpClient<MatchService>((client) =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddHttpClient<ShipService>((client) =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddHttpClient<ThemeService>((client) =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

var app = builder.Build();

// Middleware padrão
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
