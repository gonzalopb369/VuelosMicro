using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuelos.Domain.Model.Aeronaves.ValueObjects
{
    public record ColumnaAsientoValue : ValueObject
    {
        public int Value { get; }


        public ColumnaAsientoValue(int value)
        {
            CheckRule(new NotNullRule(value));
            if (value <= 0 && value > 6)
            {
                throw new BusinessRuleValidationException("La Columna del asiento debe estar entre 1 y 6 !!");
            }
            Value = value;
        }


        public static implicit operator int(ColumnaAsientoValue value)
        {
            return value.Value;
        }

        public static implicit operator ColumnaAsientoValue(int value)
        {
            return new ColumnaAsientoValue(value);
        }
    }
}
