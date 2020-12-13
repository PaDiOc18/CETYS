using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewtonRaphson(3);

            PuntoFijo2(2);

            Console.ReadKey();



            //Ejercicio 1
            double ValorFuncionNewtonDerivada(double x)
            {
                //double Funcion = 3 * Math.Pow(x, 2) - 1;
                double Funcion = 2*x - 1;
                return Funcion;
            }
            double ValorFuncionNewton(double x)
            {
                //double Funcion = Math.Pow(x, 3) - x - 1;
                double Funcion = Math.Pow(x,2) - x - 1 ;
                return Funcion;
            }
            void NewtonRaphson(double ValorInicial)
            {
                Console.WriteLine("--Método de Newton Rhapson");
                double p = 0, p0 = 0;
                int Itera = 0;
                bool sigue = true;
                p0 = ValorInicial;
                while (sigue == true)
                {
                    p = p0 - (ValorFuncionNewton(p0) / ValorFuncionNewtonDerivada(p0));
                    Console.WriteLine("Valor de p: " + p);
                    Console.WriteLine("Valor de p0: " + p0);
                    Console.WriteLine("La diferencia es de: " + Math.Abs(p - p0));
                    Console.WriteLine("Número de Iteración: " + Itera);
                    Console.WriteLine("________________________");
                    if (Math.Abs(p - p0) < 0.0001)
                    {
                        Console.WriteLine("Tolerancia alcanzada");
                        break;
                    }
                    Itera++;
                    p0 = p;
                }
                Console.WriteLine("La raíz es: " + p);
                Console.WriteLine("Número de Iteraciones es: " + Itera);
            }

            //Ejercicio 3
            double ValorFuncionDespeje2(double x)
            {
                double temp = (22 * Math.Sin(x))/10 ;
                double funcion = Math.Sqrt(temp);
                return funcion;
            }

            void PuntoFijo2(double puntoInicial)
            {
                Console.WriteLine("--Método Punto fijo");
                bool sigue = true;
                double x = 0, x0 = 0;
                int aux = 0;
                x0 = puntoInicial;
                while (sigue == true)
                {
                    
                    x = ValorFuncionDespeje2(x0);
                    Console.WriteLine("Valor de x: " + x);
                    Console.WriteLine("Valor de x0: " + x0);
                    Console.WriteLine("Diferencia: " + Math.Abs(x - x0));
                    Console.WriteLine("Iteración: " + aux);
                    Console.WriteLine("________________________");

                    if (Math.Abs(x - x0) < 0.0001)
                    {
                        Console.WriteLine("Tolerancia alcanzada");
                        break;
                    }
                    x0 = x;
                    aux++;
                }
                Console.WriteLine("El número es: " + x);
                Console.WriteLine("Número de iteraciones: " + aux);


            }



        }
    }
}
