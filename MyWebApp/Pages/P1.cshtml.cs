using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class P1Model : PageModel
{
    private readonly ILogger<P1Model> _logger;

    public P1Model(ILogger<P1Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
