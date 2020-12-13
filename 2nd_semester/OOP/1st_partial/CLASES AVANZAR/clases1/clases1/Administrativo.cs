using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Administrativo : Empleado
    {
        public string departamento { get; set; }
        public string turno { get; set; }

        public Administrativo(string departamento, string turno, int numeroempleado, double sueldo, string nombre, DateTime FechaDeIngreso, string apellidopaterno, string apellidomaterno, DateTime fechadenacimiento) : 
            base(numeroempleado, sueldo, nombre, FechaDeIngreso, apellidopaterno, apellidomaterno, fechadenacimiento)
        {
            this.departamento = departamento;
            this.turno = turno;
        }
        public override string ToString()
        {
            return $"Administrativo: {this.numeroEmpleado}: {this.apellidopaterno}, {this.nombre}";
        }
    }
}
