using System;
using System.Text;

namespace String2
{
    class String02
    {
        static void Main(string[] args)
        {
            char char1;
            string cadenaFin = "";
            Console.WriteLine("Introduce una cadena por favor: ");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Introduce la segunda cadena por favor: ");
            string cadena2 = Console.ReadLine();
            if (cadena1.Length > cadena2.Length)
            {
                for(int i = 0; i< cadena1.Length; i++)
                {
                    if (cadena2[i] == cadena1[i])
                    {
                        char1 = cadena1[i];
                        cadenaFin = char1.ToString();
                    }

                }
                
                Console.WriteLine(cadenaFin);
            }
            if(cadena1.Length<cadena2.Length)
            {

            }


        }
    }
}
