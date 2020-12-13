using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
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
            if (N == 0)
            {
                Console.WriteLine("Nulo");
            }
            else
            {
                if (N >0)
                {
                    Console.WriteLine("Positivo");
                }
                else
                {
                    Console.WriteLine("Negativo");
                }
            }

            Console.ReadKey();
        }
    }
}
