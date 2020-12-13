using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoUnoPabloDiaz
{
    class Baraja
    {
        public Carta[] Cartas { get; }
        public CartaEspecial[] CartasEspeciales { get; set; }

        public Baraja()
        {
            Cartas = new Carta[108];
            //En este arreglos se meten las 108 cartas del Uno, incluyendo las especiales
            string[] ColorCarta = new string[4] { "azul", "rojo", "amarillo", "verde" };
            Cartas[0] = new Carta("azul", 0);
            Cartas[1] = new Carta("rojo", 0);
            Cartas[2] = new Carta("amarillo", 0);
            Cartas[3] = new Carta("verde", 0);
            int conta = 4;
            //Metemos Cartas Normales
            for (int p = 0; p < 2; p++)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        Cartas[conta] = new Carta(ColorCarta[i], j);
                        conta++;
                    }
                }
            }
            //Metemos +2
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Cartas[conta] = new CartaEspecial(ColorCarta[i], 0, "Más Dos");
                    conta++;
                }
            }
            //Metemos Reverse
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Cartas[conta] = new CartaEspecial(ColorCarta[i], 0, "Reverse");
                    conta++;
                }
            }
            //Cancelar Turno
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Cartas[conta] = new CartaEspecial(ColorCarta[i], 0, "Cancelar Turno");
                    conta++;
                }
            }
            //Los +4
            for (int i = 0; i < 4; i++)
            {
                Cartas[conta] = new CartaEspecial("", 0, "Más Cuatro");
                conta++;
            }
            //Elige el color
            for (int i = 0; i < 4; i++)
            {
                Cartas[conta] = new CartaEspecial("", 0, "Elige Color");
                conta++;
            }
            //Carta c = new Carta(@"Imagenes\" + valores[i % 13] + "_of_" + palos[i / 13] + ".png", valor);
            //Cartas[i] = c;
        } 

        public Carta ReparteCarta()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            return Cartas[r.Next(0, 108)];
            //Repartimos las cartas
        }
    }
}
