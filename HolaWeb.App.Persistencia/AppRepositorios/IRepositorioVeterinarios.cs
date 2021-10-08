using System.Collections.Generic;
using HolaWeb.App.Dominio;
namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVeterinarios
    {
        IEnumerable<Veterinario> GetAll();
        IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro);
        Veterinario GetVeterinarioPorId(int veterinarioID);
        Veterinario Update(Veterinario veterinarioActualizado);
        Veterinario Add(Veterinario nuevoVeterinario);
    }
}