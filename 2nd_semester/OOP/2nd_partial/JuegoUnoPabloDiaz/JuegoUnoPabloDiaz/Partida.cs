using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoUnoPabloDiaz
{
    class Partida
    {
        public List<Jugador> Jugadores { get; set; }
        private Baraja Baraja { get; set; }
        public Partida()
        {
            Baraja = new Baraja();
            Jugadores = new List<Jugador>();
        }
        public void AddPlayer(string NickName)
        {
            Jugadores.Add(new Jugador(NickName));
        }
        public void ReparteCartasIniciales()
        {
            //Repartimos cartas iniciales
        }
        public void DecidirGanador()
        {
            //Pues decidimos el ganador 
        }
        public void PenalizadoSiNoDicesUno()
        {
            //Agregamos una carta al que no le de click al botón de Uno
        }
    }
}
