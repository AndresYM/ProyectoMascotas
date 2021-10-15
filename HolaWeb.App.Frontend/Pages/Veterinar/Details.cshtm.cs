using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{

    public class DetailsModel2 : PageModel
    {
        private readonly IRepositorioVeterinarios repositorioVeterinarios;
        public Veterinario Veterinario { get; set; }

        public DetailsModel2()
        {
            this.repositorioVeterinarios=new RepositorioVeterinariosMemoria(new HolaWeb.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int VeterinarioId)
        {
            Veterinario = repositorioVeterinarios.GetVeterinarioPorId(VeterinarioId);
            if(Veterinario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
    }
}