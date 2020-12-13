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

namespace ProyectoBancos
{
    /// <summary>
    /// Lógica de interacción para VentanaBuscar.xaml
    /// </summary>
    public partial class VentanaBuscar : Window
    {
        public object DatoAIdentificar { get; set; }
        public int Indice { get; set; }

        public VentanaBuscar()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void BtnRegresar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (RetornaTipoPersona(DatoAIdentificar).GetType() == typeof(Cliente))
            {
                (Owner as MainWindow).ListaPersonas[Indice]=(RetornaTipoPersona(DatoAIdentificar));
                (Owner as MainWindow).Contenedor.Items[Indice] = ("Cliente ID: " + (RetornaTipoPersona(DatoAIdentificar) as Cliente).ID_Cliente + " Nombre: " + (RetornaTipoPersona(DatoAIdentificar) as Cliente).Nombre + " " + (RetornaTipoPersona(DatoAIdentificar) as Cliente).ApellidoP);
            }
            else if (RetornaTipoPersona(DatoAIdentificar).GetType() == typeof(Trabajador))
            {
                (Owner as MainWindow).ListaPersonas[Indice]=(RetornaTipoPersona(DatoAIdentificar));
                (Owner as MainWindow).Contenedor.Items[Indice]=("Trabajador ID: " + (RetornaTipoPersona(DatoAIdentificar) as Trabajador).ID_Trabajador + " Nombre: " + (RetornaTipoPersona(DatoAIdentificar) as Trabajador).Nombre + " " + (RetornaTipoPersona(DatoAIdentificar) as Trabajador).ApellidoP);
            }
            this.Close();
        }

        public Persona RetornaTipoPersona(object DatoAIdentificar)
        {
            if (DatoAIdentificar.GetType() == typeof(Cliente))
            {
                Cliente cl = new Cliente(txtNombre.Text, txtAP.Text, txtAM.Text, int.Parse(txtEdad.Text), txtGenero.Text);
                return cl;
            }
            else if (DatoAIdentificar.GetType() == typeof(Trabajador))
            {
                Trabajador tj = new Trabajador(txtNombre.Text, txtAP.Text, txtAM.Text, int.Parse(txtEdad.Text), txtGenero.Text);
                return tj;
            }
            return null;
        }



    }
}
