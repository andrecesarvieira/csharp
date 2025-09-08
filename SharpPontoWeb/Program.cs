using Microsoft.EntityFrameworkCore;
using SharpPontoWeb.Data;
using SharpPontoWeb.Interfaces;
using SharpPontoWeb.Repositories;
using SharpPontoWeb.Services;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:8080");

// Registrar o contexto do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
    ));

// Registro de repositórios
builder.Services.AddScoped<IRegistroRepository, RegistroRepository>();
// Registro de serviços
builder.Services.AddScoped<RegistroService, RegistroService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapRazorPages().WithStaticAssets();

app.Run();