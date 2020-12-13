using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pablo Diaz Ochoa");
            Console.WriteLine("Matricula: 030343");
            Console.Write("\n");
            int Contador;
            Contador = 0;
            int Clave;
            Clave = 0;
            int Respuesta;
            Respuesta = 1;
            int Respuesta2;
            Respuesta2 = 1;
            double CantidadBoletos1,CantidadBoletos2,CantidadBoletos3,CantidadBoletos4,CantidadBoletos5;
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
            double VentaTotalIndividual1, VentaTotalIndividual2, VentaTotalIndividual3, VentaTotalIndividual4, VentaTotalIndividual5,VentaTotalIndividualG;
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

            while (Respuesta == 1)
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
                    if(Respuesta2 == 2)
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
                        Console.WriteLine("El subtotal de todo es : " + VentaTotalIndividualG+ " Para el usuario " + Contador);
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
    }
}
