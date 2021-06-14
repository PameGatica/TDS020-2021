using System;
using Logica;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactoBLL cbll = new ContactoBLL();

            Persona persona1 = new Persona("Bruno", "Gatica", 98745632);
            Persona persona2 = new Persona("Franco", "Aguilera", 56874512);
            Persona persona3 = new Persona("Sofia", "Garrido", 87465821);

            persona1.Grupo = Clasificacion.Trabajo;
            persona3.Grupo = Clasificacion.Trabajo;

            cbll.Agregar(persona1);
            cbll.Agregar(persona2);
            cbll.Agregar(persona3);

            Console.WriteLine("Todos los contactos: ");
            foreach (Persona p in cbll.Listar())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("Contactos grupo Trabajo:");
            foreach (Persona p in cbll.Listar(Clasificacion.Trabajo))
            {
                Console.WriteLine(p);
            }
        }
    }
}
