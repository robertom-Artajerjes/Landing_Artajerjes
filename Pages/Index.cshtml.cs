using System.Text;
using LandingArtajerjes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LandingArtajerjes.Pages;

public class IndexModel : PageModel
{
    // Formato internacional sin + ni espacios (Argentina móvil)
    public const string WhatsAppNumber = "5491163615125";
    public const string TelefonoDisplay = "+54 9 11 6361-5125";
    public const string TelefonoHref = "+5491163615125";
    public const string Email = "Contacto@Artajerjes.com";

    [BindProperty]
    public ContactFormModel Contacto { get; set; } = new();

    public string? WhatsAppRedirectUrl { get; private set; }

    public void OnGet()
    {
    }

    public IActionResult OnPostContacto()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var mensaje = new StringBuilder()
            .AppendLine("Hola, quiero pedir un diagnóstico digital gratis para mi empresa.")
            .AppendLine()
            .AppendLine($"Nombre: {Contacto.Nombre}")
            .AppendLine($"Empresa: {Contacto.Empresa}")
            .AppendLine($"Rubro: {Contacto.Rubro}")
            .AppendLine($"País: {Contacto.Pais}")
            .AppendLine($"Ciudad: {Contacto.Ciudad}")
            .AppendLine($"Teléfono: {Contacto.Telefono}")
            .AppendLine($"Necesito: {Contacto.Necesidad}");

        var texto = Uri.EscapeDataString(mensaje.ToString());
        WhatsAppRedirectUrl = $"https://wa.me/{WhatsAppNumber}?text={texto}";

        return Page();
    }

    public static string GetWhatsAppUrl(string? mensaje = null)
    {
        var text = Uri.EscapeDataString(
            mensaje ?? "Hola, quiero pedir un diagnóstico digital gratis para mi empresa");
        return $"https://wa.me/{WhatsAppNumber}?text={text}";
    }
}
