using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {

        public struct Operacion
        {
            public int n1, n2;

            public Operacion(int v1, int v2)
            {
                n1 = v1;
                n2 = v2;
            }
        }
        static void Main(string[] args)
        {
            int resul = 0;
            Console.WriteLine("Pablo Díaz Ochoa");
            Console.WriteLine("Matrícula: 030343");
            Operacion Operacioncita;
            Console.WriteLine("Ingrese Numero Entero 1");
            Operacioncita.n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Numero Entero 2");
            Operacioncita.n2 = int.Parse(Console.ReadLine());
            resul = Operacioncita.n1 + Operacioncita.n2;
            Console.WriteLine("La suma es: " + resul);
            Console.ReadKey();
        }
    }
}
