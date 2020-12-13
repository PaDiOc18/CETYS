using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
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
            Console.WriteLine("Ingrese Calificación del Alumno: ");
            Calif = Convert.ToDecimal(Console.ReadLine(
                ));
            if (Calif > 8 )
            {
                Console.WriteLine("Aprobado");
                Console.WriteLine("Pulse Enter para salir");
                Console.ReadKey();
            }
            else
            {
                
            }

        }
    }
}
