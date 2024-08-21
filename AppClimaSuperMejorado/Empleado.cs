using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClimaSuperMejorado
{
    //definimos la clase base para los empleados de la empresa
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Empleado(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public abstract string ObtenerIdentificacion();
    }
    //tenemos la clase pasante, la cual es una sub clase de la clase empleados
    public class Pasante : Empleado
    {
        //numero de legajo
        public int NumeroLegajo { get; set; }

        public Pasante(string nombre, string apellido, int numeroLegajo)
            : base(nombre, apellido)
        {
            NumeroLegajo = numeroLegajo;
            Nombre = nombre;
            Apellido = apellido;
        }
        public override string ObtenerIdentificacion()
        {
            return $"Pasante: ( {Nombre},{Apellido} ) Legajo:( {NumeroLegajo} )";
        }
    }

    //tenemos la clase profesional, la cual es una sub clase de la clase empleados
    public class Profesional : Empleado
    {
        //numero de Matricula
        public int NumeroMatricula { get; set; }

        public Profesional (string nombre, string apellido, int numeroMatricula)
            : base(nombre, apellido)
        {
            NumeroMatricula = numeroMatricula;
            Nombre = nombre;
            Apellido = apellido;
        }
        public override string ObtenerIdentificacion()
        {
            return $"Profesional:( {Nombre},{Apellido} )  Matriculas:( {NumeroMatricula} )";
        }
    }
}
