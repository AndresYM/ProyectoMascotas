using System;
using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio
{
    public class Propietar:Persona
    {
        [Required]
        public int Identificacion {get; set;}
        [Required, StringLength(50)]
        public string Direccion {get;set;}
    }
}