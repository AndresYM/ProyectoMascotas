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
    public class EditModel1 : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        [BindProperty]
        public Propietar Propietario { get; set; }

        public EditModel1(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }
        public IActionResult OnGet(int? propietarioId)
        {
            if (propietarioId.HasValue)
            {
                Propietario = repositorioPropietarios.GetPropietarioPorId(propietarioId.Value);
            }
            else
            {
                Propietario = new Propietar();
            }
            if (Propietario == null)
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
            if(Propietario.Id>0)
            {
            Propietario = repositorioPropietarios.Update(Propietario);
            }
            else
            {
             repositorioPropietarios.Add(Propietario);
            }
            return Page();
        }


    }
}
