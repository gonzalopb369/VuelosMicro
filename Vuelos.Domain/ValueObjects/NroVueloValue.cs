using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.ValueObjects
{
    public record NroVueloValue : ValueObject
    {
        public string Name { get; }

        public NroVueloValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if (name.Length > 10)
            {
                throw new BusinessRuleValidationException("NroVuelo no puede tener más de 10 caracteres!");
            }
            Name = name;
        }


        public static implicit operator string(NroVueloValue value)
        {
            return value.Name;
        }


        public static implicit operator NroVueloValue(string name)
        {
            return new NroVueloValue(name);
        }
    }
}
