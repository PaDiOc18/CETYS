using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            decimal Calif;
            Console.WriteLine("Ingrese calificación del alumno: ");
            Calif = Convert.ToDecimal(Console.ReadLine());
            if (Calif >= 8)
            {
                Console.WriteLine("Aprobado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Reprobado");
                Console.ReadKey();
            }
        }
    }
}
