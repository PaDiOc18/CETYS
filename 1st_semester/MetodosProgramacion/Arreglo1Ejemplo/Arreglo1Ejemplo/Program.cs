using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo1Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Díaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            double Varianza = 0, DesvEst = 0, Aux = 0, CModa = 0;
            int C = 0;
            Console.WriteLine("Cuantas calificaciones deseas ingresar?");
            C = int.Parse(Console.ReadLine());
            double[] calif = new double[C];
            //Ingresar Valores al Array
            int j = 0;
            for (int i = 0; i < calif.Length; i++)
            {
                j = i + 1;
                Console.WriteLine("Ingresa calificacion #" + j + ": ");
                calif[i] = double.Parse(Console.ReadLine());
            }
            //Sacar media 
            double SumCalif = 0;
            for (int i = 0; i < calif.Length; i++)
            {
                SumCalif = SumCalif + calif[i];

            }
            SumCalif = SumCalif / calif.Length;
            Console.WriteLine("La media es: " + Math.Round(SumCalif, 2));
            Console.ReadKey();
            double V = 0;
            //Sacar Varianza 
            for (int i = 0; i < calif.Length; i++)
            {
                V = calif[i] - SumCalif;
                V = Math.Pow(V, 2);
                Varianza = Varianza + V;
            }
            Varianza = Varianza / (calif.Length - 1);
            Console.WriteLine("La varianza es: " + Math.Round(Varianza, 2));
            //Sacar Desviación Estándar
            DesvEst = Math.Sqrt(Varianza);
            Console.WriteLine("La Desviación Estándar es: " + Math.Round(DesvEst,2));
            //Sacar moda           
            double cont=0, Max=0;
            for (int k = 0; k < calif.Length; k++)
            {
                cont = 0;
                for (int w = 0; w < calif.Length; w++)
                {
                    if (calif[k] == calif[w])
                    {
                        cont = cont + 1;
                    }
                }
                if (Max < cont)
                {
                    Max = cont;
                    Aux = calif[k];
                }
            }
            Console.WriteLine("La Moda es: " + Aux );
            Console.ReadKey();

            /*  
            */

        }
    }
}
