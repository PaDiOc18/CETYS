using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double A;
            double B;
            double C;
            double raiz;
            double res1;
            double res2;
            double DA;
            double MB;
            Console.WriteLine("Ingrese A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese C: ");
            C = double.Parse(Console.ReadLine());
            raiz = (Math.Pow(B, 2)) - 4 * A * C;
            if (raiz >0)
            {
                MB = B * -1;
                DA = 2 * A;
                res1 = (MB + (Math.Sqrt(raiz))) / DA;
                res2 = (MB - (Math.Sqrt(raiz))) / DA;
                Console.WriteLine("Valor 1: {0}", res1);
                Console.WriteLine("Valor 2: {0}",res2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay raices negativas ");
                Console.ReadKey();
            }
        }
    }
}
