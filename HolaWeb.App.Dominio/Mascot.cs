using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        [ForeignKey("Propietario")]
        public int IdPropietario {get;set;}
        public Propietar Propietario {get;set;}
    }
} 