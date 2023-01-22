using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_1
{
      internal class UtilesEntradas
    {
        public static int EntradaInt(string texto)
        {
            int nun;
            Console.WriteLine(texto);
            while (!Int32.TryParse(Console.ReadLine(), out nun))
                Console.WriteLine("tiene que ser un numero correcto");
            return nun;
        }
        public static decimal EntradaDecima()
        {
            decimal nun;
            Console.WriteLine($"dime un numero");
            while (!decimal.TryParse(Console.ReadLine(), out nun))
                Console.WriteLine("tiene que ser un numero correcto");
            return nun;
        }
        public static int[] EntradaVecInt(string texto, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"dime un numero");
                while (!Int32.TryParse(Console.ReadLine(), out vector[i]))
                    Console.WriteLine("tiene que ser un numero correcto");
            }
            return vector;
        }

    }
}
