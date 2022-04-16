using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record CodigoCiudadValue : ValueObject
    {
        public string CodigoCiudad { get; }

        public CodigoCiudadValue(string codigoCiudad)   // !!! poner en listado los valores válidos de las ciudades
        {
            CheckRule(new StringNotNullOrEmptyRule(codigoCiudad));
            if (codigoCiudad.Length != 3)
            {
                throw new BusinessRuleValidationException("El código de ciudad debe ser de 3 caracteres!");
            }
            CodigoCiudad = codigoCiudad;
        }


        public static implicit operator string(CodigoCiudadValue value)
        {
            return value.CodigoCiudad;
        }


        public static implicit operator CodigoCiudadValue(string name)
        {
            return new CodigoCiudadValue(name);
        }

        // *** Valores válidos***
        // CIJ = Cobija
        // CBB = Cochabamba
        // LPB = La Paz
        // ORU = Oruro
        // POI = Potosí
        // VVI = Santa Cruz
        // SRE = Sucre
        // TJA = Tarija
        // TDD = Trinidad
    }
}
