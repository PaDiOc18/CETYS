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
    /// Lógica de interacción para ProductsForm.xaml
    /// </summary>
    public partial class ProductsForm : Window
    {
        public Producto Product { get; set; }

        public ProductsForm(Producto ProductLlega)
        {
            InitializeComponent();
            Product = new Producto(ProductLlega.Nombre, ProductLlega.Descripcion, ProductLlega.Precio, ProductLlega.Cantidad);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lblTitulo.Content = (Product as Producto).Nombre;
            lblDescripcion.Content = "Descripcion: " + (Product as Producto).Descripcion;
            lblPrecio.Content = "Precio: $" + (Product as Producto).Precio.ToString();
            lblCantidad.Content = lblCantidad.Content + (Product as Producto).Cantidad.ToString();

        }
    }
}
