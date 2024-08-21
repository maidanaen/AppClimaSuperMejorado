using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClimaSuperMejorado
{
    public static class CalculoTemperaturas
    {
        public static float CalcularPromedioMensual(RegistroTemperatura[,] registros)
        {
            int sumaTemperaturas = 0;
            int contadorDias = 0;

            for (int semana = 0; semana < registros.GetLength(0); semana++)
            {
                for (int dia = 0; dia < registros.GetLength(1); dia++)
                {
                    if (registros[semana, dia] != null)
                    {
                        sumaTemperaturas += registros[semana, dia].Temperatura;
                        contadorDias++;
                    }
                }
            }

            return (float)sumaTemperaturas / contadorDias;
        }

        public static int CalcularTemperaturaMaxima(RegistroTemperatura[,] registros)
        {
            int maxTemp = int.MinValue;

            for (int semana = 0; semana < registros.GetLength(0); semana++)
            {
                for (int dia = 0; dia < registros.GetLength(1); dia++)
                {
                    if (registros[semana, dia] != null && registros[semana, dia].Temperatura > maxTemp)
                    {
                        maxTemp = registros[semana, dia].Temperatura;
                    }
                }
            }

            return maxTemp;
        }

        public static int CalcularTemperaturaMinima(RegistroTemperatura[,] registros)
        {
            int minTemp = int.MaxValue;

            for (int semana = 0; semana < registros.GetLength(0); semana++)
            {
                for (int dia = 0; dia < registros.GetLength(1); dia++)
                {
                    if (registros[semana, dia] != null && registros[semana, dia].Temperatura < minTemp)
                    {
                        minTemp = registros[semana, dia].Temperatura;
                    }
                }
            }

            return minTemp;
        }
    }

}
