// Calcular factorial

using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número para calcular su factorial:");
            int num = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de " + num + " es: " + factorial);
            Console.ReadLine();
        }
    }
}