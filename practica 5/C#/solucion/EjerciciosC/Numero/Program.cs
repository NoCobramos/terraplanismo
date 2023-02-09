using System.Security.Cryptography.X509Certificates;

namespace Numero
{


    class Program
    {
        private static void Main(string[] args)
        {
            int optionMenu;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al menu de Numeros");
                Console.WriteLine("Elija una de las siguientes opciones");
                Console.WriteLine("0_ Salir del programa");
                Console.WriteLine("1_Primos");
                Console.WriteLine("2_Factorial");
                Console.WriteLine("3_segundo a horas y minutos");
                Console.WriteLine("4_15 primeros numeros de Pell");
                Console.WriteLine("5_Armstrong");
                Console.WriteLine("6_Diferente");

                while (!(Int32.TryParse(Console.ReadLine(), out optionMenu)))
                    Console.WriteLine("Introduce un número valido");
                switch (optionMenu)
                {
                    case 1:
                        Funciones.Primo();
                        break;

                    case 2:
                        Funciones.Factorial();
                        break;

                    case 3:
                        Funciones.Horas();
                        break;

                    case 4:
                        Funciones.Pell();
                        break;

                    case 5:
                        Funciones.Armstrong();
                        break;

                    case 6:
                        Funciones.Diferente();
                        break;
                }


            } while (optionMenu != 0);
            Console.WriteLine("salistes");
        }
    }
}