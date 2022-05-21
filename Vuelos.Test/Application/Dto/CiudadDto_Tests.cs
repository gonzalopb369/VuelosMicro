using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Ciudad;
using Xunit;


namespace Vuelos.Test.Application.Dto
{
    public class CiudadDto_Tests
    {
        [Fact]
        public void AeronaveDto_CheckPropertiesValid()
        { 
            var idTest = Guid.NewGuid();
            var codigoCiudad = "TJA";
            var nombreCiudad = "Tarija";
            var nombreAeropuerto = "Oriel Lea Plaza";
            var estadoAeropuerto = true;
            var objCiudad = new CiudadDto();

            Assert.Equal(Guid.Empty, objCiudad.Id);
            Assert.Null(objCiudad.CodigoCiudad);
            Assert.Null(objCiudad.NombreCiudad);
            Assert.Null(objCiudad.NombreAeropuerto);
            Assert.False(objCiudad.EstadoAeropuerto);
            //Assert.Empty(objAeronave.DetalleAsientos);

            objCiudad.Id = idTest;
            objCiudad.CodigoCiudad = codigoCiudad;
            objCiudad.NombreCiudad = nombreCiudad;
            objCiudad.NombreAeropuerto = nombreAeropuerto;
            objCiudad.EstadoAeropuerto = estadoAeropuerto;

            Assert.Equal(idTest, objCiudad.Id);
            Assert.Equal(codigoCiudad, objCiudad.CodigoCiudad);
            Assert.Equal(nombreCiudad, objCiudad.NombreCiudad);
            Assert.Equal(nombreAeropuerto, objCiudad.NombreAeropuerto);
            Assert.Equal(estadoAeropuerto, objCiudad.EstadoAeropuerto);            
        }
    }
}
