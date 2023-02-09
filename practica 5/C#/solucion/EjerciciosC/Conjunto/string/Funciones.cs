using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Funciones
    {
        public static void Palindromo()
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
                Console.ReadKey();
            }
            else if (!palindromo)
            {
                Console.WriteLine("La palabra ingresada si es un palíndromo.");
                Console.ReadKey();
            }
        }
        public static void MayusMinus()
        {
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("El nombre introducido en mayúscula sería:" + nombre.ToUpper());
            Console.WriteLine("El nombre introducido en munúsculas sería: " + nombre.ToLower());

            Console.ReadKey();

        }
        public static void Ocurrencias()
        {
            Console.WriteLine("Introduce una frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Introduce una letra: ");
            char letra = Console.ReadLine()[0]; ;

            int count = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == letra)
                {
                    count++;
                }
            }

            Console.WriteLine("La letra " + letra + " aparece " + count + " veces.");
            Console.ReadKey();


        }
        public static void Repetir()
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
            string cadena3 = cadena1 + " " + cadena2;
            Console.WriteLine("Dime el numero de veces que se repiten");
            int repetir = Convert.ToInt32(Console.ReadLine());
            for (int i = repetir; i > 0; i--)
            {
                Console.WriteLine(cadena3);
            }
            Console.ReadKey();
        }
        public static void RepetirChar()
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
                Console.Write(cadena[i] + "" + cadena[i]);
            }
            Console.ReadKey();
        }
        public static void Borrar()
        {
            string resultado = "";
            string cadenaFin = "";
            Console.WriteLine("Introduce una cadena por favor: ");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("Introduce la segunda cadena por favor: ");
            string cadena2 = Console.ReadLine();

            for (int i = 0, j = 0; i < cadena1.Length; i++)
            {
                if (cadena1[i] == cadena2[j])
                {
                    if (j == cadena2.Length - 1)
                    {
                        cadenaFin = "";
                        j = 0;
                    }
                    else
                    {
                        cadenaFin += cadena1[i]; j++;
                    }
                }
                else
                {
                    resultado += cadenaFin;
                    cadenaFin = "";

                    if (j == 0)
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
            Console.ReadKey();
        }
    }
}
