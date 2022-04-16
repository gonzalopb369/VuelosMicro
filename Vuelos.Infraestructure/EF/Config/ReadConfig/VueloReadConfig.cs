using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Infraestructure.EF.ReadModel;

namespace Vuelos.Infraestructure.EF.Config.ReadConfig
{
    public class VueloReadConfig : IEntityTypeConfiguration<VueloReadModel>,
        IEntityTypeConfiguration<VueloProgramadoReadModel>
    {
        public void Configure(EntityTypeBuilder<VueloReadModel> builder)
        {
            builder.ToTable("Vuelo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NroItinerario)
                .HasColumnName("nroItinerario")
                .HasMaxLength(10);

            builder.Property(x => x.FechaInicio)
                .HasColumnName("fechaInicio")
                .HasColumnType("DateTime"); //!!! definir si será string

            builder.Property(x => x.FechaFinal)
                .HasColumnName("fechaFinal")
                .HasColumnType("DateTime"); //!!! definir si será string

            builder.HasMany(x => x.DetVueloProgramado)
                .WithOne(x => x.Vuelo);
        }


        public void Configure(EntityTypeBuilder<VueloProgramadoReadModel> builder)
        {
            builder.ToTable("VueloProgramado");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NroVuelo)
                .HasColumnName("nroVuelo")
                .HasMaxLength(10);

            builder.Property(x => x.Lunes)
                .HasColumnName("lunes")
                .HasColumnType("bit");

            builder.Property(x => x.Martes)
               .HasColumnName("martes")
               .HasColumnType("bit");

            builder.Property(x => x.Miercoles)
               .HasColumnName("miercoles")
               .HasColumnType("bit");

            builder.Property(x => x.Jueves)
               .HasColumnName("jueves")
               .HasColumnType("bit");

            builder.Property(x => x.Viernes)
               .HasColumnName("viernes")
               .HasColumnType("bit");

            builder.Property(x => x.Sabado)
               .HasColumnName("sabado")
               .HasColumnType("bit");

            builder.Property(x => x.Domingo)
               .HasColumnName("domingo")
               .HasColumnType("bit");

            builder.Property(x => x.HoraSalida)
               .HasColumnName("horaSalida")
               .HasColumnType("DateTime");

            builder.Property(x => x.HoraLlegada)
              .HasColumnName("horaLlegada")
              .HasColumnType("DateTime");

            builder.Property(x => x.CiudadOrigen)
               .HasColumnName("ciudadOrigen")
               .HasMaxLength(3);

            builder.Property(x => x.CiudadDestino)
               .HasColumnName("ciudadDestino")
               .HasMaxLength(3);

            builder.Property(x => x.PrecioVuelo)
                .HasColumnName("precioVuelo")
                .HasColumnType("decimal")
                .HasPrecision(10, 2);

            builder.Property(x => x.CantidadMillas)
                .HasColumnName("cantidadMillas")
                .HasColumnType("decimal")
                .HasPrecision(10, 2);
        }

    }
}
