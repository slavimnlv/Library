using Library.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(
    option => { 
        option.LoginPath = "/Users/Login"; 
        option.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    });

builder.Services.AddDbContext<LibraryDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

builder.Services.AddScoped<BookRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<CategoryRepository>();
builder.Services.AddScoped<ReviewRepository>();



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Login}/{id?}");

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<LibraryDbContext>();
    dbContext.Database.Migrate();
}

app.Run();
