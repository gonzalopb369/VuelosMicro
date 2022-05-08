using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Ciudades;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Infraestructure.EF.Config.WriteConfig
{
    public class CiudadWriteConfig : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudad");
            builder.HasKey(x => x.Id);

            var codigoCiudadConverter = new ValueConverter<CodigoCiudadValue, string>(
                codigoCiudadValue => codigoCiudadValue.CodigoCiudad,
                codigoCiudad => new CodigoCiudadValue(codigoCiudad));
            builder.Property(x => x.CodigoCiudad)
                .HasConversion(codigoCiudadConverter)
                .HasColumnName("codigoCiudad")
                .HasMaxLength(3);

            var nombreCiudadConverter = new ValueConverter<NombreCiudadValue, string>(
                nombreCiudadValue => nombreCiudadValue.Name,
                nombreCiudad => new NombreCiudadValue(nombreCiudad));
            builder.Property(x => x.NombreCiudad)
                .HasConversion(nombreCiudadConverter)
                .HasColumnName("nombreCiudad")
                .HasMaxLength(100);

            var nombreAeropuertoConverter = new ValueConverter<NombreAeropuertoValue, string>(
               nombreAeropuertoValue => nombreAeropuertoValue.Name,
               nombreAeropuerto => new NombreAeropuertoValue(nombreAeropuerto));
            builder.Property(x => x.NombreAeropuerto)
                .HasConversion(nombreAeropuertoConverter)
                .HasColumnName("nombreAeropuerto")
                .HasMaxLength(100);

            builder.Property(x => x.EstadoAeropuerto)
              //.HasConversion(nroPedidoConverter)
              .HasColumnName("estadoAeropuerto")
              .HasColumnType("bit");  

        }
    }
}
