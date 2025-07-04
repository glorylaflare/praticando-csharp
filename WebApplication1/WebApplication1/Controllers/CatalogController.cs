using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class CatalogController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}