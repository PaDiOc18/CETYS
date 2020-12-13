using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoUnoPabloDiaz
{
    class Mano
    {
        public List<Carta> mano { get; set; }
        public Mano()
        {
            mano = new List<Carta>();
        }
        public void RecibiriCarta(Carta c)
        {
            mano.Add(c);
        }
        public void QuitarCarta(Carta c)
        {
            mano.Remove(c);
        }
        public bool UnoEnMano()
        {
            ///Validar si tiene una carta en la mano
            if (mano.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}
