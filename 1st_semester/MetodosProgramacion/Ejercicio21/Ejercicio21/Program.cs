using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            double Voto;
            Voto = 1;
            double ContadorGeneral = 0;
            double Contador1 , Porcentaje1;
            double Contador2, Porcentaje2;
            double Contador3, Porcentaje3;
            double Contador4, Porcentaje4;
            Contador1 = 0;
            Contador2 = 0;
            Contador3 = 0;
            Contador4 = 0;
            Porcentaje1 = 0;
            Porcentaje2 = 0;
            Porcentaje3 = 0;
            Porcentaje4 = 0;
            Console.WriteLine("Candidato del 1 al 4");
            while (Voto > 0)
            {              
                Console.WriteLine("Ingrese Voto: ");
                Voto = double.Parse(Console.ReadLine());
                
                switch (Voto)
                {
                    case 1:
                        Contador1 = Contador1 + 1;
                        break;
                    case 2:
                        Contador2 = Contador2 + 1;
                        break;
                    case 3:
                        Contador3 = Contador3 + 1;
                        break;
                    case 4:
                        Contador4 = Contador4 + 1;
                        break;
                    default:
                        Console.WriteLine("No existe ese candidato");
                        ContadorGeneral = ContadorGeneral - 1;
                        break;
                }
                ContadorGeneral = ContadorGeneral + 1;
            }

            Porcentaje1 = Math.Round((Contador1 / ContadorGeneral)*100,2);
            Porcentaje2 = Math.Round((Contador2 / ContadorGeneral) *100,2);
            Porcentaje3 = Math.Round((Contador3 / ContadorGeneral)*100,2);
            Porcentaje4 = Math.Round((Contador4 / ContadorGeneral)*100,2);
            Console.Write("\n");
            Console.WriteLine("Candidato #1: " + Porcentaje1 + "%" + "   " + "Cantidad de votos: " + Contador1);
            Console.WriteLine("Candidato #2: " + Porcentaje2 + "%" + "   " + "Cantidad de votos: " + Contador2);
            Console.WriteLine("Candidato #3: " + Porcentaje3 + "%" + "   " + "Cantidad de votos: " + Contador3);
            Console.WriteLine("Candidato #4: " + Porcentaje4 + "%" + "   " + "Cantidad de votos: " + Contador4);
            Console.WriteLine("Total de votos: " + ContadorGeneral);
            Console.ReadKey();
        }
    }
}
