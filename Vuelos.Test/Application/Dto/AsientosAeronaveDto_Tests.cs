using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Aeronave;
using Xunit;

namespace Vuelos.Test.Application.Dto
{
    public class AsientosAeronaveDto_Tests
    {
        [Fact]
        public void AsientosAeronaveDto_CheckPropertieskValid()
        {
            var idTest = Guid.NewGuid();
            var nroAsientoTest = "1C";
            var filaTest = 1;
            var columnaTest = 3;
            var estadoAsientoTest = "Habilitado";
            var detalleAsientos = new AsientosAeronaveDto();

            Assert.Null(detalleAsientos.NroAsiento);
            Assert.Equal(0, detalleAsientos.Fila);
            Assert.Equal(0, detalleAsientos.Columna);
            Assert.Null(detalleAsientos.EstadoAsiento);

            detalleAsientos.NroAsiento = nroAsientoTest;
            detalleAsientos.Fila = filaTest;
            detalleAsientos.Columna = columnaTest;
            detalleAsientos.EstadoAsiento = estadoAsientoTest;

            Assert.Equal(nroAsientoTest, detalleAsientos.NroAsiento);
            Assert.Equal(filaTest, detalleAsientos.Fila);
            Assert.Equal(columnaTest, detalleAsientos.Columna);
            Assert.Equal(estadoAsientoTest, detalleAsientos.EstadoAsiento);
        }
    }
}
