using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ShareKernel.Core
{
    //[Serializable]
    public class BusinessRuleValidationException : Exception
    {
        public IBusinessRule BrokenRule { get; private set; }
        public string Details { get; private set; }


        public BusinessRuleValidationException(IBusinessRule brokenRule)
        {
            BrokenRule = brokenRule;
            Details = brokenRule.Message;
        }


        protected BusinessRuleValidationException(SerializationInfo info,
                    StreamingContext context) : base(info, context)
        {
        }


        
        public BusinessRuleValidationException(string message) : base(message)
        {            
            Details = message;
        }



        public override string ToString()
        {
            string name = BrokenRule == null ? "BusinessRule" : BrokenRule.GetType().FullName;

            return $"{name } : {Details}";           
                        
        }
    }
}
