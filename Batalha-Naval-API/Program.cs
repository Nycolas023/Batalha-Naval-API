using Batalha_Naval_API.Services;
using Supabase;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configurar Supabase
var supabaseUrl = builder.Configuration["Supabase:Url"];
var supabaseKey = builder.Configuration["Supabase:Key"];
var options = new SupabaseOptions
{
    AutoConnectRealtime = true
};
// Registrar serviços
//builder.Services.AddSingleton(supabaseClient);
//builder.Services.AddScoped<IUsuarioService, UsuarioService>();


var supabaseClient = new Client(supabaseUrl, supabaseKey, options);
await supabaseClient.InitializeAsync();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
