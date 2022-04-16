using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Rules
{
    public class StringNotNullOrEmptyRule : IBusinessRule
    {
        private readonly string _value;

        public StringNotNullOrEmptyRule(string value)
        {
            _value = value;
        }


        public string Message => "La cadena no puede ser nula!"; 


        public bool IsValid()
        {
            return !string.IsNullOrEmpty(_value);
        }
    }
}
