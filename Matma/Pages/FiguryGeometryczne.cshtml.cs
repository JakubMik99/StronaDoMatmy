using Matma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class FiguryGeometryczneModel : PageModel
    {
        [BindProperty]
        public SquareModel? Figura { get; set; }
        
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            ViewData["kwadrat"] =$"Pole wynosi {Figura.Bok*Figura.Bok}";
            return Page();
        }
    }
}
