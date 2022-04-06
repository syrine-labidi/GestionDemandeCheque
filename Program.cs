using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GchequeWebApp.Data;
using GchequeWebApp.Areas.Identity.Data;
using GchequeWebApp.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("GchequeWebAppDBContextConnection");
builder.Services.AddDbContext<GchequeWebAppContext>(options =>
    options.UseSqlServer(connectionString));builder.Services.AddDbContext<DbChequeContext>(options =>options.UseSqlServer(connectionString));
builder.Services.AddDefaultIdentity<GchequeWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DbChequeContext>();



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<DbChequeContext>();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();


app.Run();
