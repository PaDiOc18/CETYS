using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchasVentanas
{
    public class Movie : Articulo
    {
        public int Duracion { get; set; }
        public int Calificacion { get; set; }
        public string Tipo { get; set; }

        public Movie(string Nombre, string Descripcion, int Precio, int Duracion,int Calificacion, string Tipo) :
            base(Nombre, Descripcion, Precio)
        {
            this.Duracion = Duracion;
            this.Calificacion = Calificacion;
            this.Tipo = Tipo;         
        }
    }
}
