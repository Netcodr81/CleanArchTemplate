using CleanArchTemplate.BlazorWebApp.Components;
#if (UseAuthorization && UseNone)
using Microsoft.AspNetCore.Components.Server;
#endif
#if (UseAuthorization)
using CleanArchTemplate.BlazorWebApp.Data;
using CleanArchTemplate.BlazorWebApp.Components.Account;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
#endif

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#if (UseAuto)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
#elif (UseServer)
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
#elif (UseWebAssembly)
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();
#elif (UseNone)
    builder.Services.AddRazorComponents();
#endif

#if (UseAuthorization)
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();


builder.Services.AddAuthorization();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
#endif

#if (UseAuthorization && UseNone)
builder.Services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
#else
builder.Services.AddScoped<AuthenticationStateProvider, PersistingRevalidatingAuthenticationStateProvider>();
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
#elif (UseNone)
app.MapRazorComponents<App>();
#endif
#if (UseWebAssembly)
  .AddAdditionalAssemblies(typeof(CleanArchTemplate.BlazorWebApp.Client._Imports).Assembly);
#endif

#if (UseAuthorization)
app.MapAdditionalIdentityEndpoints();
#endif
app.Run();