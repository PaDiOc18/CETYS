using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Alumno
    {
        public int Matricula { get; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Genero { get; set; }
        public string Carrera { get; set; }
        
        public Alumno(int Matricula, string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Genero, string Carrera)
        {
            this.Matricula = Matricula;
            this.Nombre = Nombre;
            this.ApellidoPaterno = ApellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.Genero = Genero;
            this.Carrera = Carrera;
        }
    }
}
