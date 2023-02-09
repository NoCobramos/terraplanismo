using System;
using System.Text;

namespace String2
{
    class String02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cadena por favor: ");
            string cadena = Console.ReadLine();
            while (cadena.Length == 0)
            {
                Console.WriteLine("La cadena está vacía");
                Console.WriteLine("Introduce una cadena por favor: ");
                cadena = Console.ReadLine();
            }
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.Write(cadena[i] +""+ cadena[i]);
            }

        }
    }
}
