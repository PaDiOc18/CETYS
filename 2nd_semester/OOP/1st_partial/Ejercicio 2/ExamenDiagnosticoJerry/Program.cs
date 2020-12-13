using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDiagnosticoJerry
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Palabra: " + Fuc());
            Console.ReadKey();
        }
        
        static string Fuc()
        {
            Random rnd = new Random();
            int Consonante = rnd.Next(1, 23);
            int Vocal = rnd.Next(1, 6);
            string palabra = "CCCVVCVC";
            string NPal = "";
            string[] Con = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "ñ", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] Voc = { "a", "e", "i", "o", "u" };

            char[] letras = palabra.ToArray();

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == 'C')
                {
                    NPal = NPal + Con[rnd.Next(0, 23)];
                }
                else
                {
                    NPal = NPal + Voc[rnd.Next(0, 5)];
                }

            }
            return NPal;
        }
    }
}
