using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class EditModel2 : PageModel
    {
        private readonly IRepositorioVeterinarios repositorioVeterinarios;
        [BindProperty]
        public Veterinario Veterinario { get; set; }

        public EditModel2()
        {
            this.repositorioVeterinarios=new RepositorioVeterinariosMemoria(new HolaWeb.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? veterinarioId)
        {
            if (veterinarioId.HasValue)
            {
                Veterinario = repositorioVeterinarios.GetVeterinarioPorId(veterinarioId.Value);
            }
            else
            {
                Veterinario = new Veterinario();
            }
            if (Veterinario == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Veterinario.Id>0)
            {
            Veterinario = repositorioVeterinarios.Update(Veterinario);
            }
            else
            {
             repositorioVeterinarios.Add(Veterinario);
            }
            return Page();
        }


    }
}