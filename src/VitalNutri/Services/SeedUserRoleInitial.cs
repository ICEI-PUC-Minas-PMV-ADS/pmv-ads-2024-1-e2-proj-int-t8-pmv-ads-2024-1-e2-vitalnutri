using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Data;
using VitalNutri.Models;

namespace VitalNutri.Services;

public class SeedUserRoleInitial : ISeedUserRoleInitial
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _dbContext;

    public SeedUserRoleInitial(UserManager<IdentityUser> userManager, 
        RoleManager<IdentityRole> roleManager,
            ApplicationDbContext dbContext)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _dbContext = dbContext;
    }

    public void SeedRoles()
    {
        if(!_roleManager.RoleExistsAsync("Nutricionista").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Nutricionista";
            role.NormalizedName = "NUTRICIONISTA";
            IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
        }
        if (!_roleManager.RoleExistsAsync("Cliente").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "Cliente";
            role.NormalizedName = "CLIENTE";
            IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
        }
        if (!_roleManager.RoleExistsAsync("TreinadorPessoal").Result)
        {
            IdentityRole role = new IdentityRole();
            role.Name = "TreinadorPessoal";
            role.NormalizedName = "TREINADORPESSOAL";
            IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
        }
    }

    public void SeedUsers()
    {
        if (_userManager.FindByEmailAsync("treinador@vitalnutri.com").Result == null)
        {
            Usuario user = new Usuario();
            user.UserName = "treinador@vitalnutri.com";
            user.Email = "treinador@vitalnutri.com";
            user.NormalizedUserName = "TREINADOR@VITALNUTRI.COM";
            user.NormalizedEmail = "TREINADOR@VITALNUTRI.COM";
            user.EmailConfirmed = false;
            user.LockoutEnabled = false;
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.TipoUsuario = "TreinadorPessoal";

            IdentityResult result = _userManager.CreateAsync(user, "123456").Result;

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "TreinadorPessoal").Wait();
                var treinadorPessoal = new Models.TreinadorPessoal
                {
                    Id = user.Id,
                };

                _dbContext.TreinadoresPessoais.Add(treinadorPessoal);
                //_dbContext.SaveChangesAsync();
            }

        }

        if (_userManager.FindByEmailAsync("nutricionista@vitalnutri.com").Result == null)
        {
            Usuario user = new Usuario();
            user.UserName = "nutricionista@vitalnutri.com";
            user.Email = "nutricionista@vitalnutri.com";
            user.NormalizedUserName = "NUTRICIONISTA@VITALNUTRI.COM";
            user.NormalizedEmail = "NUTRICIONISTA@VITALNUTRI.COM";
            user.EmailConfirmed = false;
            user.LockoutEnabled = false;
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.TipoUsuario = "Nutricionista";

            IdentityResult result = _userManager.CreateAsync(user, "123456").Result;

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "Nutricionista").Wait();
                var nutricionista = new Models.Nutricionista
                {
                    Id = user.Id,
                };

                _dbContext.Nutricionistas.Add(nutricionista);
                //_dbContext.SaveChangesAsync();
            }
        }

        if (_userManager.FindByEmailAsync("cliente@vitalnutri.com").Result == null)
        {
            Usuario user = new Usuario();
            user.UserName = "cliente@vitalnutri.com";
            user.Email = "cliente@vitalnutri.com";
            user.NormalizedUserName = "CLIENTE@VITALNUTRI.COM";
            user.NormalizedEmail = "CLIENTE@VITALNUTRI.COM";
            user.EmailConfirmed = false;
            user.LockoutEnabled = false;
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.TipoUsuario = "Cliente";

            IdentityResult result = _userManager.CreateAsync(user, "123456").Result;

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "Cliente").Wait();
                var cliente = new Models.Cliente
                {
                    Id = user.Id,
                };

                _dbContext.Clientes.Add(cliente);
                
            }
        }

        _dbContext.SaveChangesAsync();


        //if (_userManager.FindByEmailAsync("admin@localhost").Result == null)
        //{
        //    IdentityUser user = new IdentityUser();
        //    user.UserName = "admin@localhost";
        //    user.Email = "admin@localhost";
        //    user.NormalizedUserName = "ADMIN@LOCALHOST";
        //    user.NormalizedEmail = "ADMIN@LOCALHOST";
        //    user.EmailConfirmed = true;
        //    user.LockoutEnabled = false;
        //    user.SecurityStamp = Guid.NewGuid().ToString();

        //    IdentityResult result = _userManager.CreateAsync(user, "Numsey#2022").Result;

        //    if (result.Succeeded)
        //    {
        //        _userManager.AddToRoleAsync(user, "Admin").Wait();
        //    }
        //}
    }
}
