using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesDeTaylor
{
    class Program
    {
        static void Main(string[] args)
        {

            //SERIE DE TAYLOR DE PI

            double aproxPi = 0, aux= 0;
            /*
            bool sigue = true;

            double aux1 = 0;

            while (sigue == true)
            {
                double resta1;
                aproxPi = aproxPi + Math.Pow((-1), aux1) / ((2 * aux1) + 1);
                resta1 = Math.Abs(3.141 - (4 * aproxPi));

                //Console.WriteLine("divise: " + 4*aproxPi);
                Console.WriteLine(resta1);
                if (resta1 <= 0.00001)
                {
                    sigue = false;
                    Console.WriteLine("Pos me salgo: " + Math.Round(resta1, 8));
                }
                aux1++;
                //Console.WriteLine(aux1);
            }

            Console.WriteLine("El pi aproxiamdo es: " + 4*aproxPi);
            Console.WriteLine("Número de iteraciones: " + aux1);
            */

            //Aproximación de PI
            for (int i = 0; i < 1688; i++)
            {
                aproxPi = aproxPi + Math.Pow((-1), i) / ((2 * i) + 1);
                aux = i;
            }
            aproxPi = 4 * aproxPi;
            Console.WriteLine("El pi aproximado es: "+ aproxPi);
            Console.WriteLine("El número de iteraciones es: " + (aux+1));
            Console.WriteLine("\n");
            
            //Serie de e

            double aproxe = 0,aux2=0;

            for (int i = 0; i < 7; i++)
            {
                aproxe = aproxe + ((Math.Pow(1, i)) / Factorial(i));
                //Console.WriteLine("Numerador: " + Math.Pow(1, i) + " " + "Denominador: " + Factorial(i) + " Factorial: " + i);
                aux2 = i;
            }

            Console.WriteLine("El e aproximado es: " + aproxe);
            Console.WriteLine("El número de iteraciones es: " + (aux2+1));
            Console.WriteLine("\n");

            //Serie de e^2

            double aproxecua = 0, aux3 = 0;

            for (int i = 0; i < 12; i++)
            {
                aproxecua = aproxecua + ((Math.Pow(2, i)) / Factorial(i));
                //Console.WriteLine("Numerador: " + Math.Pow(1, i) + " " + "Denominador: " + Factorial(i) + " Factorial: " + i);
                aux3 = i;
            }

            Console.WriteLine("El e^2 aproximado es: " + aproxecua);
            Console.WriteLine("El número de iteraciones es: " + (aux3+1));
            Console.WriteLine("\n");


            //Serie de ln(2)

            double aproxln2 = 0, aux4 = 0;

            for (int i = 1; i < 588; i++)
            {
                aproxln2 = aproxln2 + (Math.Pow(-1, i - 1) * (Math.Pow(1, i) / i));
                //Console.WriteLine("Numerador: " + Math.Pow(1, i) + " " + "Denominador: " + Factorial(i) + " Factorial: " + i);
                aux4 = i;
            }

            Console.WriteLine("El ln(2) aproximado es: " + aproxln2);
            Console.WriteLine("El número de iteraciones es: " + aux4);
            Console.WriteLine("\n");

            //Serie de Cos(pi/6)

            double aproxCos = 0, aux5 = 0;
            

            for (int i = 0; i < 3; i++)
            {
                aproxCos = aproxCos + ((Math.Pow(-1, i)) * (Math.Pow((Math.PI/6),2*i)) / Factorial(2*i));
                //Console.WriteLine("Numerador: " + Math.Pow(1, i) + " " + "Denominador: " + Factorial(i) + " Factorial: " + i);
                aux5 = i;
            }

            Console.WriteLine("El cos(pi/6) aproximado es: " + aproxCos);
            Console.WriteLine("El número de iteraciones es: " + (aux5+1));
            Console.WriteLine("\n");


            //Serie de Sen(pi/3)

            double aproxSen = 0, aux6 = 0;


            for (int i = 0; i < 3; i++)
            {
                aproxSen = aproxSen + ((Math.Pow(-1, i)) * (Math.Pow((Math.PI / 3), (2 * i)+1)) / Factorial((2 * i)+1));
                //Console.WriteLine("Numerador: " + Math.Pow(1, i) + " " + "Denominador: " + Factorial(i) + " Factorial: " + i);
                aux6 = i;
            }

            Console.WriteLine("El Sen(pi/3) aproximado es: " + aproxSen);
            Console.WriteLine("El número de iteraciones es: " + (aux6+1));
            Console.WriteLine("\n");

            Console.ReadKey();



            double Factorial(double num)
            {
                double regreso = 0;
                if (num == 0)
                {
                    return 1;
                }
                else
                {
                    regreso = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        regreso = regreso * i;
                    }
                    //Console.WriteLine("Regreso: " + regreso);
                    //Console.WriteLine("-----------------------------------------------------------------------------------------");
                }
                return regreso;
            }
        }
    }
}
