using Microsoft.AspNetCore.Identity;

namespace BhpApp.Models
{
    public class Pracownik : IdentityUser
    {
        public string Imie { get; set; } = string.Empty;

        public string Nazwisko { get; set; } = string.Empty;
        public bool CzyNaUrlopie { get; set; } = false;
    }
}
