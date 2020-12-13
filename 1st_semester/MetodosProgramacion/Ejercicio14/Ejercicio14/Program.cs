using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.ReadKey();
            double[] Calif;
            Calif = new double [5];
            int Matricula;
            
            Console.WriteLine("Ingrese Matricula");
            Matricula = int.Parse(Console.ReadLine());
            int i;
            i=0;
            int j;
            j = 0;
            while (i < 5)
            {
                Console.WriteLine("Ingrese Calificacion " + i + " :");
                Calif[i] = double.Parse(Console.ReadLine());
                i++;
                
            }
            double res;
            res = 0;
            for (j=0;j < 5; j++)
            {

                res = res + Calif[j];

            }
            res = res / 5;
            if(res >= 6)
            {
                Console.WriteLine("La matricula es: {0}", Matricula);
                Console.WriteLine("La matricula es: {0}", res);
                Console.WriteLine("Aprobado");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La matricula es: {0}", Matricula);
                Console.WriteLine("La calificacion final es: {0}", res);
                Console.WriteLine("Reprobado");
                Console.ReadKey();
            }





        }
    }
}
