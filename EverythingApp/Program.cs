using EverythingApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 1. ADD THIS SECTION: Set your development HTTPS port (e.g., 7001 or 7123 from your launchSettings.json)
builder.Services.AddHttpsRedirection(options =>
{
    options.HttpsPort = 7001; // Change 7001 to match your HTTPS port in launchSettings.json
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseHttpsRedirection(); // Only force HTTPS in Production
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();