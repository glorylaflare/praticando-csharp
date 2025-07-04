using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Signup()
    {
        return View();
    }
}