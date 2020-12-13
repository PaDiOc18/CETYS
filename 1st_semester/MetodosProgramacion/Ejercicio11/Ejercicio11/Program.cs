using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            int Sonidos;
            int Temperatura;
            Console.WriteLine("Ingrese numero de sonidos emitidos: ");
            Sonidos = int.Parse(Console.ReadLine());
            if (Sonidos >= 0)
            {
                
                Temperatura = (Sonidos / 4) + 40;
                Console.WriteLine("La temperatura total en farenheit es: {0}", Temperatura);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay sonidos negativos");
                Console.ReadKey();
            }
            
        }

    }
}
