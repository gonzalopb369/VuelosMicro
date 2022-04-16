using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Application.Dto.Aeronave
{
    public class AeronaveDto    // modelo anémico
    {
        public Guid Id { get; set; }
        public string NroAeronave { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CapacidadAsientos { get; set; }
        public int CapacidadCombustible { get; set; }
        public bool EsActivo { get; set; }
        public ICollection<AsientosAeronaveDto> DetalleAsientos { get; set; }


        public AeronaveDto()
        {
            DetalleAsientos = new List<AsientosAeronaveDto>();
        }



    }
}
