using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3
{
    class Program
    {
        static void Main(string[] args)
        {


            // Ejercicio1Bisección(-2, 1);
            //Ejercicio2Bisección(0, 10);
            NewtonRaphson(2);

            Console.ReadKey();

            //Ejercicio 1
            double Ejercicio1ValorFuncion(double x)
            {
                double Funcion = 1/x;
                return Funcion;
            }
            void Ejercicio1Bisección(double valorA, double valorB)
            {
                Console.WriteLine("--Método de bisección");
                bool sigue = true;
                int maxIter = 0;
                double PuntoMitad = 0;
                while (sigue == true || maxIter < 100)
                {
                    Console.WriteLine("Valor de A: " + valorA);
                    Console.WriteLine("Valor de B: " + valorB);
                    Console.WriteLine("Diferencia es de: " + Math.Abs(valorA - valorB));
                    Console.WriteLine("Iteración: " + maxIter);
                    Console.WriteLine("____________________________________");


                    PuntoMitad = (valorA + valorB) / 2;
                    if (Ejercicio1ValorFuncion(PuntoMitad) == 0)
                    {
                        Console.WriteLine("Raíz encontrada");
                        sigue = false;
                        break;
                    }
                    if (Ejercicio1ValorFuncion(valorA) * Ejercicio1ValorFuncion(PuntoMitad) > 0)
                    {
                        valorA = PuntoMitad;
                    }
                    else
                    {
                        valorB = PuntoMitad;
                    }
                    Ejercicio1ValorFuncion(PuntoMitad);

                    if (Math.Abs(valorA - valorB) <= 0.0001)
                    {
                        Console.WriteLine("Error 0.0001 completado");
                        Console.WriteLine("Valor de A: " + valorA);
                        Console.WriteLine("Valor de B: " + valorB);
                        Console.WriteLine("Diferencia es de: " + Math.Abs(valorA - valorB));
                        Console.WriteLine("Iteración: " + maxIter);
                        sigue = false;
                        break;
                    }
                    
                    maxIter++;
                }


                Console.WriteLine("--------------------------");
                Console.WriteLine("El valor A FINAL es: " + valorA);
                Console.WriteLine("El valor B FINAL es: " + valorB);
                Console.WriteLine("Las iteraciones totales fueron: " + maxIter);

            }

            //Ejercicio 2
            double Ejercicio2ValorFuncion(double x)
            {
                double Funcion = (20 - x + Math.Sqrt(20 - x)) * (x + Math.Sqrt(x)) - 120;
                return Funcion;
            }
            void Ejercicio2Bisección(double valorA, double valorB)
            {
                Console.WriteLine("--Método de bisección");
                bool sigue = true;
                int maxIter = 0;
                double PuntoMitad = 0;
                while (sigue == true || maxIter < 100)
                {
                    Console.WriteLine("Valor de A: " + valorA);
                    Console.WriteLine("Valor de B: " + valorB);
                    Console.WriteLine("Diferencia es de: " + Math.Abs(valorA - valorB));
                    Console.WriteLine("Iteración: " + maxIter);
                    Console.WriteLine("____________________________________");


                    PuntoMitad = (valorA + valorB) / 2;
                    if (Ejercicio2ValorFuncion(PuntoMitad) == 0)
                    {
                        Console.WriteLine("Raíz encontrada");
                        sigue = false;
                        break;
                    }
                    if (Ejercicio2ValorFuncion(valorA) * Ejercicio2ValorFuncion(PuntoMitad) > 0)
                    {
                        valorA = PuntoMitad;
                    }
                    else
                    {
                        valorB = PuntoMitad;
                    }
                    Ejercicio2ValorFuncion(PuntoMitad);

                    if (Math.Abs(valorA - valorB) <= 0.0001)
                    {
                        Console.WriteLine("Error 0.0001 completado");
                        Console.WriteLine("Valor de A: " + valorA);
                        Console.WriteLine("Valor de B: " + valorB);
                        Console.WriteLine("Diferencia es de: " + Math.Abs(valorA - valorB));
                        Console.WriteLine("Iteración: " + maxIter);
                        sigue = false;
                        break;
                    }

                    maxIter++;
                }


                Console.WriteLine("--------------------------");
                Console.WriteLine("El valor A FINAL es: " + valorA);
                Console.WriteLine("El valor B FINAL es: " + valorB);
                Console.WriteLine("Las iteraciones totales fueron: " + maxIter);

            }


            //Ejercicio 3
            double ValorFuncionNewtonDerivada(double x)
            {;
                double Funcion = Math.E;
                return Funcion;
            }
            double ValorFuncionNewton(double x)
            {

                double Funcion = Math.Pow(Math.E,x) - 2 ;
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
                    if (Math.Abs(p - p0) < 0.00001)
                    {
                        Console.WriteLine("Tolerancia alcanzada");
                        break;
                    }
                    Itera++;
                    p0 = p;
                    Console.WriteLine("Valor de P: " + p);
                    Console.WriteLine("Valor de p0: " + p0);
                    Console.WriteLine("La diferencia es: " + Math.Abs(p - p0));
                    Console.WriteLine("____________________________");
                }
                Console.WriteLine("La raíz es: " + p);
                Console.WriteLine("Número de Iteraciones es: " + Itera);
            }





        }
    }
}
