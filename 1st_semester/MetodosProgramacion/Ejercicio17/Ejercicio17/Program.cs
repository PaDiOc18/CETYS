using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double A;
            double B;
            double C;
            Console.WriteLine("Ingrese A: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese B: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese C: ");
            C = double.Parse(Console.ReadLine());
            if (A>B)
            {
                if(B>C)
                {
                    Console.WriteLine(A);
                    Console.WriteLine(B);
                    Console.WriteLine(C);
                }
                else
                {

                    Console.WriteLine(A);
                    Console.WriteLine(C);
                    Console.WriteLine(B);
                }
            }
            else
            {
                if (B>A)
                {
                    if (A>C)
                    {
                        Console.WriteLine(B);
                        Console.WriteLine(A);
                        Console.WriteLine(C);
                    }
                    else
                    {
                        Console.WriteLine(B);
                        Console.WriteLine(C);
                        Console.WriteLine(A);
                    }
                }
                else
                {
                    if (C >A && A>B)
                    {
                        Console.WriteLine(C);
                        Console.WriteLine(A);
                        Console.WriteLine(B);
                    }
                    else
                    {
                        Console.WriteLine(C);
                        Console.WriteLine(B);
                        Console.WriteLine(A);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
