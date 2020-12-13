using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double N;
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.WriteLine("\n");
            Console.ReadKey();

            Console.WriteLine("Escribe el Numero que desees: (Que sea mayor que 0)");
            N = Convert.ToInt32(Console.ReadLine());

            if (N > 0)
            {
                double N1;
                double N2;

                N1 = Math.Pow(N,2);
                Console.WriteLine("El numero al cuadrado es: " + N1);
                N2 = Math.Pow(N, 3);
                Console.WriteLine("El numero al cubo es: " + N2);
            }
            else
            {
                Console.WriteLine("Numero Negativo, no aceptado");

            }
            Console.WriteLine("Pulse enter para salir");
            Console.ReadKey();
        }

    }
}
