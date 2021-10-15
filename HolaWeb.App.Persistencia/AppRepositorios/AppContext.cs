using Microsoft.EntityFrameworkCore;
using HolaWeb.App.Dominio;

namespace HolaWeb.App.Persistencia
{
    public class AppContext : DbContext
    {
        //public DbSet<Persona> Personas { get; set; }
        public DbSet<Mascot> Mascotas { get; set; }
        public DbSet<Propietar> Propietarios { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Visitas> Visitas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HolaWebtData");
            }
        }

    }
}