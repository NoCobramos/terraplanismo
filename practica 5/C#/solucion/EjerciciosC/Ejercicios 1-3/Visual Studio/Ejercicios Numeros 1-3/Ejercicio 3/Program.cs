//   Dado un número en segundos, devolver horas y minutos
//   (3680 segundos son 1 hora, 1 min, y 20 segundos).

using System;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cantidad de segundos:");
            int totalSegundos = int.Parse(Console.ReadLine());

            int horas = totalSegundos / 3600;
            int minutos = (totalSegundos % 3600) / 60;
            int segundos = totalSegundos % 60;

            Console.WriteLine(horas + " horas, " + minutos + " minutos, y " + segundos + " segundos");
        }
    }
}