using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisitas
    {
        IEnumerable<Visitas> GetAll();
        IEnumerable<Visitas> GetVisitaPorFiltro(string filtro);
        Visitas GetVisitaPorId(int visitaID);
    }
}