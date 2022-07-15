using Matma.Calculations;
using Matma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class MacierzeModel : PageModel
    {
        [BindProperty]
        public int Rozmiar { get; set; }
        
        
        
        public IActionResult OnPostOblicz(int[]macierz1, int[]macierz2)
        {
            ObliczMatrix Wyniki = new ObliczMatrix();
            string dodawanie, odejmowanie, mnozenie, macierzA, macierzB;
            mnozenie= Wyniki.WszystkieWyniki(macierz1, macierz2,out dodawanie,out odejmowanie, out macierzA, out macierzB);
            ViewData["dodawanieMacierzy"] = dodawanie;
            ViewData["odejmowanieMacierzy"] = odejmowanie;
            ViewData["mnozenieMacierzy"] = mnozenie;
            ViewData["macierzA"] = macierzA;
            ViewData["macierzB"] = macierzB;
            int size = Rozmiar;
            for (var i = 0; i < macierz1.Length; i++)
            {
                    ViewData["Macierz"] += $"{macierz1[i]}"; 
            }
                    ViewData["Macierz"] +=  "MACIERZ2"; 
            for (var i = 0; i < macierz2.Length; i++)
            {
                    ViewData["Macierz"] += $"{macierz2[i]}"; 
            }
            return Page();
        }
        
        public IActionResult OnPost()
        {
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
