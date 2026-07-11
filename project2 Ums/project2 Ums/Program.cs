using Microsoft.EntityFrameworkCore;
using project2_Ums.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var cs = builder.Configuration.GetConnectionString("UmsDbContext"); //UmsDbContext-->
builder.Services.AddDbContext<UmsDbContext>(e => e.UseSqlServer(cs)); //UmsDbContext-->class

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Faculty}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
