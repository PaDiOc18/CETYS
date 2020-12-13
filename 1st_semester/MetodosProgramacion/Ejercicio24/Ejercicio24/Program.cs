using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio24
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuesta1 = 0; int respuesta2 = 0; int respuesta3 = 0;
            bool estado1, estado2 ,estado3;
            estado1 = true; estado2 = true; estado3 = true;

            while (estado1 == true)
            {
                while (estado2 == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.Title = "Ejemplo de Procedimientos en un menú";
                    Int32 num1, num2;
                    int opcion;
                    Console.WriteLine("\n MENU PRINCIPAL DE OPERACIONES MATEMATICAS:");
                    Console.WriteLine("\n");
                    Console.Write("\tDigitar el primer número: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.Write("\tDigitar el segundo numero: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                    while (estado3 == true)//While 3
                    {
                        Console.WriteLine("\n MENU PRINCIPAL DE OPERACIONES MATEMATICAS:");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n ===============================================");
                        Console.WriteLine("\n");
                        Console.WriteLine("\t1) Mayor de los 2");
                        Console.WriteLine("\t2) Multiplo");
                        Console.WriteLine("\t3) Potencia");
                        Console.WriteLine("\t4) Suma y Resta");
                        Console.WriteLine("\n ===============================================");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n");
                        Console.Write("\tDigitar la opción deseada [1..4]: ");
                        opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        switch (opcion)
                        {
                            case 1:
                                mayor(num1, num2);
                                break;
                            case 2:
                                multiplo(num1, num2);
                                break;
                            case 3:
                                potencia(num1, num2);
                                break;
                            case 4:
                                int n1, n2;
                                Console.WriteLine("Suma y Resta");
                                Console.WriteLine("Escribe la primera cantidad: ");
                                n1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Escribe la segunda cantidad: ");
                                n2 = int.Parse(Console.ReadLine());
                                resta(n1, n2);
                                suma(n1, n2);
                                break;
                            default:
                                Console.WriteLine("\tSe ha equivocado de opcion, solo acepta[1..3]");
                                break;
                        }
                        Console.WriteLine("Quieres regresar al menú de opciones?");
                        Console.WriteLine("1-. Si                   2-. No");
                        respuesta3 = int.Parse(Console.ReadLine());
                        if (respuesta3 == 1)
                        {
                            estado3 = true;
                        }
                        else
                        {
                            estado3 = false;
                        }
                        Console.Clear();
                    }//While3
                    Console.WriteLine("Quieres Volver a ingresar numeros?");
                    Console.WriteLine("1-. Si                   2-. No");
                    respuesta2 = int.Parse(Console.ReadLine());
                    if (respuesta2 == 1)
                    {
                        estado2 = true;
                        estado3 = true;
                    }
                    else
                    {
                        estado2 = false;
                    }
                    Console.Clear();
                    //Inicilizar el numero en 0 de nuevo
                }
                Console.WriteLine("Quieres Salir del Programa?");
                Console.WriteLine("1-. Si                   2-. No");
                respuesta1 = int.Parse(Console.ReadLine());
                if (respuesta1 == 1)
                {
                    estado1 = false;
                    Console.WriteLine("\n");
                    Console.WriteLine("\t-->Fin del programa");
                    Console.ReadKey();
                }
                else
                {
                    estado2 = true;
                }
               
            }
        }

        static void mayor(Int32 a, Int32 b)
        {
            if (a > b)
            {
                Console.WriteLine("\tEl numero {0} es mayor que {1} ", a, b);
            }
            else
            {
                Console.WriteLine("\tEl numero {0} es mayor que {1} ", b, a);
            }
        }

        static void multiplo(Int32 a, Int32 b)
         {
            Int32 w;
            w = (a%b);
            if (w == 0)
            {
                Console.WriteLine("\tEl numero {0} es multiplo de {1} ", a, b);
            }
            else
            {
                Console.WriteLine("\tEl numero {0} no es multiplo de {1} ", b, a);
            }
        }

        static void potencia(Int32 a, Int32 b)
        {
            Double s;
            s = Math.Pow(a, b);
            Console.WriteLine("\tEl numero {0} a la potencia de {1} es: {2}",a,b,s);
        }
        //Aqui va el While jejejeje
        static void suma(Int32 a, Int32 b)
        {
            double r;
            r = a + b;
            Console.WriteLine("El resultado de la suma es: " + r);
        }
        static void resta(Int32 a, Int32 b)
        {
            double r;
            r = a - b;
            Console.WriteLine("El resultado de la resta es: " + r);
        }
    }
 }

