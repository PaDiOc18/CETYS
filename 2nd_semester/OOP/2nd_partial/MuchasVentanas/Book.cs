using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuchasVentanas
{
    public class Book : Articulo
    {
        public int Paginas { get; set; }
        public string Editorial { get; set; }
        public string Autor { get; set; }
        public string Tema { get; set; }

        public Book(string Nombre, string Descripcion, int Precio, string Autor, string Tema, string Editorial, int Paginas) :
            base(Nombre, Descripcion, Precio)
        {
            this.Autor = Autor;
            this.Tema = Tema;
            this.Editorial = Editorial;
            this.Paginas = Paginas;
        }
    }
}
