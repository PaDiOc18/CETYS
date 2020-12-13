using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Problemas
{
    class Program
    {
        static void Main(string[] args)
        {
            int rompe = 0;
            while (rompe == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1-. Primero pares y depués impares");
                Console.WriteLine("2-. Distancia entre 2 valores");
                Console.WriteLine("3-. Promedio sin mayor ni menor");
                Console.WriteLine("4-. 20 números aleatorios entre 10 y 100");
                Console.WriteLine("5-. Figura chida #1 usando ciclos anidados");
                Console.WriteLine("6-. Imprimir al revés un string");
                Console.WriteLine("7-. Repetición de la primera letra en el string");
                Console.WriteLine("8-. Terminacion oy sin vocal o terminacion y con la vocal");
                Console.WriteLine("9-. Dígitos que aparecen en ambos arreglos");
                Console.WriteLine("10-. Todos los divisores de un número positivo");
                Console.WriteLine("11-. De string a char");
                Console.WriteLine("12-. De Char a string");
                Console.WriteLine("13-. Suma de potencias de 2 del 2 al 2050");
                Console.WriteLine("14-. Número divisible entre sus dígitos");
                Console.WriteLine("15-. Estadísticas de tirar 5 dados 1 millón de veces");
                Console.WriteLine("16-. 3 números enteros, si es 13 adiós");
                Console.WriteLine("17-. Cuantas veces aparece 'ss' en tu oración");
                Console.WriteLine("18-. Numeros divisibles entre 3 o 5 del 1 al 1000");
                Console.WriteLine("19-. Primeros 20 números fibonacci que son pares");
                Console.WriteLine("20-. Suma de los dígitos del factorial de 15");
                Console.WriteLine("21-. Suma de los divisores enteros de un número");
                Console.WriteLine("22-. Valores del arreglo elevados al cuadrado");
                Console.WriteLine("23-. Valores del arreglo elevados a su índice");
                Console.WriteLine("24-. Sumar todos lo valores del arreglo después del 5");
                Console.WriteLine("25-. Si hay valor repetido en el arreglo false ");
                Console.WriteLine("26-. Raíz cuadrada del promedio de los elementos de un arreglo");
                Console.WriteLine("27-. Cuantos múltiplos de 7 contiene un arreglo");
                Console.WriteLine("28-. Que valores se repiten en ambos arreglos");
                Console.WriteLine("29-. Figura chida con ciclos anidados #2");
                Console.WriteLine("30-. Cuantas veces aparece string2 en el string 1");
                Console.WriteLine("31-. Si el dígito del arreglo no es divisible entre 3 cambiar a número par");
                Console.WriteLine("32-. Cantidad de combinaciones de un valor");
                Console.WriteLine("33-. Sumar a cada valor del arreglo un número");
                Console.WriteLine("34-. Promedio de los pares y promedio de los impares");
                Console.WriteLine("35-. Quitarle vocales a un string");
                Console.WriteLine("36-. Válidar fecha");
                Console.WriteLine("37-. Cuantas veces aparece el 0 en un arreglo");
                Console.WriteLine("38-. Verificar si es una serie fibonacci");
                Console.WriteLine("39-. Arreglo de al menos 10 elementos sumar primeros 5 y restar los que siguen");
                Console.WriteLine("40-. Mínimo común denominador de 2 números");
                Console.WriteLine("41-. Tirando un dado 1000 veces");
                Console.WriteLine("42-. Número más pequeño divisible entre 1 2 3 4 5 6 7 8 y 9");
                Console.WriteLine("43-. Diferencia entre la suma de los cuadrados y el cuadrado de la suma");
                Console.WriteLine("44-. Diferencias entre 2 string");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Qué opción desea mi lord? ");
                int opc = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (opc)
                {
                    case 1:
                        Problema1();
                        break;
                    case 2:
                        Problema2();
                        break;
                    case 3:
                        Problema3();
                        break;
                    case 4:
                        Problema4();
                        break;
                    case 5:
                        Problema5();
                        break;
                    case 6:
                        Problema6();
                        break;
                    case 7:
                        Problema7();
                        break;
                    case 8:
                        Problema8();
                        break;
                    case 9:
                        Problema9();
                        break;
                    case 10:
                        Problema10();
                        break;
                    case 11:
                        Problema11();
                        break;
                    case 12:
                        Problema12();
                        break;
                    case 13:
                        Problema13();
                        break;
                    case 14:
                        Problema14();
                        break;
                    case 15:
                        Problema15();
                        break;
                    case 16:
                        Problema16();
                        break;
                    case 17:
                        Problema17();
                        break;
                    case 18:
                        Problema18();
                        break;
                    case 19:
                        Problema19();
                        break;
                    case 20:
                        Problema20();
                        break;
                    case 21:
                        Problema21();
                        break;
                    case 22:
                        Problema22();
                        break;
                    case 23:
                        Problema23();
                        break;
                    case 24:
                        Problema24();
                        break;
                    case 25:
                        Problema25();
                        break;
                    case 26:
                        Problema26();
                        break;
                    case 27:
                        Problema27();
                        break;
                    case 28:
                        Problema28();
                        break;
                    case 29:
                        Problema29();
                        break;
                    case 30:
                        Problema30();
                        break;
                    case 31:
                        Problema31();
                        break;
                    case 32:
                        Problema32();
                        break;
                    case 33:
                        Problema33();
                        break;
                    case 34:
                        Problema34();
                        break;
                    case 35:
                        Problema35();
                        break;
                    case 36:
                        Problema36();
                        break;
                    case 37:
                        Problema37();
                        break;
                    case 38:
                        Problema38();
                        break;
                    case 39:
                        Problema39();
                        break;
                    case 40:
                        Problema40();
                        break;
                    case 41:
                        Problema41();
                        break;
                    case 42:
                        Problema42();
                        break;
                    case 43:
                        Problema43();
                        break;
                    case 44:
                        Problema44();
                        break;
                    default:
                        Console.WriteLine("No existe esa opción");
                        break;
                }
                Console.WriteLine("Si desea continuar ingrese 0, en caso contrario ingrese cualquier otro número");
                rompe = int.Parse(Console.ReadLine());
                if (rompe != 0)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
            }
            Console.ReadKey();
        }
        static void Problema1()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt= NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            //Proceso
            //int[] Pares = new int[Numeros.Length];
            //int[] Impares = new int[Numeros.Length];
            //int ContaPares = 0; int ContaImpares = 0;
            //for (int i = 0; i < Numeros.Length; i++)
            //{
            //    if (Numeros[i] % 2 == 0)
            //    {
            //        Pares[ContaPares] = Numeros[i];
            //        ContaPares += 1;
            //    }
            //    else
            //    {
            //        Impares[ContaImpares] = Numeros[i];
            //        ContaImpares += 1;
            //    }
            //}
            //for (int i = 0; i < Pares.Length; i++)
            //{
            //    if (Pares[i] != 0)
            //    {
            //        Console.Write(Pares[i] + " ");
            //    }
            //}
            //for (int i = 0; i < Impares.Length; i++)
            //{
            //    if (Impares[i] != 0)
            //    {
            //        Console.Write(Impares[i] + " ");
            //    }
            //}
            int aux = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                for (int j = i + 1; j < Numeros.Length; j++)
                {
                    if (Numeros[i] % 2 != 0 && Numeros[j] % 2 == 0) //Numeros[i] > Numeros[j]
                    {
                        aux = Numeros[i];
                        Numeros[i] = Numeros[j];
                        Numeros[j] = aux;
                    }
                }
            }
            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write(Numeros[i] + " ");
            }

        }

        static void Problema2()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            Console.WriteLine("Ingrese su número a encontrar: ");
            int NumeroEncontrar = int.Parse(Console.ReadLine());
            int PosicionNumero1 = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == NumeroEncontrar)
                {
                    PosicionNumero1 = i;
                    break;
                }
            }
            int PosicionNumero2 = 0; int aparece = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == NumeroEncontrar && i != PosicionNumero1)
                {
                    PosicionNumero2 = i;
                    aparece = 1;
                    break;
                }
                else
                {
                    PosicionNumero2 = i;
                }
            }
            if (aparece == 1)
            {
                Console.WriteLine("Numero a encontrar: (1) " + NumeroEncontrar + " en la posición: " + PosicionNumero1);
                Console.WriteLine("Numero a encontrar: (2) " + NumeroEncontrar + " en la posición: " + PosicionNumero2);
                Console.WriteLine("Distancia entre " + NumeroEncontrar + " es: " + ((PosicionNumero2 - PosicionNumero1) - 1));
            }
            else
            {
                Console.WriteLine("Numero a encontrar: (1) " + NumeroEncontrar + " en la posición: " + PosicionNumero1);
                Console.WriteLine("Numero a encontrar: (2) " + NumeroEncontrar + " en la posición: " + PosicionNumero2);
                Console.WriteLine("Distancia entre " + NumeroEncontrar + " es: " + ((PosicionNumero2 - PosicionNumero1)));
            }        
        }

        static void Problema3()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            //Encontrar Mayor
            int NumMayor = 0; int NumMenor = 0;
            //Ordernamiento burbuja
            int aux = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                for (int j = 0; j < Numeros.Length; j++)
                {
                    //Numero de Menor a Mayor
                    if (Numeros[i] < Numeros[j])
                    {
                        aux = Numeros[i];
                        Numeros[i] = Numeros[j];
                        Numeros[j] = aux;
                    }
                }
            }
            NumMayor = Numeros[0];
            NumMenor = Numeros[Numeros.Length - 1];
            double Acum = 0;
            double conta = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == NumMayor || Numeros[i] == NumMenor)
                {                  
                }
                else
                {
                    Acum = Acum + Numeros[i];
                    conta = conta + 1;
                }
            }
            Console.WriteLine("El promedio es de: " + (Acum / conta));
        }

        static void Problema4()
        {
            int[] Arreglo = new int[20];
            Console.Write("{");
            for (int i = 0; i < Arreglo.Length; i++)
            {
                Arreglo[i] = NumAleatorio();
                Console.Write(Arreglo[i] + ",");
            }
            Console.WriteLine("}");
            
        }
        static int NumAleatorio()
        {
            int NumAlt = 0;
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            NumAlt = rnd.Next(10,101);
            return NumAlt;
        }

        static void Problema5()
        {
            int control = 0; int control2 = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("*");
                if (control < 3)
                {
                    control = control + 1;
                    control2 = control;
                    for (int j = 0; j < control; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int k = control2 - 1; k > 0; k--)
                    {
                        Console.Write("*");
                    }
                    control2 = control2 - 1;
                }
                
            }
        }

        static void Problema6()
        {
            Console.WriteLine("Ingresa tu frase: ");
            string frase = Console.ReadLine();
            for (int i = frase.Length- 1; i >= 0; i--)
            {
                Console.Write(frase[i]);
            }
        }

        static void Problema7()
        {
            Console.WriteLine("Ingresa tu palabra: ");
            string palabra = Console.ReadLine();
            palabra = palabra.ToLower();
            char PL = palabra[0];
            int conta = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == PL)
                {
                    conta += 1;
                }
            }
            Console.WriteLine("La letra " + PL + " aparece " + conta);
        }

        static void Problema8()
        {
            Console.WriteLine("Ingresa tu palabra: ");
            string palabra = Console.ReadLine();
            palabra = palabra.ToLower();
            char PC = palabra[0];
            string Nuevapalabra = palabra.Remove(0,1);
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int metodo = 0;
            for (int i = 0; i < vocales.Length; i++)
            {
                if (vocales[i] == PC)
                {
                    metodo = 1;
                    break;
                }
                else
                {
                    metodo = 2;
                }
            }
            if (metodo == 1)
            {
                Nuevapalabra = Nuevapalabra + PC + "y";
            }
            else
            {
                Nuevapalabra = Nuevapalabra + PC + "oy";
            }
            Console.WriteLine(Nuevapalabra);
        }

        static void Problema9()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio (Arreglo 1)");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            Console.WriteLine("Ingrese sus números separados de un espacio (Arreglo ´2)");
            string NumerosNoInt2 = Console.ReadLine();
            string[] NumeroEnArregloNoInt2 = NumerosNoInt2.Split(' ');
            int[] Numeros2 = new int[NumeroEnArregloNoInt2.Length];
            for (int i = 0; i < NumeroEnArregloNoInt2.Length; i++)
            {
                Numeros2[i] = int.Parse(NumeroEnArregloNoInt2[i]);
            }
            string NumerosRepetidos = "";
            for (int i = 0; i < Numeros.Length; i++)
            {
                for (int j = 0; j < Numeros2.Length; j++)
                {
                    if (Numeros[i] == Numeros2[j])
                    {
                        NumerosRepetidos = NumerosRepetidos + Numeros[i].ToString() + " ";
                    }
                }
            }
            Console.WriteLine("Los números repetidos son: " + NumerosRepetidos);
        }

        static void Problema10()
        {
            Console.WriteLine("Escribe un número");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 1)
            {
                string divisores = "";
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisores = divisores + i.ToString() + " ";
                    }
                }
                Console.Write("Los divisores son: " + divisores);
            }
            else
            {
                Console.WriteLine("Ingrese un número positivo");
            }
        }

        static void Problema11()
        {
            Console.WriteLine("Ingresa tu string:");
            string frase = Console.ReadLine();
            string[] ArregloLetras = new string[frase.Length];
            for (int i = 0; i < frase.Length; i++)
            {
                ArregloLetras[i] = frase[i].ToString();
            }
            Console.Write("{ ");
            for (int i = 0; i < ArregloLetras.Length; i++)
            {
                Console.Write("'" + ArregloLetras[i] + "'");
            }
            Console.Write(" }");
        }

        static void Problema12()
        {
            Console.WriteLine("Cuántas letras quieres ingresar?");
            int max = int.Parse(Console.ReadLine());
            string[] StringSiArray = new string[max];
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Ingresa letra #" + (i+1));
                StringSiArray[i] = Console.ReadLine();
            }
            string completo = "";
            Console.WriteLine("\n");
            for (int i = 0; i < StringSiArray.Length; i++)
            {
                completo = completo + StringSiArray[i];
            }
            Console.WriteLine(completo);
        }

        static void Problema13()
        {
            double n = 1; double acum = 0;
            while (acum <= 2050)
            {
                acum = acum + Math.Pow(2, n);
                n += 1;
            }
            Console.WriteLine("La suma es: " + acum);
        }

        static void Problema14()
        {
            Console.WriteLine("Ingrese un número");
            string nNoParse = Console.ReadLine();
            int[] ArregloDigitos = new int[nNoParse.Length];
            int n = int.Parse(nNoParse);
            for (int i = 0; i < nNoParse.Length; i++)
            {
                ArregloDigitos[i] = int.Parse(nNoParse[i].ToString());
            }
            int decision = 0;
            for (int i = 0; i < ArregloDigitos.Length; i++)
            {
                if (ArregloDigitos[i] != 0)
                {
                    if (n % ArregloDigitos[i] == 0)
                    {
                        decision += 1;
                    }
                    else
                    {
                        Console.WriteLine("Falso");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Falso");
                    break;
                }
            }
            if (decision == ArregloDigitos.Length)
            {
                Console.WriteLine("Verdadero");
            }
        }

        static void Problema15()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int n1 = 0; int n2 = 0; int n3 = 0; int n4 = 0; int n5 = 0; double acum = 0;
            int r5 = 0; int r6 = 0; int r7 = 0; int r8 = 0; int r9 = 0; int r10 = 0; int r11 = 0; int r12 = 0; int r13 = 0; int r14 = 0;
            int r15 = 0; int r16 = 0; int r17 = 0; int r18 = 0; int r19 = 0; int r20 = 0; int r21 = 0; int r22 = 0; int r23 = 0; int r24 = 0;
            int r25 = 0; int r26 = 0; int r27 = 0; int r28 = 0; int r29 = 0; int r30 = 0;
            for (int i = 0; i < 1000000; i++)
            {
                n1 = rnd.Next(1, 7);
                n2 = rnd.Next(1, 7);
                n3 = rnd.Next(1, 7);
                n4 = rnd.Next(1, 7);
                n5 = rnd.Next(1, 7);
                acum = n1 + n2 + n3 + n4 + n5;
                if (acum == 5)
                { r5 = r5 + 1; }
                else if (acum == 6)
                { r6 = r6 + 1; }
                else if (acum == 7)
                { r7 = r7 + 1; }
                else if (acum == 8)
                { r8 = r8 + 1; }
                else if (acum == 9)
                { r9 = r9 + 1; }
                else if (acum == 10)
                { r10 += 1; }
                else if (acum == 11)
                { r11 += 1; }
                else if (acum == 12)
                { r12 += 1; }
                else if (acum == 13)
                { r13 += 1; }
                else if (acum == 14)
                { r14 += 1; }
                else if (acum == 15)
                { r15 += 1; }
                else if (acum == 16)
                { r16 += 1; }
                else if (acum == 17)
                { r17 += 1; }
                else if (acum == 18)
                { r18 += 1; }
                else if (acum == 19)
                { r19 += 1; }
                else if (acum == 20)
                { r20 += 1; }
                else if (acum == 21)
                { r21 += 1; }
                else if (acum == 22)
                { r22 += 1; }
                else if (acum == 23)
                { r23 += 1; }
                else if (acum == 24)
                { r24 += 1; }
                else if (acum == 25)
                { r25 += 1; }
                else if (acum == 26)
                { r26 += 1; }
                else if (acum == 27)
                { r27 += 1; }
                else if (acum == 28)
                { r28 += 1; }
                else if (acum == 29)
                { r29 += 1; }
                else if (acum == 30)
                { r30 += 1; }
            }
            Console.WriteLine("El número 5 salió: " + r5); Console.WriteLine("El número 6 salió: " + r6); Console.WriteLine("El número 7 salió: " + r7);
            Console.WriteLine("El número 8 salió: " + r8); Console.WriteLine("El número 9 salió: " + r9); Console.WriteLine("El número 10 salió: " + r10);
            Console.WriteLine("El número 11 salió: " + r11); Console.WriteLine("El número 12 salió: " + r12); Console.WriteLine("El número 13 salió: " + r13);
            Console.WriteLine("El número 14 salió: " + r14); Console.WriteLine("El número 15 salió: " + r15); Console.WriteLine("El número 16 salió: " + r16);
            Console.WriteLine("El número 17 salió: " + r17); Console.WriteLine("El número 18 salió: " + r18); Console.WriteLine("El número 19 salió: " + r19);
            Console.WriteLine("El número 20 salió: " + r20); Console.WriteLine("El número 21 salió: " + r21); Console.WriteLine("El número 22 salió: " + r22);
            Console.WriteLine("El número 23 salió: " + r23); Console.WriteLine("El número 24 salió: " + r24); Console.WriteLine("El número 25 salió: " + r25);
            Console.WriteLine("El número 26 salió: " + r26); Console.WriteLine("El número 27 salió: " + r27); Console.WriteLine("El número 28 salió: " + r28);
            Console.WriteLine("El número 29 salió: " + r29); Console.WriteLine("El número 30 salió: " + r30);
        }

        static void Problema16()
        {
            Console.WriteLine("Ingresa número 1: ");       
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa número 2: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa número 3: ");
            int n3 = int.Parse(Console.ReadLine());
            int[] Arreglo = { n1, n2, n3 };
            int acum = 0;
            for (int i = 0; i < Arreglo.Length; i++)
            {
                if (Arreglo[i] ==13 )
                {
                    break;
                }
                else
                {
                    acum = acum + Arreglo[i];
                }
            }
            Console.WriteLine("La suma es de: " + acum);
        }

        static void Problema17()
        {
            Console.WriteLine("Ingresa tu palabra: ");
            string palabra = Console.ReadLine();
            string buscar = "ss";
            int conta = 0;
            for (int i = 0; i < palabra.Length - 1; i++)
            {
                    if (palabra[i] == 's' && palabra[i+1] == 's')
                    {
                    conta = conta + 1;
                    }
                    else
                    {
                    }
            }
            Console.WriteLine("ss aparece: " + conta);
        }

        static void Problema18()
        {
            int n = 1; int acum = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    acum += n;
                }
                n = n + 1;
            } 
            Console.WriteLine("La suma es: " + acum);
        }

        static void Problema19()
        {
            long acum = 0;
            int conta = 0;
            long[] NumerosCambiables = new long[3];
            NumerosCambiables[0] = 0; NumerosCambiables[1] = 1;
            while (conta < 20)
            {
                NumerosCambiables[2] = NumerosCambiables[0] + NumerosCambiables[1];
                if (NumerosCambiables[2] % 2 == 0)
                {
                    Console.WriteLine(NumerosCambiables[2]);
                    acum = acum + NumerosCambiables[2];
                    conta += 1;
                }
                NumerosCambiables[0] = NumerosCambiables[1];
                NumerosCambiables[1] = NumerosCambiables[2];
            }
            Console.WriteLine("La suma de los números pares es: " + acum);
        }

        static void Problema20()
        {
            long res = 1;
            for (int i = 1; i <= 15; i++)
            {
                res = res * i;
            }
            string Hola = res.ToString();
            int[] numeros = new int[Hola.Length];
            int acum = 0;
            for (int i = 0; i < Hola.Length; i++)
            {
                numeros[i] = int.Parse(Hola[i].ToString());
                acum = acum + numeros[i];
            }
            Console.WriteLine("La suma de los dígitos es: " + acum);
        }

        static void Problema21()
        {
            Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());
            int acum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    acum = acum + i;
                }
            }
            Console.WriteLine("La suma de los factores es: " + acum);
        }

        static void Problema22()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            string concatenar = "";
            for (int i = 0; i < Numeros.Length; i++)
            {
                concatenar = concatenar + (Numeros[i] * Numeros[i]).ToString() + ",";
            }
            Console.WriteLine(concatenar);
        }

        static void Problema23()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            string concatenar = "";
            for (int i = 0; i < Numeros.Length; i++)
            {
                concatenar = concatenar + (Math.Pow(Numeros[i],i)).ToString() + ",";
            }
            Console.WriteLine(concatenar);
        }

        static void Problema24()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            int acum = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] == 5)
                {
                    for (int j = i + 1; j < Numeros.Length; j++)
                    {
                        acum = acum + Numeros[j];
                    }
                    break;
                }
            }
            Console.WriteLine("La suma es de: " + acum);
        }

        static void Problema25()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            int conta = 0; int decision = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                conta = 0;
                for (int j = 0; j < Numeros.Length; j++)
                {
                    if (Numeros[i] == Numeros[j])
                    {
                        conta = conta + 1;
                    }
                }
                if (conta >= 2)
                {
                    decision = 1;
                    break;
                }
            }
            if (decision == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Problema26()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            double acum = 0;
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                acum = acum + Numeros[i];
            }
            double division = acum / Numeros.Length;
            Console.WriteLine(acum);
            double res = Math.Sqrt(division);
            Console.WriteLine("Raíz Cuadrada del promedio de sus elementos: " + Math.Round(res,3));
        }

        static void Problema27()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            int conta = 0;
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                if (Numeros[i] % 7 == 0)
                {
                    conta = conta + 1;
                }
            }
            Console.WriteLine("Hay " + conta  +" múltiplos de 7");
        }

        static void Problema28()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio (Arreglo 1)");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            Console.WriteLine("Ingrese sus números separados de un espacio (Arreglo ´2)");
            string NumerosNoInt2 = Console.ReadLine();
            string[] NumeroEnArregloNoInt2 = NumerosNoInt2.Split(' ');
            int[] Numeros2 = new int[NumeroEnArregloNoInt2.Length];
            for (int i = 0; i < NumeroEnArregloNoInt2.Length; i++)
            {
                Numeros2[i] = int.Parse(NumeroEnArregloNoInt2[i]);
            }
            string NumerosRepetidos = "";
            for (int i = 0; i < Numeros.Length; i++)
            {
                for (int j = 0; j < Numeros2.Length; j++)
                {
                    if (Numeros[i] == Numeros2[j])
                    {
                        NumerosRepetidos = NumerosRepetidos + Numeros[i].ToString() + " ";
                    }
                }
            }
            Console.WriteLine("Los números repetidos son: " + NumerosRepetidos);
        }

        static void Problema29()
        {
            int control = 9;
            for (int i = 0; i < 5; i++)
            {
                for (int j = control; j > 0; j--)
                {
                    Console.Write("*");
                }
                control = control - 2;
                Console.WriteLine("*");
            }
        }

        static void Problema30()
        {
            Console.WriteLine("Ingresa tu palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine("Ingresa tu palabra a buscar: ");
            string buscar = Console.ReadLine();
            int cont = 0; int numrepe = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == buscar[cont])
                {
                    cont = cont + 1;
                    if (cont == buscar.Length)
                    {
                        numrepe = numrepe + 1;
                        cont = 0;
                    }
                }
                else
                {
                    cont = 0;
                }
            }
            if (numrepe != 0)
            {
                Console.WriteLine("La palabra aparece: " + numrepe);
            }
            else
            {
                Console.WriteLine("No se repite");
            }
        }

        static void Problema31()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio: ");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (Numeros[i] % 3 == 0)
                {
                }
                else
                {
                    Numeros[i] = Numeros[i] + 1;
                    while (Numeros[i] % 2 != 0)
                    {
                        Numeros[i] = Numeros[i] + 1;
                    }
                }
            }

            Console.Write("{");
            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.Write(Numeros[i] + ",");
            }
            Console.Write("}");
        }

        static void Problema32()
        {

        }//No le entendí

        static void Problema33()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio: ");
            string NumerosNoInt = Console.ReadLine();
            Console.WriteLine("Ingrese el parámetro: ");
            int Parametro = int.Parse(Console.ReadLine());
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            Console.WriteLine(" ");
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                Numeros[i] = Numeros[i] + Parametro;
                Console.Write(Numeros[i] + ",");
            }
        }

        static void Problema34()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            double sumaPares = 0; double sumaImpares = 0;
            int contaPares = 0; int contaImpares = 0;
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                if (Numeros[i] % 2 == 0)
                {
                    sumaPares = sumaPares + Numeros[i];
                    contaPares += 1;
                }
                else
                {
                    sumaImpares = sumaImpares + Numeros[i];
                    contaImpares += 1;
                }
            }
            Console.WriteLine("El promedio de los pares: " + (sumaPares/contaPares));
            Console.WriteLine("El promedio de los Impares: " + (sumaImpares / contaImpares));
        }

        static void Problema35()
        {
            Console.WriteLine("Escribe tu string: ");
            string cadena = Console.ReadLine();
            cadena = cadena.ToLower();
            char[] cadena2 = cadena.ToCharArray();
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
           for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < vocales.Length; j++)
                {
                    if (cadena2[i] == vocales[j])
                    {
                        cadena2[i] = ' ';
                    }
                }
            }
            for (int i = 0; i < cadena2.Length; i++)
            {
                if (cadena2[i] == ' ')
                { 
                }
                else
                {
                    Console.Write(cadena2[i]);
                }
            }
        }

        static void Problema36()
        {
            Console.WriteLine("Ingresa año: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese mes: ");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese día: ");
            int dia = int.Parse(Console.ReadLine());
            int decisionBisiesto = 0; int ERRORDEBESER1 = 0;
            if (n >= 1900 && n <= 2099)
            {
                if (n % 400 == 0)
                {
                    Console.WriteLine("Bisiesto");
                    decisionBisiesto = 1;
                }
                else
                {
                    if (n % 4 == 0 && n % 100 != 0)
                    {
                        Console.WriteLine("Bisiesto");
                        decisionBisiesto = 1;
                    }
                    else
                    {
                        Console.WriteLine("No bisiesto");
                        decisionBisiesto = 0;
                    }
                }
                if (decisionBisiesto == 1)//Es bisiestos
                {
                    if (mes >= 1 && mes <= 12)
                    {
                        int[] diasmeses = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                        int Max = diasmeses[mes - 1];
                        if (dia >= 1 && dia <= Max)
                        {
                        }
                        else
                        {
                            ERRORDEBESER1 = 1;
                        }
                    }
                    else
                    {
                        ERRORDEBESER1 = 1;
                    }
                }
                else//No es bisiesto
                {
                    if (mes >= 1 && mes <= 12)
                    {
                        int[] diasmeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                        int Max = diasmeses[mes - 1];
                        if (dia >= 1 && dia <= Max)
                        {
                        }
                        else
                        {
                            ERRORDEBESER1 = 1;
                        }
                    }
                    else
                    {
                        ERRORDEBESER1 = 1;
                    }
                }
            }
            else
            {
                ERRORDEBESER1 = 1;
            }
            //Válidame Pofavoh
            if (ERRORDEBESER1 == 1)
            {
                Console.WriteLine("La fecha es inválida");
            }
            else
            {
                Console.WriteLine("La fecha es válida");
            }
        } 

        static void Problema37()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            int contaceros = 0;
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                if (Numeros[i] == 0)
                {
                    contaceros += 1;
                }
            }
            Console.WriteLine("En el arreglo hay " + contaceros + " ceros");
        }

        static void Problema38()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
            }
            int n = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (i>=2)
                {
                    if (Numeros[i] == (Numeros[i-1] + Numeros[i-2]))
                    {
                        n = n + 1;
                    }
                    else
                    {
                        Console.WriteLine("False");
                        break;
                    }
                }
                else
                {  }
            }
            if (n == Numeros.Length-2)
            {
                Console.WriteLine("True");
            }
        }

        static void Problema39()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio (10 elementos):");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            if (NumeroEnArregloNoInt.Length < 10)
            {
                Console.WriteLine("No ingresaste 10 o más elementos");
            }
            else
            {
                int[] Numeros = new int[NumeroEnArregloNoInt.Length];
                for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
                {
                    Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                }
                int SumaPrimeros5 = 0; int SumaRestantes = 0;
                for (int i = 0; i < Numeros.Length; i++)
                {
                    if (i < 5)
                    {
                        SumaPrimeros5 = SumaPrimeros5 + Numeros[i];
                    }
                    else
                    {
                        SumaRestantes = SumaRestantes + Numeros[i];
                    }
                }
                Console.WriteLine("El resultado de los primeros 5 números: " + SumaPrimeros5);
                Console.WriteLine("La suma de los restantes es: " + SumaRestantes);
                Console.WriteLine("La resta es: " + (SumaPrimeros5-SumaRestantes));
            }
            
        }

        static void Problema40()
        {
            Console.WriteLine("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int multi = 1; int nk = 0;  
            while (nk == 0)
            {
                multi = multi + 1;
                if (multi % n1 == 0 && multi % n2 == 0)
                {
                    break;
                }
            }
                Console.WriteLine("El m.c.m es: " + multi);
        } 

        static void Problema41()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int n1 = 0; int n2 = 0;
            int suma = 0;
            int contador7o11 = 0; int contador23o12 = 0;
            for (int i = 0; i < 1000; i++)
            {
                n1 = rnd.Next(1, 7); n2 = rnd.Next(1, 7);
                suma = n1 + n2;
                if (suma == 7 || suma == 11)
                {
                    contador7o11 = contador7o11 + 1;
                }
                else if(suma ==2 || suma == 3 || suma ==12)
                {
                    contador23o12 = contador23o12 + 1;
                }
                else
                { }
            }
            Console.WriteLine("El 7 o el 11 salió: " + contador7o11);
            Console.WriteLine("eL 2,3 O 12 salió: " + contador23o12);
        }

        static void Problema42()
        {
            int n = 0;
            int conta = 0;
            while (conta < 10)
            {
                n += 1;
                if (n % 1 == 0 && n % 2 == 0 && n % 3 == 0 && n % 4 == 0 && n%5 == 0 && n % 6==0 && n % 7== 0 && n% 8 == 0 && n % 9 == 0 && n% 10 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("El número es: " + n);
        }

        static void Problema43()
        {
            Console.WriteLine("Ingrese sus números separados de un espacio");
            string NumerosNoInt = Console.ReadLine();
            string[] NumeroEnArregloNoInt = NumerosNoInt.Split(' ');
            int[] Numeros = new int[NumeroEnArregloNoInt.Length];
            double SumaCuadrados = 0; double Alkuadradoh = 0;
            for (int i = 0; i < NumeroEnArregloNoInt.Length; i++)
            {
                Numeros[i] = int.Parse(NumeroEnArregloNoInt[i]);
                SumaCuadrados = SumaCuadrados + Numeros[i];
            }
            for (int i = 0; i < Numeros.Length; i++)
            {
                Alkuadradoh = Alkuadradoh + Math.Pow(Numeros[i],2);
            }
            SumaCuadrados = Math.Pow(SumaCuadrados, 2);
            Console.WriteLine(SumaCuadrados);
            Console.WriteLine(Alkuadradoh);
            Console.WriteLine("La resta es: "  + (SumaCuadrados - Alkuadradoh));
        }

        static void Problema44()
        {
            Console.WriteLine("Ingresa primer string: ");
            string cadena1 = Console.ReadLine();
            cadena1.ToLower();
            Console.WriteLine("Ingresa segundo string: ");
            string cadena2 = Console.ReadLine();
            cadena2.ToLower();
            int diferencias = 0;
            if (cadena1.Length == cadena2.Length)
            {
                for (int i = 0; i < cadena1.Length; i++)
                {
                    if (cadena1[i] != cadena2[i])
                    {
                        diferencias += 1;
                    }
                }
                Console.WriteLine("Las cantidad de diferencias es: " + diferencias);
            }
            else
            {
                Console.WriteLine("No son del mismo tamaño");
            }
        }
    }
}
