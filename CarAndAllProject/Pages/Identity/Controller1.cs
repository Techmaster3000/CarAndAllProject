using Microsoft.AspNetCore.Mvc;

namespace CarAndAllProject.Pages.Identity;

public class Controller1 : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}