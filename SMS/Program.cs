using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SMS.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SMSContextConnection") ?? throw new InvalidOperationException("Connection string 'SMSContextConnection' not found.");

builder.Services.AddDbContext<SMSContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SMSUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SMSContext>();

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

app.MapRazorPages();

app.Run();
