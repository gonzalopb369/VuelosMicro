using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.ValueObjects
{
    public record NroItinerarioValue : ValueObject
    {
        public string NroItinerario { get; }

        public NroItinerarioValue(string nroItinerario)
        {
            CheckRule(new StringNotNullOrEmptyRule(nroItinerario));
            if (nroItinerario.Length < 3 || nroItinerario.Length > 10)
            {
                throw new BusinessRuleValidationException("El NroItinerario debe contener de 3 a 10 caracteres!");
            }            
            NroItinerario = nroItinerario;
        }


        public static implicit operator string(NroItinerarioValue value)
        {
            return value.NroItinerario;
        }


        public static implicit operator NroItinerarioValue(string nroItinerario)
        {
            return new NroItinerarioValue(nroItinerario);
        }
    }
}
