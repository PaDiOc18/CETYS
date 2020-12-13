using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Alumno:persona
    {
       public int matricula { get; }
       public string carrera { get; set; }
       public int semestre { get; set; }

        public Alumno(int matricula, string carrera, int semestre, string nombre, string apellidopaterno, string apellidomaterno, DateTime fechadenacimiento):
            base(nombre,apellidopaterno, apellidomaterno,fechadenacimiento)
        {
            this.matricula = matricula;
            this.carrera = carrera;
            this.semestre = semestre;
        }
        public override string ToString()
        {
            return $"Alumno:{this.matricula}: {this.apellidopaterno}, {this.nombre}";
        }
    }
}
