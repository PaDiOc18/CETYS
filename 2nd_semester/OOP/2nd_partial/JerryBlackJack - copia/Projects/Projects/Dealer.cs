using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class Dealer : Jugador
    {
        public bool EsDealer { get; }
        public Dealer():
        base(1, "Dealer")
        {
            this.EsDealer = true;
        }
        public override string ToString()
        {
            return "Dealer";
        }
    }
}
