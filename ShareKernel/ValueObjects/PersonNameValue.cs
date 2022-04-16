using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareKernel.Rules;


namespace ShareKernel.ValueObjects
{
    public record PersonNameValue : ValueObject
    {
        public string Name { get; }

        public PersonNameValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if (name.Length > 500)
            {
                throw new BusinessRuleValidationException("PersonName no puede tener más de 500 caracteres!");
            }
            Name = name;
        }


        public static implicit operator string(PersonNameValue value)
        {
            return value.Name;
        }


        public static implicit operator PersonNameValue(string name)
        {
            return new PersonNameValue(name);
        }
    }
}
