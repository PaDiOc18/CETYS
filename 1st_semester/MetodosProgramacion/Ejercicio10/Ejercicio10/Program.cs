using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            double Sueldo;
            double Categoria;
            double res;
            Console.WriteLine("Ingrese Sueldo:  ");
            Sueldo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Categoria 1");
            Console.WriteLine("Categoria 2");
            Console.WriteLine("Categoria 3");
            Console.WriteLine("Categoria 4");
            Console.WriteLine("Ingrese Categoria:  "); 
            Categoria = Convert.ToInt32(Console.ReadLine());

            switch (Categoria)
            {

                case 1:
                    res = Sueldo * 1.15;
                    Console.WriteLine("El nuevo sueldo es:" + res);
                    Console.ReadKey();
                    break;
                case 2:
                    res = Sueldo * 1.10;
                    Console.WriteLine("El nuevo sueldo es:" + res);
                    Console.ReadKey();
                    break;
                case 3:
                    res = Sueldo * 1.08;
                    Console.WriteLine("El nuevo sueldo es:" + res);
                    Console.ReadKey();
                    break;
                case 4:
                    res = Sueldo * 1.07;
                    Console.WriteLine("El nuevo sueldo es:" + res);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("No existe esa categoria");
                    Console.ReadKey();
                    break;

            }
            
        }
    }
}
