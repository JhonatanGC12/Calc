using System.ComponentModel.DataAnnotations; //Extensión

namespace ElectivaProfesional.Models; //Nombre

public class Calculadora //La clase que representa a la calculadora creada
{
    public decimal Opr1 { get; set; } // Recibe y utiliza un valor introducido por un usuario
    public decimal Opr2 { get; set; } //Recibe y utiliza el segundo valor introducido por un usuario
    public string Action { get; set; } // Establece la Acción a realizar en los operandos por ejemplo la suma, resta, etc.
    public decimal Respuesta { get; set; } // Recibimos la respuesta de la operación

    
}
