using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioVisitasMemoria : IRepositorioVisitas
    {
        List <Visitas> visitas;
        public RepositorioVisitasMemoria()
        {
            visitas = new List <Visitas> ()
            {
                new Visitas{Id=1,IdMascota=1,IdVeterinario=1,Temperatura=27,peso=13,FrecuenciaRes=99,FrecuenciaCar=120,EstadoAnimo="Bien",Fecha="121212",Recomendaciones="121212"},
                new Visitas{Id=2,IdMascota=2,IdVeterinario=3,Temperatura=28,peso=15,FrecuenciaRes=100,FrecuenciaCar=130,EstadoAnimo="Mal",Fecha="121212",Recomendaciones="121212"},
                new Visitas{Id=3,IdMascota=2,IdVeterinario=2,Temperatura=28,peso=8,FrecuenciaRes=89,FrecuenciaCar=123,EstadoAnimo="Triste",Fecha="121212",Recomendaciones="121212"}
            };
        }

        public Visitas Add(Visitas nuevoVisita)
        {
            nuevoVisita.Id=visitas.Max(r => r.Id) +1; 
            visitas.Add(nuevoVisita);
            return nuevoVisita;
        }

        public IEnumerable<Visitas> GetAll()
        {
            return visitas;
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
            return visitas.SingleOrDefault(p => p.Id==visitaID);
        }

        public Visitas Update(Visitas visitaActualizado)
        {
            var visita= visitas.SingleOrDefault(r => r.Id==visitaActualizado.Id);
            if (visita!=null)
            {
                visita.IdMascota = visitaActualizado.IdMascota;
                visita.IdVeterinario=visitaActualizado.IdVeterinario;
                visita.Temperatura=visitaActualizado.Temperatura;
                visita.peso=visitaActualizado.peso;
                visita.FrecuenciaRes=visitaActualizado.FrecuenciaRes;
                visita.FrecuenciaCar=visitaActualizado.FrecuenciaCar;
                visita.EstadoAnimo=visitaActualizado.EstadoAnimo;
                visita.Fecha=visitaActualizado.Fecha;
                visita.Recomendaciones=visitaActualizado.Recomendaciones;
    
            }
            return visita;
        }
    }
}