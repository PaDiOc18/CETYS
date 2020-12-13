using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            int N;
            Console.WriteLine("Ingrese Numero: ");
            N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                if (N % 2 > 0)
                {
                    Console.WriteLine("Impar");
                }
                else
                {
                    Console.WriteLine("Nulo");
                }
            }

            Console.ReadKey();
        }
    }
}
