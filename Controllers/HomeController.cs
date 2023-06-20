using Microsoft.AspNetCore.Mvc;
using CS_Razor_Tutorial.Models;

namespace CS_Razor_Tutorial.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
