using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.ValueObjects
{
    public record CantidadMillasValue : ValueObject
    {
        public decimal CantidadMilla { get; }


        public CantidadMillasValue(decimal cantidadMilla)
        {
            if (cantidadMilla < 0)
            {
                throw new BusinessRuleValidationException("La cantidad de millas no puede ser un valor negativo!!");
            }
            CantidadMilla = cantidadMilla;
        }


        public static implicit operator decimal(CantidadMillasValue value)
        {
            return value.CantidadMilla;
        }


        public static implicit operator CantidadMillasValue(decimal value)
        {
            return new CantidadMillasValue(value);
        }
    }
}
