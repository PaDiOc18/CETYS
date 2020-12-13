using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double P;
            double Q;
            double P3;
            double Q4;
            double P2;
            double res;
            Console.WriteLine("Ingrese P: ");
            P = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Q: ");
            Q = double.Parse(Console.ReadLine());
            P3 = Math.Pow(P,3);
            P2 = Math.Pow(P,2);
            Q4 = Math.Pow(Q, 4);
            res = (P3 + Q4) - (2 * P2);
            if (res < 680)
            {

                
                Console.WriteLine("P es igual a: {0} Y Q es igual a: {1} Calculo auxiliar es: {2}",P,Q, res);
                Console.WriteLine("Verdadero");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Falso");
                Console.ReadKey();
            }
        }
    }
}
