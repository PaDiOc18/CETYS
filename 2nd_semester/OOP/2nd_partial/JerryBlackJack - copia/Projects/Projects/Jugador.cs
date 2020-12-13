using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class Jugador
    {
        //Atributos
        private Mano mano {get; set;}
        private int Credito { get; set; }
        public string NickName { get; set; }

        public Jugador(int Credito, string NickName)
        {
            this.mano = new Mano();
            this.Credito = Credito;
            this.NickName = NickName;
        }
        public bool Apostar(int dinero)
        {
            if (dinero <= Credito)
            {
                Credito -= dinero;
                return true;
            }
            return false;
        }
        public void Hit(Carta carta)
        {
            this.mano.RecibiriCarta(carta);
        }
        public void RecibirCredito(int ganancia)
        {
            Credito += ganancia;
        }
        //Las propiedades se heredan Le da comportamiento a objetos
        //Los atributos no le da datos al objetos

        //Propiedad
        public int CreditoJugador
        {
            get
            {
                return Credito;
            }
        }
        public Mano Mano
        {
            get
            {
                return this.mano;
            }
        }
        public void ResetMano()
        {
            this.mano = new Mano();
        }
        public override string ToString()
        {
            return "Jugador";
        }
    }
}
