using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ElectivaProfesional.Models;

namespace ElectivaProfesional.Controllers;

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

}
