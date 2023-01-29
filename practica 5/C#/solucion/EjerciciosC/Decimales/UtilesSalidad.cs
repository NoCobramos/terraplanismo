using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_3
{
    internal class UtileSalida
    {
        static public void MostraVecto(int[] vector)
        {
            Console.WriteLine("en:");
            foreach(int i in vector){Console.Write(i+" ");}
            Console.WriteLine();
        }
    }
}
