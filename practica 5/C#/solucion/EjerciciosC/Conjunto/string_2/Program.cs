// Escribir el nombre todo en mayúsculas y todo en minúsculas.

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("El nombre introducido en mayúscula sería:" + nombre.ToUpper());
            Console.WriteLine("El nombre introducido en munúsculas sería: " + nombre.ToLower());
        }
    }
}