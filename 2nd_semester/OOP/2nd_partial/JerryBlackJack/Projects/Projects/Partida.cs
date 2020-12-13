using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class Partida
    {
        public int ConteoDealer { get; set; }
        public int ConteoJugador { get; set; }
        
        public Partida(int ConteoDealer, int ConteoJugador)
        {
            this.ConteoJugador = ConteoJugador;
            this.ConteoDealer = ConteoDealer;
        }

        public string Ganador()
        {
            int Dealer21 = 21 - ConteoDealer;
            int Jugador21 = 21 - ConteoJugador;
            if (Dealer21 >= 0 && Jugador21 >= 0)
            {
                if (Dealer21 < Jugador21)
                {
                    return "Perdiste";
                }
                else if (Dealer21  > Jugador21)
                {
                    return "Ganaste";
                }
                else
                {
                    return "Empate";
                }
            }
            else if(Dealer21 < 0 && Jugador21 >= 0)
            {
                return "Ganaste";
            }
            else if (Dealer21 >= 0 && Jugador21 < 0)
            {
                return "Perdiste";
            }
            //Este caso ocurre cuando no entra en ningun if y los dos son mayores que 21
            return "Empate";
        }

           

    }
}
