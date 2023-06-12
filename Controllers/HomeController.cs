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

    public IActionResult respuestaSala2(string respuesta1){

        Console.WriteLine(respuesta1);

        if (Escape.ResolverSala(2, respuesta1.ToUpper()))
        {
            return RedirectToAction("Sala2Des");
        }
        return View("Sala2");
    }

    public IActionResult sala2Des(){
        return View();
    }

    public IActionResult Sala3(){
        return View();
    }
    public IActionResult Sala3Des(){
        return View();
    }

    public IActionResult Sala3SinLlave(){
        return View();
    }
}
