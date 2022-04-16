using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Aeronaves.ValueObjects;
using Vuelos.Domain.ValueObjects;

namespace Vuelos.Infraestructure.EF.Config.WriteConfig
{
    public class AeronaveWriteConfig : IEntityTypeConfiguration<Aeronave>,
       IEntityTypeConfiguration<AsientosAeronave>
    {
        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            //var nroPedidoConverter = new ValueConverter<NumeroPedido, string>(
            //    nroPedidoValue => nroPedidoValue.Value,
            //    nroPedido => new NumeroPedido(nroPedido)
            //);
            builder.Property(x => x.NroAeronave)
                //.HasConversion(nroPedidoConverter)
                .HasColumnName("nroAeronave")
                .HasMaxLength(6);

            var matriculaConverter = new ValueConverter<MatriculaValue, string>(
                matriculaValue => matriculaValue.Matricula,
                matricula => new MatriculaValue(matricula));
            builder.Property(x => x.Matricula)
                .HasConversion(matriculaConverter)
                .HasColumnName("matricula")
                .HasMaxLength(10);

            builder.Property(x => x.Marca)
               //.HasConversion(nroPedidoConverter)
               .HasColumnName("marca")
               .HasMaxLength(10);

            builder.Property(x => x.Modelo)
              //.HasConversion(nroPedidoConverter)
              .HasColumnName("modelo")
              .HasMaxLength(10);

            var capacidadAsientosConverter = new ValueConverter<CapacidadAsientosValue, int>(
                 capacidadAsientosValue => capacidadAsientosValue.Value,
                 capacidadAsientos => new CapacidadAsientosValue(capacidadAsientos));
            builder.Property(x => x.CapacidadAsientos)
                .HasConversion(capacidadAsientosConverter)
                .HasColumnName("capacidadAsientos");
            //.HasPrecision(12, 2);

            builder.Property(x => x.CapacidadCombustible)
               //.HasConversion(nroPedidoConverter)
               .HasColumnName("capacidadCombustible")
               .HasColumnType("int");

            builder.Property(x => x.EsActivo)
               //.HasConversion(nroPedidoConverter)
               .HasColumnName("esActivo")
               .HasColumnType("bool");  // !!! ver. si no cambiar a BIT

            builder.HasMany(typeof(AsientosAeronave), "_detalleAsientos"); //_asientosAeronave
            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
            builder.Ignore(x => x.DetalleAsientos);
            //builder.Ignore(x => x.ClienteId);
        }


        public void Configure(EntityTypeBuilder<AsientosAeronave> builder)
        {
            builder.ToTable("AsientosAeronave");
            builder.HasKey(x => x.Id);

            var nroAsientoConverter = new ValueConverter<NroAsientoValue, string>(
                 nroAsientoValue => nroAsientoValue.NroAsiento,
                 nroAsiento => new NroAsientoValue(nroAsiento));
            builder.Property(x => x.NroAsiento)
                .HasConversion(nroAsientoConverter)
                .HasColumnName("nroAsiento")
                .HasMaxLength(3);

            var filaConverter = new ValueConverter<FilaAsientoValue, int>(
                filaValue => filaValue.Value,
                fila => new FilaAsientoValue(fila));
            builder.Property(x => x.Fila)
                .HasConversion(filaConverter)
                .HasColumnName("fila");
            //.HasPrecision(12, 2);

            var columnaConverter = new ValueConverter<ColumnaAsientoValue, int>(
               columnaValue => columnaValue.Value,
               columna => new ColumnaAsientoValue(columna));
            builder.Property(x => x.Columna)
                .HasConversion(columnaConverter)
                .HasColumnName("columna");
            //.HasPrecision(12, 2);

            var estadoAsientoConverter = new ValueConverter<EstadoAsientoValue, string>(
                  estadoAsientoValue => estadoAsientoValue.EstadoAsiento,
                  estadoAsiento => new EstadoAsientoValue(estadoAsiento));
            builder.Property(x => x.EstadoAsiento)
                .HasConversion(estadoAsientoConverter)
                .HasColumnName("estadoAsiento")
                .HasMaxLength(10);

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
