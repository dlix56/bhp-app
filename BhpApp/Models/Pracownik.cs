using Microsoft.AspNetCore.Identity;
using System;

namespace BhpApp.Models
{
    public class Pracownik : IdentityUser
    {
        public string Imie { get; set; } = string.Empty;
        public string Nazwisko { get; set; } = string.Empty;
        public bool CzyNaUrlopie { get; set; }

        public string NumerPracownika { get; set; } = string.Empty;
        public DateTime? DataUrodzenia { get; set; }
        public string Pesel { get; set; } = string.Empty;

        public string Ulica { get; set; } = string.Empty;
        public string NrBudynku { get; set; } = string.Empty;
        public string NrLokalu { get; set; } = string.Empty;
        public string KodPocztowy { get; set; } = string.Empty;
        public string Miasto { get; set; } = string.Empty;

        public string Dzial { get; set; } = string.Empty;
        public string Stanowisko { get; set; } = string.Empty;
        public string RodzajUmowy { get; set; } = string.Empty;
        public DateTime? DataZatrudnienia { get; set; }

        public string AktualnyPoziom { get; set; } = string.Empty;
        public string Zmiana { get; set; } = string.Empty;

        public bool CzyKierownikZespolu { get; set; }
        public bool CzyAktywny { get; set; }

        public string GrupaZaszeregowania { get; set; } = string.Empty;
        public string KontaktAwaryjnyNazwa { get; set; } = string.Empty;
        public string KontaktAwaryjnyTelefon { get; set; } = string.Empty;
        public string Notatki { get; set; } = string.Empty;
    }
}