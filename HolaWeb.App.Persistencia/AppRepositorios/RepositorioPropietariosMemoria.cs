using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietariosMemoria : IRepositorioPropietarios
    {
        List <Propietar> propietarios;
        public RepositorioPropietariosMemoria()
        {
            propietarios = new List <Propietar> ()
            {
                new Propietar{Id=1,Nombre="as13",Apellidos="asaww",NumeroTelefono="12sd1212",Identificacion=12121212,Direccion="121212"},
                new Propietar{Id=2,Nombre="as2",Apellidos="asass",NumeroTelefono="121sd212",Identificacion=121444212,Direccion="122321212"},
                new Propietar{Id=3,Nombre="as212",Apellidos="asdda",NumeroTelefono="12sd212",Identificacion=12133212,Direccion="1235561212"}
            };
        }
        public IEnumerable<Propietar> GetAll()
        {
            return propietarios;
        }

        public IEnumerable<Propietar> GetPropietarioPorFiltro(string filtro)
        {
            var propietars = GetAll(); // Obtiene todos los saludos
            if (propietars != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    propietars = propietars.Where(s => s.Nombre.Contains(filtro)); 
                    /// <summary>
                    /// Filtra los mensajes que contienen el filtro
                    /// </summary>
                }
            }
            return propietars;
        }

        public Propietar GetPropietarioPorId(int propietarioID)
        {
            return propietarios.SingleOrDefault(p => p.Id==propietarioID);
        }
    }
}