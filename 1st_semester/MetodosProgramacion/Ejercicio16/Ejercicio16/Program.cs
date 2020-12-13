using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double Matricula;
            string Carrera;
            double Semestre;
            double Promedio;
            Console.WriteLine("Ingrese Matricula: ");
            Matricula = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Carrera: ");
            Carrera = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese Semestre: ");
                Semestre = double.Parse((Console.ReadLine()));
                Console.WriteLine("Ingrese Promedio: ");
                Promedio = double.Parse((Console.ReadLine()));
                switch (Carrera)
                {
                    case "Economia":
                        if (Semestre >= 6 && Promedio >= 8.8)
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("Aceptado");
                        }
                        else
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("No aceptado");
                        }
                        break;
                    case "Computacion":
                        if (Semestre > 6 && Promedio > 8.5)
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("Aceptado");

                        }
                        else
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("No aceptado");
                        }
                        break;
                    case "Administracion":
                        if (Semestre > 5 && Promedio > 8.5)
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("Aceptado");

                        }
                        else
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("No aceptado");
                        }
                        break;
                    case "Contabilidad":
                        if (Semestre > 6 && Promedio > 8.5)
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("Aceptado");

                        }
                        else
                        {
                            Console.WriteLine("Matricula: " + Matricula);
                            Console.WriteLine("Carrera: " + Carrera);
                            Console.WriteLine("No aceptado");
                        }
                        break;
                    default:
                        Console.WriteLine("No existe carrera");
                        break;
                }
            
            Console.ReadKey();
        }
    }
}
