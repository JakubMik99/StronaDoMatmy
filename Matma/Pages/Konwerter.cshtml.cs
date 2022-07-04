using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Matma.Models;

namespace MyApp.Namespace
{
    public class KonwerterModel : PageModel
    {
        [BindProperty]
        public ConvertModel Liczby { get; set; }
        
        public void OnGet()
        {
        }
    }
}
