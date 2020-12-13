using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases1
{
    class Libro
    {
        public int ID_Libro { get; set; }
        public string NombreLibro { get;}
        public string Genero { get;}
        public string Idioma { get;}
        public bool Estado { get; set; } //Me refiero a si está disponible o no 
        public int No_Paginas { get;}
        public Libro(int ID_Libro, string NombreLibro, string Genero, string Idioma, bool Estado, int No_Paginas)
        {
            this.ID_Libro = ID_Libro;
            this.NombreLibro = NombreLibro;
            this.Genero = Genero;
            this.Idioma = Idioma;
            this.Estado = Estado;
            this.No_Paginas = No_Paginas;
        }

        
    }
}
