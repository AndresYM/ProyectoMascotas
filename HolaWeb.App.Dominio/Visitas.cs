using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolaWeb.App.Dominio
{
    public class Visitas
    {
        public int Id {get;set;}
        [Required]
        [ForeignKey("Mascota")]
        public int IdMascota {get;set;}
        public Mascot Mascota {get;set;}
        [Required]
        [ForeignKey("Veterinario")]
        public int IdVeterinario {get;set;}
        public Veterinario Veterinario {get;set;}
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