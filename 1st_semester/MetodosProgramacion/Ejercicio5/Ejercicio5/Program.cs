using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        

        }
        static int simpleArraySum(int[] ar)
        {

            int suma;
            suma = 0;
            int i = 0;
            for (i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
                suma = suma + ar[i];
            }
            return suma;
            Console.Write(suma);
            Console.ReadKey();
        }
    }
}
