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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MuchasVentanas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Articulo> ListaArticulos { get; set; } 
       
        public MainWindow()
        {
            ListaArticulos = new List<Articulo>();
            InitializeComponent();
        }

        //Agregar uno de los 3 Items
        private void BtnNuevaVentana_Click(object sender, RoutedEventArgs e) 
        {        
            if (rbMovie.IsChecked == true)
            {
                AgregarGeneral FormaAgregar = new AgregarGeneral();
                FormaAgregar.Owner = this;
                FormaAgregar.txtDuracion.Visibility = Visibility.Visible; FormaAgregar.lblDuracion.Visibility = Visibility.Visible;
                FormaAgregar.txtCalificacion.Visibility = Visibility.Visible; FormaAgregar.lblCalificacion.Visibility = Visibility.Visible;
                FormaAgregar.txtCategoria.Visibility = Visibility.Visible; FormaAgregar.lblCategoria.Visibility = Visibility.Visible;
                FormaAgregar.btnModificar.Visibility = Visibility.Hidden;
                Movie Pelicula = new Movie("", "", 0, 0, 0, "");
                FormaAgregar.DatoAIdentificar = Pelicula;
                FormaAgregar.Show();
                this.Hide();
            }
            else if (rbBook.IsChecked == true)
            {
                AgregarGeneral FormaAgregar = new AgregarGeneral();
                FormaAgregar.Owner = this;
                FormaAgregar.txtAutor.Visibility = Visibility.Visible; FormaAgregar.lblAutor.Visibility = Visibility.Visible;
                FormaAgregar.txtPaginas.Visibility = Visibility.Visible; FormaAgregar.lblPaginas.Visibility = Visibility.Visible;
                FormaAgregar.txtEditorial.Visibility = Visibility.Visible; FormaAgregar.lblEditorial.Visibility = Visibility.Visible;
                FormaAgregar.txtTema.Visibility = Visibility.Visible; FormaAgregar.lblTema.Visibility = Visibility.Visible;
                FormaAgregar.btnModificar.Visibility = Visibility.Hidden;
                Book Libro = new Book("", "", 0, "", "", "", 0);
                FormaAgregar.DatoAIdentificar = Libro;
                FormaAgregar.Show();
                this.Hide();
            }
            else if (rbProduct.IsChecked == true)
            {
                AgregarGeneral FormaAgregar = new AgregarGeneral();
                FormaAgregar.Owner = this;
                FormaAgregar.txtCantidad.Visibility = Visibility.Visible; FormaAgregar.lblCantidad.Visibility = Visibility.Visible;
                FormaAgregar.btnModificar.Visibility = Visibility.Hidden;
                Producto Produc = new Producto("", "", 0, 0);
                FormaAgregar.DatoAIdentificar = Produc;
                FormaAgregar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Si desea agregar, seleccione una opción");
            }
        }

        private void BtnPrueba_Click(object sender, RoutedEventArgs e)
        {
            Contenedor.Items.Add("Hola jejejeje");
            //object mo = DateTime.Now;
            //if (mo.GetType() == typeof(DateTime))
            //{
            //    //El objeto es de tipo DateTime.
            //}
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (Contenedor.Items.Count <= 0)
            {
                throw new IndexOutOfRangeException("Ya no hay más elementos");
            }
            else
            {
                MessageBox.Show(Contenedor.SelectedIndex.ToString());
                int indice = Contenedor.SelectedIndex;
                Contenedor.Items.RemoveAt(Contenedor.SelectedIndex);
                ListaArticulos.RemoveAt(indice);
                Contenedor.Items.Clear();
                foreach (var item in ListaArticulos)
                {
                    Contenedor.Items.Add(item.Nombre);
                }
            }        
        }

        private void Contenedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnNuevaVentana_MouseEnter(object sender, MouseEventArgs e)
        {
            //btnNuevaVentana.Background = Brushes.Yellow;
        }

        private void BtnNuevaVentana_MouseLeave(object sender, MouseEventArgs e)
        {
            //btnNuevaVentana.Background = Brushes.Green;
        }

        private void Contenedor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int Index = 0;
            if (Contenedor.SelectedIndex != -1)
            {
                //MessageBox.Show("Clickeaste dos veces");
                Index = Contenedor.SelectedIndex;
                //MessageBox.Show(Index.ToString());
                object QueVoyAMostrar = ListaArticulos[Index];
                if (QueVoyAMostrar.GetType() == typeof(Movie))
                {
                    MoviesForm mf = new MoviesForm((QueVoyAMostrar as Movie));
                    mf.Show();
                    mf.Owner = this;
                    this.Hide();
                }
                else if (QueVoyAMostrar.GetType() == typeof(Book))
                {
                    BooksForm bf = new BooksForm((QueVoyAMostrar as Book));
                    bf.Show();
                    bf.Owner = this;
                    this.Hide();
                }
                else if (QueVoyAMostrar.GetType() == typeof(Producto))
                {
                    ProductsForm pf = new ProductsForm((QueVoyAMostrar as Producto));
                    pf.Show();
                    pf.Owner = this;
                    this.Hide();
                }
            }
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            int Index = Contenedor.SelectedIndex;
            object Temporal = ListaArticulos[Index];
            if (Temporal.GetType() == typeof(Movie))
            {
                AgregarGeneral FormaAgregar = new AgregarGeneral();
                FormaAgregar.Owner = this;
                FormaAgregar.txtDuracion.Visibility = Visibility.Visible; FormaAgregar.lblDuracion.Visibility = Visibility.Visible;
                FormaAgregar.txtCalificacion.Visibility = Visibility.Visible; FormaAgregar.lblCalificacion.Visibility = Visibility.Visible;
                FormaAgregar.txtCategoria.Visibility = Visibility.Visible; FormaAgregar.lblCategoria.Visibility = Visibility.Visible;
                FormaAgregar.btnModificar.Visibility = Visibility.Visible;
                FormaAgregar.Agregame.Visibility = Visibility.Hidden;
                FormaAgregar.txtNombre.Text = (Temporal as Movie).Nombre;
                FormaAgregar.txtDescripcion.Text = (Temporal as Movie).Descripcion;
                FormaAgregar.txtPrecio.Text = (Temporal as Movie).Precio.ToString();
                FormaAgregar.txtDuracion.Text = (Temporal as Movie).Duracion.ToString();
                FormaAgregar.txtCalificacion.Text = (Temporal as Movie).Calificacion.ToString();
                FormaAgregar.txtCategoria.Text = (Temporal as Movie).Tipo;
                Movie Pelicula = new Movie("", "", 0, 0, 0, "");
                FormaAgregar.DatoAIdentificar = Pelicula;
                FormaAgregar.Indice = Index;
                FormaAgregar.Show();
                this.Hide();
            }
            else if (Temporal.GetType() == typeof(Book))
            {
                AgregarGeneral FormaAgregar = new AgregarGeneral();
                FormaAgregar.Owner = this;
                FormaAgregar.txtAutor.Visibility = Visibility.Visible; FormaAgregar.lblAutor.Visibility = Visibility.Visible;
                FormaAgregar.txtPaginas.Visibility = Visibility.Visible; FormaAgregar.lblPaginas.Visibility = Visibility.Visible;
                FormaAgregar.txtEditorial.Visibility = Visibility.Visible; FormaAgregar.lblEditorial.Visibility = Visibility.Visible;
                FormaAgregar.txtTema.Visibility = Visibility.Visible; FormaAgregar.lblTema.Visibility = Visibility.Visible;
                FormaAgregar.btnModificar.Visibility = Visibility.Visible;
                FormaAgregar.Agregame.Visibility = Visibility.Hidden;
                FormaAgregar.txtNombre.Text = (Temporal as Book).Nombre;
                FormaAgregar.txtDescripcion.Text = (Temporal as Book).Descripcion;
                FormaAgregar.txtPrecio.Text = (Temporal as Book).Precio.ToString();
                FormaAgregar.txtAutor.Text = (Temporal as Book).Autor;
                FormaAgregar.txtPaginas.Text = (Temporal as Book).Paginas.ToString();
                FormaAgregar.txtEditorial.Text = (Temporal as Book).Editorial;
                FormaAgregar.txtTema.Text = (Temporal as Book).Tema;
                Book Libro = new Book("", "", 0, "", "", "", 0);
                FormaAgregar.DatoAIdentificar = Libro;
                FormaAgregar.Indice = Index;
                FormaAgregar.Show();
                this.Hide();
            }
            else if (Temporal.GetType() == typeof(Producto))
            {
                AgregarGeneral FormaAgregar = new AgregarGeneral();
                FormaAgregar.Owner = this;
                FormaAgregar.txtCantidad.Visibility = Visibility.Visible; FormaAgregar.lblCantidad.Visibility = Visibility.Visible;
                FormaAgregar.btnModificar.Visibility = Visibility.Visible;
                FormaAgregar.Agregame.Visibility = Visibility.Hidden;
                FormaAgregar.txtNombre.Text = (Temporal as Producto).Nombre;
                FormaAgregar.txtDescripcion.Text = (Temporal as Producto).Descripcion;
                FormaAgregar.txtPrecio.Text = (Temporal as Producto).Precio.ToString();
                FormaAgregar.txtCantidad.Text = (Temporal as Producto).Cantidad.ToString();
                Producto Produc = new Producto("", "", 0, 0);
                FormaAgregar.DatoAIdentificar = Produc;
                FormaAgregar.Indice = Index;
                FormaAgregar.Show();
                this.Hide();
            }
        }
    }
}
