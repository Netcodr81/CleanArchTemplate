using CleanArchTemplate.BlazorWebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
#if (UseAuto)
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
#elif (UseServer)
    .AddInteractiveServerComponents();
#elif (UseWebAssembly)
    .AddInteractiveWebAssemblyComponents();
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.
#if (UseWebAssembly)
if (app.Environment.IsDevelopment())
{
#if (UseWebAssembly)
    app.UseWebAssemblyDebugging();
#endif
}
else
#else
if (!app.Environment.IsDevelopment())
#endif
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

#if (UseAuto)
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode();
#elif (UseServer)
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
#elif (UseWebAssembly)
app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
#endif
#if (UseWebAssembly)
  .AddAdditionalAssemblies(typeof(CleanArchTemplate.BlazorWebApp.Client._Imports).Assembly);
#endif
app.Run();