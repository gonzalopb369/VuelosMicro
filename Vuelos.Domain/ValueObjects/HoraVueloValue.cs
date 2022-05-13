using ShareKernel.Core;
using ShareKernel.Rules;
using System;


namespace Vuelos.Domain.ValueObjects
{
    public record HoraVueloValue : ValueObject
    {
        public string HoraVuelo { get; }

        public HoraVueloValue(string horaVuelo)
        {
            CheckRule(new StringNotNullOrEmptyRule(horaVuelo));
            if (horaVuelo.Length < 3 || horaVuelo.Length > 5)
            {
                throw new BusinessRuleValidationException("La hora del vuelo deben ser 5 caracteres (HH:MM) !");
            }
            int hora = Convert.ToInt32(horaVuelo.Substring(0, 2));
            int minutos = Convert.ToInt32(horaVuelo.Substring(3, 2));            
            if (hora < 0 || hora > 23)
                throw new BusinessRuleValidationException("La hora debe estar entre 0 y 23 !");
            if (horaVuelo.Substring(2, 1) != ":")
                throw new BusinessRuleValidationException("El separador de hora y minutos es el : (dos puntos) !");            
            if (minutos < 0 || minutos > 59)
                throw new BusinessRuleValidationException("Los minutos deben estar entre 0 y 59 !");
            HoraVuelo = horaVuelo;
        }


        public static implicit operator string(HoraVueloValue value)
        {
            return value.HoraVuelo;
        }


        public static implicit operator HoraVueloValue(string nameHoraVuelo)
        {
            return new HoraVueloValue(nameHoraVuelo);
        }
    }
}
