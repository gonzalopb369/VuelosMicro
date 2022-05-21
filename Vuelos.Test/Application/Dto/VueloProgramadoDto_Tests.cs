using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Dto.Vuelos;
using Xunit;


namespace Vuelos.Test.Application.Dto
{
    public class VueloProgramadoDto_Tests
    {
        [Fact]
        public void VueloProgramadoDto_CheckPropertiesValid()
        {
            //var idTest = Guid.NewGuid();
            var nroVuelo = "369";
            var lunes = true;
            var martes = false;
            var miercoles = true;
            var jueves = false;
            var viernes = true;
            var sabado = false;
            var domingo = true;
            var horaSalida = "11:11";
            var horaLlegada = "12:11";
            var ciudadOrigen = "VVI";
            var ciudadDestino = "LPB";
            decimal precioVuelo = new(600.0);
            decimal cantidadMillas = new(350.0);
            var objVueloProgramado = new VueloProgramadoDto();

            //Assert.Equal(Guid.Empty, objVuelo.Id);
            Assert.Null(objVueloProgramado.NroVuelo);
            Assert.False(objVueloProgramado.Lunes);
            Assert.False(objVueloProgramado.Martes);
            Assert.False(objVueloProgramado.Miercoles);
            Assert.False(objVueloProgramado.Jueves);
            Assert.False(objVueloProgramado.Viernes);
            Assert.False(objVueloProgramado.Sabado);
            Assert.False(objVueloProgramado.Domingo);
            Assert.Null(objVueloProgramado.HoraSalida);
            Assert.Null(objVueloProgramado.HoraLlegada);
            Assert.Null(objVueloProgramado.CiudadOrigen);
            Assert.Null(objVueloProgramado.CiudadDestino);
            Assert.Equal(new decimal(0.0), objVueloProgramado.PrecioVuelo);
            Assert.Equal(new decimal(0.0), objVueloProgramado.CantidadMillas);
           

            //vueloProgramado.id =idTEst
            objVueloProgramado.NroVuelo = nroVuelo;
            objVueloProgramado.Lunes = lunes;
            objVueloProgramado.Martes = martes;
            objVueloProgramado.Miercoles = miercoles;
            objVueloProgramado.Jueves = jueves;
            objVueloProgramado.Viernes = viernes;
            objVueloProgramado.Sabado = sabado;
            objVueloProgramado.Domingo = domingo;
            objVueloProgramado.HoraSalida = horaSalida;
            objVueloProgramado.HoraLlegada = horaLlegada;
            objVueloProgramado.CiudadOrigen = ciudadOrigen;
            objVueloProgramado.CiudadDestino = ciudadDestino;
            objVueloProgramado.PrecioVuelo = precioVuelo;
            objVueloProgramado.CantidadMillas = cantidadMillas;

            //Assert.Equal(idTest, objVuelo.Id);
            Assert.Equal(nroVuelo, objVueloProgramado.NroVuelo);
            Assert.Equal(lunes, objVueloProgramado.Lunes);
            Assert.Equal(martes, objVueloProgramado.Martes);
            Assert.Equal(miercoles, objVueloProgramado.Miercoles);
            Assert.Equal(jueves, objVueloProgramado.Jueves);
            Assert.Equal(viernes, objVueloProgramado.Viernes);
            Assert.Equal(sabado, objVueloProgramado.Sabado);
            Assert.Equal(domingo, objVueloProgramado.Domingo);
            Assert.Equal(horaSalida, objVueloProgramado.HoraSalida);
            Assert.Equal(horaLlegada, objVueloProgramado.HoraLlegada);
            Assert.Equal(ciudadOrigen, objVueloProgramado.CiudadOrigen);
            Assert.Equal(ciudadDestino, objVueloProgramado.CiudadDestino);
            Assert.Equal(precioVuelo, objVueloProgramado.PrecioVuelo);
            Assert.Equal(cantidadMillas, objVueloProgramado.CantidadMillas);

        }
    }
}
