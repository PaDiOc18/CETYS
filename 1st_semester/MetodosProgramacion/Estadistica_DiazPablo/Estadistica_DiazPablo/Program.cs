using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_DiazPablo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.WriteLine("\n");
            Console.WriteLine("Pulse Enter para continuar");
            Console.ReadKey();
            Console.Clear();
            string sexo;
            int edad, Respuesta;
            Respuesta = 0;
            double sueldo, ContM500Mas, ContH400Men, PorM500Mas, PorH400Mas, PorHombres, PorMujeres,ContH, ContM, ContT, CuanHM18YMen25, CuanMM20YMen28,NominaH, NominaM, NominaT ;
            ContM500Mas = 0; ContH400Men = 0; PorM500Mas = 0; PorH400Mas = 0; PorHombres = 0; PorMujeres = 0; ContH = 0; ContM = 0; ContT = 0; CuanHM18YMen25 = 0; CuanMM20YMen28 = 0; NominaH = 0; NominaM = 0; NominaT = 0;
            bool estado; estado = true;

            while (estado == true)
            {
                Console.WriteLine("Ingrese el sueldo: ");
                sueldo = double.Parse(Console.ReadLine());
                NominaT = NominaT + sueldo;
                Console.WriteLine("Ingrese el H si es Hombre y M si es Mujer: ");
                sexo = Console.ReadLine();
                if (sexo == "H")
                {
                    NominaH = NominaH + sueldo;
                    ContH = ContH + 1;
                }
                else if(sexo == "M")
                {
                    NominaM = NominaM + sueldo;
                    ContM = ContM + 1;
                }
                else
                {
                    break;
                }
                Console.WriteLine("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
                if (sexo == "M" && sueldo > 500)
                {
                    ContM500Mas = ContM500Mas + 1;
                }
                if (sexo == "H" && sueldo < 400)
                {
                    ContH400Men = ContH400Men + 1;
                }
                if (sexo =="H" && edad > 18 && edad < 25)
                {
                    CuanHM18YMen25 = CuanHM18YMen25 + 1;
                }
                if (sexo =="M" && edad > 20 && edad <28)
                {
                    CuanMM20YMen28 = CuanMM20YMen28 + 1;
                }
                ContT = ContT + 1;
                Console.WriteLine("Quieres seguir ingresar otro empleado?");
                Console.WriteLine("1-. Si          2-. No");
                Respuesta = int.Parse(Console.ReadLine());
                if (Respuesta == 1)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                }
                Console.Clear();

            } //Termina Ciclo While

            string cadenita1, cadenita2, cadenita3, cadenita4;
            PorM500Mas = (ContM500Mas / ContM) * 100;
            cadenita1 = Convert.ToString(Math.Round(PorM500Mas, 2));
            Console.WriteLine("Numero de Mujeres que ganan mas de $500 pesos: " + ContM500Mas + " El porcentaje es: " + cadenita1 + "%");
            PorH400Mas = (ContH400Men / ContH)*100;
            cadenita2 = Convert.ToString(Math.Round(PorH400Mas, 2));
            Console.WriteLine("Numero de Hombres que ganan menos de $400 pesos: " + ContH400Men + " El porcentaje es: " + cadenita2 + "%");
            PorHombres = (ContH / ContT) * 100;
            cadenita3 = Convert.ToString(Math.Round(PorHombres, 2));
            Console.WriteLine("Numero de Hombres en la empresa: " + ContH + " El porcentaje es: " + cadenita3  + "%");
            PorMujeres = (ContM / ContT) * 100;
            cadenita4 = Convert.ToString(Math.Round(PorMujeres, 2));
            Console.WriteLine("Numero de Mujeres en la empresa: " + ContM + " El porcentaje es: " + cadenita4 + "%");
            Console.WriteLine("Hombres Mayores de 18 años y menores de 28 años: " + CuanHM18YMen25);
            Console.WriteLine("Mujeres mayores de 20 años y menores de 28 años: " + CuanMM20YMen28);
            Console.WriteLine("Nomina Total de Mujeres: $" + NominaM);
            Console.WriteLine("Nomina Total de Hombres: $" + NominaH);
            Console.WriteLine("Nomina Total de " + ContT + " numero de empleados : " + NominaT);
            Console.ReadKey();
        }
    }
}
