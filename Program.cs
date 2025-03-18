using Microsoft.EntityFrameworkCore;
using OnData.Data;
using OnData.Services;
using Microsoft.OpenApi.Models;
using System.Reflection;
using on_data_server_dotnet.service;

var builder = WebApplication.CreateBuilder(args);

// Configuração das URLs, incluindo as portas HTTP e HTTPS
builder.WebHost.UseUrls("http://localhost:5146", "https://localhost:7114");

// Registrar o singleton do AppConfigurationService
var configService = AppConfigurationService.GetInstance(builder.Configuration);
builder.Services.AddSingleton(configService);

// Configuração dos serviços, agora com suporte a Views
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<OnDataDbContext>(options =>
    options.UseOracle(configService.GetDatabaseConnectionString()));

// Configuração do Swagger para documentação da API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "OnData API", Version = "v1" });

    // Configuração do arquivo XML de documentação
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    if (System.IO.File.Exists(xmlPath))
    {
        c.IncludeXmlComments(xmlPath);
    }
    else
    {
        Console.WriteLine($"Arquivo XML de documentação não encontrado: {xmlPath}");
    }
});

// Injeção de dependência para os serviços
builder.Services.AddScoped<PacienteService>();
builder.Services.AddScoped<OcorrenciaService>();

var app = builder.Build();

// Configuração do pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Habilita o uso de arquivos estáticos na pasta wwwroot
app.UseStaticFiles();

// Habilitar o redirecionamento para HTTPS
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllers();

app.Run();