using Batalha_Naval_API.Services;
using Supabase;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

var supabaseUrl = builder.Configuration["Supabase:Url"];
var supabaseKey = builder.Configuration["Supabase:Key"];

var options = new SupabaseOptions
{
    AutoConnectRealtime = true
};

var supabaseClient = new Client(supabaseUrl, supabaseKey, options);
await supabaseClient.InitializeAsync();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient<ConsultaService>(client =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddHttpClient<CadastroService>(client =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddHttpClient<CompraService>(client =>
{
    client.BaseAddress = new Uri(supabaseUrl!);
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
});

builder.Services.AddSingleton(supabaseClient);
builder.Services.AddScoped<DeletesService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();



//builder.Services.AddHttpClient<UsuarioService>((client) =>
//{
//    client.BaseAddress = new Uri(supabaseUrl!);
//    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
//    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
//});

//builder.Services.AddHttpClient<BombService>((client) =>
//{
//    client.BaseAddress = new Uri(supabaseUrl!);
//    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
//    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
//});

//builder.Services.AddHttpClient<MatchService>((client) =>
//{
//    client.BaseAddress = new Uri(supabaseUrl!);
//    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
//    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
//});

//builder.Services.AddHttpClient<ShipService>((client) =>
//{
//    client.BaseAddress = new Uri(supabaseUrl!);
//    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
//    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
//});

//builder.Services.AddHttpClient<ThemeService>((client) =>
//{
//    client.BaseAddress = new Uri(supabaseUrl!);
//    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
//    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
//});
