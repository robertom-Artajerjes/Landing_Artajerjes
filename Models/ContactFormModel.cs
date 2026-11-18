using System.ComponentModel.DataAnnotations;

namespace LandingArtajerjes.Models;

public class ContactFormModel
{
    [Required(ErrorMessage = "Ingresá tu nombre")]
    [Display(Name = "Nombre")]
    [StringLength(120)]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ingresá el nombre de tu empresa")]
    [Display(Name = "Empresa")]
    [StringLength(160)]
    public string Empresa { get; set; } = string.Empty;

    [Required(ErrorMessage = "Indicá el rubro")]
    [Display(Name = "Rubro")]
    [StringLength(120)]
    public string Rubro { get; set; } = string.Empty;

    [Required(ErrorMessage = "Indicá el país")]
    [Display(Name = "País")]
    [StringLength(80)]
    public string Pais { get; set; } = "Argentina";

    [Required(ErrorMessage = "Indicá la ciudad")]
    [Display(Name = "Ciudad")]
    [StringLength(120)]
    public string Ciudad { get; set; } = string.Empty;

    [Required(ErrorMessage = "Ingresá un teléfono con código de país")]
    [Display(Name = "Teléfono")]
    [RegularExpression(@"^[+\d][\d\s().-]{6,}$", ErrorMessage = "Usá un teléfono con código de país, por ejemplo +54 9 11...")]
    [StringLength(40)]
    public string Telefono { get; set; } = string.Empty;

    [Required(ErrorMessage = "Contanos qué necesitás")]
    [Display(Name = "Qué necesitás")]
    [StringLength(1000)]
    public string Necesidad { get; set; } = string.Empty;
}
