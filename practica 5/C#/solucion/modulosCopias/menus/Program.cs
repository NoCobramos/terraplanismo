using System.Security.Cryptography.X509Certificates;

namespace EjeciciosFinales
{
    //entrada x numero decimales de 2 digitos para 4 grupos 
    // dividir los gastos en 4 tipos 
    // comvertilos en una impesion de esos numero en asteriscos

    class Program
    {
        private static void Main(string[] args)
        {
            int optionMenu;
            decimal seguro = 0.005m;
            //Recojer datos
            do
            {
                Console.Clear();
                Console.WriteLine("Bien venido al menu");
                Console.WriteLine("Elija una de las siguientes opciones");
                Console.WriteLine("0_ Salir del programa");
                Console.WriteLine("1_");
                Console.WriteLine("2_");
                Console.WriteLine("3_");
                Console.WriteLine("4_");
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
                else if (optionMenu == 0)
                {


                }



            } while (optionMenu != 0);
            Console.WriteLine("salistes");
        }
    }
}
