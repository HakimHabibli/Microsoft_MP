using Microsoft.EntityFrameworkCore;
using MVC_.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVC_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVC_Context") ?? throw new InvalidOperationException("Connection string 'MVC_Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
