using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascotas
    {
        IEnumerable<Mascot> GetAll();
        IEnumerable<Mascot> GetMascotaPorFiltro(string filtro);
        Mascot GetMascotaPorId(int mascotaID);
    }
}