using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Docente : Empleado
    {
        public string materias { get; set; }
        public int nivel { get; set; }
        public int tipo { get; set; }

        public Docente(string materias, int nivel, int tipo, int numeroempleado, double sueldo, string nombre, DateTime FechaDeIngreso, string apellidopaterno, string apellidomaterno, DateTime fechadenacimiento) :
            base(numeroempleado, sueldo, nombre, FechaDeIngreso, apellidopaterno, apellidomaterno, fechadenacimiento)
        {
            this.materias = materias;
            this.nivel = nivel;
            this.tipo = nivel;
        }
        public override string ToString()
        {
            return $"Docente: {numeroEmpleado}: {apellidopaterno} , {nombre} ";
        }
    }
}
