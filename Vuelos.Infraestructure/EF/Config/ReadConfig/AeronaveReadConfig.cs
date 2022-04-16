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
    public class AeronaveReadConfig : IEntityTypeConfiguration<AeronaveReadModel>,
        IEntityTypeConfiguration<AsientosAeronaveReadModel>
    {
        public void Configure(EntityTypeBuilder<AeronaveReadModel> builder)
        {
            builder.ToTable("Aeronave");  //!!! corregir todo
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NroAeronave)
                .HasColumnName("nroAeronave")
                .HasMaxLength(6);

            builder.Property(x => x.Matricula)
                .HasColumnName("matricula")
                .HasMaxLength(10);
            //.HasColumnType("decimal")
            //.HasPrecision(12, 2);

            builder.Property(x => x.Marca)
                .HasColumnName("marca")
                .HasMaxLength(10);

            builder.Property(x => x.Modelo)
                .HasColumnName("modelo")
                .HasMaxLength(10);

            builder.Property(x => x.CapacidadAsientos)
                .HasColumnName("capacidadAsientos")
                .HasColumnType("int");

            builder.Property(x => x.CapacidadCombustible)
               .HasColumnName("capacidadCombustible")
               .HasColumnType("int");

            builder.Property(x => x.EsActivo)
                .HasColumnName("esActivo")
                .HasColumnType("bit");

            builder.HasMany(x => x.DetalleAsientos)
                .WithOne(x => x.Aeronave);
        }

        public void Configure(EntityTypeBuilder<AsientosAeronaveReadModel> builder)
        {
            builder.ToTable("AsientosAeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NroAsiento)
                .HasColumnName("nroAsiento")
                .HasMaxLength(3);

            builder.Property(x => x.Fila)
                .HasColumnName("fila")
                .HasColumnType("int");
            //.HasPrecision(12, 2);

            builder.Property(x => x.Columna)
                .HasColumnName("columna")
                .HasColumnType("int");
                //.HasPrecision(12, 2);

            builder.Property(x => x.EstadoAsiento)
                .HasColumnName("estadoAsiento")
                .HasMaxLength(10);
        }
    }
}
