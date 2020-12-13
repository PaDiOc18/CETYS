

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bisección2(1,3);
            //NewtonRaphson2(3);
            //PuntoFijo2(3);
            Console.ReadKey();



            //Bisección
            double ValorFuncion2(double x)
            {
                double Funcion = Math.Pow(x, 3) - 12;
                return Funcion;
            }
            void Bisección2(double valorA, double valorB)
            {
                Console.WriteLine("--Método de bisección");
                bool sigue = true;
                int maxIter = 0;
                double PuntoMitad = 0;
                while (sigue == true)
                {
                    PuntoMitad = (valorA + valorB) / 2;
                    if (ValorFuncion2(PuntoMitad) == 0)
                    {
                        Console.WriteLine("Raíz encontrada");
                        sigue = false;
                        break;
                    }
                    if (ValorFuncion2(valorA) * ValorFuncion2(PuntoMitad) > 0)
                    {
                        valorA = PuntoMitad;
                    }
                    else
                    {
                        valorB = PuntoMitad;
                    }

                    //Console.WriteLine("Valor A :" + valorA);
                    //Console.WriteLine("    Valor B :" + valorB);
                    //Console.WriteLine("    Valor Mitad: " + PuntoMitad);
                    //Console.WriteLine("    Error: " + Math.Abs(valorA - valorB));
                    //Console.WriteLine(maxIter);
                    Console.WriteLine(valorA);
                    //Console.WriteLine("________________________________________________________");
                    ValorFuncion2(PuntoMitad);

                    if (Math.Abs(valorA - valorB) <= 0.0001)
                    {
                        Console.WriteLine("Error 0.0001 completado");
                        Console.WriteLine(valorA);
                        sigue = false;
                        break;
                    }
                    maxIter++;
                }
                Console.WriteLine("El valor es: " + valorA);
                Console.WriteLine("El valor 2 es: " + valorB);
                Console.WriteLine("Las iteraciones totales fueron: " + maxIter);

            }





            ///Newton
            double ValorFuncionNewtonDerivada2(double x)
            {
                //double Funcion = 3 * Math.Pow(x, 2) - 1;
                double Funcion = 3 * Math.Pow(x, 2);
                return Funcion;
            }
            double ValorFuncionNewton2(double x)
            {
                //double Funcion = Math.Pow(x, 3) - x - 1;
                double Funcion = Math.Pow(x, 3) - 12;
                return Funcion;
            }
            void NewtonRaphson2(double ValorInicial)
            {
                Console.WriteLine("--Método de Newton Rhapson");
                double p = 0, p0 = 0;
                int Itera = 0;
                bool sigue = true;
                p0 = ValorInicial;
                while (sigue == true)
                {
                    p = p0 - (ValorFuncionNewton2(p0) / ValorFuncionNewtonDerivada2(p0));
                    if (Math.Abs(p - p0) < 0.0001)
                    {
                        Console.WriteLine("Tolerancia alcanzada");
                        Console.WriteLine("El error es :" + Math.Abs(p - p0));
                        Console.WriteLine(p);
                        Itera++;
                        break;
                    }
                    Console.WriteLine(Math.Abs(p - p0));
                    Itera++;
                    p0 = p;
                }
                Console.WriteLine("La raíz es: " + p);
                Console.WriteLine("Número de Iteraciones es: " + Itera);
            }





            //Punto Fijo
            double ValorFuncionDespeje2(double x)
            {
                double funcion = Math.Sqrt(12 / x);
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
                    if (Math.Abs(x - x0) < 0.0001)
                    {
                        Console.WriteLine(Math.Abs(x - x0));
                        Console.WriteLine("Tolerancia alcanzada");
                        break;
                    }
                    Console.WriteLine(Math.Abs(x - x0));
                    x0 = x;
                    aux++;
                }
                Console.WriteLine("El número es: " + x);
                Console.WriteLine("Número de iteraciones: " + aux);
            }
        }

    }
}
