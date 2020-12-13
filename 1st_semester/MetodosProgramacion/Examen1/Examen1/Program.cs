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
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            double Compra;
            double Descuento;
            double NC;/*Declaramos variables*/
            string Por;
            Descuento = 0;
            NC = 0; /*Inicializamos variables*/
            Por = "0";
            Console.WriteLine("Ingrese la compra: ");
            Compra = double.Parse(Console.ReadLine());
            if (Compra < 0) /*Agregue esta condicion para que no acepte valores negativos*/
            {
                Console.WriteLine("No hay compras negativas");
            }
            else if (Compra >0 && Compra <500)/*Comparacion 1*/
            {
                Descuento = 0;
                NC = Compra - Descuento;
                Por = "0";
            }
            else if (Compra >= 500 && Compra < 1000)/*Comparacion 2*/
            {
                Descuento = Compra * 0.05;
                NC = Compra - Descuento;
                Por = "5%";
            }
            else if (Compra >=1000 && Compra < 7000)/*Comparacion 3*/
            {
                Descuento = Compra * 0.11;
                NC = Compra - Descuento;
                Por = "11%";
            }
            else if (Compra >= 7000 && Compra < 15000)/*Comparacion 4*/
            {
                Descuento = Compra * 0.18;
                NC = Compra - Descuento;
                Por = "18%";
            }
            else
            {
                Descuento = Compra * 0.25;/*Si no es ninguna de las anteriores es esta*/
                NC = Compra - Descuento;
                Por = "25%";
            }
            Console.Write("\n");
            Console.WriteLine("Compra Original: " + Compra);
            Console.WriteLine("Porcentaje: " + Por);/*Imprimimos los acumuladores y contadores*/
            Console.WriteLine("Descuento: " + Descuento);
            Console.WriteLine("Precio total: " + NC);
            Console.ReadKey();
        }
    }
}
