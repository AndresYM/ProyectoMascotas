using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinariosMemoria : IRepositorioVeterinarios
    {
        private readonly AppContext _appContext;
        public RepositorioVeterinariosMemoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Veterinario Add(Veterinario nuevoVeterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(nuevoVeterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        public IEnumerable<Veterinario> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Veterinario> GetAll_()
        {
            return _appContext.Veterinarios;
        }

        public IEnumerable<Veterinario> GetVeterinarioPorFiltro(string filtro)
        {
            var veterinarios = GetAll(); // Obtiene todos los saludos
            if (veterinarios != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    veterinarios = veterinarios.Where(s => s.Nombre.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return veterinarios;
        }

        public Veterinario GetVeterinarioPorId(int veterinarioID)
        {
            return _appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinarioID);
        }

        public Veterinario Update(Veterinario veterinarioActualizado)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(p => p.Id == veterinarioActualizado.Id);
            if (veterinarioEncontrado!=null)
            {
                veterinarioEncontrado.Nombre = veterinarioActualizado.Nombre;
                veterinarioEncontrado.Apellidos=veterinarioActualizado.Apellidos;
                veterinarioEncontrado.NumeroTelefono=veterinarioActualizado.NumeroTelefono;
                veterinarioEncontrado.TarjetaProfesional=veterinarioActualizado.TarjetaProfesional;

                _appContext.SaveChanges();
    
            }
            return veterinarioEncontrado;
        }
    }
}