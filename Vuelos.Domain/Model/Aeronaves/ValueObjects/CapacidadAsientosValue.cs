using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.Model.Aeronaves.ValueObjects
{
    public record CapacidadAsientosValue : ValueObject
    {
        public int Value { get; }


        public CapacidadAsientosValue(int value)
        {
            CheckRule(new NotNullRule(value));
            if (value <= 0 && value > 120)
            {
                throw new BusinessRuleValidationException("La capacidad de asientos de la aeronave debe estar entre 1 y 120 !!");
            }
            Value = value;
        }


        public static implicit operator int(CapacidadAsientosValue value)
        {
            return value.Value;
        }

        public static implicit operator CapacidadAsientosValue(int value)
        {
            return new CapacidadAsientosValue(value);
        }
    }
}
