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
    public class EditModel4 : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisitas;
        [BindProperty]
        public Visitas Visita { get; set; }

        public EditModel4()
        {
            this.repositorioVisitas=new RepositorioVisitasMemoria(new HolaWeb.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? visitaId)
        {
            if (visitaId.HasValue)
            {
                Visita = repositorioVisitas.GetVisitaPorId(visitaId.Value);
            }
            else
            {
                Visita = new Visitas();
            }
            if (Visita == null)
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
            if(Visita.Id>0)
            {
            Visita = repositorioVisitas.Update(Visita);
            }
            else
            {
             repositorioVisitas.Add(Visita);
            }
            return Page();
        }


    }
}