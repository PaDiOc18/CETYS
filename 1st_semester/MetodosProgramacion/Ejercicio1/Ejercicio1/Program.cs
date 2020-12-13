using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.WriteLine("\n");
            Console.WriteLine("Pulse Enter para continuar");
                Console.ReadKey();
            Console.WriteLine("Ingrese valor de A: ");
                A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese valor de B: ");
                B = Convert.ToInt32(Console.ReadLine());
            double res;
            res = A + B;
            res = Math.Pow(res, 2);
            res = res / 3;
            Console.WriteLine("El resultado3 es: " + res);
            Console.WriteLine("Pulse enter para salir");
                Console.ReadKey();
        }
    }
}
