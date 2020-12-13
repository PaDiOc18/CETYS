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
using Newtonsoft.Json;
using System.IO;

namespace ProyectoBancos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<Trabajador> ListaTrabajadores { get; set; }
        //public List<Cliente> ListaClientes { get; set; } 
        public List<Persona> ListaPersonas { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //ListaClientes = new List<Cliente>();
            //ListaTrabajadores = new List<Trabajador>();
            ListaPersonas = new List<Persona>();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (rbCliente.IsChecked == true)
            {
                AgregarPersona ag = new AgregarPersona();
                ag.Owner = this;
                Cliente NuevoCliente = new Cliente("", "", "", 0, "");
                ag.DatoAIdentificar = NuevoCliente;
                ag.Show();
                this.Hide();
            }
            else if (rbTrabajador.IsChecked == true)
            {
                AgregarPersona ag = new AgregarPersona();
                ag.Owner = this;
                Trabajador NuevoTrabajador = new Trabajador("", "", "", 0, "");
                ag.DatoAIdentificar = NuevoTrabajador;
                ag.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Favor de Seleccionar una opción");
            }
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //VentanaBuscar vb = new VentanaBuscar();
            //vb.Owner = this;
            //vb.Show();
            //this.Hide();
            int Index = Contenedor.SelectedIndex;
            object Temporal = ListaPersonas[Index];
            if (Temporal.GetType() == typeof(Cliente))
            {
                VentanaBuscar vb = new VentanaBuscar();
                vb.Owner = this;
                vb.txtNombre.IsEnabled = true; vb.txtAP.IsEnabled = true; vb.txtAM.IsEnabled = true; vb.txtEdad.IsEnabled = true; vb.txtGenero.IsEnabled = true;
                vb.txtID.Text = (Temporal as Cliente).ID_Cliente;
                vb.txtNombre.Text = (Temporal as Cliente).Nombre;
                vb.txtAP.Text = (Temporal as Cliente).ApellidoP;
                vb.txtAM.Text = (Temporal as Cliente).ApellidoM;
                vb.txtEdad.Text = (Temporal as Cliente).Edad.ToString();
                vb.txtGenero.Text = (Temporal as Cliente).Genero;
                Cliente NuevoCliente = new Cliente("", "", "", 0, "");
                vb.DatoAIdentificar = NuevoCliente;
                vb.Indice = Index;
                vb.Show();
                this.Hide();
            }
            else if (Temporal.GetType() == typeof(Trabajador))
            {
                VentanaBuscar vb = new VentanaBuscar();
                vb.Owner = this;
                vb.txtNombre.IsEnabled = true; vb.txtAP.IsEnabled = true; vb.txtAM.IsEnabled = true; vb.txtEdad.IsEnabled = true; vb.txtGenero.IsEnabled = true;
                vb.txtID.Text = (Temporal as Trabajador).ID_Trabajador;
                vb.txtNombre.Text = (Temporal as Trabajador).Nombre;
                vb.txtAP.Text = (Temporal as Trabajador).ApellidoP;
                vb.txtAM.Text = (Temporal as Trabajador).ApellidoM;
                vb.txtEdad.Text = (Temporal as Trabajador).Edad.ToString();
                vb.txtGenero.Text = (Temporal as Trabajador).Genero;
                Trabajador NuevoTrabajador = new Trabajador("", "", "", 0, "");
                vb.DatoAIdentificar = NuevoTrabajador;
                vb.Indice = Index;
                vb.Show();
                this.Hide();
            }
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (Contenedor.Items.Count <= 0)
            {
                throw new IndexOutOfRangeException("Ya no hay más elementos");
            }
            else
            {
                //MessageBox.Show(Contenedor.SelectedIndex.ToString());
                int indice = Contenedor.SelectedIndex;
                Contenedor.Items.RemoveAt(Contenedor.SelectedIndex);
                ListaPersonas.RemoveAt(indice);
                Contenedor.Items.Clear();
                foreach (var item in ListaPersonas)
                {
                    if (item.GetType() == typeof(Cliente))
                    {
                        Contenedor.Items.Add("Cliente ID: " + (item as Cliente).ID_Cliente + " Nombre: " + (item as Cliente).Nombre + " " + (item as Cliente).ApellidoP);
                    }
                    else if (item.GetType() == typeof(Trabajador))
                    {
                        Contenedor.Items.Add("Cliente ID: " + (item as Trabajador).ID_Trabajador + " Nombre: " + (item as Trabajador).Nombre + " " + (item as Trabajador).ApellidoP);
                    }
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (var item in ListaPersonas)
            {
                string contenido = JsonConvert.SerializeObject(item);
                File.AppendAllText("Personas.json", contenido + "\n");
            }
        }
    }
}
