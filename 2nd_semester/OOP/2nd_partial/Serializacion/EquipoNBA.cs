using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    [Serializable]
    public class EquipoNBA
    {
        public string NombreEquipo { get; set; }
        public string Coach { get; set; }
        public string Asistente { get; set; }
        public string Ciudad { get; set; }
        public string Propietario { get; set; }
        public List<string> ListaJugadores { get; set; } 

        
        public EquipoNBA(string Coach, string NombreEquipo, string[] Jugadores, string Asistente)
        {
            this.Coach = Coach;
            this.NombreEquipo = NombreEquipo;
            this.ListaJugadores = new List<string>();
            this.Asistente = Asistente;
            this.Ciudad = Ciudad;
            this.Propietario = Propietario;
        }

        public EquipoNBA()
        {
            this.ListaJugadores = new List<string>();
        }
    }
}
