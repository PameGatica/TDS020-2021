using System;

namespace EjerciciosFundamentosdeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, num;
            do
            {
                op = Menu();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("\nSuma de dígitos de un número");
                        SumaDigitos();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\nNumeros pares, impares y primos");
                        ParesImparesPrimos();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\nSecuencia Fibonacci");
                        do
                        {
                            num = LeeNum();
                            if (num < 2)
                            {
                                MensajeError("Valor debe ser mayor o igual a 2");
                            }
                        } while (num < 2);
                        Fibonacci(num);
                        Console.ReadKey();
                        break;
                }

            } while (op != 4);
        }

        private static void Fibonacci(int num)
        {
            int a = 0;
            int b = 1;
            int c;

            for (int i = 1; i <= num; i++)
            {
                Console.Write("{0} ", a);
                c = a + b;
                a = b;
                b = c;
            }
        }

        private static int LeeNum()
        {
            int num;
            bool correcto = true;
            do
            {
                Console.Write("Ingresa un número: ");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    MensajeError("Debes ingresar un número entero");
                    correcto = false;
                }
            } while (!correcto);

            return num;
        }

        private static void ParesImparesPrimos()
        {
            int num = LeeNum();
            Console.Write("\nPrimeros {0} pares: ", num);
            Pares(num);
            Console.Write("\nPrimeros {0} impares: ", num);
            Impares(num);
            Console.Write("\nPrimeros {0} primos: ", num);
            Primos(num);
        }

        private static void Primos(int num)
        {
            int cont = 0;
            int i = 1;
            while (cont < num)
            {
                if (EsPrimo(i))
                {
                    Console.Write("{0} ", i);
                    cont++;
                }
                i++;
            }
        }

        private static bool EsPrimo(int n)
        {
            if (n == 1 || n == 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private static void Impares(int num)
        {
            for (int i = 1; i < num * 2; i += 2)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void Pares(int num)
        {
            for (int i = 2; i < num * 2; i += 2)
            {
                Console.Write("{0} ", i);
            }
        }

        private static void SumaDigitos()
        {
            int suma = 0;
            int num = LeeNum();

            do
            {
                suma += num % 10;
                num = num / 10;
            } while (num != 0);

            Console.WriteLine("La suma de los dígitos es: " + suma);

        }

        private static int Menu()
        {
            int op;
            Console.Clear();
            Console.WriteLine("EJERCICIOS FUNDAMENTOS DE C#");
            Console.WriteLine("============================");
            Console.WriteLine("1. Suma de dígitos de un número");
            Console.WriteLine("2. Numeros pares, impares y primos");
            Console.WriteLine("3. Secuencia Fibonacci");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            int.TryParse(Console.ReadLine(), out op);

            if (op < 1 || op > 4)
            {
                MensajeError("Opción no válida");
            }
            return op;


        }

        private static void MensajeError(string m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(m);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
