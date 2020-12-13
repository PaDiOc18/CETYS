using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchasVentanas
{
    public class Producto : Articulo
    {
        public int Cantidad { get; set; }

        public Producto(string Nombre, string Descripcion, int Precio, int Cantidad) :
            base(Nombre, Descripcion, Precio)
        {
            this.Cantidad = Cantidad;
        }
    }
}
