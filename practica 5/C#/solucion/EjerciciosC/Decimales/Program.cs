using ejercicios_1;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace EjeciciosFinales
{

    class Program
    {
        private static void Main(string[] args)
        {
            decimal nun;
            double a, b,c;
            int optionMenu;
            do
            {
                Console.Clear();
                Console.WriteLine("Bien venido al menu de Decimales");
                Console.WriteLine("Elija una de las siguientes opciones");
                Console.WriteLine("0_ Salir del programa");
                Console.WriteLine("1_Redondear al alza");
                Console.WriteLine("2_Eliminar los decimales");
                Console.WriteLine("3_ecuacion de segundo grado");
                while (!(Int32.TryParse(Console.ReadLine(), out optionMenu)) && (optionMenu >= 0 && optionMenu <= 4))
                    Console.WriteLine("elija un numero del los designados");
                switch (optionMenu)
                {
                    case 1:
                        nun=UtilesEntradas.EntradaDecima();
                        Console.WriteLine($"Numero sin redondear: {nun}");
                        nun=UtilesAction.ThreeDecimal(nun);
                        Console.WriteLine($"numero redondeado {nun}");
                        Console.ReadKey();
                        break;
                    case 2:
                        nun = UtilesEntradas.EntradaDecima();
                        Console.WriteLine($"Numero: {nun}");
                        nun = UtilesAction.NotDecimal(nun);
                        Console.WriteLine($"Numero sin decimales: {nun}");
                        Console.ReadKey();
                        break;
                    case 3:
                        a = UtilesEntradas.EntradaDouble();
                        b = UtilesEntradas.EntradaDouble();
                        c = UtilesEntradas.EntradaDouble();
                        UtilesAction.Ecuaciones(a, b, c);
                        Console.ReadKey();
                        break;
         
                }

            } while (optionMenu != 0);
            Console.WriteLine("salistes");
        }
    }
}
