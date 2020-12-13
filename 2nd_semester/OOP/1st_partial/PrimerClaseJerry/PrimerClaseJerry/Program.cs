using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerClaseJerry
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = CaclculaRaiz();
            Console.WriteLine(x);
            Console.ReadLine();

            
            double z = CaclculaRaiz2(4);
            Console.WriteLine(z);
            Console.ReadLine();


            string nombre = "Nestorin";
            ImprimeCaudrado(nombre);
            SegundoProblema("CVCV");
            Console.ReadLine();
            int i = 0;
            int[] numeritos = { 1, 2, 3, 4, 5 };
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 10);

            Console.WriteLine(" ");

            foreach (int numero in numeritos)
            {
                Console.WriteLine(numero);
            }
            
        }
        static void ImprimeCaudrado(string palabra)
        {
            Console.WriteLine(palabra);

            for (int i = 1; i < palabra.Length - 1; i++)
            {
                Console.Write(palabra[1]);
                for (int j = 0; j < palabra.Length - 2; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(palabra[palabra.Length - 1 - i]);
                Console.WriteLine();
            }
            for (int  w = palabra.Length -1 ;  w >=0 ;  w--)
            {
                Console.Write(palabra[w]);
            }
            Console.ReadKey();
        }
        static void SegundoProblema (string patron)
        {
            Random randy = new Random(Guid.NewGuid().GetHashCode());
            string vocales = "aeiou";
            string consonantes = "bcdfghjklmnpqrstwvxyz";
            string resultado = "";
            foreach(char letruca in patron.ToLower())
            {
                if(letruca == 'c')
                    {
                    resultado += consonantes[randy.Next(0, 21)];
                    }
                else if (letruca == 'v')
                {
                    resultado += vocales[randy.Next(0, 5)];
                }
                
            }
            Console.WriteLine("");
            Console.Write(resultado);
        }
        static double CaclculaRaiz()
        {
            double x = 0;
            double.TryParse(Console.ReadLine(), out x);
            double intento = 1;
            while(intento * intento < x)
            {
                intento++;
            }
            return intento;
        }
        static double CaclculaRaiz2(double numero)
        {
            double intento = numero / 2;
            double limiteinferioir = 0;
            double limitesuperiois = numero;
            if (numero < 1)
            {
                limitesuperiois = 1;
            }

            double margenError = .001;
            while (Math.Abs( numero - (intento * intento)) > margenError)
            {
                if (intento * intento > numero)
                {
                    limitesuperiois = intento;
                }
                else
                {
                    limiteinferioir = intento;
                }
                    intento = (limitesuperiois + limiteinferioir) / 2;
            }
            return intento;
            
        }

    }
}
