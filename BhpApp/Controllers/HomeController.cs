using Microsoft.AspNetCore.Mvc;
using BhpApp.Data;
using BhpApp.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace BhpApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var zapisaneWypadki = _context.Wypadki.ToList();

            var listaPracownikow = _context.Users
                .Select(p => new { p.Id, Nazwa = p.Imie + " " + p.Nazwisko + " (" + p.NumerPracownika + ")" })
                .ToList();
            ViewBag.Pracownicy = listaPracownikow;

            var podZiemia = _context.Users
                .Where(p => !string.IsNullOrEmpty(p.AktualnyPoziom) && p.AktualnyPoziom != "Powierzchnia")
                .OrderBy(p => p.AktualnyPoziom)
                .ToList();

            ViewBag.PodZiemia = podZiemia;
            ViewBag.PodZiemiaCount = podZiemia.Count;

            return View(zapisaneWypadki);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DodajWypadek(double WspolrzednaX, double WspolrzednaY, string Opis, string Strefa)
        {
            if (string.IsNullOrEmpty(Opis))
            {
                return BadRequest("Opis nie mo¿e byæ pusty.");
            }

            var aktualnyUzytkownikId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var nowyWypadek = new Wypadek
            {
                WspolrzednaX = WspolrzednaX,
                WspolrzednaY = WspolrzednaY,
                Opis = Opis,
                Strefa = Strefa,
                DataZgloszenia = DateTime.Now,
                Status = "Wniosek",
                CzyPodziemne = true,
                ZglaszajacyId = aktualnyUzytkownikId
            };

            _context.Wypadki.Add(nowyWypadek);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Authorize(Roles = "AdminBHP")]
        public async Task<IActionResult> ZatwierdzProtokol(int WypadekId, string PoszkodowanyId, string Zmiana, DateTime DataWypadku)
        {
            var wypadekIdzBazy = await _context.Wypadki.FindAsync(WypadekId);

            if (wypadekIdzBazy != null)
            {
                wypadekIdzBazy.PoszkodowanyId = PoszkodowanyId;
                wypadekIdzBazy.Zmiana = Zmiana;
                wypadekIdzBazy.DataWypadku = DataWypadku;
                wypadekIdzBazy.Status = "Zatwierdzony";

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Authorize(Roles = "Pracownik")]
        public async Task<IActionResult> DodajKomentarz(int WypadekId, string Komentarz)
        {
            var wypadekIdzBazy = await _context.Wypadki.FindAsync(WypadekId);

            if (wypadekIdzBazy != null)
            {
                wypadekIdzBazy.KomentarzPoszkodowanego = Komentarz;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}