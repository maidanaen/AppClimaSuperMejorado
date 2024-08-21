using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClimaSuperMejorado
{
    public class EstacionMeteorologica
    {
        //matriz para cargar las temperaturas
        public RegistroTemperatura[,] matrizRegis;

        public EstacionMeteorologica()
        {
            matrizRegis = new RegistroTemperatura[5, 7]; // 5 semanas, 7 días
            CargarDatos();
        }

        public void CargarDatos()
        {
            //cargamos las temperaturas de manera automatica usando random
            Random rand = new Random();
            List<Empleado> personas = new List<Empleado>
            {
                new Pasante("Juan", "Perez", 1234),
                new Profesional("Ana", "Gomez", 5678),
                new Pasante("Lucas", "Diaz", 91011),
                new Profesional("Maria", "Lopez", 1213),
                new Pasante("Carlos", "Sanchez", 1415),
                new Profesional("Laura", "Fernandez", 1617),
            };

            DateTime fechaInicial = new DateTime(2024, 8, 1, 0, 0, 0);
            int personaIndex = 0;

            for (int semana = 0; semana < matrizRegis.GetLength(0); semana++)
            {
                for (int dia = 0; dia < matrizRegis.GetLength(1); dia++)
                {
                    if (semana * 7 + dia < 31)
                    {
                        matrizRegis[semana, dia] = new RegistroTemperatura
                            (
                            rand.Next(-10, 43),
                            personas[personaIndex % personas.Count],
                            fechaInicial.AddDays(semana * 7 + dia).AddHours(rand.Next(0, 24))
                            );
                        personaIndex++;
                    }
                }
            }
        }

        public void GuardarTemperatura(RegistroTemperatura registro, int semana, int dia)
        {
            if (semana * 7 + dia < 31)
            {
                matrizRegis[semana, dia] = registro;
            }
            else
            {
                Console.WriteLine("Fecha incorrecta.");
            }
        }

        public void VerTemperaturas()
        {
            for (int semana = 0; semana < matrizRegis.GetLength(0); semana++)
            {
                for (int dia = 0; dia < matrizRegis.GetLength(1); dia++)
                {
                    if (matrizRegis[semana, dia] != null)
                    {
                        Console.WriteLine(matrizRegis[semana, dia]);
                    }
                }
            }
        }

        public RegistroTemperatura VerTemperaturaDia(int dia)
        {
            int semana = (dia - 1) / 7;
            int diaSem = (dia - 1) % 7;

            return matrizRegis[semana, diaSem];
        }
    }
}

