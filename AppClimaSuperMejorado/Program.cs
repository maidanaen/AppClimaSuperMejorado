using AppClimaSuperMejorado;
namespace AppClimaSuperMejorado
{
    
    public class Program
    {
        #region
        static void Main(string[] args)
        {
            // Crear la estación meteorológica
            EstacionMeteorologica estacion = new EstacionMeteorologica();

            // Ver todas las temperaturas registradas (inicialmente cargadas automaticamente)
            Console.WriteLine("Temperaturas registradas en el mes:");
            estacion.VerTemperaturas();

            // Consultar la temperatura de un día específico 
            Console.WriteLine("\nIngresar un dia para verificar su temperatura :");
            int dia = int.Parse(Console.ReadLine());
            var tempDia = estacion.VerTemperaturaDia(dia);
            if (tempDia != null)
            {
                Console.WriteLine(tempDia);
                
            }
            else
            {
                Console.WriteLine("No se encontró un registro para ese día.");
            }

            //calcular el promedio mensual de temperaturas
            float promedioMensual = CalculoTemperaturas.CalcularPromedioMensual(estacion.matrizRegis);
            Console.WriteLine($"\nPromedio mensual de temperaturas: {promedioMensual:F2} °C");

            //calcular la temperatura máxima registrada
            int tempMaxima = CalculoTemperaturas.CalcularTemperaturaMaxima(estacion.matrizRegis);
            Console.WriteLine($"Temperatura máxima registrada en el mes: {tempMaxima} °C");

            // calcular la temperatura mínima registrada
            int tempMinima = CalculoTemperaturas.CalcularTemperaturaMinima(estacion.matrizRegis);
            Console.WriteLine($"Temperatura mínima registrada en el mes: {tempMinima} °C");
            #endregion



        }
    }
}
//// Registrar una nueva temperatura manualmente
//Console.WriteLine("\nRegistrando una nueva temperatura manualmente...");
//Pasante pasante = new Pasante("Fernando", "Hernandez", 2021);
//RegistroTemperatura nuevoRegistro = new RegistroTemperatura(25, pasante, DateTime.Now);
//estacion.GuardarTemperatura(nuevoRegistro, 4, 3); // Semana 5, Día 4

//// Ver todas las temperaturas después de la nueva adición
//Console.WriteLine("\nTemperaturas actualizadas en el mes:");
//estacion.VerTemperaturas();