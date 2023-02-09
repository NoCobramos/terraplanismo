using System.Security.Cryptography.X509Certificates;

namespace Strings
{

    class Program
    {
        public static void Main(string[] args)
        {
            int optionMenu;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al menu de strings");
                Console.WriteLine("Elije una de las siguientes opciones");
                Console.WriteLine("0_Salir del programa");
                Console.WriteLine("1_Palindromo");
                Console.WriteLine("2_Mayusculas y Minusculas");
                Console.WriteLine("3_Ocurrencias");
                Console.WriteLine("4_Repetir frase");
                Console.WriteLine("5_Repetir char");
                Console.WriteLine("6_Borrar string");
                while (!(Int32.TryParse(Console.ReadLine(), out optionMenu)))
                    Console.WriteLine("Inserta un numero valido");
                switch (optionMenu)
                {
                    case 1:
                        Funciones.Palindromo();
                        break;

                    case 2:
                        Funciones.MayusMinus();
                        break;
                    case 3:
                        Funciones.Ocurrencias();
                        break;
                    case 4:
                        Funciones.Repetir();
                        break;
                    case 5:
                        Funciones.RepetirChar();
                        break;
                    case 6:
                        Funciones.Borrar();
                        break;
                }
            } while (optionMenu != 0);
            Console.WriteLine("salistes");
        }
    }
}