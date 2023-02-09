using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero
{
    internal class Funciones
    {
        public static void Primo()
        {

        }
        public static void Factorial()
        {

        }
        public static void Horas()
        {

        }
        public static void Pell()
        {
            int number1 = 0, number2 = 1;
            int aux = 0;

            //Casos bases 
            /*Console.WriteLine(number1);
            Console.WriteLine(number2);*/

            for (int i = 0; i < 15; i++)
            {
                aux = (number2 * 2) + number1;
                Console.WriteLine(aux);
                number1 = number2;
                number2 = aux;
            }
        }
        public static void Armstrong()
        {
            Console.Write("Introduzca un numero para calcular si es  o no Armstrong: ");
            string numero = Console.ReadLine();
            bool commprobante = Funciones.Armstrong1(numero);
            if (commprobante)
            {
                Console.WriteLine("Es armstrong");
            }
            else
            {
                Console.WriteLine("No es armstrong");
            }
        }
        public static bool Armstrong1(string number)
        {
            int num_usu = Convert.ToInt32(number);
            int longitud = number.Length;
            double resultado = 0;

            for (int i = 0; i < longitud; i++)
            {
                resultado += Math.Pow(Convert.ToInt32(number[0]), longitud);
            }

            if (resultado == num_usu)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Diferente()
        {
            int salida;
            while (Int32.TryParse(Console.ReadLine(), out salida))
            {
                Console.WriteLine("Introduzca un numero para saber si tiene o no los digitos distintos: ");
                if (Funciones.NumerosDif(salida))
                {
                    Console.WriteLine("Son iguales");

                }
                else
                {
                    Console.WriteLine("Son distintos");
                }
            }
        }
        public static bool NumerosDif(int number)
        {
            string str = number.ToString();
            return str.Length == str.Distinct().Count();
        }
    }
}
