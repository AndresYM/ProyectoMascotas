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
    public class PropiModel : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietar;
        public IEnumerable<Propietar> Propietar { get; set; }

        //[BindProperty(SupportsGet =true)]
        //public string FiltroBusqueda { get; set; }


        public PropiModel(IRepositorioPropietarios repositorioPropietar)
        {
            this.repositorioPropietar = repositorioPropietar;
        }
        public void OnGet()
        {
            //FiltroBusqueda=filtroBusqueda;
            Propietar = repositorioPropietar.GetAll();
            //GetSaludosPorFiltro(filtroBusqueda);
        }
    }

}