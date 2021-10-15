using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioMascotasMemoria : IRepositorioMascotas
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioMascotasMemoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascot Add(Mascot nuevoMascota)
        {
            var mascotaAdicionada = _appContext.Mascotas.Add(nuevoMascota);
            _appContext.SaveChanges();
            return mascotaAdicionada.Entity;
        }

        public IEnumerable<Mascot> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Mascot> GetAll_()
        {
            return _appContext.Mascotas;
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
            return _appContext.Mascotas.FirstOrDefault(p => p.Id == mascotaID);
        }

        public Mascot Update(Mascot mascotaActualizado)
        {
            var mascotaEncontrada = _appContext.Mascotas.FirstOrDefault(p => p.Id == mascotaActualizado.Id);
            if (mascotaEncontrada!=null)
            {
                mascotaEncontrada.Nombre = mascotaActualizado.Nombre;
                mascotaEncontrada.Edad=mascotaActualizado.Edad;
                mascotaEncontrada.Raza=mascotaActualizado.Raza;

                _appContext.SaveChanges();
    
            }
            return mascotaEncontrada;
        }
    }
}