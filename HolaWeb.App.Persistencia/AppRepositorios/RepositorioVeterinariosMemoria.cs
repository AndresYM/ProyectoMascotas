using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinariosMemoria : IRepositorioVeterinarios
    {
        List <Veterinario> veterinarios;
        public RepositorioVeterinariosMemoria()
        {
            veterinarios = new List <Veterinario> ()
            {
                new Veterinario{Id=1,Nombre="as13",Apellidos="asaww",NumeroTelefono="12sd1212",TarjetaProfesional=12121212},
                new Veterinario{Id=2,Nombre="as2",Apellidos="asass",NumeroTelefono="121sd212",TarjetaProfesional=121444212},
                new Veterinario{Id=3,Nombre="as212",Apellidos="asdda",NumeroTelefono="12sd212",TarjetaProfesional=12133212}
            };
        }

        public Veterinario Add(Veterinario nuevoVeterinario)
        {
            nuevoVeterinario.Id=veterinarios.Max(r => r.Id) +1; 
            veterinarios.Add(nuevoVeterinario);
            return nuevoVeterinario;
        }

        public IEnumerable<Veterinario> GetAll()
        {
            return veterinarios;
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
            return veterinarios.SingleOrDefault(p => p.Id==veterinarioID);
        }

        public Veterinario Update(Veterinario veterinarioActualizado)
        {
            var veterinario= veterinarios.SingleOrDefault(r => r.Id==veterinarioActualizado.Id);
            if (veterinario!=null)
            {
                veterinario.Nombre = veterinarioActualizado.Nombre;
                veterinario.Apellidos=veterinarioActualizado.Apellidos;
                veterinario.NumeroTelefono=veterinarioActualizado.NumeroTelefono;
                veterinario.TarjetaProfesional=veterinarioActualizado.TarjetaProfesional;
    
            }
            return veterinario;
        }
    }
}