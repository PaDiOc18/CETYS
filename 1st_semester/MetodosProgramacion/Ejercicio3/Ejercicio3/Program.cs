using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.WriteLine("\n");
            Console.ReadKey();
            double Base;
            double Altura;
            Console.WriteLine("Ingrese la base");
            Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            Altura = Convert.ToInt32(Console.ReadLine());
            double Perimetro;
            double Area;
            Perimetro = Base *2 + Altura * 2;
            Area = Base * Altura;
            Console.WriteLine("El perimetro es: " + Perimetro);
            Console.WriteLine("El Area es: " + Area);
            Console.ReadKey();
        }
    }
}
