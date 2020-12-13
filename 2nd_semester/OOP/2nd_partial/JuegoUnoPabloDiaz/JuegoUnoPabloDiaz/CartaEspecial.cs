using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoUnoPabloDiaz
{
    class CartaEspecial:Carta
    {
        public string FuncionCarta { get; set; }
        public string Color { get; set; }

        public CartaEspecial(string Color, int valor, string FuncionCarta) 
        : base(Color, valor)
        {
            this.FuncionCarta = FuncionCarta;
            this.Color = Color;
        }
        public void Reverse()
        {
            //Funcionalidad de Reverse
        }
        public void MasDos()
        {
            //Mas dos a la mano del jugador
        }
        public void CancelarTurno()
        {
            //Cancelar turno siguiente
        }
        public void MasCuatro()
        {
            //Mas cuatro a la persona que sigue
        }
        public void ElegirColor()
        {
            //Elegimos color que queremos
        }
    }
}
