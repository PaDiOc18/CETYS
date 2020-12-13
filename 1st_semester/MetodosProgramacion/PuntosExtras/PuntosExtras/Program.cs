using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntosExtras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");

            double Precio;
            double Impuesto;
            double Descuento;
            Console.WriteLine("Ingrese el precio del articulo: ");
            Precio = double.Parse(Console.ReadLine());
            if (Precio > 500)
            {
                Console.WriteLine("El impuesto fue de 50%");
                Console.WriteLine("El Precio base es: " + Precio);
                Impuesto = 20 * 0.3;
                Descuento = Precio - 40;
                Impuesto = Impuesto + (Descuento * 0.5);
                Precio = Precio + Impuesto;
                
                Console.WriteLine("Precio total : $" + Precio);

            }
                
            else
            {
                if (Precio <= 20)
                {
                    Console.WriteLine("No hay impuestos");
                    Console.WriteLine("Precio total : $" + Precio);

                }
                else if( Precio > 20 && Precio <= 40)
                {
                    Console.WriteLine("El impuesto fue de 30%");
                    Console.WriteLine("El Precio base es: " + Precio);
                    Precio = Precio - 20;
                    Impuesto = Precio * 0.3;
                    Precio = Precio + Impuesto;
                    Console.WriteLine("Precio total : $" + Precio);
                }
                else if( Precio > 40)
                {
                    Console.WriteLine("El impuesto fue de 40%");
                    Console.WriteLine("El Precio base es: " + Precio);
                    Impuesto = 20 * 0.3;
                    Descuento = Precio - 40;
                    Impuesto = Impuesto + (Descuento * 0.4);
                    Precio = Precio + Impuesto;
                    Console.WriteLine("Precio total : $" + Precio);
                }

            }
            Console.ReadKey();
        }
    }
}
