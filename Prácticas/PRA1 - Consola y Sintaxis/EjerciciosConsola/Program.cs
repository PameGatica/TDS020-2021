using System;

namespace EjerciciosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorTexto= ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = colorTexto;
            Console.Clear();

            Console.Write("Ingresa un texto: ");
            string texto = Console.ReadLine();

            int largo = texto.Length;

            Console.WriteLine("Texto ingresado: " + texto);
            Console.WriteLine("Cantidad de caracteres: " + largo);

            if (largo % 2  == 0)  // cantidad de caracteres par
            {
                colorTexto = ConsoleColor.White;
            }
            else // cantidad de caracteres impar
            {
                colorTexto = ConsoleColor.DarkRed;
            }

            Console.ForegroundColor = colorTexto;

            for (int i = 0; i < largo; i++)
            {
                Console.WriteLine(texto);
            }
        }
    }
}
