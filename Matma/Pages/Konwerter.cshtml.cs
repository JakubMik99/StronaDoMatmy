using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Matma.Models;
using Matma.Calculations;
namespace MyApp.Namespace
{
    public class KonwerterModel : PageModel
    {
        [BindProperty]
        public ConvertModel Liczby { get; set; }
        
        
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            ViewData["konwersja"] = SystemyLiczbowe.Przekonwertuj(Liczby.Wartosc,Liczby.System);
            return Page();
        }
        
        //Mam już zmienne w Liczby.System i liczby.Wartość, teraz muszę stworzyć funkcje która konwertuje liczby z jednego systemu na pozostałe
        //I funkcję która upewnia sie, że odpowiednie znaki znajdują się w stringu z określonym systemem liczbowym



    }
}
