using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Data;
using VitalNutri.Models;
using VitalNutri.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    // Configurar as pol�ticas de senha
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 6; // M�nimo de 8 caracteres
    options.Password.RequiredUniqueChars = 0; // M�nimo de 6 caracteres diferentes}
}
)
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders().AddDefaultUI();


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("Admin", policy =>
    {
     policy.RequireRole("Admin");
    });

    options.AddPolicy("Cliente", policy =>
    {
        policy.RequireRole("Cliente");
    });

    options.AddPolicy("Nutricionista", policy =>
    {
        policy.RequireRole("Nutricionista");
    });

    options.AddPolicy("TreinadorPessoal", policy =>
    {
        policy.RequireRole("TreinadorPessoal");
    });
});



builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AlimentoService>();
builder.Services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

CriarPerfisUsuarios(app);

app.UseAuthentication();
app.UseAuthorization();

#pragma warning disable ASP0014
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "cliente",
    pattern: "{area:exists}/{controller=Cliente}/{action=Index}/{id?}");


    endpoints.MapControllerRoute(
    name: "ClienteArea",
    pattern: "Cliente/{action=Index}/{id?}",
    defaults: new { area = "Cliente", controller = "Cliente" });

    endpoints.MapControllerRoute(
    name: "NutricionistaAlimento",
    pattern: "Nutricionista/Alimento/{action=Index}/{id?}",
    defaults: new { area = "Nutricionista", controller = "Alimento" });

    endpoints.MapControllerRoute(
    name: "treinadorpessoal",
    pattern: "{area:exists}/{controller=TreinadorPessoal}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});



app.MapRazorPages();

app.Run();

void CriarPerfisUsuarios(WebApplication app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory?.CreateScope())
    {
        var service = scope?.ServiceProvider.GetService<ISeedUserRoleInitial>();
        service?.SeedRoles();
        service?.SeedUsers();
    }
}