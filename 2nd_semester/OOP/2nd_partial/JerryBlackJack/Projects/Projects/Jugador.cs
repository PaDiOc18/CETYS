using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class Jugador
    {
        public int dinero { get; set; }
        public int apuesta { get; set; }
        public Jugador()
        {
            dinero = 1000;
            apuesta = 0;
        }
    }
}
