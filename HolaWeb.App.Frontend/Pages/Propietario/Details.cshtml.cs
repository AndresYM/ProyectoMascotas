using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{

    public class DetailsModel1 : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        public Propietar Propietar { get; set; }

        public DetailsModel1(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }
        public IActionResult OnGet(int PropietarId)
        {
            Propietar = repositorioPropietarios.GetPropietarioPorId(PropietarId);
            if(Propietar==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}