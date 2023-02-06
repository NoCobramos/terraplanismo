// Calcular si el número es primo

using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ntroduce un número: ");
            int num = int.Parse(Console.ReadLine());
            bool primo = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine(num + " es un número primo.");
            }
            else
            {
                Console.WriteLine(num + " no es un número primo");
            }
            Console.ReadLine();
        }
    }
}