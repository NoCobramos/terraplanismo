using System;

namespace String2
{
    class String02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una cadena");
            string cadena1 = Console.ReadLine();
            while (cadena1.Length == 0)
                Console.WriteLine("La cadena está vacía");
                Console.WriteLine("Introduce una cadena por favor: ");
                cadena1 = Console.ReadLine();
            
            Console.WriteLine("Introduzca cadena numero 2");
            string cadena2 = Console.ReadLine();
            while (cadena2.Length == 0)
            {
                Console.WriteLine("La cadena está vacía");
                Console.WriteLine("Introduce una cadena por favor: ");
                cadena2 = Console.ReadLine();
            }
            string cadena3 = cadena1+ " " + cadena2;
            Console.WriteLine("Dime el numero de veces que se repiten");
            int repetir = Convert.ToInt32(Console.ReadLine());  
            for(int i = repetir; i > 0; i--)
            {
                Console.WriteLine(cadena3);
            }

        }
    }
}
