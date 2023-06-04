using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class AllprojectsModel : PageModel
{
    private readonly ILogger<AllprojectsModel> _logger;

    public AllprojectsModel(ILogger<AllprojectsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
