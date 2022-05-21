using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;
using Xunit;


namespace Vuelos.Test.Application.Dto
{
    public class VueloDto_Tests
    {
        [Fact]
        public void VueloDto_CheckPropertiesValid()
        {
            var idTest = Guid.NewGuid();
            var nroItinerario = "111";
            var fechaInicio = new DateTime(2022, 01, 01);
            var fechaFinal = new DateTime(2022, 06, 30);
            var detalleVuelosProgramados = getVuelosProgramados();
            var objVuelo = new VueloDto();

            Assert.Equal(Guid.Empty, objVuelo.Id);
            Assert.Null(objVuelo.NroItinerario);
            //Assert.NotNull(objVuelo.FechaInicio); 
            //Assert.Null(@object: objVuelo.FechaFinal); //!!! ver qué hacer en este caso
            Assert.Empty(objVuelo.VueloProgramado);

            objVuelo.Id = idTest;
            objVuelo.NroItinerario = nroItinerario;
            objVuelo.FechaInicio = fechaInicio;
            objVuelo.FechaFinal = fechaFinal;
            objVuelo.VueloProgramado = detalleVuelosProgramados;

            Assert.Equal(idTest, objVuelo.Id);
            Assert.Equal(nroItinerario, objVuelo.NroItinerario);
            Assert.Equal(fechaInicio, objVuelo.FechaInicio);
            Assert.Equal(fechaFinal, objVuelo.FechaFinal);
            Assert.Equal(detalleVuelosProgramados.Count, objVuelo.VueloProgramado.Count);
        }


        private List<VueloProgramadoDto> getVuelosProgramados()
        {
            return new List<VueloProgramadoDto>()
            {
                new()
                {
                    NroVuelo = "301",
                    Lunes = true,
                    Martes = false,
                    Miercoles = true,
                    Jueves = false,
                    Viernes = true,
                    Sabado = true,
                    Domingo = true,
                    HoraSalida = "11:21",
                    HoraLlegada = "12:30",
                    CiudadOrigen = "VVI",
                    CiudadDestino = "LPZ",
                    PrecioVuelo = 700,
                    CantidadMillas = 500
                },
                new()
                {
                    NroVuelo = "302",
                    Lunes = true,
                    Martes = false,
                    Miercoles = true,
                    Jueves = true,
                    Viernes = true,
                    Sabado = true,
                    Domingo = false,
                    HoraSalida = "12:34",
                    HoraLlegada = "13:13",
                    CiudadOrigen = "VVI",
                    CiudadDestino = "CBB",
                    PrecioVuelo = 600,
                    CantidadMillas = 450
                },
                new()
                {
                    NroVuelo = "303",
                    Lunes = true,
                    Martes = true,
                    Miercoles = true,
                    Jueves = true,
                    Viernes = true,
                    Sabado = false,
                    Domingo = true,
                    HoraSalida = "09:10",
                    HoraLlegada = "10:01",
                    CiudadOrigen = "VVI",
                    CiudadDestino = "TJA",
                    PrecioVuelo = 650,
                    CantidadMillas = 500
                }
            };
        }
    }
}
