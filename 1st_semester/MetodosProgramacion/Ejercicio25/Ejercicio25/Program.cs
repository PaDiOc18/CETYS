using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Trabajando en Procedimientos";
            suma();
            Console.ReadKey();
            Console.Clear();
            resta();
            Console.ReadKey();
            Console.WriteLine("\n-----------> Fin del Programa -------!");
            Console.ReadKey();

        }
        static void suma()
        {
            double r, n1, n2;
            Console.WriteLine("Escribe la primera cantidad: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la segunda cantidad: ");
            n2 = double.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine("El resultado de la suma es: " + r);
        }
        static void resta()
        {
            double r, n1, n2;
            Console.WriteLine("Escribe la primera cantidad: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la segunda cantidad: ");
            n2 = double.Parse(Console.ReadLine());
            r = n1 - n2;
            Console.WriteLine("El resultado de la suma es: " + r);
        }
    }
}
