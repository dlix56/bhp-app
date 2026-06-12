using Microsoft.AspNetCore.Identity;
using BhpApp.Models;

namespace BhpApp.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndUsersAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<Pracownik>>();

            string[] roleNames = { "AdminBHP", "Pracownik" };
            foreach (var roleName in roleNames)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            if (await userManager.FindByEmailAsync("admin@bhp.pl") == null)
            {
                var admin = new Pracownik
                {
                    UserName = "admin@bhp.pl",
                    Email = "admin@bhp.pl",
                    Imie = "Jan",
                    Nazwisko = "Kowalski",
                    CzyNaUrlopie = false,
                    EmailConfirmed = true 
                };
                var result = await userManager.CreateAsync(admin, "Admin123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "AdminBHP");
                }
            }

            if (await userManager.FindByEmailAsync("gornik@bhp.pl") == null)
            {
                var pracownik = new Pracownik
                {
                    UserName = "gornik@bhp.pl",
                    Email = "gornik@bhp.pl",
                    Imie = "Piotr",
                    Nazwisko = "Nowak",
                    CzyNaUrlopie = false,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(pracownik, "Gornik123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(pracownik, "Pracownik");
                }
            }
        }
    }
}