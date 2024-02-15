using System.Diagnostics; //Proporciona clases que permiten interactuar con el sistema de diagnóstico.
using Microsoft.AspNetCore.Mvc; // Proporciona clases para trabajar con ASP.NET Core MVC.
using ElectivaProfesional.Models; // Espacio de nombres que contiene la clase Calculadora.

namespace ElectivaProfesional.Controllers //Nombre del controlador
{
public class CalculadoraController : Controller //Controlador que maneja las acciones relacionadas con la calculadora.
{
    private readonly ILogger<HomeController> _logger; //Controlador que maneja las acciones relacionadas con la calculadora.

    public CalculadoraController(ILogger<HomeController> logger) //Constructor del controlador que recibe un logger como parámetro.
    {
        _logger = logger; //Inicia el variable
    }

    public IActionResult Index() //Acción que responde a la solicitud GET para mostrar la vista principal de la calculadora. "return" es La vista previa de la Calculadora
    {
        return View(); //Nos devuelve la vista principal de la calculadora
    }
    //Acción que responde a la solicitud POST para realizar cálculos según la acción especificada.
    [HttpPost]
    public IActionResult Calcular (Calculadora objCalculadora){ //el objCalculadora es la Instancia de la clase Calculadora con datos de la operación
        if("+".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 + objCalculadora.Opr2; // La operación que le pedimos (en este es la suma)
        }

        if("-".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 - objCalculadora.Opr2; // La operación que le pedimos (en este es la resta)
        }

        if("*".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 * objCalculadora.Opr2; // La operación que le pedimos (en este es la multiplicación)
        }

        if("/".Equals(objCalculadora.Action)){
            objCalculadora.Respuesta= objCalculadora.Opr1 / objCalculadora.Opr2; // La operación que le pedimos (en este es división)
        }
    
        return View("index",objCalculadora);  // Devuelve la vista principal de la calculadora con el resultado de la operación.
        
    }

}

}