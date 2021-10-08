using System.ComponentModel.DataAnnotations;

namespace HolaWeb.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; }
        [Required, StringLength(50)]
        public string Apellidos { get; set; }
        [Required, StringLength(11)]
        public string NumeroTelefono { get; set; }

    }
}