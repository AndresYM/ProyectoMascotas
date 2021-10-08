using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioMascotasMemoria : IRepositorioMascotas
    {
        List <Mascot> mascotas;
        public RepositorioMascotasMemoria()
        {
            mascotas = new List <Mascot> ()
            {
                new Mascot{Id=1,Nombre="as13",Edad=2,Raza="12sd1212"},
                new Mascot{Id=2,Nombre="as2",Edad=3,Raza="121sd212"},
                new Mascot{Id=3,Nombre="as212",Edad=5,Raza="12sd212"}
            };
        }

        public Mascot Add(Mascot nuevoMascota)
        {
            nuevoMascota.Id=mascotas.Max(r => r.Id) +1; 
            mascotas.Add(nuevoMascota);
            return nuevoMascota;
        }

        public IEnumerable<Mascot> GetAll()
        {
            return mascotas;
        }

        public IEnumerable<Mascot> GetMascotaPorFiltro(string filtro)
        {
            var mascotas = GetAll(); // Obtiene todos los saludos
            if (mascotas != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    mascotas = mascotas.Where(s => s.Nombre.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return mascotas;
        }

        public Mascot GetMascotaPorId(int mascotaID)
        {
            return mascotas.SingleOrDefault(p => p.Id==mascotaID);
        }

        public Mascot Update(Mascot mascotaActualizado)
        {
            var mascota= mascotas.SingleOrDefault(r => r.Id==mascotaActualizado.Id);
            if (mascota!=null)
            {
                mascota.Nombre = mascotaActualizado.Nombre;
                mascota.Edad=mascotaActualizado.Edad;
                mascota.Raza=mascotaActualizado.Raza;
    
            }
            return mascota;
        }
    }
}