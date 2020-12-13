using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double SUE;
            double CAT;
            double HE;
            double NS;
            Console.WriteLine("Ingrese sueldo: ");
            SUE = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese horas extras: ");
            HE = double.Parse((Console.ReadLine()));
            Console.WriteLine("Ingrese Categoria: ");
            CAT = double.Parse((Console.ReadLine()));
            switch (CAT)
            {
                case 1:
                    if (HE <30 )
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 30");
                        NS = SUE + (HE * 30);
                        Console.WriteLine("Nuevo sueldo: " + NS);
                    }
                    else
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 30");
                        NS = SUE + (30 * 30);
                        Console.WriteLine("Nuevo sueldo: " + NS);
                    }
                    break;
                case 2:
                    if (HE <30)
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 38");
                        NS = SUE + (HE * 38);
                        Console.WriteLine("Nuevo sueldo: " + NS);
                    }
                    else
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 30");
                        NS = SUE + (30 * 30);
                        Console.WriteLine("Nuevo sueldo: " + NS);
                    }
                    break;
                case 3:
                    if (HE < 30)
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 50");
                        NS = SUE + (HE * 50);
                        Console.WriteLine("Nuevo sueldo: " + NS);

                    }
                    else
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 30");
                        NS = SUE + (30 * 30);
                        Console.WriteLine("Nuevo sueldo: " + NS);
                    }
                    break;
                case 4:
                    if (HE < 30)
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 70");
                        NS = SUE + (HE * 70);
                        Console.WriteLine("Nuevo sueldo: " + NS);

                    }
                    else
                    {
                        Console.WriteLine("Sueldo Base: " + SUE);
                        Console.WriteLine("Categoria: " + CAT);
                        Console.WriteLine("Horas extras: " + HE);
                        Console.WriteLine("Costo hora extra: 30");
                        NS = SUE + (30 * 30);
                        Console.WriteLine("Nuevo sueldo: " + NS);
                    }
                    break;
                default:
                    Console.WriteLine("Sueldo Base: " + SUE);
                    Console.WriteLine("Categoria: " + CAT);
                    Console.WriteLine("Horas extras: " + HE);
                    break;
            }

            Console.ReadKey();
        }
    }
}
