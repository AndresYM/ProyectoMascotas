using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio
{
    public class Mascot
    {
        public int Id {get;set;}
        [Required, StringLength(50)]
        public string Nombre {get;set;}
        [Required]
        public int Edad {get;set;}
        [Required, StringLength(50)]
        public string Raza {get;set;}
    }
} 