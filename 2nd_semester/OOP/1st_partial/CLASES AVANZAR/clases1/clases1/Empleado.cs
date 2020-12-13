using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Empleado : persona
    {
        public double sueldo { get; set; }
        public int numeroEmpleado { get; }
        public DateTime FechaDeIngreso { get; set; }
        public Empleado(int numeroEmpleado, double sueldo, string nombre, DateTime FechaDeIngreso, string apellidopaterno, string apellidomaterno, DateTime fechadenacimiento) : 
            base(nombre, apellidopaterno, apellidomaterno, fechadenacimiento)
        {
            this.numeroEmpleado = numeroEmpleado;
            this.sueldo = sueldo;
            this.FechaDeIngreso = DateTime.Now;
        }
    }
}
