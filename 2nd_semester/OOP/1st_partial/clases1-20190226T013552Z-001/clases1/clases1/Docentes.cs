using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Docentes
    {
        public int ID_Maestro { get; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Genero { get; set; }
        public string ClaseImpartida { get; set; }

        public Docentes(int ID_Maestro, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Genero, string ClaseImpartida)
        {
            this.ID_Maestro = ID_Maestro;
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.Genero = Genero;
            this.ClaseImpartida = ClaseImpartida;
        }
    }
}
