using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 2, 3, 4, 5, 4, 3, 2, 4, 3, 2, 4 };
            int[] res = Picos(arreglo);
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res);
            }

            Console.ReadKey();
        }
        static int[] Picos (int[] arreglo)
        {
            int[] picos = new int[arreglo.Length];
            int llevo = 0;
            for (int i = 0; i < arreglo.Length-1; i++)
            {
                if (arreglo[i-1] < arreglo[i] && )
                {

                }
            }
        }
    }
}
