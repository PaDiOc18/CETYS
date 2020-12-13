using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaicesMetodos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1
            Console.ForegroundColor = ConsoleColor.Yellow;
            Bisección(-1, 0);
            Bisección(0, 1);
            Bisección(2, 3);

            Console.WriteLine("\n");
            //Ejercicio 2
            Console.ForegroundColor = ConsoleColor.White;
            NewtonRaphson(5);
            PuntoFijo1(5);
            Console.WriteLine("\n");
            //NewtonRaphson(1); //Una prueba

            //Ejercicio 3 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Bisección2(0.5, 1.5);
            NewtonRaphson2(1);
            PuntoFijo2(2);
            Console.WriteLine("\n");

            //Ejercicio 4
            Console.ForegroundColor = ConsoleColor.Magenta;
            Bisección4(2, 4);


            Console.ReadKey();

            //Ejercicio 1
            double ValorFuncion(double x)
            {
                double Funcion = Math.Pow(x,3) - 3*Math.Pow(x,2) + 1;
                return Funcion;
            }
            void Bisección(double valorA, double valorB)
            {
                Console.WriteLine("--Método de bisección");
                bool sigue = true;
                int maxIter = 0;
                double PuntoMitad = 0;
                while (sigue == true)
                {
                    PuntoMitad = (valorA + valorB) / 2;
                    if (ValorFuncion(PuntoMitad) == 0)
                    {
                        Console.WriteLine("Raíz encontrada");
                        sigue = false;
                        break;
                    }
                    if (ValorFuncion(valorA) * ValorFuncion(PuntoMitad) > 0)
                    {
                        valorA = PuntoMitad;
                    }
                    else
                    {
                        valorB = PuntoMitad;
                    }
                    ValorFuncion(PuntoMitad);

                    if (Math.Abs(valorA-valorB) <= 0.0001)
                    {
                        Console.WriteLine("Error 0.0001 completado");
                        sigue = false;
                        break;
                    }
                    maxIter++;
                }
                Console.WriteLine("El valor es: " + valorA);
                Console.WriteLine("El valor 2 es: " + valorB);
                Console.WriteLine("Las iteraciones totales fueron: " + maxIter);

            }

            //Ejercicio2
            double ValorFuncionNewtonDerivada(double x)
            {
                //double Funcion = 3 * Math.Pow(x, 2) - 1;
                double Funcion = 3 * Math.Pow(x, 2);
                return Funcion;
            }
            double ValorFuncionNewton(double x)
            {
                //double Funcion = Math.Pow(x, 3) - x - 1;
                double Funcion = Math.Pow(x, 3) - 21;
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
            double ValorFuncionDespeje(double x)
            {
                double funcion = Math.Sqrt(21 / x);
                return funcion;
            }
            void PuntoFijo1(double puntoInicial)
            {
                Console.WriteLine("--Método Punto fijo");
                bool sigue = true;
                double x = 0, x0 = 0;
                int aux = 0;
                x0 = puntoInicial;
                while (sigue == true)
                {
                    x = ValorFuncionDespeje(x0);
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
            //Ejercicio 3
            double ValorFuncion2(double x)
            {
                double Funcion = Math.Sin(x) - Math.Pow(x,2);
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
                    ValorFuncion2(PuntoMitad);

                    if (Math.Abs(valorA - valorB) <= 0.0001)
                    {
                        Console.WriteLine("Error 0.0001 completado");
                        sigue = false;
                        break;
                    }
                    maxIter++;
                }
                Console.WriteLine("El valor es: " + valorA);
                Console.WriteLine("El valor 2 es: " + valorB);
                Console.WriteLine("Las iteraciones totales fueron: " + maxIter);

            }      
            double ValorFuncionNewtonDerivada2(double x)
            {
                //double Funcion = 3 * Math.Pow(x, 2) - 1;
                double Funcion = Math.Cos(x) - 2 * x;
                return Funcion;
            }
            double ValorFuncionNewton2(double x)
            {
                //double Funcion = Math.Pow(x, 3) - x - 1;
                double Funcion = Math.Sin(x) - Math.Pow(x, 2);
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
                        break;
                    }
                    Itera++;
                    p0 = p;
                }
                Console.WriteLine("La raíz es: " + p);
                Console.WriteLine("Número de Iteraciones es: " + Itera);
            }
            double ValorFuncionDespeje2(double x)
            {
                double funcion = Math.Sqrt(Math.Sin(x));
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
                        Console.WriteLine("Tolerancia alcanzada");
                        break;
                    }
                    x0 = x;
                    aux++;
                }
                Console.WriteLine("El número es: " + x);
                Console.WriteLine("Número de iteraciones: " + aux);
            }

            //Ejercicio 4
            double ValorFuncion4(double x)
            {
                double Funcion = Math.Sin(x);
                return Funcion;
            }
            void Bisección4(double valorA, double valorB)
            {
                Console.WriteLine("--Método de bisección");
                bool sigue = true;
                int maxIter = 0;
                double PuntoMitad = 0;
                while (sigue == true)
                {
                    PuntoMitad = (valorA + valorB) / 2;
                    if (ValorFuncion4(PuntoMitad) == 0)
                    {
                        Console.WriteLine("Raíz encontrada");
                        sigue = false;
                        break;
                    }
                    if (ValorFuncion4(valorA) * ValorFuncion4(PuntoMitad) > 0)
                    {
                        valorA = PuntoMitad;
                    }
                    else
                    {
                        valorB = PuntoMitad;
                    }
                    ValorFuncion4(PuntoMitad);

                    if (Math.Abs(valorA - valorB) <= 0.0001)
                    {
                        Console.WriteLine("Error 0.0001 completado");
                        sigue = false;
                        break;
                    }
                    maxIter++;
                }
                Console.WriteLine("El valor es: " + valorA);
                Console.WriteLine("El valor 2 es: " + valorB);
                Console.WriteLine("Las iteraciones totales fueron: " + maxIter);

            }


        }
    }
}
