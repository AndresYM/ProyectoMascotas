using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioVisitasMemoria : IRepositorioVisitas
    {
        private readonly AppContext _appContext;
        public RepositorioVisitasMemoria(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Visitas Add(Visitas nuevaVisita)
        {
            var visitaAdicionada = _appContext.Visitas.Add(nuevaVisita);
            _appContext.SaveChanges();
            return visitaAdicionada.Entity;
        }

        public IEnumerable<Visitas> GetAll()
        {
            return GetAll_();
        }

        public IEnumerable<Visitas> GetAll_()
        {
            return _appContext.Visitas;
        }


        public IEnumerable<Visitas> GetVisitaPorFiltro(string filtro)
        {
            var visita = GetAll(); // Obtiene todos los saludos
            if (visita != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    visita = visita.Where(s => s.Fecha.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return visita;
        }

        public Visitas GetVisitaPorId(int visitaID)
        {
            return _appContext.Visitas.FirstOrDefault(p => p.Id == visitaID);
        }

        public Visitas Update(Visitas visitaActualizado)
        {
            var visitaEncontrada = _appContext.Visitas.FirstOrDefault(p => p.Id == visitaActualizado.Id);
            if (visitaEncontrada!=null)
            {
                visitaEncontrada.IdMascota = visitaActualizado.IdMascota;
                visitaEncontrada.IdVeterinario=visitaActualizado.IdVeterinario;
                visitaEncontrada.Temperatura=visitaActualizado.Temperatura;
                visitaEncontrada.peso=visitaActualizado.peso;
                visitaEncontrada.FrecuenciaRes=visitaActualizado.FrecuenciaRes;
                visitaEncontrada.FrecuenciaCar=visitaActualizado.FrecuenciaCar;
                visitaEncontrada.EstadoAnimo=visitaActualizado.EstadoAnimo;
                visitaEncontrada.Fecha=visitaActualizado.Fecha;
                visitaEncontrada.Recomendaciones=visitaActualizado.Recomendaciones;
                
                _appContext.SaveChanges();
    
            }
            return visitaEncontrada;
        }
    }
}