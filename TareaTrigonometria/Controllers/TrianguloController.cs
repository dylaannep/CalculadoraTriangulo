using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TareaTrigonometria.Models;

namespace TareaTrigonometria.Controllers;

public class TrianguloController : Controller
{
    private readonly ILogger<TrianguloController> _logger;

    public TrianguloController(ILogger<TrianguloController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public IActionResult CalcularDatos(TrianguloModel triangulo)
    {
        if (ModelState.IsValid)
        {
            //Guardar los valores de los lados
            double a = triangulo.LadoA;
            double b = triangulo.LadoB;
            double c = triangulo.LadoC;
            // Validacion  de desigualdad de triángulos
            // Se debe de cumplir que la suma de dos lados debe ser mayor que el tercer lado
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                ViewData["ErrorMessage"] = "La suma de dos lados debe ser mayor que el tercer lado.";
                // Retornar a la vista con el mensaje de error
                return View("Index", triangulo);
            }
            // Cálculos
            // Perímetro, semiperímetro y área
            triangulo.Perimetro = a + b + c;
            triangulo.Semiperimetro = triangulo.Perimetro / 2;
            double s  = triangulo.Semiperimetro;
            triangulo.Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            // Se determina el tipo de triángulo
            if (a == b && b == c)
                triangulo.TipoTriangulo = "Equilátero";
            else if (a == b || b == c || a == c)
                triangulo.TipoTriangulo = "Isósceles";
            else
                triangulo.TipoTriangulo = "Escaleno";

            // Lllamada al método para calcular los ángulos
            CalcularAngulos(triangulo);
            // Retornar a la vista con los datos calculados
            return View("Index", triangulo); // se recomienda pasar el modelo
        }
        // Si el modelo no es válido, retornar a la vista con el modelo actual
        return View("Index", triangulo);
    }

    private void CalcularAngulos(TrianguloModel triangulo)
    {
        // Guardar los valores de los lados
        double a = triangulo.LadoA;
        double b = triangulo.LadoB;
        double c = triangulo.LadoC;

        // Ley del coseno: cos(ÁnguloA) = (b² + c² - a²) / (2bc)
        triangulo.AnguloA = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * (180 / Math.PI);
        triangulo.AnguloB = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * (180 / Math.PI);
        triangulo.AnguloC = 180 - triangulo.AnguloA - triangulo.AnguloB; // suma total debe ser 180°
    }



}