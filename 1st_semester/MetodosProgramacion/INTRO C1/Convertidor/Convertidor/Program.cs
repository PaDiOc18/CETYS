using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matrícula: 030343");
            Console.WriteLine("ICC");
            Console.WriteLine("\n");
            int Caso;
            Console.WriteLine("1-. Convertir de Decimal a Binario");
            Console.WriteLine("2-. Convertir de Decimal a Hexadecimal");
            Console.WriteLine("3-. Convertir de Binario a Decimal");
            Console.WriteLine("4-. Convertir de Binario a Hexadecimal");
            Console.WriteLine("5-. Convertir de Hexadecimal a Decimal");
            Console.WriteLine("6-. Convertir de Hexadecimal a Binario");
            Console.WriteLine("Elige tu opción: ");
            Caso = Convert.ToInt32(Console.ReadLine());
            switch (Caso)
            {
                case 1:
                Console.WriteLine("Ingrese un el número decimal: ");
                int Decimal = int.Parse(Console.ReadLine());
                if (Decimal > 0)
                {
                    string Resultado;
                    int residuo;
                    residuo = 1;

                    while (Decimal > 0)
                    {
                        if (residuo == 0)
                        {
                                Resultado = "0" + Resultado;
                        }
                        else
                        {
                                Resultado = "1" + Resultado;
                        }
                        Decimal = Decimal / 2;
                    }
                    Console.WriteLine(Resultado);
                }
                else
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("0");
                    }
                }
                    break;

                case 2:

                break;

                case 3:

                break;

                case 4:

                break;




                default:
                    Console.WriteLine("No existe ese caso");
                break;
            }




            Console.ReadKey();
            

        }
    }
}
