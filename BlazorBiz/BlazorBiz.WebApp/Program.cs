using BlazorBiz.CasosDeUso.InterfacePlugins;
using BlazorBiz.CasosDeUso.Inventarios;
using BlazorBiz.CasosDeUso.Inventarios.Interfaces;
using BlazorBiz.CasosDeUso.Produtos;
using BlazorBiz.CasosDeUso.Produtos.Interfaces;
using BlazorBiz.PluginsTeste;
using BlazorBiz.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register the plugin repository for inventory management
builder.Services.AddSingleton<IInventarioRepositorio, InventarioRepositorio>();
builder.Services.AddTransient<IBuscarItemPorNome, BuscarItemPorNome>();
builder.Services.AddTransient<IBuscarItemPorID, BuscarItemPorID>();
builder.Services.AddTransient<IAdicionarItem, AdicionarItem>();
builder.Services.AddTransient<IEditarItem, EditarItem>();
builder.Services.AddTransient<IExcluirItem, ExcluirItem>();

// Register the plugin repository for product management
builder.Services.AddSingleton<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddTransient<IBuscarProdutoPorNome, BuscarProdutoPorNome>();
builder.Services.AddTransient<IBuscarProdutoPorID, BuscarProdutoPorID>();
builder.Services.AddTransient<IAdicionarProduto, AdicionarProduto>();
builder.Services.AddTransient<IEditarProduto, EditarProduto>();
builder.Services.AddTransient<IExcluirProduto, ExcluirProduto>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
