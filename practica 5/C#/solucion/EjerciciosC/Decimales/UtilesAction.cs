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
            int nun=vector.Min();
            Console.WriteLine(nun);
            return nun;
        }
        public static int devolverPosMin(int[]vector)
        {
            int cont = 0, nun=0;
            bool check = false;
           do
            {
                if (vector.Min() == vector[cont])
                {
                    nun=cont;
                    check = true;
                }
                else cont++;

            } while (!check || nun==vector.Min());
            return nun;
        }
           public static int[] GenerarRanVecInt(int[]vector)
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
            bool es=false; 
            if(año % 400==0 || (año % 100 == 1 && año % 4 == 0)){ es = true;}
            return es;
        }
        public static decimal ThreeDecimal(decimal nun)
        {
            return Math.Round(nun, 3,MidpointRounding.ToEven);
        }
        public static decimal NotDecimal(decimal nun)
        {
            return Math.Truncate(nun);
        }
        public static void Ecuaciones(double a, double b, double c)
        {
           double x, x2, conRazi;
            conRazi = Math.Pow(b, 2) - 4 * a * c;
            x =-b-Math.Sqrt(conRazi);
            x2 = -b+ Math.Sqrt(conRazi);
            x /= 2 * a;
            x2 /= 2 * a;
            Console.WriteLine($"los baloresd de x son x1={x} y x{x2}");
            
        }
    }
}
