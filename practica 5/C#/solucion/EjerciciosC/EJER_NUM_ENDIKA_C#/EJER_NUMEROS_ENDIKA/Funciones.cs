using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_NUMEROS_ENDIKA
{
    internal class Funciones
    {
        //Funciones
        public static void SecuenciaPell()
        {
            int number1 = 0, number2 = 1;
            int aux = 0;

            //Casos bases 
            /*Console.WriteLine(number1);
            Console.WriteLine(number2);*/

            for(int i  = 0; i < 15; i++) 
            { 
                aux = (number2 * 2) + number1;
                Console.WriteLine(aux);
                number1 = number2;
                number2 = aux;
            }
        }

        public static bool Armstrong(string number)
        {
            int num_usu = Convert.ToInt32(number);
            int longitud = number.Length;
            double resultado = 0;
            
            for(int i = 0; i < longitud; i++)
            {
                resultado += Math.Pow(Convert.ToInt32(number[0]),longitud);
            }

            if(resultado == num_usu)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool NumerosDif(int number)
        {
            string str = number.ToString();
            return str.Length == str.Distinct().Count();
        }


        //Para finalizar el progrma
        public static void Bye()
        {
            Console.WriteLine("Pulser cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
