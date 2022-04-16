using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Aeronaves.ValueObjects
{
    public record FilaAsientoValue : ValueObject
    {
        public int Value { get; }


        public FilaAsientoValue(int value)
        {
            CheckRule(new NotNullRule(value));
            if (value <= 0 && value > 20)
            {
                throw new BusinessRuleValidationException("La Fila del asiento debe estar entre 1 y 20 !!");
            }
            Value = value;            
        }


        public static implicit operator int(FilaAsientoValue value)
        {
            return value.Value;
        }

        public static implicit operator FilaAsientoValue(int value)
        {
            return new FilaAsientoValue(value);
        }
    }
}
