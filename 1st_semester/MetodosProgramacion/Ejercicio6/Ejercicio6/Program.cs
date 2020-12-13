using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
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
            Console.WriteLine("Ingrese sueldo del trabajador: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());
            if (Sueldo < 1000)
            {
                Sueldo = (Sueldo * 0.15) + Sueldo; 
                Console.WriteLine(Sueldo);
                Console.WriteLine("Pulse Enter para salir");
                Console.ReadKey();
            }
            else
            {

            }
        }
    }
}
