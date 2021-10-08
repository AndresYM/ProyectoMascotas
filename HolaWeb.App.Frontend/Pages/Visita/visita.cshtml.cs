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
    public class visitaModel : PageModel
    {
        private readonly IRepositorioVisitas repositorioVisita;
        public IEnumerable<Visitas> Visita { get; set; }

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda { get; set; }


        public visitaModel(IRepositorioVisitas repositorioVisita)
        {
            this.repositorioVisita = repositorioVisita;
        }

        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Visita = repositorioVisita.GetVisitaPorFiltro(filtroBusqueda);
        }
    }
}
