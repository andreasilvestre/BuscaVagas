using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BuscaVagas.Data;
using BuscaVagas.Models;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BuscaVagasContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BuscaVagasContext") ?? throw new InvalidOperationException("Connection string 'BuscaVagasContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();


//alteração Andrea 14-07-22 ==> 
//string conexao = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BuscaVagas;TrustServerCertificate=True;Integrated Security=True";
////localhost\sqlexpress
//builder.Services.AddDbContext<BaseContext>
//    (options => options.UseSqlServer(conexao));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
