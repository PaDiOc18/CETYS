using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            double Sueldo;
            Console.WriteLine("Ingrese sueldo del trabajador:  ");
            Sueldo = Convert.ToDouble(Console.ReadLine());
            if (Sueldo < 1000)
            {
                Sueldo = (Sueldo * 0.15) + Sueldo;
                Console.WriteLine("Nuevo sueldo:  " + Sueldo);
                Console.ReadKey();
            }
            else
            {
                Sueldo = (Sueldo * 0.12) + Sueldo;
                Console.WriteLine("Nuevo sueldo:  " + Sueldo);
                Console.ReadKey();
            }
        }
    }
}
