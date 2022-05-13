using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Infraestructure.EF.Config.WriteConfig
{
    public class VueloWriteConfig : IEntityTypeConfiguration<Vuelo>,
       IEntityTypeConfiguration<VueloProgramado>
    {

        public void Configure(EntityTypeBuilder<Vuelo> builder)
        {
            builder.ToTable("Vuelo");
            builder.HasKey(x => x.Id);

            var nroItinerarioConverter = new ValueConverter<NroItinerarioValue, string>(
                nroItinerarioValue => nroItinerarioValue.NroItinerario,
                nroItinerario => new NroItinerarioValue(nroItinerario)
            );
            builder.Property(x => x.NroItinerario)
                .HasConversion(nroItinerarioConverter)
                .HasColumnName("nroItinerario")
                .HasMaxLength(10);

            builder.Property(x => x.FechaInicio)
               .HasColumnName("fechaInicio")
               .HasColumnType("DateTime"); //!!! definir si será string

            builder.Property(x => x.FechaFinal)
              .HasColumnName("fechaFinal")
              .HasColumnType("DateTime"); //!!! definir si será string

            builder.HasMany(typeof(VueloProgramado), "_vuelosProgramados");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.VuelosProgramados);
            //builder.Ignore(x => x.ClienteId);
        }


        public void Configure(EntityTypeBuilder<VueloProgramado> builder)
        {
            builder.ToTable("VueloProgramado");
            builder.HasKey(x => x.Id);

            var nroVueloConverter = new ValueConverter<NroVueloValue, string>(
                nroVueloValue => nroVueloValue.Name,
                nroVuelo => new NroVueloValue(nroVuelo)
            );
            builder.Property(x => x.NroVuelo)
                .HasConversion(nroVueloConverter)
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

            var horaSalidaVueloConverter = new ValueConverter<HoraVueloValue, string>(
                horaVueloValue => horaVueloValue.HoraVuelo,
                horaVuelo => new HoraVueloValue(horaVuelo)
            );
            builder.Property(x => x.HoraSalida)
              .HasColumnName("horaSalida")
              .HasConversion(horaSalidaVueloConverter)
              //.HasColumnType("varchar") !!! esto no debe haber
              .HasMaxLength(5);

            var horaLlegadaVueloConverter = new ValueConverter<HoraVueloValue, string>(
               horaVueloValue => horaVueloValue.HoraVuelo,
               horaVuelo => new HoraVueloValue(horaVuelo)
           );
            builder.Property(x => x.HoraLlegada)
              .HasColumnName("horaLlegada")
              .HasConversion(horaLlegadaVueloConverter)
              //.HasColumnType("varchar") !!! esto no debe haber
              .HasMaxLength(5);

            var ciudadOrigenConverter = new ValueConverter<CodigoCiudadValue, string>(
                ciudadOrigenValue => ciudadOrigenValue.CodigoCiudad,
                ciudadOrigen => new CodigoCiudadValue(ciudadOrigen)
            );
            builder.Property(x => x.CiudadOrigen)
               .HasColumnName("ciudadOrigen")
               .HasConversion(ciudadOrigenConverter)
               .HasMaxLength(3);

            var ciudadDestinoConverter = new ValueConverter<CodigoCiudadValue, string>(
                ciudadDestinoValue => ciudadDestinoValue.CodigoCiudad,
                ciudadDestino => new CodigoCiudadValue(ciudadDestino)
            );
            builder.Property(x => x.CiudadDestino)
               .HasColumnName("ciudadDestino")
               .HasConversion(ciudadDestinoConverter)
               .HasMaxLength(3);
            
            var precioVueloConverter = new ValueConverter<PrecioValue, decimal>(
                precioValue => precioValue.Value,
                precioVuelo => new PrecioValue(precioVuelo)
            );
            builder.Property(x => x.PrecioVuelo)
                .HasConversion(precioVueloConverter)
                .HasColumnName("precioVuelo")
                .HasColumnType("decimal")
                .HasPrecision(10, 2);

            var cantidadMillasConverter = new ValueConverter<CantidadMillasValue, decimal>(
                cantidadMillasValue => cantidadMillasValue.CantidadMilla,
                cantidadMillas => new CantidadMillasValue(cantidadMillas)
            );
            builder.Property(x => x.CantidadMillas)
                .HasConversion(cantidadMillasConverter)
                .HasColumnName("cantidadMillas")
                .HasColumnType("decimal")
                .HasPrecision(10, 2);

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }

    }
}
