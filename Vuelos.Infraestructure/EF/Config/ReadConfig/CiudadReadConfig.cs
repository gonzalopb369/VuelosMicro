using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Infraestructure.EF.Config.ReadConfig
{
    public class CiudadReadConfig //: IEntityTypeConfiguration<CiudadReadModel>
    {
        //public void Configure(EntityTypeBuilder<CiudadReadModel> builder)
        //{
        //    builder.ToTable("Producto"); // !!! CORREGIR
        //    builder.HasKey(x => x.Id);

        //    builder.Property(x => x.Nombre)  // !!! CORREGIR
        //        .HasMaxLength(500)
        //        .HasColumnName("nombre");


        //    builder.Property(x => x.PrecioVenta)     // !!! CORREGIR
        //        .HasColumnName("precioVenta")
        //        .HasColumnType("decimal")
        //        .HasPrecision(12, 2);

        //    builder.Property(x => x.StockActual)     // !!! CORREGIR
        //        .HasColumnName("stockActual");

        //}
    }
}
