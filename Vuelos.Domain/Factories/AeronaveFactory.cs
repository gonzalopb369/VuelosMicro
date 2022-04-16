using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;


namespace Vuelos.Domain.Factories
{
    public class AeronaveFactory : IAeronaveFactory
    {
        //public Aeronave CrearCabAeronave()
        //{
        //    return new Aeronave(string nroAeronave, string matricula, string marca,   // Añadido
        //            string modelo, int capacidadAsientos, int capacidadCombustible,
        //            bool esActivo);
        //    //NroAeronave = nroAeronave;
        //    //Matricula = matricula;
        //    //Marca = marca;
        //    //Modelo = modelo;
        //    //CapacidadAsientos = capacidadAsientos;
        //    //CapacidadCombustible = capacidadCombustible;
        //    //EsActivo = esActivo;
        //}

        public Aeronave CrearCabAeronave(string nroAeronave, string matricula, string marca, 
                string modelo, int capacidadAsientos, int capacidadCombustible, bool esActivo)
        {
            return new Aeronave(nroAeronave, matricula, marca, modelo, capacidadAsientos, 
                    capacidadCombustible, esActivo);
        }


        public Aeronave Create(string nroAeronave)  //!!!, string matricula)
        {
            return new Aeronave(nroAeronave);    //!!!matricula);
        }
    }
}
