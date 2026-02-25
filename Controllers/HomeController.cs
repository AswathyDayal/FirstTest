using Microsoft.AspNetCore.Mvc;

namespace FirstTest.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
