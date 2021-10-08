using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospiEnCasa.App.Fronted.Pages
{
    public class VeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinarios repositorioVeterinario;
        public IEnumerable<Veterinario> Veterinario { get; set; }

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda { get; set; }


        public VeterinarioModel(IRepositorioVeterinarios repositorioVeterinario)
        {
            this.repositorioVeterinario = repositorioVeterinario;
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Veterinario = repositorioVeterinario.GetVeterinarioPorFiltro(filtroBusqueda);
        }
    }
}
