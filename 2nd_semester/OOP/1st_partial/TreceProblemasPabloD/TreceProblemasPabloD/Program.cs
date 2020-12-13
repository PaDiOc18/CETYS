using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreceProblemasPabloD
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu = 1;
            while (Menu != 0)
            {
                Console.WriteLine("13 con Tokyo");
                Console.WriteLine("¿Qué programa desea? (Escribe 0 para salir)");
                Console.WriteLine(" \n");
                Console.WriteLine("1-. Encuentra la primer letra que se repita");
                Console.WriteLine("2-. Tirar n dados de n caras");
                Console.WriteLine("3-. Marcador de un juego");
                Console.WriteLine("4-. Quitar vocales a una palabra");
                Console.WriteLine("5-. Cuantas palabras tiene tu frase? ");
                Console.WriteLine("6-. Puede ser formada la palabra quitandole una letra? ");
                Console.WriteLine("7-. Coeficientes de un polinomio");
                Console.WriteLine("8-. Formato hora en español");
                Console.WriteLine("9-. Letras ordenadas de forma alfabetica");
                Console.WriteLine("10-. Tamaño promedio de cada palabra");
                Console.WriteLine("11-. Cuantos días faltan para una fecha?");
                Console.WriteLine("12-. Segundo número más grande de un arreglo");
                Console.WriteLine("13-. Entero positivo menor");
                Menu = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Menu)
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
                    default:
                        if (Menu == 0)
                        { Environment.Exit(0); }
                        else
                        {
                            Console.WriteLine("No contamos con esa opción");
                        }
                    break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Problema1()
        {
            Console.WriteLine("Ingrese su palabra: ");
            string Palabra = Console.ReadLine();
            char LetraRepetida = ' ';
            int Conta = 0;
            for (int i = 0; i < Palabra.Length; i++)
            {
                for (int j = 0; j < Palabra.Length; j++)
                {
                    if (Palabra[i] == Palabra[j])
                    {
                        Conta = Conta + 1;
                        if (Conta >= 2)
                        {
                            LetraRepetida = Palabra[i];
                        }
                    }
                }
                if (Conta >= 2)
                {
                    break;
                }
                else
                {
                    Conta = 0;
                }
            }
            if (Conta >= 2)
            {
                Console.WriteLine("La letra que se repite es: " + LetraRepetida);
                Console.WriteLine("Las veces que se repite es: " + Conta);
            }
            else
            {
                Console.WriteLine("No se repite ninguna letra");
            }

        }
        static void Problema2()
        {
            Random ran = new Random(Guid.NewGuid().GetHashCode());
            Console.WriteLine("Ingrese su Patrón: (ndn) n es cualquier número");
            string Patron = Console.ReadLine();
            string[] Separar = Patron.Split('d');
            for (int i = 0; i < Separar.Length; i++)
            {
                Console.WriteLine("Num: " + Separar[i]);
            }
            int numDados = int.Parse(Separar[0]); //Numero de dados
            int numCaras = int.Parse(Separar[1]);//NumeroCaras;
            int[] ArregloResultados = new int[numDados];
            int SumaTotal = 0;
            for (int i = 0; i < numDados; i++)
            {
                ArregloResultados[i] = ran.Next(1, numCaras + 1);
                SumaTotal = SumaTotal + ArregloResultados[i];
            }
            Console.WriteLine("La suma: " + SumaTotal + " ");
            for (int i = 0; i < numDados; i++)
            {
                Console.Write(ArregloResultados[i] + " ");
            }
        }
        static void Problema3()
        {
            Console.WriteLine("Ingresa tu marcador: (Letras de la 'a' a la 'e')");
            string Marcador = Console.ReadLine();
            string var = " "; int ContA = 0; int ContB = 0; int ContC = 0; int ContD = 0; int ContE = 0;
            for (int i = 0; i < Marcador.Length; i++)
            {
                switch (var = Marcador[i].ToString().ToUpper())
                {
                    case "A":
                        ContA = ContA + RegresarMayusculaOMinuscula(Marcador[i]);
                        break;
                    case "B":
                        ContB = ContB + RegresarMayusculaOMinuscula(Marcador[i]);
                        break;
                    case "C":
                        ContC = ContC + RegresarMayusculaOMinuscula(Marcador[i]);
                        break;
                    case "D":
                        ContD = ContD + RegresarMayusculaOMinuscula(Marcador[i]);
                        break;
                    case "E":
                        ContE = ContE + RegresarMayusculaOMinuscula(Marcador[i]);
                        break;
                    default:
                        Console.WriteLine(" ");
                        break;
                }
            }
            Console.WriteLine("a: {0} b: {1} c: {2} d:{3} e:{4}", ContA, ContB, ContC, ContD, ContE);
        }
        static int RegresarMayusculaOMinuscula(char Letra)
        {
            if (char.IsUpper(Letra))
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        static void Problema4()
        {
            Console.WriteLine("Ingrese su palabra:");
            string Pal = Console.ReadLine();
            char[] Hola = Pal.ToCharArray();
            char[] arregloVocales = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < Hola.Length; i++)
            {
                for (int j = 0; j < arregloVocales.Length; j++)
                {
                    if (Hola[i] == arregloVocales[j])
                    {
                        Hola[i] = ' ';
                    }
                }
            }
            for (int i = 0; i < Hola.Length; i++)
            {
                if (Hola[i] == ' ')
                {

                }
                else
                {
                    Console.Write(Hola[i]);
                }
            }

        }
        static void Problema5()
        {
            Console.WriteLine("Ingresa tu frase con espacios: ");
            string frase = Console.ReadLine();
            string[] Divisiones = frase.Split(' ');
            int conta1 = Divisiones.Length;
            int conta2 = 0;
            for (int i = 0; i < Divisiones.Length; i++)
            {
                if (Divisiones[i] == "")
                {
                    conta2 += 1;
                }
                //Console.WriteLine("[" + Divisiones[i] + "]"); 
            }

            Console.WriteLine("Esta frase tiene: " + (conta1 - conta2) + " palabras");
        }
        static void Problema6()
        {
            Console.WriteLine("--Asegurate de no dejar ningun espacio al terminar de escribir--");
            Console.WriteLine("Ingrese primera palabra:");
            string Palabra = Console.ReadLine();
            Console.WriteLine("Ingrese segunda palabra: ");
            string Palabra2 = Console.ReadLine();
            int ContaDif = 0;
            int ayuda = 0;
            for (int i = 0; i < Palabra2.Length; i++)
            {
                if (Palabra2[i] != Palabra[ayuda])
                {
                    ContaDif = ContaDif + 1;
                    ayuda = ayuda + 1;
                    i = i - 1;
                }
                else
                {
                    ayuda = ayuda + 1;
                    //Porque si no se pone el else, se sumaría doble el ayuda
                }
            }
            if (ContaDif >= 2)
            {
                Console.WriteLine("No se puede formar ");
            }
            else
            {
                Console.WriteLine("Si se puede");
            }
        }
        static void Problema7()
        {
            Console.WriteLine("--Asegurate de no dejar ningun espacio al terminar de escribir--");
            Console.WriteLine("Ingrese sus numeros: (Separarlos con espacios)");
            string cadena = Console.ReadLine();
            string[] numerocadena = cadena.Split(' ');
            int[] numeros = new int[numerocadena.Length];
            for (int i = 0; i < numerocadena.Length; i++)
            {
                numeros[i] = int.Parse(numerocadena[i]);
                //Console.WriteLine(numeros[i]);
            }
            int Multiplicador = 0;
            int[] Derivadas = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                Derivadas[i] = numeros[i] * Multiplicador;
                Multiplicador += 1;
                if (i == 0)
                { }
                else
                { Console.Write("[" + Derivadas[i] + "]"); }
            }
        }
        static void Problema8()
        {
            Console.WriteLine("Ingresa la hora: HH:MM");
            string horaT = Console.ReadLine();
            int horas = int.Parse(horaT[0].ToString() + horaT[1].ToString());
            int Minutos1 = int.Parse(horaT[3].ToString());
            int Minutos2 = int.Parse(horaT[4].ToString());
            string cadena = "";
            if (horas >= 0 && horas <= 12)
            {
                cadena = " de la mañana";
            }
            else
            {
                cadena = " de la tarde";
            }
            Console.WriteLine("La hora es: " + CompararHora(horas) + " " + CompararMinutos(Minutos1) + CompararHora(Minutos2) + cadena);

        }
        static string CompararHora(int Hora)
        {
            string RegresoCadenaHora = " ";
            if (Hora == 0)
            {
                RegresoCadenaHora = "Cero";
            }
            else if (Hora == 1 || Hora == 13)
            { RegresoCadenaHora = "una"; }
            else if (Hora == 2 || Hora == 14)
            { RegresoCadenaHora = "dos"; }
            else if (Hora == 3 || Hora == 15)
            { RegresoCadenaHora = "tres"; }
            else if (Hora == 4 || Hora == 16)
            { RegresoCadenaHora = "cuatro"; }
            else if (Hora == 5 || Hora == 17)
            { RegresoCadenaHora = "cinco"; }
            else if (Hora == 6 || Hora == 18)
            { RegresoCadenaHora = "seis"; }
            else if (Hora == 7 || Hora == 19)
            { RegresoCadenaHora = "siete"; }
            else if (Hora == 8 || Hora == 20)
            { RegresoCadenaHora = "ocho"; }
            else if (Hora == 9 || Hora == 21)
            { RegresoCadenaHora = "nueve"; }
            else if (Hora == 10 || Hora == 22)
            { RegresoCadenaHora = "diez"; }
            else if (Hora == 11 || Hora == 23)
            { RegresoCadenaHora = "once"; }
            else if (Hora == 12 || Hora == 24)
            { RegresoCadenaHora = "doce"; }
            return RegresoCadenaHora;
        }
        static string CompararMinutos(int Minutos)
        {
            string RegresoCadena = " ";
            if (Minutos == 0)
            {
                RegresoCadena = "";
            }
            else if (Minutos == 1)
            {
                RegresoCadena = "dieci";
            }
            else if (Minutos == 2)
            {
                RegresoCadena = "veinti";
            }
            else if (Minutos == 3)
            {
                RegresoCadena = "treintai";
            }
            else if (Minutos == 4)
            {
                RegresoCadena = "cuarentai";
            }
            else if (Minutos == 5)
            {
                RegresoCadena = "cincuentai";
            }
            return RegresoCadena;
        }
        static void Problema9()
        {
            Console.WriteLine("Ingrese su palabra: ");
            string palabra = Console.ReadLine();
            palabra = palabra.ToUpper();
            char[] abecedario = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[] ArregloIndexs = new int[palabra.Length];
            for (int j = 0; j < palabra.Length; j++)
            {
                for (int i = 0; i < abecedario.Length; i++)
                {
                    if (abecedario[i] == palabra[j])
                    {
                        ArregloIndexs[j] = i;
                    }
                }
            }
            Console.WriteLine("--------");
            //Ahora a comparar índices
            int Max = ArregloIndexs.Length;
            int decision = 0;
            for (int i = 0; i < ArregloIndexs.Length; i++)
            {
                if (palabra.Length == 1)
                {
                    Console.WriteLine("Favor de escribir mínimo 2 carácteres");
                    break;
                }
                if (i == Max - 1)
                {
                    break;//Para no pasar del índice 
                }
                if (ArregloIndexs[i] > ArregloIndexs[i + 1])
                {
                    decision = 1;
                }
            }
            if (decision == 1)
            {
                Console.WriteLine("Falso");
            }
            else
            {
                Console.WriteLine("Verdadero");
            }
        }
        static void Problema10()
        {
            Console.WriteLine("Ingresa tu frase con espacios: ");
            string frase = Console.ReadLine();
            string[] Divisiones = frase.Split(' ');
            int conta1 = Divisiones.Length;
            int conta2 = 0;
            double Prom = 0;
            for (int i = 0; i < Divisiones.Length; i++)
            {
                if (Divisiones[i] == "")
                {
                    conta2 += 1;
                }

            }
            double letras = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    letras += 1;
                }
            }
            int palabras = (conta1 - conta2);
            Console.WriteLine(letras);
            Console.WriteLine(palabras);
            Prom = letras / palabras;
            Console.WriteLine("El promedio de letras por palabra es de: " + Prom);
        }
        static void Problema11()
        {
            Console.WriteLine("Ingresa tu fecha:  (DD/MM) ");
            string fecha = Console.ReadLine();
            string[] DividirFechaIngresada = fecha.Split('/');
            int HastaDia = 0; int HastaMes = 0;
            HastaDia = int.Parse(DividirFechaIngresada[0]); HastaMes = int.Parse(DividirFechaIngresada[1]);
            //Fecha Actual
            DateTime h = DateTime.Today;
            string horario = h.ToShortDateString();
            string[] DividirFechaActual = horario.Split('/');
            int ActualDia = 0; int ActualMes = 0;
            ActualDia = int.Parse(DividirFechaActual[0]); ActualMes = int.Parse(DividirFechaActual[1]);
            //Proceso
            int[] DiasDeMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int total1 = 0; int total2 = 0;
            if (HastaMes >= ActualMes)
            {
                //Dias Mes Hasta
                for (int i = 0; i < HastaMes - 1; i++)
                {
                    total2 = total2 + DiasDeMeses[i];
                }
                //Dias Mes Actual
                for (int i = 0; i < ActualMes - 1; i++)
                {
                    total1 = total1 + DiasDeMeses[i];
                }
                total2 = total2 + HastaDia;
                total1 = total1 + ActualDia;
                Console.WriteLine("La diferencia de días es de: " + (total2 - total1));
            }
            else if (HastaMes < ActualMes)
            {
                Console.WriteLine("Mes " + HastaMes + " Es menor que " + ActualMes);
                //Dias Mes Hasta
                if (HastaMes == 1)
                {
                    total2 = HastaDia;
                }
                else
                {
                    for (int i = 0; i < HastaMes - 1; i++)
                    {
                        total2 = total2 + DiasDeMeses[i];
                    }
                    total2 = total2 + HastaDia;
                }
                //Dias Mes Actual
                for (int i = 0; i < ActualMes - 1; i++)
                {
                total1 = total1 + DiasDeMeses[i];
                }
                total1 = total1 + ActualDia;
                Console.WriteLine(total1);
                Console.WriteLine(total2);
                int hola = 365 - total1;
                hola = hola + total2;
                Console.WriteLine("Faltan: " + hola + " dias");
            }
        }
        static void Problema12()
        {
            Console.WriteLine("--Asegurate de no dejar ningun espacio al terminar de escribir--");
            Console.WriteLine("Ingrese sus numeros: (Separarlos con espacios)");
            string cadena = Console.ReadLine();
            string[] numerocadena = cadena.Split(' ');
            int[] numeros = new int[numerocadena.Length];
            for (int i = 0; i < numerocadena.Length; i++)
            {
                numeros[i] = int.Parse(numerocadena[i]);
                //Console.WriteLine(numeros[i]);
            }
            int aux = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    //Numero de Menor a Mayor
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            Console.WriteLine("El arreglo ordenado es: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("El segundo Número mayor es: "  + numeros[numeros.Length -2]);
        }
        static void Problema13()
        {
            Console.WriteLine("Ingrese sus numeros: (Separarlos con espacios)");
            string cadena = Console.ReadLine();
            string[] numerocadena = cadena.Split(' ');
            int[] numeros = new int[numerocadena.Length];
            for (int i = 0; i < numerocadena.Length; i++)
            {
                numeros[i] = int.Parse(numerocadena[i]);
                //Console.WriteLine(numeros[i]);
            }
            int aux = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    //Numero de Menor a Mayor
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }
            Console.WriteLine("El arreglo ordenado es: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i] + " ");
            }
            //Doble Ciclo
            int NumAux = 0;
            NumAux = numeros[0];
            int decision = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (NumAux == numeros[i])
                {
                }
                else
                {
                    Console.WriteLine("Numero mas pequeño: " + NumAux );
                    decision = 1;
                    break;
                }
                NumAux = NumAux + 1;
            }
            if (decision == 0)
            {
                Console.Write((numeros[numeros.Length - 1]) + 1);
                //Tomar el ultimo valor y agregarle uno
            }
            else { }
        }
    }
}
