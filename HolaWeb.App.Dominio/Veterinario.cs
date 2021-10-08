using System;
using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio
{
    public class Veterinario:Persona
    {
        [Required]
        public int TarjetaProfesional {get; set;}
    }
}