﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vuelos.Infraestructure.EF.Contexts;

namespace Vuelos.Infraestructure.EF.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20220507131430_AgregaCiudad")]
    partial class AgregaCiudad
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.AeronaveReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CapacidadAsientos")
                        .HasColumnType("int")
                        .HasColumnName("capacidadAsientos");

                    b.Property<int>("CapacidadCombustible")
                        .HasColumnType("int")
                        .HasColumnName("capacidadCombustible");

                    b.Property<bool>("EsActivo")
                        .HasColumnType("bit")
                        .HasColumnName("esActivo");

                    b.Property<string>("Marca")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("marca");

                    b.Property<string>("Matricula")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("matricula");

                    b.Property<string>("Modelo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("modelo");

                    b.Property<string>("NroAeronave")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)")
                        .HasColumnName("nroAeronave");

                    b.HasKey("Id");

                    b.ToTable("Aeronave");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.AsientosAeronaveReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AeronaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Columna")
                        .HasColumnType("int")
                        .HasColumnName("columna");

                    b.Property<string>("EstadoAsiento")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("estadoAsiento");

                    b.Property<int>("Fila")
                        .HasColumnType("int")
                        .HasColumnName("fila");

                    b.Property<string>("NroAsiento")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("nroAsiento");

                    b.HasKey("Id");

                    b.HasIndex("AeronaveId");

                    b.ToTable("AsientosAeronave");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.CiudadReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoCiudad")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("codigoCiudad");

                    b.Property<bool>("EstadoAeropuerto")
                        .HasColumnType("bit")
                        .HasColumnName("estadoAeropuerto");

                    b.Property<string>("NombreAeropuerto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombreAeropuerto");

                    b.Property<string>("NombreCiudad")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("nombreCiudad");

                    b.HasKey("Id");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.VueloProgramadoReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("CantidadMillas")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("cantidadMillas");

                    b.Property<string>("CiudadDestino")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("ciudadDestino");

                    b.Property<string>("CiudadOrigen")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("ciudadOrigen");

                    b.Property<bool>("Domingo")
                        .HasColumnType("bit")
                        .HasColumnName("domingo");

                    b.Property<DateTime>("HoraLlegada")
                        .HasColumnType("DateTime")
                        .HasColumnName("horaLlegada");

                    b.Property<DateTime>("HoraSalida")
                        .HasColumnType("DateTime")
                        .HasColumnName("horaSalida");

                    b.Property<bool>("Jueves")
                        .HasColumnType("bit")
                        .HasColumnName("jueves");

                    b.Property<bool>("Lunes")
                        .HasColumnType("bit")
                        .HasColumnName("lunes");

                    b.Property<bool>("Martes")
                        .HasColumnType("bit")
                        .HasColumnName("martes");

                    b.Property<bool>("Miercoles")
                        .HasColumnType("bit")
                        .HasColumnName("miercoles");

                    b.Property<string>("NroVuelo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("nroVuelo");

                    b.Property<decimal>("PrecioVuelo")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("precioVuelo");

                    b.Property<bool>("Sabado")
                        .HasColumnType("bit")
                        .HasColumnName("sabado");

                    b.Property<bool>("Viernes")
                        .HasColumnType("bit")
                        .HasColumnName("viernes");

                    b.Property<Guid?>("VueloId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VueloId");

                    b.ToTable("VueloProgramado");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.VueloReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("DateTime")
                        .HasColumnName("fechaFinal");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("DateTime")
                        .HasColumnName("fechaInicio");

                    b.Property<string>("NroItinerario")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("nroItinerario");

                    b.HasKey("Id");

                    b.ToTable("Vuelo");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.AsientosAeronaveReadModel", b =>
                {
                    b.HasOne("Vuelos.Infraestructure.EF.ReadModel.AeronaveReadModel", "Aeronave")
                        .WithMany("DetalleAsientos")
                        .HasForeignKey("AeronaveId");

                    b.Navigation("Aeronave");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.VueloProgramadoReadModel", b =>
                {
                    b.HasOne("Vuelos.Infraestructure.EF.ReadModel.VueloReadModel", "Vuelo")
                        .WithMany("DetVueloProgramado")
                        .HasForeignKey("VueloId");

                    b.Navigation("Vuelo");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.AeronaveReadModel", b =>
                {
                    b.Navigation("DetalleAsientos");
                });

            modelBuilder.Entity("Vuelos.Infraestructure.EF.ReadModel.VueloReadModel", b =>
                {
                    b.Navigation("DetVueloProgramado");
                });
#pragma warning restore 612, 618
        }
    }
}
