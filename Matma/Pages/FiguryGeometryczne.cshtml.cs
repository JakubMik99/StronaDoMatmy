using Matma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Matma.Calculations;


namespace MyApp.Namespace
{
    public class FiguryGeometryczneModel : PageModel
    {
        [BindProperty]
        public SquareModel Figura { get; set; }
        
        
        public void OnGet()
        {
        }
        public IActionResult OnPostObliczKwadrat()
        {
            ViewData["kwadrat"] = Geometria.WynikKwadrat(Figura.KwadratBok,Figura.KwadratPrzekatna);
            return Page();
        }
        public IActionResult OnPostObliczProstokat()
        {
            ViewData["prostokat"] = Geometria.WynikProstokat(Figura.ProstokatBokA,Figura.ProstokatBokB,Figura.ProstokatPrzekatna);
            return Page();
        }
        public IActionResult OnPostObliczKolo()
        {
            ViewData["kolo"] = Geometria.WynikKolo(Figura.KoloPromien);
            return Page();
        }
        public IActionResult OnPostObliczTrapez()
        {
            ViewData["trapez"] = Geometria.WynikTrapez(Figura.TrapezPodstawa1,Figura.TrapezPodstawa2,Figura.TrapezBok1,Figura.TrapezBok2,Figura.TrapezWysokosc);
            return Page();
        }
        public IActionResult OnPostObliczRomb()
        {
            ViewData["romb"] =Geometria.WynikRomb(Figura.RombBok,Figura.RombWysokosc,Figura.RombPrzekatnaA,Figura.RombPrzekatnaB,Figura.RombKatAlpha);
            return Page();
        }
        public IActionResult OnPostObliczSzescian()
        {
            ViewData["szescian"] = Geometria.WynikSzescian(Figura.SzescianBok);
            return Page();
        }
        public IActionResult OnPostObliczProstopadloscian()
        {
            ViewData["prostopadloscian"] = Geometria.WynikProstopadloscian(Figura.ProstopadloscianBokA,Figura.ProstopadloscianBokB,Figura.ProstopadloscianBokC);
            return Page();
        }
        public IActionResult OnPostObliczWalec()
        {
            ViewData["walec"] = Geometria.WynikWalec(Figura.WalecPromien,Figura.WalecWysokosc);
            return Page();
        }
        public IActionResult OnPostObliczKula()
        {
            ViewData["kula"] = Geometria.WynikKula(Figura.KulaPromien);
            return Page();
        }
        public IActionResult OnPostObliczStozek()
        {
            ViewData["stozek"] = Geometria.WynikStozek(Figura.StozekPromien,Figura.StozekTworzaca,Figura.StozekWysokosc);
            return Page();
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
