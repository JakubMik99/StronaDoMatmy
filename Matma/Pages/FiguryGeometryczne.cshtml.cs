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
        public IActionResult OnPost()
        {
            //1stLocation.Visible = false;
            ViewData["kwadrat"] = Geometria.WynikKwadrat(Figura.KwadratBok,Figura.KwadratPrzekatna);
            ViewData["prostokat"] = Geometria.WynikProstokat(Figura.ProstokatBokA,Figura.ProstokatBokB,Figura.ProstokatPrzekatna);
            ViewData["kolo"] = Geometria.WynikKolo(Figura.KoloPromien);
            ViewData["trapez"] = Geometria.WynikTrapez(Figura.TrapezPodstawa1,Figura.TrapezPodstawa2,Figura.TrapezBok1,Figura.TrapezBok2,Figura.TrapezWysokosc);
            ViewData["romb"] =Geometria.WynikRomb(Figura.RombBok,Figura.RombWysokosc,Figura.RombPrzekatnaA,Figura.RombPrzekatnaB,Figura.RombKatAlpha);
            ViewData["szescian"] = Geometria.WynikSzescian(Figura.SzescianBok);
            ViewData["prostopadloscian"] = Geometria.WynikProstopadloscian(Figura.ProstopadloscianBokA,Figura.ProstopadloscianBokB,Figura.ProstopadloscianBokC);
            ViewData["walec"] = Geometria.WynikWalec(Figura.WalecPromien,Figura.WalecWysokosc);
            ViewData["kula"] = Geometria.WynikKula(Figura.KulaPromien);
            ViewData["stozek"] = Geometria.WynikStozek(Figura.StozekPromien,Figura.StozekTworzaca,Figura.StozekWysokosc);
            return Page();
        }
    }
}
