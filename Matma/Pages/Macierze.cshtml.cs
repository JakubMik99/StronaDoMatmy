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
