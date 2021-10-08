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
    public class mascotaModel : PageModel
    {
        private readonly IRepositorioMascotas repositorioMascota;
        public IEnumerable<Mascot> Mascota { get; set; }

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda { get; set; }


        public mascotaModel(IRepositorioMascotas repositorioMascota)
        {
            this.repositorioMascota = repositorioMascota;
        }

        public void OnGet(string filtroBusqueda)
        {
            FiltroBusqueda=filtroBusqueda;
            Mascota = repositorioMascota.GetMascotaPorFiltro(filtroBusqueda);
        }
    }
}
