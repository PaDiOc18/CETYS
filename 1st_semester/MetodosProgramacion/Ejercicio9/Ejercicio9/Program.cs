using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            int Num;
            int V;
            double res;
            Console.WriteLine("Ingrese Variable:  ");
            V = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Caso 1");
            Console.WriteLine("Caso 2");
            Console.WriteLine("Caso 3");
            Console.WriteLine("Ingrese Caso:  ");
            Num = Convert.ToInt32(Console.ReadLine());

            switch (Num)
            {

                case 1:
                    res = 100 * V;
                    break;
                case 2:
                    res = Math.Pow(100, V);
                    break;
                case 3:
                    res = 100 / V;
                    break;
                default:
                    res = 0;
                    break;

            }
            Console.WriteLine("El valor es:" + res);
            Console.ReadKey();
        }
    }
}
