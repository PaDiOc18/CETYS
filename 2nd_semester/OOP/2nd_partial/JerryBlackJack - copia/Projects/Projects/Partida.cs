using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class Partida
    {
        public List<Jugador> Jugadores { get; set; }
        private Baraja Baraja { get; set; }

        public Partida()
        {
            Baraja = new Baraja();
            Jugadores = new List<Jugador>();
            Jugadores.Add(new Dealer());
        }

        public void AddPlayer(string NickName, int Credito)
        {
            Jugadores.Add(new Jugador(Credito, NickName));
        }


        public void ReparteCartasIniciales()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (Jugador player in Jugadores)
                {
                    Carta salio = Baraja.ReparteCarta();
                    if (player.ToString() == "Dealer" && i==0)
                    {
                        salio.Mostrar = false;
                    }
                    player.Hit(salio);
                }
            }        
        }





    }
}
