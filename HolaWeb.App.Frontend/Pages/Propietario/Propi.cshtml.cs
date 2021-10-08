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
    public class PropiModel1 : PageModel
    {
        private readonly IRepositorioPropietarios repositorioPropietarios;
        public IEnumerable<Propietar> Propietar { get; set; }

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda { get; set; }


        public PropiModel1(IRepositorioPropietarios repositorioPropietarios)
        {
            this.repositorioPropietarios = repositorioPropietarios;
        }
        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Propietar = repositorioPropietarios.GetPropietarioPorFiltro(filtroBusqueda);
        }
    }

}