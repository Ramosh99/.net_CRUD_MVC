using Microsoft.EntityFrameworkCore;
using Project01.Data;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//we want to add entitiy frmework
builder.Services.AddDbContext<ApplicationDbContext>(options=>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
// this may injection of services

// Configure the HTTP request pipeline.
//if envirionment not in development then put exception
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//this enable static file in root
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//how rout should work | '?' use when we can define variable or not
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//run project
app.Run();
