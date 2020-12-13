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
    /// Lógica de interacción para MoviesForm.xaml
    /// </summary>
    public partial class MoviesForm : Window
    {
        public Movie Pelicula { get; set; }
        public MoviesForm(Movie PeliculaLlega)
        {
            InitializeComponent();
            Pelicula = new Movie(PeliculaLlega.Nombre, PeliculaLlega.Descripcion, PeliculaLlega.Precio, PeliculaLlega.Duracion, PeliculaLlega.Calificacion, PeliculaLlega.Tipo);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {         
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblTitulo.Content = (Pelicula as Movie).Nombre;
            lblDescripcion.Content = "Argumento: " + (Pelicula as Movie).Descripcion;
            lblPrecio.Content = "Precio: $" + (Pelicula as Movie).Precio.ToString();
            lblDuracion.Content = lblDuracion.Content + (Pelicula as Movie).Duracion.ToString() + " min";
            lblCalificacion.Content = lblCalificacion.Content + (Pelicula as Movie).Calificacion.ToString();
            lblCategoria.Content = lblCategoria.Content + (Pelicula as Movie).Tipo;
        }
    }
}
