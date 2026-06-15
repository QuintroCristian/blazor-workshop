using blazor_workshop.Components;
using blazor_workshop.Models;
using Microsoft.AspNetCore.Http.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registra HttpClient como un servicio.
// Esta es una forma más simple y segura para Blazor Server.
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        // Asegúrate de que esta URL coincida con la de tu aplicación.
        // Puedes verla en la barra de direcciones cuando depuras.
        BaseAddress = new Uri("https://localhost:44378")
    });


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