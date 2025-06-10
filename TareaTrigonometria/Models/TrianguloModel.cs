namespace TareaTrigonometria.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

public class TrianguloModel
{
    [Required(ErrorMessage = "El lado A es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El lado A debe ser mayor que 0.")]
    public double LadoA { get; set; }

    [Required(ErrorMessage = "El lado B es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El lado B debe ser mayor que 0.")]

    public double LadoB { get; set; }

    [Required(ErrorMessage = "El lado C es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El lado C debe ser mayor que 0.")]

    public double LadoC { get; set; }

    [ValidateNever]

    public double Perimetro { get; set; }
    [ValidateNever]

    public double Semiperimetro { get; set; }
    [ValidateNever]

    public double Area { get; set; }
    [ValidateNever]

    public string TipoTriangulo { get; set; }
    [ValidateNever]

    public double AnguloA { get; set; }
    [ValidateNever]

    public double AnguloB { get; set; }
    [ValidateNever]

    public double AnguloC { get; set; }

}