// Devolver el número de ocurrencias de una letra.

using System;

namespace ejercicio_3
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce una frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Introduce una letra: ");
            char letra = Console.ReadLine()[0]; ;

            int count = CountLetter(frase, letra);
            Console.WriteLine("La letra " + letra + " aparece " + count + " veces.");

        }

        static int CountLetter(string frase, char letra)
        { 
            int count = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == letra)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
