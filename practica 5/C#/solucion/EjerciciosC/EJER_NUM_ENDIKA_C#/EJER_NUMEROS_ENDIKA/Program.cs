namespace EJER_NUMEROS_ENDIKA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funciones.SecuenciaPell();

            Console.Write("Introduzca un numero para calcular si es  o no Armstrong: ");
            string numero  = Console.ReadLine();
            bool commprobante = Funciones.Armstrong(numero);
            if(commprobante)
            {
                Console.WriteLine("Es armstrong");
            }
            else
            {
                Console.WriteLine("No es armstrong");
            }

            
            int salida;
            while(Int32.TryParse(Console.ReadLine(), out salida))
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


            Funciones.Bye();
        }
    }
}