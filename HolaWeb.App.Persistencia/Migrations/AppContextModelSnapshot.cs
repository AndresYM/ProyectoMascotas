﻿// <auto-generated />
using HolaWeb.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HolaWeb.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HolaWeb.App.Dominio.Mascot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdPropietario")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPropietario");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("HolaWeb.App.Dominio.Propietar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Identificacion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.ToTable("Propietarios");
                });

            modelBuilder.Entity("HolaWeb.App.Dominio.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("HolaWeb.App.Dominio.Visitas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EstadoAnimo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("FrecuenciaCar")
                        .HasColumnType("int");

                    b.Property<int>("FrecuenciaRes")
                        .HasColumnType("int");

                    b.Property<int>("IdMascota")
                        .HasColumnType("int");

                    b.Property<int>("IdVeterinario")
                        .HasColumnType("int");

                    b.Property<string>("Recomendaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Temperatura")
                        .HasColumnType("real");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("IdMascota");

                    b.HasIndex("IdVeterinario");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("HolaWeb.App.Dominio.Mascot", b =>
                {
                    b.HasOne("HolaWeb.App.Dominio.Propietar", "Propietario")
                        .WithMany()
                        .HasForeignKey("IdPropietario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Propietario");
                });

            modelBuilder.Entity("HolaWeb.App.Dominio.Visitas", b =>
                {
                    b.HasOne("HolaWeb.App.Dominio.Mascot", "Mascota")
                        .WithMany()
                        .HasForeignKey("IdMascota")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HolaWeb.App.Dominio.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("IdVeterinario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}
