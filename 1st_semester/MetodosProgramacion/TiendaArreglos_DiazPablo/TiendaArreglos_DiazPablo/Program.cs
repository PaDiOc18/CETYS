using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaArreglos_DiazPablo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Díaz Ochoa");
            Console.WriteLine("Matrícula: 030343");
            Console.ReadKey();
            Random randum1 = new Random();
            Console.Clear();
            int Max = 0;
            Console.WriteLine("Cuantos productos quieres?");
            Max = int.Parse(Console.ReadLine());
            double[] PRO = new double[Max];
            double[] CAN = new double[Max];
            int[] CLAVE = new int[Max];
            Console.WriteLine("Tienda Don Chapo");
            for (int i = 0; i < Max; i++)
            {
                CLAVE[i] = randum1.Next(0, 100);
                PRO[i] = randum1.Next(0, 100);
                CAN[i] = randum1.Next(0, 100);
            }
            //imprimir esa cosa
            for (int k = 0; k < Max; k++)
            {
                Console.WriteLine("La Clave es: " + CLAVE[k]);
                Console.WriteLine("El Producto es: " + PRO[k]);
                Console.WriteLine("La Cantidad es: " + CAN[k]);
                Console.WriteLine("-----------------------------------------/");
            }
            //Sacar la cantidad mayor   
            double Mayor = 0;
            Mayor = CAN.Max();
            for (int m = 0; m < Max; m++)
            {
                if (CAN[m] == Mayor)
                {
                    Console.WriteLine("El producto con mayor cantidad");
                    Console.WriteLine("Clave:" + CLAVE[m]);
                    Console.WriteLine("La cantidad es: " + Mayor);
                    Console.WriteLine("--------------------------------------/");
                }
            }
            double resta = 0;
            for (int w = 0; w < Max; w++)
            {               
                if (CAN[w] <50)
                {
                    resta = 50 - CAN[w];
                    Console.WriteLine("Del producto " + CLAVE[w] + " se necesitan: " + resta + " para tener 50");
                    Console.WriteLine("");
                }
                
                else
                {
                    Console.WriteLine("Del producto " + CLAVE[w] + " no se necesita pedir al proveedor");
                    Console.WriteLine("");
                }
                resta = 0;
            }
            Console.ReadKey();
        }
    }
}
