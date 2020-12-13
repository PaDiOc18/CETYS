using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double Minutos;
            double Clave;
            double Total;
            Console.WriteLine("Ingrese Minutos: ");
                Minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Clave: ");
            Console.WriteLine("12");
            Console.WriteLine("15");
            Console.WriteLine("18");
            Console.WriteLine("19");
            Console.WriteLine("23");
            Console.WriteLine("25");
            Console.WriteLine("29");
            Clave = int.Parse(Console.ReadLine());
            switch (Clave)
            {
                case 12:
                    Total = 2 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : America del Norte" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                case 15:
                    Total = 2.2 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : America Central" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                case 18:
                    Total = 4.5 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : America del Sur" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                case 19:
                    Total = 3.5 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : Europa" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                case 23:
                    Total = 6 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : Asia" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                case 25:
                    Total = 6 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : Africa" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                case 29:
                    Total = 5 * Minutos;
                    Console.WriteLine("Clave: " + Clave + " , " + " Zona : Oceania" + " , " + "Minutos Consumidos: " + Minutos + " , " + "Costo total:" + Total);
                    break;
                default:
                    Console.WriteLine("No existe Zona, intente de nuevo");
                    break;
            }
            Console.ReadKey();


        }
    }
}
