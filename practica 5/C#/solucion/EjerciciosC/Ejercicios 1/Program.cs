using ejercicios_1;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace EjeciciosFinales
{

    class Program
    {
        private static void Main(string[] args)
        {
            string entrada = "dime el tamaño del Array", entradaVec="dime un numero";
            int size = UtilesEntradas.EntradaInt(entrada), max; ;
            int[] vector = new int[size];
            UtilesEntradas.EntradaVecInt(entradaVec,vector);
            bool check = true;
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
                while (!(Int32.TryParse(Console.ReadLine(), out optionMenu)) && (optionMenu >= 0 && optionMenu <= 5))
                    Console.WriteLine("elija un numero del los designados");
               switch(optionMenu)
                {
                    case 1:
                        Console.WriteLine($"El numero maximo del vector es: {UtilesAction.MaxVector(vector)}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"El numero Minimo del vector es: {UtilesAction.devolverMin(vector)} ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"la Media del vector es: {UtilesAction.Media(vector)}");
                        Console.ReadKey();
                        break;
                    case 4:
                        UtilesAction.OrdenarVecMenorMayor(vector);
                        UtileSalida.MostraVecto(vector);
                        Console.ReadKey();
                        break;
                    case 5:
                        UtilesAction.Binarizar(vector);
                        UtileSalida.MostraVecto(vector);
                        Console.ReadKey();
                        break;

                        
                }

            } while (optionMenu != 0);
            Console.WriteLine("salistes");
        }
    }
}