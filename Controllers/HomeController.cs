using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Sala1()
    {
        Escape.InicializarJuego();
        return View();
    }

    public IActionResult Sala2()
    {
        Escape.estadoJuego++;
        return View();
    }
}
