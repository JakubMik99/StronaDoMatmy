using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Matma.Models;
using Matma.Calculations;
namespace MyApp.Namespace
{
    public class KonwerterModel : PageModel
    {
        [BindProperty]
        public ConvertModel? Liczby { get; set; }
        
        
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            ViewData["konwersja"] = SystemyLiczbowe.Przekonwertuj(Liczby.Wartosc,Liczby.System);
            return Page();
        }

    }
}
