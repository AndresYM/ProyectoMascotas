namespace HolaWeb.App.Dominio
{
    public class Visitas
    {
        public int Id {get;set;}
        public int IdMascota {get;set;}
        public int IdVeterinario {get;set;}
        public float Temperatura {get; set;}
        public float peso {get;set;}
        public int FrecuenciaRes {get;set;}
        public int FrecuenciaCar {get;set;}
        public string EstadoAnimo {get;set;}
        public string Fecha {get;set;}
        public string  Recomendaciones {get;set;}
    }
}