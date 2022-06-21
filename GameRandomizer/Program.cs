using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GameRandomizer.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<GameRandomizerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GameRandomizerContext") ?? throw new InvalidOperationException("Connection string 'GameRandomizerContext' not found.")));


builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Games}/{action=Index}/{id?}");

app.Run();
