using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.ValueObjects
{
    public record EstadoAsientoValue : ValueObject
    {
        public string EstadoAsiento {get;}

        public EstadoAsientoValue(string estadoAsiento)
        {
            CheckRule(new StringNotNullOrEmptyRule(estadoAsiento));
            if (estadoAsiento != "Libre" || estadoAsiento != "Ocupado" || estadoAsiento != "Restringido")
            {
                throw new BusinessRuleValidationException("El Estado del Asiento es incorrecto !!");
            }
            EstadoAsiento = estadoAsiento;
        }


        public static implicit operator string(EstadoAsientoValue value)
        {
            return value.EstadoAsiento;
        }


        public static implicit operator EstadoAsientoValue(string estadoAsiento)
        {
            return new EstadoAsientoValue(estadoAsiento);
        }

    }
}
