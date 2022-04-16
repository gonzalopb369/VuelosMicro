using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.ValueObjects
{
    public record NroAsientoValue : ValueObject
    {
        public string NroAsiento { get; }

        public NroAsientoValue(string nroAsiento)
        {
            CheckRule(new StringNotNullOrEmptyRule(nroAsiento));
            if (nroAsiento.Length < 2 || nroAsiento.Length > 3)
            {
                throw new BusinessRuleValidationException("El NroAsiento debe contener de 2 a 3 caracteres!");
            }
            int fila = Convert.ToInt32(nroAsiento.Substring(0, nroAsiento.Length - 1));
            string asiento = nroAsiento.Substring(nroAsiento.Length - 1, 1).ToUpper();
            if (fila < 1 || fila > 20)
            {
                throw new BusinessRuleValidationException("El número de la fila debe estar entre 1 y 20 !");
            }
            if (asiento != "A" && asiento != "B" && asiento != "C"
                    && asiento != "D" && asiento != "E" && asiento != "F")
            {
                throw new BusinessRuleValidationException("Asiento incorrecto, asientos válidos son de la A a la F !");
            }
            NroAsiento = nroAsiento;
        }


        public static implicit operator string(NroAsientoValue value)
        {
            return value.NroAsiento;
        }


        public static implicit operator NroAsientoValue(string nroAsiento)
        {
            return new NroAsientoValue(nroAsiento);
        }
    }
}
