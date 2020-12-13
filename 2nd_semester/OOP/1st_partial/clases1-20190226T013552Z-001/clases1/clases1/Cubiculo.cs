using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Cubiculo
    {
        public int No_Cubiculo { get; }
        public bool Estado { get; set; }
        public string Credencial { get; set; }
        public string PersonaEncargada { get; set; } //De ese cubículo
        public int TiempoOcupado { get; set; }

        public Cubiculo(int No_Cubiculo, bool Estado,  string credencial, string PersonaEncargada, int TiempoOcupado)
        {
            this.No_Cubiculo = No_Cubiculo;
            this.Estado = Estado;
            this.Credencial = Credencial;
            this.PersonaEncargada = PersonaEncargada;
            this.TiempoOcupado = TiempoOcupado;
        }
    }
}
