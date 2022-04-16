using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShareKernel.ValueObjects
{
    public record NombreAeropuertoValue : ValueObject
    {
        public string Name { get; }

        public NombreAeropuertoValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if (name.Length > 100)
            {
                throw new BusinessRuleValidationException("NombreAeropuerto no puede tener más de 100 caracteres!");
            }
            Name = name;
        }


        public static implicit operator string(NombreAeropuertoValue value)
        {
            return value.Name;
        }


        public static implicit operator NombreAeropuertoValue(string name)
        {
            return new NombreAeropuertoValue(name);
        }
    }
}
