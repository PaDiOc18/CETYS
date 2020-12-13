using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoUnoPabloDiaz
{
    class Jugador
    {
        private Mano mano { get; set; }
        public string NickName { get; set; }

        public Jugador(string NickName)
        {
            this.mano = new Mano();
            this.NickName = NickName;
        }
        public void TomarCarta(Carta c)
        {
            //Tomamos una carta de la baraja
        }
        public void DejarCarta(Carta c)
        {
            //Dejamos la carta en la mesa y se válida si se puede dejar o no
        }
        //Para ver la mano
        public Mano Mano
        {
            get
            {
                return this.mano;
            }
        }

    }
}
