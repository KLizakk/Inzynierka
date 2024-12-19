using Inzynierka.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Inicjalizacja ról podczas uruchamiania aplikacji
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    // Wywo³anie metody inicjalizuj¹cej role
    await InitializeRolesAndUsersAsync(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
static async Task InitializeRolesAndUsersAsync(IServiceProvider serviceProvider)
{
    // Pobranie RoleManager i UserManager
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

    // Tworzenie roli "Kierowca"
    if (!await roleManager.RoleExistsAsync("Kierowca"))
    {
        await roleManager.CreateAsync(new IdentityRole("Kierowca"));
    }

    // Tworzenie u¿ytkownika testowego z rol¹ "Kierowca" (opcjonalne)
    var user = await userManager.FindByEmailAsync("test@example.com");
    if (user == null)
    {
        user = new IdentityUser
        {
            UserName = "test@example.com",
            Email = "test@example.com",
            EmailConfirmed = true
        };
        var result = await userManager.CreateAsync(user, "Test123!");
        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user, "Kierowca");
        }
    }
    // Tworzenie roli Admin
    if (!await roleManager.RoleExistsAsync("Admin"))
    {
        await roleManager.CreateAsync(new IdentityRole("Admin"));
    }

    // Tworzenie u¿ytkownika Admin
    var adminEmail = "admin@example.com";
    var adminUser = await userManager.FindByEmailAsync(adminEmail);
    if (adminUser == null)
    {
        adminUser = new IdentityUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
        await userManager.CreateAsync(adminUser, "Admin123!");
        await userManager.AddToRoleAsync(adminUser, "Admin");
    }
}