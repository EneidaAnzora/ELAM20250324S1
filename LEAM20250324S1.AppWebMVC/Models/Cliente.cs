using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LEAM20250324S1.AppWebMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [Display(Name = "Dirección")]
    public string? Direccion { get; set; }

    [Display(Name = "Teléfono")]
    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El email es obligatorio.")]
    public string? Email { get; set; }
}
