using Microsoft.EntityFrameworkCore;
using Parcial1_AP1_EliezerTerrero.Components;
using Parcial1_AP1_EliezerTerrero.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var Constr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Contexto>(options => options.UseSqlite(Constr));
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
