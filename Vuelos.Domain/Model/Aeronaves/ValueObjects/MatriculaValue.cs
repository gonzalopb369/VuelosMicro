using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vuelos.Domain.Model.Aeronaves.ValueObjects
{
    public record MatriculaValue : ValueObject
    {
        public string Matricula { get; }


        public MatriculaValue(string matricula)
        {
            CheckRule(new StringNotNullOrEmptyRule(matricula));
            if (matricula.Length < 3 || matricula.Length > 10)
            {
                throw new BusinessRuleValidationException("La matrícula de la aeronave debe tener entre 3 y 10 caracteres!!");
            }
            Matricula = matricula;
        }


        public static implicit operator string(MatriculaValue value)
        {
            return value.Matricula;
        }

        public static implicit operator MatriculaValue(string value)
        {
            return new MatriculaValue(value);
        }
    }
}
