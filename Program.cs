using Microsoft.EntityFrameworkCore;
using GastosCore.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar configuración de Entity Framework Core con SQL Server
builder.Services.AddDbContext<GastosCoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GastosCoreDB"))
);

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
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
