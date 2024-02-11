using System.ComponentModel.DataAnnotations;

namespace ElectivaProfesional.Models;

public class Calculadora
{
    public int Opr1 { get; set; }
    public int Opr2 { get; set; }
    public string Action { get; set; }

    [Display(Name ="La respuesta es: ")]
    public int Respuesta { get; set; }

    
}
