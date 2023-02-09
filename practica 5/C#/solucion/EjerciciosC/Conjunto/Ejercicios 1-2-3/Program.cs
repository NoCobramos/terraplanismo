//Devolver si el string es un palíndromo

using System;

namespace Ejercicio_1
{
    class Program
    {
         static void Main(string[] args)
        {

            Console.WriteLine("Introduce una palabra para comprobar si es una palabra palíndroma o no:");
            string palabra = Console.ReadLine();
            bool palindromo = true;
            string inverso = "";

            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                char letras = Convert.ToChar(palabra[i]);

                inverso += letras.ToString();

                if (palabra == inverso)
                {
                    palindromo = false;
                }
            }
            if (palindromo)
            {
                Console.WriteLine("La palabra ingresada no es un palíndromo.");
            }
            else if (palindromo == false)
            {
                Console.WriteLine("La palabra ingresada si es un palíndromo.");
            }
        }
    }
}

