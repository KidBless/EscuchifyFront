using System.ComponentModel.DataAnnotations;

namespace escuchify_app.Components.Models;

public class Artista
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre completo es obligatorio")]
    public string NombreCompleto { get; set; } = string.Empty;

    [Required(ErrorMessage = "El nombre artístico es obligatorio")]
    public string NombreArtistico { get; set; } = string.Empty;

    [Required(ErrorMessage = "El año de inicio es obligatorio")]
    [Range(1800, 2025, ErrorMessage = "Ingresa un año válido")]
    public int AnioInicio { get; set; }

    [Required(ErrorMessage = "La nacionalidad es obligatoria")]
    public string Nacionalidad { get; set; } = string.Empty;

    [Required(ErrorMessage = "La discográfica es obligatoria")]
    public string Discografica { get; set; } = string.Empty;

    public string? ImagenUrl { get; set; }
}