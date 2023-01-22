using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_1
{
    internal class UtilesAction
    {
        public static int devolverMin(int[] vector)
        {
            int nun = vector.Min();
            Console.WriteLine(nun);
            return nun;
        }
        public static int devolverPosMin(int[] vector)
        {
            int cont = 0, nun = 0;
            bool check = false;
            do
            {
                if (vector.Min() == vector[cont])
                {
                    nun = cont;
                    check = true;
                }
                else cont++;

            } while (!check || nun == vector.Min());
            return nun;
        }
        public static int[] GenerarRanVecInt(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Random ale = new Random();
                vector[i] = ale.Next(1, 99);
            }
            return vector;
        }
        public static bool IsBisiesto(int año)
        {
            bool es = false;
            if (año % 400 == 0 || (año % 100 == 1 && año % 4 == 0)) { es = true; }
            return es;
        }
        public static int MaxVector( int[] vector)
        {
            int salida = vector.Max();
            return salida;
        }
        public static double Media(int[] vector)
        {
            double paso = vector.Average();
            return paso;
        }
        public static void OrdenarVecMenorMayor(int[] vector)
        {
            Array.Sort(vector);  
        }
        public static void Binarizar(int[] vector)
        {
            int nun = 0;
            Console.WriteLine("dime un numero  para compararlo con el vevtor");
            while (!Int32.TryParse(Console.ReadLine(), out nun))
                Console.WriteLine("tiene que ser un numero correcto");
            for (int i = 0; i < vector.Length; i++)
            {
                if (nun > vector[i]) { vector[i] = 0;}
                else {vector[i] = 1;}   
            }
        }
    }
}

