using System.Reflection;
using StaticWebApp;
using StaticWebApp.Components;
using StaticWebApp.Components.Htmx;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

// Add Htmx services
builder.Services.AddSingleton<HxCounterState>();

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

app.MapRazorComponents<App>();
// app.MapHtmxEndpoints();

// Map Htmx components
// Scan for all components that implement IHasEndpoints and map their endpoints
Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(t => t is { IsClass: true, IsAbstract: false } && typeof(IHasEndpoints).IsAssignableFrom(t))
    .Select(t => t.GetMethod("MapEndpoints", BindingFlags.Public | BindingFlags.Static))
    .Where(m => m != null)
    .Cast<MethodInfo>()
    .ToList()
    .ForEach(m => m.Invoke(null, [app]));

app.Run();