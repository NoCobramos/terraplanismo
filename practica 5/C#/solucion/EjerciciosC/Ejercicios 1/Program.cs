using System.Security.Cryptography.X509Certificates;

namespace EjeciciosFinales
{

    class Program
    {
        private static void Main(string[] args)
        {
            int optionMenu;
            do
            {
                Console.Clear();
                Console.WriteLine("Bien venido al menu de Array");
                Console.WriteLine("Elija una de las siguientes opciones");
                Console.WriteLine("0_ Salir del programa");
                Console.WriteLine("1_Calcular Maximo");
                Console.WriteLine("2_Calcular Mínimo");
                Console.WriteLine("3_Calcular Media");
                Console.WriteLine("4_Ordenar de mayor a menor");
                Console.WriteLine("5_Binarizar");
                while (!(Int32.TryParse(Console.ReadLine(), out optionMenu)) && (optionMenu >= 0 && optionMenu <= 4))
                    Console.WriteLine("elija un numero del los designados");
                if (optionMenu == 1)
                {

                }
                else if (optionMenu == 2)
                {

                }
                else if (optionMenu == 3)
                {

                }
                else if (optionMenu == 4)
                {

                }
                else if (optionMenu == 5)
                {


                }
                else if(optionMenu==0)
                {

                }

            } while (optionMenu != 0);
            Console.WriteLine("salistes");
        }
    }
}