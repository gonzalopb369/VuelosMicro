using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;
using Xunit;

namespace Vuelos.Test.Application.Dto
{
    public class AeronaveDto_Tests
    {
        [Fact]
        public void AeronaveDto_CheckPropertiesValid()
        {
            var idTest = Guid.NewGuid();
            var nroAeronave = "101";
            var matricula = "CP-1011";
            var marca = "Boeing";
            var modelo = "737-300";
            var capacidadAsientos = 120;
            var capacidadCombustible = 15000;
            //var esActivo = true;  !!! ver. si se usará
            var detalleAsientosTest = getAsientosAeronave();
            var objAeronave = new AeronaveDto();

            Assert.Equal(Guid.Empty, objAeronave.Id);
            Assert.Null(objAeronave.NroAeronave);
            Assert.Null(objAeronave.Matricula);
            Assert.Null(objAeronave.Marca);
            Assert.Null(objAeronave.Modelo);
            Assert.Equal(0, objAeronave.CapacidadAsientos);
            Assert.Equal(0, objAeronave.CapacidadCombustible);
            Assert.Empty(objAeronave.DetalleAsientos);

            objAeronave.Id = idTest;
            objAeronave.NroAeronave = nroAeronave;
            objAeronave.Matricula = matricula;
            objAeronave.Marca = marca;
            objAeronave.Modelo = modelo;
            objAeronave.CapacidadAsientos = capacidadAsientos;
            objAeronave.CapacidadCombustible = capacidadCombustible;
            objAeronave.DetalleAsientos = detalleAsientosTest;

            Assert.Equal(idTest, objAeronave.Id);
            Assert.Equal(nroAeronave, objAeronave.NroAeronave);
            Assert.Equal(matricula, objAeronave.Matricula);
            Assert.Equal(marca, objAeronave.Marca);
            Assert.Equal(modelo, objAeronave.Modelo);
            Assert.Equal(capacidadAsientos, objAeronave.CapacidadAsientos);
            Assert.Equal(capacidadCombustible, objAeronave.CapacidadCombustible);
            Assert.Equal(detalleAsientosTest.Count, objAeronave.DetalleAsientos.Count);
        }


        private List<AsientosAeronaveDto> getAsientosAeronave()
        {
            return new List<AsientosAeronaveDto>()
            {
                new()
                {
                    NroAsiento ="1A",
                    Fila=1,
                    Columna=1,
                    EstadoAsiento="Habilitado"
                },
                new()
                {
                    NroAsiento ="6C",
                    Fila=6,
                    Columna=3,
                    EstadoAsiento="Habilitado"
                },
                new()
                {
                    NroAsiento ="9F",
                    Fila=9,
                    Columna=6,
                    EstadoAsiento="Habilitado"
                }
            };
        }
    }
}
