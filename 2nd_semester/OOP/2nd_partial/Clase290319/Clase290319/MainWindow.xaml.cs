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

namespace Clase290319
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        List<punto> puntos = new List<punto>();
        List<Linea> listalineas = new List<Linea>();
        int CantidadMaximaLineas = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void elCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    punto p = punto.CreaPuntoRandom(elCanvas.ActualWidth, elCanvas.ActualHeight);
            //    p.Dibujate(elCanvas);
            //    puntos.Add(p);
            //    Console.WriteLine(p.EsLattice());
            //}
            elCanvas.IsEnabled = false;
            btnCalculaLongitud.IsEnabled = false;
            btnLimpiar.IsEnabled = false;
        }

        private void elCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void elCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void elCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (puntos.Count < CantidadMaximaLineas )
            {
                Point clieckeo = e.GetPosition(elCanvas);
                punto p = new punto((int)clieckeo.X, (int)clieckeo.Y);
                p.Dibujate(elCanvas);
                puntos.Add(p);
            }
            else
            {
                elCanvas.IsEnabled = false;
            }                   
        }

        private void BtnCalculaLongitud_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < puntos.Count; i++)
            {
                for (int j = 0; j < puntos.Count; j++)
                {
                    Linea l = new Linea((int)puntos[i].X, (int)puntos[j].X, (int)puntos[i].Y, (int)puntos[j].Y);
                    listalineas.Add(l);
                    l.DibujaLinea(elCanvas);
                }
            }
            double acum = 0;
            for (int i = 0; i < listalineas.Count; i++)
            {
                acum += listalineas[i].CalculaLongitud();
            }
            acum = acum / listalineas.Count;
            MessageBox.Show("El promedio es: " + acum);
        }

        private void TxtPuntos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CantidadMaximaLineas = int.Parse(txtPuntos.Text);
                MessageBox.Show("Cantidad máxima de líneas es de: " + CantidadMaximaLineas);
                txtPuntos.Text = "";
                elCanvas.IsEnabled = true;
                btnCalculaLongitud.IsEnabled = true;
                btnLimpiar.IsEnabled = true;
            }
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            elCanvas.Children.Clear();
            puntos.Clear();
            listalineas.Clear();
            txtPuntos.Text = "";
            btnLimpiar.IsEnabled = false;
            btnCalculaLongitud.IsEnabled = false;
        }
    }
}
