using System;
using Logica;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Monica";
            persona.Apellido = "Caballero";
            persona.FechaNacimiento = new DateTime(1980, 8, 6);

            Console.WriteLine("Hola " + persona);
            Console.WriteLine("Tienes {0} años", persona.Edad());

            Persona persona2 = new Persona("Teresa", "Lopez");
            persona2.FechaNacimiento = new DateTime(1982, 11, 2);
            Console.WriteLine("Hola " + persona2.Nombre);
            Console.WriteLine("Tienes {0} años", persona2.Edad());
        }
    }
}
