using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClimaSuperMejorado
{
    public class RegistroTemperatura
    {
        public int Temperatura { get; set; }
        public Empleado PersonaDeTurno { get; set; }
        public DateTime FechaRegistro { get; set; }

        public RegistroTemperatura(int temperatura, Empleado personaDeTurno, DateTime fechaRegistro)
        {
            Temperatura = temperatura;
            PersonaDeTurno = personaDeTurno;
            FechaRegistro = fechaRegistro;
        }
        public override string ToString()
        {
            return $"{FechaRegistro.ToString("dd/MM/yyyy")}: Temperatura-> {Temperatura}°C - Registrado por: {PersonaDeTurno.ObtenerIdentificacion()}";
        }
    }
}
