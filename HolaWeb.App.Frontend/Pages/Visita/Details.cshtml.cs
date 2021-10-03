using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{

    public class DetailsModel4 : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisitas;
        public Visitas Visita { get; set; }

        public DetailsModel4(IRepositorioVisitas repositorioVisitas)
        {
            this.repositorioVisitas = repositorioVisitas;
        }
        public IActionResult OnGet(int VisitaId)
        {
            Visita = repositorioVisitas.GetVisitaPorId(VisitaId);
            if(Visita==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}