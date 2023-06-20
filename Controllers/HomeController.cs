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
        ViewBag.pista = Escape.InicializarSala(1);
        return View();
    }

    public IActionResult Sala2()
    {
        ViewBag.pista = Escape.InicializarSala(2);
        return View();
    }

    public IActionResult respuestaSala2(string respuesta1){


        if (Escape.ResolverSala(2, respuesta1.ToUpper()))
        {
            return RedirectToAction("Sala2Des");
        }
        return View("Sala2");
    }

    public IActionResult sala2Des(){
        ViewBag.pista = Escape.InicializarSala(2);
        return View();
    }

    public IActionResult Sala3(){
        ViewBag.pista = Escape.InicializarSala(3);
        return View();
    }
    public IActionResult Sala3Des(){
        return View();
    }

    public IActionResult Sala3SinLlave(){
        ViewBag.pista = Escape.InicializarSala(4);
        return View();
    }

    public IActionResult Sala4(){
        ViewBag.pista = Escape.InicializarSala(5);
        return View();
    }

    public IActionResult respuesta4(int respuesta){


        if (Escape.ResolverSala(4, Convert.ToString(respuesta)))
        {   
            return View("Sala4");

        }
            return RedirectToAction("Sala4Des");

    }
}
