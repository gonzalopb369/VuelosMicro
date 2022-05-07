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
    public class CiudadReadConfig : IEntityTypeConfiguration<CiudadReadModel>
    {
        public void Configure(EntityTypeBuilder<CiudadReadModel> builder)
        {
            builder.ToTable("Ciudad");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CodigoCiudad)
                .HasMaxLength(3)
                .HasColumnName("codigoCiudad");

            builder.Property(x => x.NombreCiudad)
                .HasMaxLength(100)
                .HasColumnName("nombreCiudad");

            builder.Property(x => x.NombreAeropuerto)
               .HasMaxLength(100)
               .HasColumnName("nombreAeropuerto");


            builder.Property(x => x.EstadoAeropuerto)
                .HasColumnName("estadoAeropuerto")
                .HasColumnType("bit");
            //.HasPrecision(12, 2);           
        }
    }
}
