using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio
{
    public class Visitas
    {
        public int Id {get;set;}
        [Required]
        public int IdMascota {get;set;}
        [Required]
        public int IdVeterinario {get;set;}
        [Required]
        public float Temperatura {get; set;}
        [Required]
        public float peso {get;set;}
        [Required]
        public int FrecuenciaRes {get;set;}
        [Required]
        public int FrecuenciaCar {get;set;}
        [Required, StringLength(15)]
        public string EstadoAnimo {get;set;}
        [Required, StringLength(15)]
        public string Fecha {get;set;}
        public string  Recomendaciones {get;set;}
    }
}