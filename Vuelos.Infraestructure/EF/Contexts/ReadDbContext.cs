using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Infraestructure.EF.Config.ReadConfig;
using Vuelos.Infraestructure.EF.ReadModel;


namespace Vuelos.Infraestructure.EF.Contexts
{
    public class ReadDbContext : DbContext
    {
        public virtual DbSet<AeronaveReadModel> Aeronave { set; get; }
        public virtual DbSet<VueloReadModel> Vuelo { set; get; }
        //public virtual DbSet<ProductoReadModel> Producto { set; get; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aeronaveConfig = new AeronaveReadConfig();
            modelBuilder.ApplyConfiguration<AeronaveReadModel>(aeronaveConfig);
            modelBuilder.ApplyConfiguration<AsientosAeronaveReadModel>(aeronaveConfig);

            var vueloConfig = new VueloReadConfig();
            modelBuilder.ApplyConfiguration<VueloReadModel>(vueloConfig);
            modelBuilder.ApplyConfiguration<VueloProgramadoReadModel>(vueloConfig);

            //var productoConfig = new ProductoReadConfig();
            //modelBuilder.ApplyConfiguration<ProductoReadModel>(productoConfig);

            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<AeronaveCreada>();
            modelBuilder.Ignore<AsientoAeronaveAgregada>();
            modelBuilder.Ignore<VueloCreado>();
            modelBuilder.Ignore<ItemVueloAgregado>();
        }
    }
}
