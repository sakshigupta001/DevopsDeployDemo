using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

public class TechStackController : Controller
{
    public IActionResult Automation()
    {
        return View();
    }


    public IActionResult Testing()
    {
        return View();
    }

    public IActionResult Security()
    {
        return View();
    }

}

