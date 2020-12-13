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
    /// Lógica de interacción para AgregarGeneral.xaml
    /// </summary>
    public partial class AgregarGeneral : Window
    {
        public object DatoAIdentificar { get; set; }
        public int Indice { get; set; }


        public AgregarGeneral()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            txtDuracion.Visibility = Visibility.Hidden; lblDuracion.Visibility = Visibility.Hidden;
            txtCalificacion.Visibility = Visibility.Hidden; lblCalificacion.Visibility = Visibility.Hidden;
            txtCategoria.Visibility = Visibility.Hidden; lblCategoria.Visibility = Visibility.Hidden;
            txtCantidad.Visibility = Visibility.Hidden; lblCantidad.Visibility = Visibility.Hidden;
            txtAutor.Visibility = Visibility.Hidden; lblAutor.Visibility = Visibility.Hidden;
            txtPaginas.Visibility = Visibility.Hidden; lblPaginas.Visibility = Visibility.Hidden;
            txtEditorial.Visibility = Visibility.Hidden; lblEditorial.Visibility = Visibility.Hidden;
            txtTema.Visibility = Visibility.Hidden; lblTema.Visibility = Visibility.Hidden;
        }

        private void Agregame_Click(object sender, RoutedEventArgs e)
        {
            (Owner as MainWindow).ListaArticulos.Add(RetornaArticulo(DatoAIdentificar));
            (Owner as MainWindow).Contenedor.Items.Add(RetornaArticulo(DatoAIdentificar).Nombre);
        }

        public Articulo RetornaArticulo(object DatoAIdentificar)
        {
            if (DatoAIdentificar.GetType() == typeof(Movie))
            {
                //MessageBox.Show("SOLO SE QUE ES PELICULA");
                Movie Peli = new Movie(txtNombre.Text, txtDescripcion.Text, int.Parse(txtPrecio.Text), int.Parse(txtDuracion.Text), int.Parse(txtCalificacion.Text), txtCategoria.Text);
                return Peli;
            }
            else if (DatoAIdentificar.GetType() == typeof(Book))
            {
                //MessageBox.Show("SOLO SE QUE ES LIBRO");
                Book Librillo = new Book(txtNombre.Text, txtDescripcion.Text, int.Parse(txtPrecio.Text), txtAutor.Text, txtTema.Text, txtEditorial.Text, int.Parse(txtPaginas.Text));
                return Librillo;
            }
            else if (DatoAIdentificar.GetType() == typeof(Producto))
            {
                //MessageBox.Show("SOLO SE QUE ES PRODUCTO");
                Producto Produ = new Producto(txtNombre.Text, txtDescripcion.Text, int.Parse(txtPrecio.Text), int.Parse(txtCantidad.Text));
                return Produ;
            }
            return null;
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            (Owner as MainWindow).ListaArticulos[Indice] = (RetornaArticulo(DatoAIdentificar));
            (Owner as MainWindow).Contenedor.Items[Indice] = (RetornaArticulo(DatoAIdentificar).Nombre);
        }
    }
}
