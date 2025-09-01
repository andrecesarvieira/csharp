using Microsoft.EntityFrameworkCore;
using SharpPontoWeb.Data;
using SharpPontoWeb.Interfaces;
using SharpPontoWeb.Repositories;
using SharpPontoWeb.Services;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:8080");

// Registrar o contexto do banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro de repositórios
builder.Services.AddScoped<IRegistroRepository, RegistroRepository>();
// Registro de serviços
builder.Services.AddScoped<RegistroService, RegistroService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
