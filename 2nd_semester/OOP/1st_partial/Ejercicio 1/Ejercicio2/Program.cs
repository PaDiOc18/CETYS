using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribeme Apellido:");
            string Apellido = Console.ReadLine();
            Console.WriteLine("El nombre es: " + nombre + " " + Apellido);
            Console.ReadKey();
        }

        //static void ImprimeCuadrado(string Palabra)
        //{
        //    Console.WriteLine(Palabra);
        //    for (int i = 1; i < Palabra.Length-1; i++)
        //    {
        //        Console.WriteLine(Palabra[i]);
        //        for (int j = 0; j < Palabra.Length-2; j++)
        //        {
        //            Console.Write(" ");
        //        }
        //        Console.Write(Palabra[Palabra.Length - 1 - i]);
        //        Console.WriteLine();
        //    }
        //    for (int i = Palabra.Length-1; i >= 0 ; i--)
        //    {
        //        Console.Write(Palabra[i]);
        //    }
            

        
    }
}
