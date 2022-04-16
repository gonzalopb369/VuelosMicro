using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Core
{
    public abstract record ValueObject
    {

        protected void CheckRule(IBusinessRule rule)
        {
            if (rule is null)
            {
                throw new ArgumentException("La regla no puede ser nula!");
            }
            if (!rule.IsValid())
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}
