using System.Collections.Generic;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietarios
    {
        IEnumerable<Propietar> GetAll();
        IEnumerable<Propietar> GetPropietarioPorFiltro(string filtro);
        Propietar GetPropietarioPorId(int propietarioID);
        Propietar Update(Propietar propietarioActualizado);
        Propietar Add(Propietar nuevoPropietario);
    }
}