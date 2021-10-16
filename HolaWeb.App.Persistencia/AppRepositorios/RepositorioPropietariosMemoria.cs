using System;
using System.Collections.Generic;
using System.Linq;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioPropietariosMemoria : IRepositorioPropietarios
    {
        private readonly AppContext _appContext;
        public RepositorioPropietariosMemoria(AppContext appContext)
        {
           _appContext = appContext;
        }

        public Propietar Add(Propietar nuevoPropietario)
        {
           var propietarioAdicionado = _appContext.Propietarios.Add(nuevoPropietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        public IEnumerable<Propietar> GetAll()
        {
            return GetAll_();
        }

         public IEnumerable<Propietar> GetAll_()
        {
            return _appContext.Propietarios;
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
            return _appContext.Propietarios.FirstOrDefault(p => p.Id == propietarioID);
        }

        public Propietar Update(Propietar propietarioActualizado)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(p => p.Id == propietarioActualizado.Id);
            if (propietarioEncontrado!=null)
            {
                propietarioEncontrado.Nombre = propietarioActualizado.Nombre;
                propietarioEncontrado.Apellidos=propietarioActualizado.Apellidos;
                propietarioEncontrado.NumeroTelefono=propietarioActualizado.NumeroTelefono;
                propietarioEncontrado.Identificacion=propietarioActualizado.Identificacion;
                propietarioEncontrado.Direccion=propietarioActualizado.Direccion;

                _appContext.SaveChanges();
            }
            return propietarioEncontrado;
        }
    }
}