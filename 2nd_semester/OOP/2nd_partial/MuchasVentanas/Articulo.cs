using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchasVentanas
{
    public class Articulo
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }

        public Articulo(string Nombre, string Descripcion, int Precio)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Precio = Precio;
        }
    }
}
