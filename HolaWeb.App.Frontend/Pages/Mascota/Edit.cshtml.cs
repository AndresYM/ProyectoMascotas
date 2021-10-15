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
    public class EditModel3 : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascotas;
        [BindProperty]
        public Mascot Mascota { get; set; }

        public EditModel3()
        {
            this.repositorioMascotas=new RepositorioMascotasMemoria(new HolaWeb.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? mascotaId)
        {
            if (mascotaId.HasValue)
            {
                Mascota = repositorioMascotas.GetMascotaPorId(mascotaId.Value);
            }
            else
            {
                Mascota = new Mascot();
            }
            if (Mascota == null)
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
            if(Mascota.Id>0)
            {
            Mascota = repositorioMascotas.Update(Mascota);
            }
            else
            {
             repositorioMascotas.Add(Mascota);
            }
            return Page();
        }


    }
}