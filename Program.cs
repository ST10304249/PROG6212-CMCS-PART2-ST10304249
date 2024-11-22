using Prog_P2.Models;
using Prog_P2.Services; 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("CMCSDatabase"));

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddSignalR(); 
builder.Services.AddScoped<IUserService, UserService>(); 

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapHub<ClaimHub>("/claimHub");

app.Run();

