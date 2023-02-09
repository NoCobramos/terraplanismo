using System;
using System.Text;

namespace String2
{
    class String02
    {
        static void Main(string[] args)
        {
            string resultado = "";
            string cadenaFin = "";
            Console.WriteLine("Introduce una cadena por favor: ");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Introduce la segunda cadena por favor: ");
            string cadena2 = Console.ReadLine();

           for(int i = 0, j = 0; i < cadena1.Length; i++)
            {
                if(cadena1[i] == cadena2[j])
                {
                    if(j == cadena2.Length - 1)
                    {
                        cadenaFin = "";
                        j = 0;
                    }
                    else
                    {
                        cadenaFin += cadena1[i];j++;
                    }
                }
                else
                {
                    resultado += cadenaFin;
                    cadenaFin = "";

                    if( j == 0)
                    {
                        resultado += cadena1[i];
                    }
                    else
                    {
                        j = 0;
                        i--;
                    }
                }
            }
            Console.WriteLine(resultado);
        }
    }
}
