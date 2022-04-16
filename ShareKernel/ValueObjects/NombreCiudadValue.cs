using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record NombreCiudadValue : ValueObject
    {
        public string Name { get; }

        public NombreCiudadValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if (name.Length > 100)
            {
                throw new BusinessRuleValidationException("NombreCiudad no puede tener más de 100 caracteres!");
            }
            Name = name;
        }


        public static implicit operator string(NombreCiudadValue value)
        {
            return value.Name;
        }


        public static implicit operator NombreCiudadValue(string name)
        {
            return new NombreCiudadValue(name);
        }
    }
}
