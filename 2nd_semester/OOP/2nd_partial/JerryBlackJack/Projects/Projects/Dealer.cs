using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class Dealer
    {
        public Carta[] Deal { get; }
        public int SumaTotal { get; set; }
        public bool Imprimir3ra { get; set; }

        public Dealer(Carta Uno, Carta Dos, int Suma, Mano Del, Baraja b)
        {
            Deal = new Carta[3];
            Deal[0] = Uno;
            Deal[1] = Dos;
            if (Suma >= 17)
            {
                //Se queda
                SumaTotal = Del.SumaMano();
                Imprimir3ra = false;
            }
            else
            {
                Imprimir3ra = true;
                Carta Nueva = b.ReparteCarta();
                //Metemos la carta a la mano
                Del.RecibiriCarta(Nueva);
                Deal[2] = Nueva;
                SumaTotal=  Del.SumaMano();
            }
        }
        public bool SaberSiImprime3eraCarta()
        {
            return Imprimir3ra;
        }
        public Carta CartitaExtra()
        {
            return Deal[2];
        }
        public Carta VoltearCarta()
        {
            return Deal[1];
        }
        public int SumaTotalDealer()
        {
            return SumaTotal;
        }       
    }
}
