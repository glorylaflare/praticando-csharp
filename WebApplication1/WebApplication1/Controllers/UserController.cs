﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}