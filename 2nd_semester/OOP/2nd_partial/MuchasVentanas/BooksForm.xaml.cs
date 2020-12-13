using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MuchasVentanas
{
    /// <summary>
    /// Lógica de interacción para BooksForm.xaml
    /// </summary>
    public partial class BooksForm : Window
    {
        public Book Libro { get; set; }
        public BooksForm(Book LibroLlega)
        {
            InitializeComponent();
            Libro = new Book(LibroLlega.Nombre, LibroLlega.Descripcion, LibroLlega.Precio, LibroLlega.Autor, LibroLlega.Tema, LibroLlega.Editorial, LibroLlega.Paginas);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lblTitulo.Content = Libro.Nombre;
            lblDescripcion.Content = "Sinopsis: " + Libro.Descripcion;
            lblPrecio.Content = lblPrecio.Content + "$" + Libro.Precio.ToString();
            lblPaginas.Content = lblPaginas.Content + Libro.Paginas.ToString() + " páginas";
            lblEditorial.Content = lblEditorial.Content + Libro.Editorial;
            lblAutor.Content = lblAutor.Content + Libro.Autor;
            lblTema.Content = lblTema.Content + Libro.Tema;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
