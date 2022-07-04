using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;


namespace Matma.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    [BindProperty(SupportsGet = true)]
    public string FirstName { get; set; }


    public void OnGet()
    {
    }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid==false)
            {
                return RedirectToPage("./index");
            }
                return Page();
        }
}
