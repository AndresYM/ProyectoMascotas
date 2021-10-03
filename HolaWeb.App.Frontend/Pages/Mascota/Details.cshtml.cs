using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{

    public class DetailsModel3 : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascotas;
        public Mascot Mascota { get; set; }

        public DetailsModel3(IRepositorioMascotas repositorioMascotas)
        {
            this.repositorioMascotas = repositorioMascotas;
        }
        public IActionResult OnGet(int MascotaId)
        {
            Mascota = repositorioMascotas.GetMascotaPorId(MascotaId);
            if(Mascota==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}