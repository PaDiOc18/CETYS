using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class persona
    {
       public string nombre { get; set; }
       public string apellidopaterno { get; set; }
       public string apellidomaterno { get; set; }
       public  DateTime fechadenacimiento { get; }

        public persona(string nombre, string apellidopaterno, DateTime fechadenacimiento)
        {
            this.nombre = nombre;
            this.apellidopaterno = apellidopaterno;
            this.apellidomaterno = apellidomaterno;
            this.fechadenacimiento = fechadenacimiento;
        }
        public persona(string nombre, string apellidopaterno, string apellidomaterno, DateTime fechadenacimiento):
            this(nombre, apellidopaterno, fechadenacimiento)
        {
            this.apellidomaterno = apellidomaterno;
        }

        public int edad()
        {
            if (DateTime.Now.Month < fechadenacimiento.Month)
            {
                return (DateTime.Now.Year - fechadenacimiento.Year) - 1;
            }
            else if(DateTime.Now.Month == fechadenacimiento.Month)
            {
                if (DateTime.Now.Day >= fechadenacimiento.Day)
                {
                    return DateTime.Now.Year - fechadenacimiento.Year;
                }
                else
                {
                    return DateTime.Now.Year - fechadenacimiento.Year - 1;
                }
            }
            else
            {
                return DateTime.Now.Year - fechadenacimiento.Year;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{this.apellidopaterno},{this.nombre}";
        }
    }
}
