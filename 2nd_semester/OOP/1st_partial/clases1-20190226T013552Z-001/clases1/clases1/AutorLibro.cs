using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class AutorLibro
    {
        public string Nombre { get; }
        public string LugarNacimiento {get;}
        public DateTime FechaNacimiento { get; }
        
        public AutorLibro(string Nombre, string LugarNacimiento, DateTime FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.LugarNacimiento = LugarNacimiento;
            this.FechaNacimiento = FechaNacimiento;
        }
    }
}
