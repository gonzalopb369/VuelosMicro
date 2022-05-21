using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Application.Services;
using Xunit;


namespace Vuelos.Test.Application.Services
{    
    public class AeronaveService_Tests
    {
        [Theory]
        [InlineData("ABC", true)]
        [InlineData("123", false)]
        [InlineData("456", true)]
        [InlineData("789", false)]
        [InlineData("111", true)]
        [InlineData("sss", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public async void GenerarAeronave_CheckValidData(string expectedNroAeronave, bool isEqual)
        {
            var aeronaveService = new AeronaveService();
            string nroAeronave = await aeronaveService.GenerarNroAeronaveAsync();
            if (isEqual)
            {
                Assert.Equal(expectedNroAeronave, nroAeronave);
            }
            else
            {
                Assert.NotEqual(expectedNroAeronave, nroAeronave);
            }
        }


        //[Fact]
        //public async void GenerarAeronave_CheckValidData()
        //{
        //    var aeronaveService = new AeronaveService();
        //    string nroAeronave = await aeronaveService.GenerarNroAeronaveAsync();
        //    Assert.Equal("ABC", nroAeronave); //!!! corregir esto
        //}


        //[Fact]
        //public async void GenerarAeronave_CheckInValidData()
        //{
        //    var aeronaveService = new AeronaveService();
        //    string nroAeronave = await aeronaveService.GenerarNroAeronaveAsync();
        //    Assert.NotEqual("123", nroAeronave); //!!! corregir esto
        //}
    }
}
