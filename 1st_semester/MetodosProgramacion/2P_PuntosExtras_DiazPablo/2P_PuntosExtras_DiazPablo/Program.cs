using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P_PuntosExtras_DiazPablo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Programa Random";
            bool estado = true;
            int ran = 0, L2 = 0, L3 = 0, L4 = 0, L5 = 0, L6 = 0, L7 = 0, L8 = 0;
            Random rnd = new Random();
            while (estado == true)
            {
                double RespuestaIrregular = 0;
                int randum = rnd.Next(2, 9);
                Console.WriteLine("Numero random entre 2 y 8 es: " + randum);
                Console.WriteLine("\n");
                if (randum == 2)
                {
                    L2 = L2 + 1;
                    Console.WriteLine("2 Lados");
                    Console.WriteLine("\n");
                    double lado1 = 0, lado2 = 0;
                    int R1 = 0;
                    Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                    R1 = int.Parse(Console.ReadLine());
                    if (R1 == 1)
                    {
                        double randim = rnd.Next(1, 100);
                        double randim2 = rnd.Next(1, 100);
                        Console.WriteLine("Lado 1: " + randim + " cm");
                        Console.WriteLine("Lado 2: " + randim2 + " cm");
                        DosLados(randim, randim2);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("\n");
                        Console.WriteLine("Ingrese Lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Lado 1: " + lado1 + " cm");
                        Console.WriteLine("Lado 2: " + lado2 + " cm");
                        DosLados(lado1, lado2);
                    }
                }
                else if (randum == 3)
                {
                    L3 = L3 + 1;
                    Console.WriteLine("3 Lados");
                    double lado1 = 0, lado2 = 0, lado3 = 0;
                    int R2 = 0;
                    Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                    R2 = int.Parse(Console.ReadLine());
                    if (R2 == 1)
                    {
                        double randim = rnd.Next(1, 100);
                        double randim2 = rnd.Next(1, 100);
                        double randim3 = rnd.Next(1, 100);
                        Console.WriteLine("\n");
                        Console.WriteLine("Lado 1: " + randim + " cm");
                        Console.WriteLine("Lado 2: " + randim2 + " cm");
                        Console.WriteLine("Lado 3: " + randim3 + " cm");
                        TresLados(randim, randim2, randim3);
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Ingrese Lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese Lado 3: ");
                        lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Lado 1: " + lado1 + " cm");
                        Console.WriteLine("Lado 2: " + lado2 + " cm");
                        Console.WriteLine("Lado 3: " + lado3 + " cm");
                        TresLados(lado1, lado2, lado3);
                    }
                }
                else if (randum == 4)
                {
                    L4 = L4 + 1;
                    Console.WriteLine("4 Lados");
                    Console.WriteLine(" ");
                    Console.WriteLine("Es Regular o irregular?");
                    Console.WriteLine("1-. Irregular        2-. Regular");
                    RespuestaIrregular = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    if (RespuestaIrregular == 1)
                    {

                        // Figura irregular de 4 lados
                        Console.WriteLine("     Figura irregular de 4 lados de la forma: ");
                        Console.WriteLine("");
                        Console.WriteLine("        ****************");
                        Console.WriteLine("       *****************");
                        Console.WriteLine("      ******************");
                        Console.WriteLine("     *******************");
                        Console.WriteLine("    ********************");
                        Console.WriteLine("   *********************");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para continuar....");
                        Console.ReadKey();
                        Console.WriteLine("     1-. Dividimos en triangulos iguales la figura: ");
                        Console.WriteLine("\n");
                        Console.WriteLine("                          Lado 2                                     ");
                        Console.WriteLine("                                                         ");
                        Console.WriteLine("                   ****************                              *");
                        Console.WriteLine("                 *************                              ******");
                        Console.WriteLine("   Lado 1       **********       <--Lado 3-->            *********");
                        Console.WriteLine("             *******             (Lado Común)         ************    Lado 4 ");
                        Console.WriteLine("           ****                                  *****************");
                        Console.WriteLine("         *                                   *********************");
                        Console.WriteLine("                                                      Lado 5             ");
                        Console.WriteLine("        Triángulo 1                                           Triángulo 2               ");
                        Console.WriteLine("");
                        Console.WriteLine("Presione enter para continuar....");
                        Console.ReadKey();
                        double lado1 = 0, lado2 = 0, lado3 = 0, lado4 = 0, lado5 = 0, s1 = 0, s2 = 0, a1 = 0, a2 = 0, p = 0;
                        Console.WriteLine("Ingrese lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 3: ");
                        lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 4: ");
                        lado4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 5: ");
                        lado5 = double.Parse(Console.ReadLine());
                        s1 = (lado1 + lado2 + lado3) / 2;
                        a1 = Math.Round(Math.Sqrt(Math.Abs(s1 * (s1 - lado1) * (s1 - lado2) * (s1 - lado3))), 2);
                        s2 = (lado3 + lado4 + lado5) / 2;
                        a2 = Math.Round(Math.Sqrt(Math.Abs(s2 * (s2 - lado3) * (s2 - lado4) * (s2 - lado5))), 2);
                        p = lado1 + lado2 + lado3 + lado4 + lado5;
                        Console.WriteLine(" ");
                        Console.WriteLine("Lado 1: " + lado1 + " cm"); Console.WriteLine("Lado 2: " + lado2 + " cm"); Console.WriteLine("Lado 3 o diagonal: " + lado3 + " cm");
                        Console.WriteLine("Lado 4: " + lado4 + " cm"); Console.WriteLine("Lado 5: " + lado5 + " cm");
                        Console.WriteLine("Área de triángulo 1: " + a1 + " cm");
                        Console.WriteLine("Área de triángulo 2: " + a2 + " cm");
                        Console.WriteLine("Perimetro total de la figura: " + Math.Round(p, 2) + " cm");
                        Console.WriteLine("Área total de la figura: " + Math.Round((a1 + a2), 2) + " cm");
                        Console.WriteLine("Presione enter para continuar....");
                        Console.ReadKey();
                    }
                    else
                    {
                        double lado1 = 0, lado2 = 0, lado3 = 0;
                        int R2 = 0;
                        Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                        R2 = int.Parse(Console.ReadLine());
                        if (R2 == 1)
                        {
                            double Mayor = 0; double Medio = 0; double Menor = 0;
                            double randim = rnd.Next(1, 100);
                            double randim2 = rnd.Next(1, 100);
                            double randim3 = rnd.Next(1, 100);
                            if (randim > randim2 && randim > randim3)//Primera comparación
                            {
                                Mayor = randim;
                                if (randim2 > randim3)
                                {
                                    Medio = randim2;
                                    Menor = randim3;
                                }
                                else if (randim2 < randim3)
                                {
                                    Medio = randim3;
                                    Menor = randim2;
                                }
                            }
                            else if (randim2 > randim && randim2 > randim3)//Segunda Comparación
                            {
                                Mayor = randim2;
                                if (randim > randim3)
                                {
                                    Medio = randim;
                                    Menor = randim3;
                                }
                                else if (randim < randim3)
                                {
                                    Medio = randim3;
                                    Menor = randim;
                                }
                            }
                            else if (randim3 > randim && randim3 > randim2)//Tercera  Comparación
                            {
                                Mayor = randim3;
                                if (randim > randim2)
                                {
                                    Medio = randim;
                                    Menor = randim2;
                                }
                                else if (randim < randim2)
                                {
                                    Medio = randim2;
                                    Menor = randim;
                                }
                            }
                            Console.WriteLine("\n");
                            Console.WriteLine("Base Mayor: " + Mayor + " cm");
                            Console.WriteLine("Base Menor: " + Menor + " cm");
                            Console.WriteLine("lado: " + Medio + " cm");
                            CuatroLados(Mayor, Menor, Medio);
                        }
                        else
                        {
                            double Mayor = 0; double Medio = 0; double Menor = 0;
                            Console.WriteLine("\n");
                            Console.WriteLine("Ingrese lado 1: ");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese lado 2: ");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa lado 3: ");
                            lado3 = double.Parse(Console.ReadLine());
                            if (lado1 > lado2 && lado1 > lado3)//Primera comparación
                            {
                                Mayor = lado1;
                                if (lado2 > lado3)
                                {
                                    Medio = lado2;
                                    Menor = lado3;
                                }
                                else if (lado2 < lado3)
                                {
                                    Medio = lado3;
                                    Menor = lado2;
                                }
                            }
                            else if (lado2 > lado1 && lado2 > lado3)//Segunda Comparación
                            {
                                Mayor = lado2;
                                if (lado1 > lado3)
                                {
                                    Medio = lado1;
                                    Menor = lado3;
                                }
                                else if (lado1 < lado3)
                                {
                                    Medio = lado3;
                                    Menor = lado1;
                                }
                            }
                            else if (lado3 > lado1 && lado3 > lado2)//Tercera  Comparación
                            {
                                Mayor = lado3;
                                if (lado1 > lado2)
                                {
                                    Medio = lado1;
                                    Menor = lado2;
                                }
                                else if (lado1 < lado2)
                                {
                                    Medio = lado2;
                                    Menor = lado1;
                                }
                            }//Terminacion                          
                            Console.WriteLine("\n");
                            Console.WriteLine("Base Mayor: " + Mayor + " cm");
                            Console.WriteLine("Base Menor: " + Menor + " cm");
                            Console.WriteLine("Lado : " + Medio + " cm");
                            CuatroLados(Mayor, Menor, Medio);
                        }

                    }
                }
                else if (randum == 5)
                {
                    L5 = L5 + 1;
                    Console.WriteLine("5 Lados");
                    Console.WriteLine(" ");
                    Console.WriteLine("Es Regular o irregular?");
                    Console.WriteLine("1-. Irregular        2-. Regular");
                    RespuestaIrregular = double.Parse(Console.ReadLine());
                    Console.WriteLine(" "); ;
                    if (RespuestaIrregular == 1)
                    {
                        //Figura Irregular 5 lados
                        double lado1 = 0, lado2 = 0, lado3 = 0, lado4 = 0, lado5 = 0, altura1 = 0, altura2 = 0, altura3 = 0, altura4 = 0, altura5 = 0;
                        Console.WriteLine("Ingrese lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 1: ");
                        altura1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 2: ");
                        altura2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 3: ");
                        lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 3: ");
                        altura3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 4: ");
                        lado4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 4: ");
                        altura4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 5: ");
                        lado5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 5: ");
                        altura5 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        CincoLadosIrregular(lado1, lado2, lado3, lado4, lado5, altura1, altura2, altura3, altura4, altura5);
                        Console.ReadKey();
                    }
                    else
                    {
                        double lado1 = 0, lado2 = 0;
                        int R2 = 0;
                        Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                        R2 = int.Parse(Console.ReadLine());
                        if (R2 == 1)
                        {
                            double randim = rnd.Next(1, 100);
                            double randim2 = rnd.Next(1, 100);
                            Console.WriteLine("\n");
                            Console.WriteLine("Lado : " + randim + " cm");
                            Console.WriteLine("apotema: " + randim2 + " cm");
                            CincoLados(randim, randim2);
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Ingrese lado: ");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese apotema: ");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("lado: " + lado1 + " cm");
                            Console.WriteLine("apotema: " + lado2 + " cm");
                            CincoLados(lado1, lado2);
                        }
                    }
                }
                else if (randum == 6)
                {
                    L6 = L6 + 1;
                    Console.WriteLine("6 Lados");
                    Console.WriteLine(" ");
                    Console.WriteLine("Es Regular o irregular?");
                    Console.WriteLine("1-. Irregular        2-. Regular");
                    RespuestaIrregular = double.Parse(Console.ReadLine());
                    Console.WriteLine(" "); ;
                    if (RespuestaIrregular == 1)
                    {
                        double lado1 = 0, lado2 = 0, lado3 = 0, lado4 = 0, lado5 = 0, lado6 = 0, altura1 = 0, altura2 = 0, altura3 = 0, altura4 = 0, altura5 = 0, altura6 = 0;
                        Console.WriteLine("Ingrese lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 1: ");
                        altura1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 2: ");
                        altura2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 3: ");
                        lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 3: ");
                        altura3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 4: ");
                        lado4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 4: ");
                        altura4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 5: ");
                        lado5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 5: ");
                        altura5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 6: ");
                        lado6 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 6: ");
                        altura6 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        SeisLadosIrregular(lado1, lado2, lado3, lado4, lado5, lado6, altura1, altura2, altura3, altura4, altura5, altura6);
                        Console.ReadKey();
                    }
                    else
                    {
                        double lado1 = 0, lado2 = 0;
                        int R2 = 0;
                        Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                        R2 = int.Parse(Console.ReadLine());
                        if (R2 == 1)
                        {
                            double randim = rnd.Next(1, 100);
                            double randim2 = rnd.Next(1, 100);
                            Console.WriteLine("\n");
                            Console.WriteLine("Lado : " + randim + " cm");
                            Console.WriteLine("apotema: " + randim2 + " cm");
                            SeisLados(randim, randim2);
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Ingrese lado: ");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese apotema: ");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("lado: " + lado1 + " cm");
                            Console.WriteLine("apotema: " + lado2 + " cm");
                            SeisLados(lado1, lado2);
                        }
                    }
                }
                else if (randum == 7)
                {
                    L7 = L7 + 1;
                    Console.WriteLine("7 Lados");
                    Console.WriteLine(" ");
                    Console.WriteLine("Es Regular o irregular?");
                    Console.WriteLine("1-. Irregular        2-. Regular");
                    RespuestaIrregular = double.Parse(Console.ReadLine());
                    Console.WriteLine(" "); ;
                    if (RespuestaIrregular == 1)
                    {
                        //Figura Irregular 7 lados
                        double lado1 = 0, lado2 = 0, lado3 = 0, lado4 = 0, lado5 = 0, lado6 = 0, lado7 = 0, altura1 = 0, altura2 = 0, altura3 = 0, altura4 = 0, altura5 = 0, altura6 = 0, altura7 = 0;
                        Console.WriteLine("Ingrese lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 1: ");
                        altura1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 2: ");
                        altura2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 3: ");
                        lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 3: ");
                        altura3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 4: ");
                        lado4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 4: ");
                        altura4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 5: ");
                        lado5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 5: ");
                        altura5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 6: ");
                        lado6 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 6: ");
                        altura6 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 7: ");
                        lado7 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 7: ");
                        altura7 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        SieteLadosIrregular(lado1, lado2, lado3, lado4, lado5, lado6, lado7, altura1, altura2, altura3, altura4, altura5, altura6, altura7);
                        Console.ReadKey();
                    }
                    else
                    {
                        double lado1 = 0, lado2 = 0;
                        int R2 = 0;
                        Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                        R2 = int.Parse(Console.ReadLine());
                        if (R2 == 1)
                        {
                            double randim = rnd.Next(1, 100);
                            double randim2 = rnd.Next(1, 100);
                            Console.WriteLine("\n");
                            Console.WriteLine("Lado : " + randim + " cm");
                            Console.WriteLine("apotema: " + randim2 + " cm");
                            SieteLados(randim, randim2);
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Ingrese lado: ");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese apotema: ");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("lado: " + lado1 + " cm");
                            Console.WriteLine("apotema: " + lado2 + " cm");
                            SieteLados(lado1, lado2);
                        }
                    }

                }
                else if (randum == 8)
                {
                    L8 = L8 + 1;
                    Console.WriteLine("8 Lados");
                    Console.WriteLine(" ");
                    Console.WriteLine("Es Regular o irregular?");
                    Console.WriteLine("1-. Irregular        2-. Regular");
                    RespuestaIrregular = double.Parse(Console.ReadLine());
                    Console.WriteLine(" "); ;
                    if (RespuestaIrregular == 1)
                    {
                        double lado1 = 0, lado2 = 0, lado3 = 0, lado4 = 0, lado5 = 0, lado6 = 0, lado7 = 0, lado8 = 0, altura1 = 0, altura2 = 0, altura3 = 0, altura4 = 0, altura5 = 0, altura6 = 0, altura7 = 0, altura8 = 0;
                        Console.WriteLine("Ingrese lado 1: ");
                        lado1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 1: ");
                        altura1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 2: ");
                        lado2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 2: ");
                        altura2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 3: ");
                        lado3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 3: ");
                        altura3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 4: ");
                        lado4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 4: ");
                        altura4 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 5: ");
                        lado5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 5: ");
                        altura5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 6: ");
                        lado6 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 6: ");
                        altura6 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 7: ");
                        lado7 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 7: ");
                        altura7 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese lado 8: ");
                        lado8 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura 8: ");
                        altura8 = double.Parse(Console.ReadLine());
                        Console.Clear();
                        OchoLadosIrregular(lado1, lado2, lado3, lado4, lado5, lado6, lado7, lado8, altura1, altura2, altura3, altura4, altura5, altura6, altura7, altura8);
                        Console.ReadKey();
                    }
                    else
                    {
                        double lado1 = 0, lado2 = 0;
                        int R2 = 0;
                        Console.WriteLine("1-. Numeros Random               2-. Tu los Ingresas");
                        R2 = int.Parse(Console.ReadLine());
                        if (R2 == 1)
                        {
                            double randim = rnd.Next(1, 100);
                            double randim2 = rnd.Next(1, 100);
                            Console.WriteLine("\n");
                            Console.WriteLine("Lado : " + randim + " cm");
                            Console.WriteLine("apotema: " + randim2 + " cm");
                            OchoLados(randim, randim2);
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Ingrese lado: ");
                            lado1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese apotema: ");
                            lado2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("lado: " + lado1 + " cm");
                            Console.WriteLine("apotema: " + lado2 + " cm");
                            OchoLados(lado1, lado2);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("El numero es: " + randum + " Y no es válido");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Quieres continuar? ");
                Console.WriteLine("1-. Si                         2-.No (Salir)");
                ran = int.Parse(Console.ReadLine());
                if (ran == 1)
                {
                    estado = true;
                }
                else
                {
                    estado = false;
                    Console.WriteLine("Calculaste el rectangulo : " + L2 + " veces");
                    Console.WriteLine("Calculaste el triangulo : " + L3 + " veces");
                    Console.WriteLine("Calculaste el trapecio : " + L4 + " veces");
                    Console.WriteLine("Calculaste el pentagono : " + L5 + " veces");
                    Console.WriteLine("Calculaste el hexagono : " + L6 + " veces");
                    Console.WriteLine("Calculaste el heptagono : " + L7 + " veces");
                    Console.WriteLine("Calculaste el octagono : " + L8 + " veces");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.Clear();
            }

        }
        static void DosLados(Double A, Double B)
        {
            double perimetro, superficie;
            if (A == B)
            {
                Console.WriteLine("Es un Cuadrado");
                Console.WriteLine("Dibujo: ");
                Console.WriteLine("");
                //Cuadrado
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine(" *");
                }
                Console.WriteLine("");
                perimetro = 4 * A;
                superficie = A * A;
                Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");
            }
            else if (A != B)
            {
                Console.WriteLine("Es un Rectángulo");
                Console.WriteLine("Dibujo: ");
                Console.WriteLine("");
                //Rectangulo
                for (int i = 0; i <= 3; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine(" *");
                }
                Console.WriteLine("");
                perimetro = (2 * A) + (2 * B);
                superficie = A * B;
                Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");
            }
            else
            {
                Console.WriteLine("No pues no sé cual es esa figura mijo");
            }
        }
        static void TresLados(Double A, Double B, Double C)
        {
            double perimetro, superficie;
            double s = 0;
            s = (A + B + C) / 2;
            if (A == B && B == C)
            {
                Console.WriteLine("Es un Triángulo Equilatero");
                Console.WriteLine("Dibujo: ");
                Console.WriteLine("");
                Console.WriteLine("      *");
                Console.WriteLine("     ***");
                Console.WriteLine("    *****");
                Console.WriteLine("   *******");
                Console.WriteLine("  *********");
                Console.WriteLine(" ***********");
                Console.WriteLine("");
                perimetro = 3 * A;
                double op = 0;
                op = s * (s - A) * (s - B) * (s - C);
                if (op <= 0)
                {

                    op = Math.Abs(op);
                    superficie = Math.Sqrt(op);
                    Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                    Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");

                }
                else
                {
                    superficie = Math.Sqrt(op);
                    Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                    Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");
                }
            }
            else if (A == B || B == C || C == A)
            {
                Console.WriteLine("Es un Triángulo Isosceles");
                Console.WriteLine("Dibujo: ");
                Console.WriteLine("");
                Console.WriteLine("      *");
                Console.WriteLine("     ***");
                Console.WriteLine("    *****");
                Console.WriteLine("   *******");
                Console.WriteLine("  *********");
                Console.WriteLine("");
                perimetro = A + B + C;
                double op = 0;
                op = s * (s - A) * (s - B) * (s - C);
                if (op <= 0)
                {
                    op = Math.Abs(op);
                    superficie = Math.Sqrt(op);
                    Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                    Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");
                }
                else
                {
                    superficie = Math.Sqrt(op);
                    Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                    Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");
                }
            }
            else if (A != B || B != C)
            {
                Console.WriteLine("Es un Triángulo Escaleno");
                Console.WriteLine("Dibujo: ");
                Console.WriteLine("");
                Console.WriteLine(" *");
                Console.WriteLine("  ***");
                Console.WriteLine("   *****");
                Console.WriteLine("    *******");
                Console.WriteLine("     *********");
                Console.WriteLine("");
                perimetro = A + B + C;
                double op = 0;
                op = s * (s - A) * (s - B) * (s - C);
                if (op <= 0)
                {
                    op = Math.Abs(op);
                    superficie = Math.Sqrt(op);
                    Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                    Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");


                }
                else
                {
                    superficie = Math.Sqrt(op);
                    Console.WriteLine("Perimetro: " + Math.Round(perimetro, 2) + " cm");
                    Console.WriteLine("Superficie: " + Math.Round(superficie, 2) + " cm");
                }

            }
            else
            {
                Console.WriteLine("No pues no sé cual es esa figura mijo");
            }
        }
        static void CuatroLados(Double B, Double b, Double l)
        {
            Console.WriteLine("Dibujo: ");
            Console.WriteLine("");
            Console.WriteLine("     *****");
            Console.WriteLine("    *******");
            Console.WriteLine("   *********");
            Console.WriteLine("  ***********");
            Console.WriteLine(" *************");
            Console.WriteLine("");
            double A, P, h, n;
            n = (B - b) / 2;
            h = (Math.Pow(l, 2) - Math.Pow(n, 2));
            if (h <= 0)
            {
                h = Math.Sqrt(Math.Abs(Math.Pow(l, 2) - Math.Pow(n, 2)));
                A = Math.Round(((B + b) * h) / 2, 2);
                P = Math.Round((B + b) + (2 * l), 2);
                Console.WriteLine("El área es: " + A + " cm");
                Console.WriteLine("El perimetro es: " + P + " cm");
                Console.ReadKey();
            }
            else
            {
                h = Math.Sqrt(Math.Pow(l, 2) - Math.Pow(n, 2));
                A = Math.Round(((B + b) * h) / 2, 2);
                P = Math.Round((B + b) + (2 * l), 2);
                Console.WriteLine("El área es: " + A + " cm");
                Console.WriteLine("El perimetro es: " + P + " cm");
                Console.ReadKey();
            }
        }
        static void CincoLados(Double A, Double L)
        {
            Console.WriteLine("Dibujo: ");
            Console.WriteLine("");
            Console.WriteLine("        *            ");
            Console.WriteLine("     *     *    ");
            Console.WriteLine(" *             *");
            Console.WriteLine("  *           *     ");
            Console.WriteLine("   *         *");
            Console.WriteLine("    * * * * *");
            Console.WriteLine("");
            double p, a;
            p = 5 * L;
            Console.WriteLine("Perimetro es igual a: " + Math.Round(p, 2) + " cm");
            a = (p * A) / 2;
            Console.WriteLine("Área es igual a: " + Math.Round(a, 2) + "cm");
        }
        static void SeisLados(Double A, Double L)
        {
            Console.WriteLine("Dibujo: ");
            Console.WriteLine("");
            Console.WriteLine("    * * * * *    ");
            Console.WriteLine("   *         *    ");
            Console.WriteLine("  *           *    ");
            Console.WriteLine(" *             *");
            Console.WriteLine("  *           *     ");
            Console.WriteLine("   *         *");
            Console.WriteLine("    * * * * *");
            Console.WriteLine("");
            double p, a;
            p = 6 * L;
            Console.WriteLine("Perimetro es igual a: " + Math.Round(p, 2) + " cm");
            a = (p * A) / 2;
            Console.WriteLine("Área es igual a: " + Math.Round(a, 2) + " cm");
        }
        static void SieteLados(Double A, Double L)
        {
            Console.WriteLine("Dibujo: ");
            Console.WriteLine("");
            Console.WriteLine("        * * *        ");
            Console.WriteLine("     *        *        ");
            Console.WriteLine("   *             *        ");
            Console.WriteLine("  *               *        ");
            Console.WriteLine(" *                 *        ");
            Console.WriteLine("*                   *        ");
            Console.WriteLine("  *               *        ");
            Console.WriteLine("    *           *           ");
            Console.WriteLine("       * * * *        ");
            Console.WriteLine("");
            double p, a;
            p = 7 * L;
            Console.WriteLine("Perimetro es igual a: " + Math.Round(p, 2) + " cm");
            a = (p * A) / 2;
            Console.WriteLine("Área es igual a: " + Math.Round(a, 2) + " cm");
        }
        static void OchoLados(Double A, Double L)
        {
            Console.WriteLine("Dibujo: ");
            Console.WriteLine("");
            Console.WriteLine("       * * * *        ");
            Console.WriteLine("    *           *        ");
            Console.WriteLine("  *               *        ");
            Console.WriteLine("  *               *        ");
            Console.WriteLine("  *               *        ");
            Console.WriteLine("  *               *        ");
            Console.WriteLine("    *           *           ");
            Console.WriteLine("       * * * *        ");
            Console.WriteLine("");
            double p, a;
            p = 8 * L;
            Console.WriteLine("Perimetro es igual a: " + Math.Round(p, 2) + " cm");
            a = (p * A) / 2;
            Console.WriteLine("Área es igual a: " + Math.Round(a, 2) + " cm");
        }
        static void CincoLadosIrregular(double l1, double l2, double l3, double l4, double l5,
                                       double h1, double h2, double h3, double h4, double h5)
        {
            double p = 0; double a = 0, c = 0, acumA = 0;
            double[] lados = new double[5];
            lados[0] = l1; lados[1] = l2; lados[2] = l3; lados[3] = l4; lados[4] = l5;
            double[] alturas = new double[5] { h1, h2, h3, h4, h5 };
            alturas[0] = h1; alturas[1] = h2; alturas[2] = h3; alturas[3] = h4; alturas[4] = h5;

            for (int i = 0; i < 5; i++)
            {
                c = i + 1;
                Console.WriteLine("Lado " + c + ": " + lados[i] + "cm");
                Console.WriteLine("Altura " + c + ": " + alturas[i] + "cm");
                acumA = acumA + (lados[i] * alturas[i]) / 2;
                p = p + lados[i];
                Console.WriteLine(" ");
            }
            Console.WriteLine("Área: " + Math.Round(acumA, 2) + "cm^2");
            Console.WriteLine("Perímetro: " + Math.Round(p, 2) + "cm");
        }
        static void SeisLadosIrregular(double l1, double l2, double l3, double l4, double l5, double l6,
                                         double h1, double h2, double h3, double h4, double h5, double h6)
        {
            double p = 0; double a = 0, c = 0, acumA = 0;
            double[] lados = new double[6];
            lados[0] = l1; lados[1] = l2; lados[2] = l3; lados[3] = l4; lados[4] = l5; lados[5] = l6;
            double[] alturas = new double[6] { h1, h2, h3, h4, h5, h6 };
            alturas[0] = h1; alturas[1] = h2; alturas[2] = h3; alturas[3] = h4; alturas[4] = h5; alturas[5] = h6;

            for (int i = 0; i < 6; i++)
            {
                c = i + 1;
                Console.WriteLine("Lado " + c + ": " + lados[i] + "cm");
                Console.WriteLine("Altura " + c + ": " + alturas[i] + "cm");
                acumA = acumA + (lados[i] * alturas[i]) / 2;
                p = p + lados[i];
                Console.WriteLine(" ");
            }
            Console.WriteLine("Área: " + Math.Round(acumA, 2) + "cm^2");
            Console.WriteLine("Perímetro: " + Math.Round(p, 2) + "cm");
        }
        static void SieteLadosIrregular(double l1, double l2, double l3, double l4, double l5, double l6, double l7,
                                       double h1, double h2, double h3, double h4, double h5, double h6, double h7)
        {
            double p = 0; double a = 0, c = 0, acumA = 0;
            double[] lados = new double[7];
            lados[0] = l1; lados[1] = l2; lados[2] = l3; lados[3] = l4; lados[4] = l5; lados[5] = l6; lados[6] = l7;
            double[] alturas = new double[7] { h1, h2, h3, h4, h5, h6, h7 };
            alturas[0] = h1; alturas[1] = h2; alturas[2] = h3; alturas[3] = h4; alturas[4] = h5; alturas[5] = h6; alturas[6] = h7;

            for (int i = 0; i < 7; i++)
            {
                c = i + 1;
                Console.WriteLine("Lado " + c + ": " + lados[i] + "cm");
                Console.WriteLine("Altura " + c + ": " + alturas[i] + "cm");
                acumA = acumA + (lados[i] * alturas[i]) / 2;
                p = p + lados[i];
                Console.WriteLine(" ");
            }
            Console.WriteLine("Área: " + Math.Round(acumA, 2) + "cm^2");
            Console.WriteLine("Perímetro: " + Math.Round(p, 2) + "cm");
        }
        static void OchoLadosIrregular(double l1, double l2, double l3, double l4, double l5, double l6, double l7, double l8,
                                       double h1, double h2, double h3, double h4, double h5, double h6, double h7, double h8)
        {
            double p = 0; double a = 0, c = 0, acumA = 0;
            double[] lados = new double[8];
            lados[0] = l1; lados[1] = l2; lados[2] = l3; lados[3] = l4; lados[4] = l5; lados[5] = l6; lados[6] = l7; lados[7] = l8;
            double[] alturas = new double[8] { h1, h2, h3, h4, h5, h6, h7, h8 };
            alturas[0] = h1; alturas[1] = h2; alturas[2] = h3; alturas[3] = h4; alturas[4] = h5; alturas[5] = h6; alturas[6] = h7; alturas[7] = h8;

            for (int i = 0; i < 8; i++)
            {
                c = i + 1;
                Console.WriteLine("Lado " + c + ": " + lados[i] + "cm");
                Console.WriteLine("Altura " + c + ": " + alturas[i] + "cm");
                acumA = acumA + (lados[i] * alturas[i]) / 2;
                p = p + lados[i];
                Console.WriteLine(" ");
            }
            Console.WriteLine("Área: " + Math.Round(acumA, 2) + "cm^2");
            Console.WriteLine("Perímetro: " + Math.Round(p, 2) + "cm");
        }
    }
}
