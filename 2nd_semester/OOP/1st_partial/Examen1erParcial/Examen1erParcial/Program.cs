using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JUEGO DEL GATO");
            Console.WriteLine("Inicializando juego de Gato....");
            string[] arreglin = new string[9];
            for (int i = 0; i < arreglin.Length; i++)
            {arreglin[i] = i.ToString();}
            Console.WriteLine(arreglin[0] + "|" + arreglin[1] + "|" + arreglin[2]);
            Console.WriteLine(arreglin[3] + "|" + arreglin[4] + "|" + arreglin[5]);
            Console.WriteLine(arreglin[6] + "|" + arreglin[7] + "|" + arreglin[8]);
            Console.WriteLine("Inicializado!!");
            Console.WriteLine("\n");
            string simbolojugador1 = "x";
            string simbolojugador2 = "o";
            int posicioningreso = 0;
            int TurnoJugador = 2;
            for (int i = 0; i < 9; i++)
            {
                int NumeroJugador = TurnoDeJugador(TurnoJugador);
                TurnoJugador = NumeroJugador;
                Console.WriteLine("Turno de: Jugador " + NumeroJugador);
                Console.WriteLine("Ingrese la posición donde desea agregar su símbolo: ");
                posicioningreso = int.Parse(Console.ReadLine());
                bool EstaRepetido = validarsinoestaocupado(posicioningreso, arreglin);
                while (EstaRepetido == true)
                {
                    
                    Console.WriteLine("Ya está ocupada esa casilla");
                    Console.WriteLine("Ingrese la posición donde desea agregar su símbolo: ");
                    posicioningreso = int.Parse(Console.ReadLine());
                    EstaRepetido = validarsinoestaocupado(posicioningreso, arreglin);
                }
                if (NumeroJugador == 1)
                {
                    arreglin[posicioningreso] = simbolojugador1;
                }
                else
                {
                    arreglin[posicioningreso] = simbolojugador2;
                }
                Console.WriteLine(arreglin[0] + "|" + arreglin[1] + "|" + arreglin[2]);
                Console.WriteLine(arreglin[3] + "|" + arreglin[4] + "|" + arreglin[5]);
                Console.WriteLine(arreglin[6] + "|" + arreglin[7] + "|" + arreglin[8]);
                Console.WriteLine("\n");
                if (ValidarGanador(arreglin) == "Ganaste")
                {
                    Console.WriteLine("Ganaste");
                    break;
                }
                if (i==8)
                {
                    Console.WriteLine("NADIE GANÓ");
                }
            }
            Console.ReadKey();
        }
        static int TurnoDeJugador(int jugador)
        {
            if (jugador == 1)
            {
                jugador = jugador + 1;
            }
            else if (jugador == 2)
            {
                jugador = jugador - 1;
            }
            return jugador;
        }

        static bool validarsinoestaocupado(int SioNoOcupado, string[] arreglo)
        {
            if (arreglo[SioNoOcupado] == "*" || arreglo[SioNoOcupado] == "-")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ValidarGanador(string[] Arreglo)
        {
            if (Arreglo[0] == Arreglo[1] && Arreglo[1] == Arreglo[2])
            {
                return "Ganaste";
            }
            else if (Arreglo[0] == Arreglo[3] && Arreglo[0] == Arreglo[6])
            {
                return "Ganaste";
            }
            else if (Arreglo[6] == Arreglo[7] && Arreglo[7] == Arreglo[8])
            {
                return "Ganaste";
            }
            else if (Arreglo[2] == Arreglo[5] && Arreglo[5] == Arreglo[8])
            {
                return "Ganaste";
            }
            else if (Arreglo[1] == Arreglo[4] && Arreglo[4] == Arreglo[7])
            {
                return "Ganaste";
            }
            else if (Arreglo[3] == Arreglo[4] && Arreglo[4] == Arreglo[5])
            {
                return "Ganaste";
            }
            else if (Arreglo[6] == Arreglo[4] && Arreglo[4] == Arreglo[2])
            {
                return "Ganaste";
            }
            else if (Arreglo[0] == Arreglo[4] && Arreglo[4] == Arreglo[8])
            {
                return "Ganaste";
            }
            return "Sigue!!";
        }
    }
}
