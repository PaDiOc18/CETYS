using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            //Proceso
            for (int i = 0; i < Numeros.Length - 1; i++)
            {
                if (Numeros[i] % 2 == 0)
                {

                }
            }
        }
    }
}