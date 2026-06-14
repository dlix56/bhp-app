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
            if (await userManager.FindByEmailAsync("urlop@bhp.pl") == null)
            {
                var urlopowicz = new Pracownik
                {
                    UserName = "urlop@bhp.pl",
                    Email = "urlop@bhp.pl",
                    Imie = "Tomek",
                    Nazwisko = "Działowy",
                    CzyNaUrlopie = true,
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(urlopowicz, "Urlop123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(urlopowicz, "Pracownik");
                }
            }

            var csvPath = Path.Combine(Directory.GetCurrentDirectory(), "pracownicy_demo_1200.csv");

            if (File.Exists(csvPath))
            {
                var lines = await File.ReadAllLinesAsync(csvPath);

                for (int i = 1; i < lines.Length; i++)
                {
                    var line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var data = line.Split(',');

                    if (data.Length >= 24)
                    {
                        var email = data[6].Trim();

                        if (await userManager.FindByEmailAsync(email) == null)
                        {
                            var pracownik = new Pracownik
                            {
                                NumerPracownika = data[0].Trim(),
                                Imie = data[1].Trim(),
                                Nazwisko = data[2].Trim(),
                                DataUrodzenia = DateTime.TryParse(data[3], out var dUr) ? dUr : null,
                                Pesel = data[4].Trim(),
                                PhoneNumber = data[5].Trim(),
                                Email = email,
                                UserName = email,
                                Ulica = data[7].Trim(),
                                NrBudynku = data[8].Trim(),
                                NrLokalu = data[9].Trim(),
                                KodPocztowy = data[10].Trim(),
                                Miasto = data[11].Trim(),
                                Dzial = data[12].Trim(),
                                Stanowisko = data[13].Trim(),
                                RodzajUmowy = data[14].Trim(),
                                DataZatrudnienia = DateTime.TryParse(data[15], out var dZat) ? dZat : null,
                                AktualnyPoziom = data[16].Trim(),
                                Zmiana = data[17].Trim(),
                                CzyKierownikZespolu = data[18].Trim().ToUpper() == "TAK",
                                CzyAktywny = data[19].Trim().ToUpper() == "TAK",

                                CzyNaUrlopie = data[19].Trim().ToUpper() != "TAK",
                                GrupaZaszeregowania = data[20].Trim(),
                                KontaktAwaryjnyNazwa = data[21].Trim(),
                                KontaktAwaryjnyTelefon = data[22].Trim(),
                                Notatki = data[23].Trim(),
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
        }
    }
}