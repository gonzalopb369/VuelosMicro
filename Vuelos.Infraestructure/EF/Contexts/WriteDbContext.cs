using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Event;
using Vuelos.Domain.Model.Aeronaves;
using Vuelos.Domain.Model.Ciudades;
using Vuelos.Domain.Model.Vuelos;
using Vuelos.Infraestructure.EF.Config.WriteConfig;


namespace Vuelos.Infraestructure.EF.Contexts
{
    public class WriteDbContext : DbContext
    {
        public virtual DbSet<Aeronave> Aeronave { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Vuelo> Vuelo { get; set; }


        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aeronaveConfig = new AeronaveWriteConfig();
            modelBuilder.ApplyConfiguration<Aeronave>(aeronaveConfig);
            modelBuilder.ApplyConfiguration<AsientosAeronave>(aeronaveConfig);

            var vueloConfig = new VueloWriteConfig();
            modelBuilder.ApplyConfiguration<Vuelo>(vueloConfig);
            modelBuilder.ApplyConfiguration<VueloProgramado>(vueloConfig);

            var ciudadConfig = new CiudadWriteConfig();  
            modelBuilder.ApplyConfiguration<Ciudad>(ciudadConfig);

            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<AeronaveCreada>();
            modelBuilder.Ignore<AsientoAeronaveAgregada>();
            modelBuilder.Ignore<VueloCreado>();
            modelBuilder.Ignore<ItemVueloAgregado>();
        }
    }
}
