using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            double sueldo;
            sueldo = 1;
            double numEmpleMayor;
            numEmpleMayor = 0;
            double mayor;
            mayor = 0;
            int Contador;
            Contador = 0;
            Console.WriteLine("Para salir del programa, teclear 0");

            while (sueldo > 0)
            {
                Contador = Contador + 1;
                Console.WriteLine("Numero del empleado: " + Contador);
                Console.WriteLine("Ingrese sueldo del trabajador");
                sueldo = int.Parse(Console.ReadLine());

                if (sueldo > mayor)
                {
                    numEmpleMayor = Contador;
                    mayor = sueldo;
                }
                Console.Write("\n");

            }
            Console.WriteLine("El numero de empleado con mayor sueldo es: " + numEmpleMayor);
            Console.WriteLine("Su sueldo es " + mayor);
            Console.ReadKey();
        }
    }
}
