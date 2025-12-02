using System.ComponentModel.DataAnnotations;

namespace escuchify_app.Components.Models;

public class Cancion
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El título es obligatorio")]
    public string Titulo { get; set; } = string.Empty;

    [Required(ErrorMessage = "La duración es obligatoria")]
    public string Duracion { get; set; } = string.Empty;

    [Required(ErrorMessage = "El género es obligatorio")]
    public string Genero { get; set; } = string.Empty;

    // Relación con Disco
    [Required(ErrorMessage = "Debes seleccionar un disco")]
    [Range(1, int.MaxValue, ErrorMessage = "Selecciona un disco válido")]
    public int DiscoId { get; set; }
}