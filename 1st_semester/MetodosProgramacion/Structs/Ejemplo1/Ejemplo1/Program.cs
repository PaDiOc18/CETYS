using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        public struct Impresion
        {
            public int Uno, Dos;

            public Impresion(int  V1, int V2)
            {
                Uno = V1;
                Dos = V2;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Díaz Ochoa");
            Console.WriteLine("Matrícula: 030343");
            Impresion Imprimir;
            Imprimir.Uno = 19;
            Imprimir.Dos = 1999;
            Console.WriteLine("Mi nombre es Pablo y nací en: " + Imprimir.Dos + " y tengo: " + Imprimir.Uno + " años");
            Console.ReadKey();
        }
    }
}
