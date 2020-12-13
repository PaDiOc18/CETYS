using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_DiazPablo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.WriteLine("Presione enter para continuar....");
            Console.ReadKey();
            int Programa, Respuesta;
            Programa = 0;  Respuesta = 0;
            bool estado;
            estado = true;
            while (estado == true)
            {
                Console.WriteLine("¿A que programa quieres ingresar?");
                Console.WriteLine("1-. Programa Estadístico");
                Console.WriteLine("2-. Programa Estadio");
                Console.WriteLine("3-. Programa Contabilización de Votos");
                Console.WriteLine("4-. Suma y Resta de dos números");
                Programa = int.Parse(Console.ReadLine());
                if (Programa == 1)
                {
                    Programa_Estadístico();
                }
                else if (Programa == 2)
                {
                    Programa_Estadio();
                }
                else if (Programa == 3)
                {
                    Programa_Votos();
                }
                else
                {
                    Console.WriteLine("El programa no existe");
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Quieres ingresar a otro Programa?");
                Console.WriteLine("1-. Si               2-. No");
                Respuesta = int.Parse(Console.ReadLine());
                if (Respuesta == 1)
                {
                    estado = true;
                }
                else if (Respuesta == 2)
                {
                    estado = false;
                }
                else
                {
                    Console.WriteLine("Ingrese una opción válida");
                    break;
                }
            } //Fin Ciclo While

        }
        static void Programa_Estadístico()
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.WriteLine("\n");
            Console.WriteLine("Pulse Enter para continuar");
            Console.ReadKey();
            Console.Clear();
            string sexo;
            int edad, Respuesta4;
            Respuesta4 = 0;
            double sueldo, ContM500Mas, ContH400Men, PorM500Mas, PorH400Mas, PorHombres, PorMujeres, ContH, ContM, ContT, CuanHM18YMen25, CuanMM20YMen28, NominaH, NominaM, NominaT;
            ContM500Mas = 0; ContH400Men = 0; PorM500Mas = 0; PorH400Mas = 0; PorHombres = 0; PorMujeres = 0; ContH = 0; ContM = 0; ContT = 0; CuanHM18YMen25 = 0; CuanMM20YMen28 = 0; NominaH = 0; NominaM = 0; NominaT = 0;
            bool estado2; estado2 = true;

            while (estado2 == true)
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
                else if (sexo == "M")
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
                if (sexo == "H" && edad > 18 && edad < 25)
                {
                    CuanHM18YMen25 = CuanHM18YMen25 + 1;
                }
                if (sexo == "M" && edad > 20 && edad < 28)
                {
                    CuanMM20YMen28 = CuanMM20YMen28 + 1;
                }
                ContT = ContT + 1;
                Console.WriteLine("Quieres seguir ingresar otro empleado?");
                Console.WriteLine("1-. Si          2-. No");
                Respuesta4 = int.Parse(Console.ReadLine());
                if (Respuesta4 == 1)
                {
                    estado2 = true;
                }
                else
                {
                    estado2 = false;
                }
                Console.Clear();

            } //Termina Ciclo While

            string cadenita1, cadenita2, cadenita3, cadenita4;
            PorM500Mas = (ContM500Mas / ContM) * 100;
            cadenita1 = Convert.ToString(Math.Round(PorM500Mas, 2));
            Console.WriteLine("Numero de Mujeres que ganan mas de $500 pesos: " + ContM500Mas + " El porcentaje es: " + cadenita1 + "%");
            PorH400Mas = (ContH400Men / ContH) * 100;
            cadenita2 = Convert.ToString(Math.Round(PorH400Mas, 2));
            Console.WriteLine("Numero de Hombres que ganan menos de $400 pesos: " + ContH400Men + " El porcentaje es: " + cadenita2 + "%");
            PorHombres = (ContH / ContT) * 100;
            cadenita3 = Convert.ToString(Math.Round(PorHombres, 2));
            Console.WriteLine("Numero de Hombres en la empresa: " + ContH + " El porcentaje es: " + cadenita3 + "%");
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
        static void Programa_Estadio()
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            int Contador;
            Contador = 0;
            int Clave;
            Clave = 0;
            int Respuesta3;
            Respuesta3 = 1;
            int Respuesta2;
            Respuesta2 = 1;
            double CantidadBoletos1, CantidadBoletos2, CantidadBoletos3, CantidadBoletos4, CantidadBoletos5;
            double CantidadBoletos1Individual, CantidadBoletos2Individual, CantidadBoletos3Individual, CantidadBoletos4Individual, CantidadBoletos5Individual, CantidadTotalBoletosIndividual;
            CantidadTotalBoletosIndividual = 0;
            double CantidadBoletos1Total, CantidadBoletos2Total, CantidadBoletos3Total, CantidadBoletos4Total, CantidadBoletos5Total, CantidadTotalBoletosTotal;
            CantidadBoletos1Total = 0;
            CantidadBoletos2Total = 0;
            CantidadBoletos3Total = 0;
            CantidadBoletos4Total = 0;
            CantidadBoletos5Total = 0;
            CantidadTotalBoletosTotal = 0;
            CantidadBoletos1Individual = 0;
            CantidadBoletos2Individual = 0;
            CantidadBoletos3Individual = 0;
            CantidadBoletos4Individual = 0;
            CantidadBoletos5Individual = 0;
            CantidadTotalBoletosIndividual = 0;
            CantidadBoletos1 = 0;
            CantidadBoletos1 = 0;
            CantidadBoletos2 = 0;
            CantidadBoletos3 = 0;
            CantidadBoletos4 = 0;
            CantidadBoletos5 = 0;
            double VentaIndividual1, VentaIndividual2, VentaIndividual3, VentaIndividual4, VentaIndividual5;
            VentaIndividual1 = 0;
            VentaIndividual2 = 0;
            VentaIndividual3 = 0;
            VentaIndividual4 = 0;
            VentaIndividual5 = 0;
            double VentaTotalIndividual1, VentaTotalIndividual2, VentaTotalIndividual3, VentaTotalIndividual4, VentaTotalIndividual5, VentaTotalIndividualG;
            VentaTotalIndividual1 = 0;
            VentaTotalIndividual2 = 0;
            VentaTotalIndividual3 = 0;
            VentaTotalIndividual4 = 0;
            VentaTotalIndividual5 = 0;
            VentaTotalIndividualG = 0;
            double VentaTotalTotal1, VentaTotalTotal2, VentaTotalTotal3, VentaTotalTotal4, VentaTotalTotal5, VentaSuperTotal;
            VentaSuperTotal = 0;
            VentaTotalTotal1 = 0;
            VentaTotalTotal2 = 0;
            VentaTotalTotal3 = 0;
            VentaTotalTotal4 = 0;
            VentaTotalTotal5 = 0;

            double Precio1, Precio2, Precio3, Precio4, Precio5;
            Precio1 = 50;
            Precio2 = 120;
            Precio3 = 80;
            Precio4 = 90;
            Precio5 = 160;

            while (Respuesta3 == 1)
            {
                CantidadBoletos1Individual = 0;
                CantidadBoletos2Individual = 0;
                CantidadBoletos3Individual = 0;
                CantidadBoletos4Individual = 0;
                CantidadBoletos5Individual = 0;
                VentaTotalIndividual1 = 0;
                VentaTotalIndividual2 = 0;
                VentaTotalIndividual3 = 0;
                VentaTotalIndividual4 = 0;
                VentaTotalIndividual5 = 0;
                CantidadTotalBoletosTotal = 0;
                VentaTotalIndividualG = 0;
                Contador = Contador + 1;
                while (Respuesta2 == 1)
                {

                    Console.WriteLine("Claves 1: $50 pesos ");
                    Console.WriteLine("Claves 2: $120 pesos ");
                    Console.WriteLine("Claves 3: $80 pesos ");
                    Console.WriteLine("Claves 4: $90 pesos ");
                    Console.WriteLine("Claves 5: $160 pesos ");
                    Console.WriteLine("Ingrese clave:  ");
                    Clave = int.Parse(Console.ReadLine());
                    switch (Clave)
                    {
                        case 1:
                            Console.WriteLine("Ingrese cantidad de boletos: ");
                            CantidadBoletos1 = int.Parse(Console.ReadLine());
                            CantidadBoletos1Individual = CantidadBoletos1Individual + CantidadBoletos1;
                            CantidadBoletos1Total = CantidadBoletos1Total + CantidadBoletos1;
                            VentaIndividual1 = Precio1 * CantidadBoletos1;
                            VentaTotalIndividual1 = VentaTotalIndividual1 + VentaIndividual1;
                            VentaTotalIndividual1 += VentaTotalIndividual1;
                            VentaTotalTotal1 = VentaTotalTotal1 + VentaIndividual1;
                            break;

                        case 2:
                            Console.WriteLine("Ingrese cantidad de boletos: ");
                            CantidadBoletos2 = int.Parse(Console.ReadLine());
                            CantidadBoletos2Individual = CantidadBoletos2Individual + CantidadBoletos2;
                            CantidadBoletos2Total = CantidadBoletos2Total + CantidadBoletos2;
                            VentaIndividual2 = Precio2 * CantidadBoletos2;
                            VentaTotalIndividual2 = VentaTotalIndividual2 + VentaIndividual2;
                            VentaTotalIndividual2 += VentaTotalIndividual2;
                            VentaTotalTotal2 = VentaTotalTotal2 + VentaIndividual2;
                            break;

                        case 3:
                            Console.WriteLine("Ingrese cantidad de boletos: ");
                            CantidadBoletos3 = int.Parse(Console.ReadLine());
                            CantidadBoletos3Individual = CantidadBoletos3Individual + CantidadBoletos3;
                            CantidadBoletos3Total = CantidadBoletos3Total + CantidadBoletos3;
                            VentaIndividual3 = Precio3 * CantidadBoletos3;
                            VentaTotalIndividual3 = VentaTotalIndividual3 + VentaIndividual3;
                            VentaTotalIndividual3 += VentaTotalIndividual3;
                            VentaTotalTotal3 = VentaTotalTotal3 + VentaIndividual3;

                            break;

                        case 4:
                            Console.WriteLine("Ingrese cantidad de boletos: ");
                            CantidadBoletos4 = int.Parse(Console.ReadLine());
                            CantidadBoletos4Individual = CantidadBoletos4Individual + CantidadBoletos4;
                            CantidadBoletos4Total = CantidadBoletos4Total + CantidadBoletos4;
                            VentaIndividual4 = Precio4 * CantidadBoletos4;
                            VentaTotalIndividual4 = VentaTotalIndividual4 + VentaIndividual4;
                            VentaTotalIndividual4 += VentaTotalIndividual4;
                            VentaTotalTotal4 = VentaTotalTotal4 + VentaIndividual4;

                            break;

                        case 5:
                            Console.WriteLine("Ingrese cantidad de boletos: ");
                            CantidadBoletos5 = int.Parse(Console.ReadLine());
                            CantidadBoletos5Individual = CantidadBoletos5Individual + CantidadBoletos5;
                            CantidadBoletos5Total = CantidadBoletos5Total + CantidadBoletos5;
                            VentaIndividual5 = Precio5 * CantidadBoletos5;
                            VentaTotalIndividual5 = VentaTotalIndividual5 + VentaIndividual5;
                            VentaTotalIndividual5 += VentaTotalIndividual5;
                            VentaTotalTotal5 = VentaTotalTotal5 + VentaIndividual5;

                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("¿Quiere efectuar otra compra? ");
                    Console.WriteLine("1-. Si             2-.No");
                    Respuesta2 = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    Console.Clear();
                    if (Respuesta2 == 2)
                    {
                        Console.WriteLine("Vendedor Numero " + Contador);
                        Console.WriteLine("Localidad 1: " + CantidadBoletos1Individual + " Boletos" + "   Subtotal: " + VentaTotalIndividual1);
                        Console.WriteLine("Localidad 2: " + CantidadBoletos2Individual + " Boletos" + "   Subtotal: " + VentaTotalIndividual2);
                        Console.WriteLine("Localidad 3: " + CantidadBoletos3Individual + " Boletos" + "   Subtotal: " + VentaTotalIndividual3);
                        Console.WriteLine("Localidad 4: " + CantidadBoletos4Individual + " Boletos" + "   Subtotal: " + VentaTotalIndividual4);
                        Console.WriteLine("Localidad 5: " + CantidadBoletos5Individual + " Boletos" + "   Subtotal: " + VentaTotalIndividual5);
                        CantidadTotalBoletosIndividual = CantidadBoletos1Individual + CantidadBoletos2Individual + CantidadBoletos3Individual + CantidadBoletos4Individual + CantidadBoletos5Individual;
                        Console.WriteLine("La cantidad total de boletos vendidos es: " + CantidadTotalBoletosIndividual + " Para el usuario " + Contador);
                        VentaTotalIndividualG = VentaTotalIndividual1 + VentaTotalIndividual2 + VentaTotalIndividual3 + VentaTotalIndividual4 + VentaTotalIndividual5;
                        Console.WriteLine("El subtotal de todo es : " + VentaTotalIndividualG + " Para el usuario " + Contador);
                        Console.ReadKey();
                        Console.Clear();
                    }

                } /*Fin Ciclo While 2*/
                Console.WriteLine("¿Quieres comprar boletos? (Nuevo usuario)");
                Console.WriteLine("1-. Si             2-.No");
                Respuesta2 = int.Parse(Console.ReadLine());
                if (Respuesta2 == 2)
                {
                    break;
                }

            }/*Fin Ciclo While 1*/
            CantidadTotalBoletosTotal = CantidadBoletos1Total + CantidadBoletos2Total + CantidadBoletos3Total + CantidadBoletos4Total + CantidadBoletos5Total;
            Console.WriteLine("El numero total de boletos son: " + CantidadTotalBoletosTotal);
            VentaSuperTotal = VentaTotalTotal1 + VentaTotalTotal2 + VentaTotalTotal3 + VentaTotalTotal4 + VentaTotalTotal5;
            Console.WriteLine("La venta total es: " + VentaSuperTotal);
            Console.WriteLine("Localidad 1: " + CantidadBoletos1Total + " Boletos" + "     El Subtotal es: " + VentaTotalTotal1);
            Console.WriteLine("Localidad 2: " + CantidadBoletos2Total + " Boletos" + "     El Subtotal es: " + VentaTotalTotal2);
            Console.WriteLine("Localidad 3: " + CantidadBoletos3Total + " Boletos" + "     El Subtotal es: " + VentaTotalTotal3);
            Console.WriteLine("Localidad 4: " + CantidadBoletos4Total + " Boletos" + "     El Subtotal es: " + VentaTotalTotal4);
            Console.WriteLine("Localidad 5: " + CantidadBoletos5Total + " Boletos" + "     El Subtotal es: " + VentaTotalTotal5);
            Console.ReadKey();
        }
        static void Programa_Votos()
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            Console.ReadKey();
            double Voto;
            Voto = 1;
            double ContadorGeneral = 0;
            double Contador1, Porcentaje1;
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

            Porcentaje1 = Math.Round((Contador1 / ContadorGeneral) * 100, 2);
            Porcentaje2 = Math.Round((Contador2 / ContadorGeneral) * 100, 2);
            Porcentaje3 = Math.Round((Contador3 / ContadorGeneral) * 100, 2);
            Porcentaje4 = Math.Round((Contador4 / ContadorGeneral) * 100, 2);
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
