using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ElectivaProfesional.Models;

namespace ElectivaProfesional.Controllers
{
public class CalculadoraController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public CalculadoraController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calcular (Calculadora objCalculadora){
        if("+".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 + objCalculadora.Opr2;
        }

        if("-".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 - objCalculadora.Opr2;
        }

        if("*".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 * objCalculadora.Opr2;
        }

        if("/".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 / objCalculadora.Opr2;
        }
    
        return View("index",objCalculadora);
        
    }

}

}