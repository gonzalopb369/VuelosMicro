using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Domain.Model.Aeronaves;


namespace Vuelos.Domain.Factories
{
    public interface IAeronaveFactory
    {
        Aeronave Create(string nroAeronave);  //!!!, string matricula);

        Aeronave CrearCabAeronave(string nroAeronave, string matricula, string marca,   // Añadido
                    string modelo, int capacidadAsientos, int capacidadCombustible,
                    bool esActivo);
    }
}
