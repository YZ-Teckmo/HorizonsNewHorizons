using Database;
using OriginsNewHorizons.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddHttpClient();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.UseRouting();
app.MapControllers();

app.UseAntiforgery();


app.MapStaticAssets();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

var context = new DatabaseContext();
context.Database.EnsureCreated();

app.Run();
