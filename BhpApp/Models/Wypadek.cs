using System;
using System.ComponentModel.DataAnnotations;

namespace BhpApp.Models
{
    public class Wypadek
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Opis { get; set; } = string.Empty;

        // współrzędne
        public double WspolrzednaX { get; set; }
        public double WspolrzednaY { get; set; }

        public bool CzyPodziemne { get; set; } = true;

        public DateTime DataZgloszenia { get; set; } = DateTime.Now;

        // czy wniosek
        public string Status { get; set; } = "Wniosek";

        // kto zgłosił
        public string? ZglaszajacyId { get; set; }
        public Pracownik? Zglaszajacy { get; set; }
    }
}
