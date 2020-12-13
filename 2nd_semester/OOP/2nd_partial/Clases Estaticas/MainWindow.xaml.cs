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

namespace Clases_Estaticas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Punto> puntos = new List<Punto>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Punto p = Punto.CreaPuntoRandom(elcanvitas.ActualWidth, elcanvitas.Height);  
                p.Dibujate(elcanvitas);
                puntos.Add(p);
                Console.WriteLine(p.EsLatice());
            }
            //Punto noEs = new Punto(1.7,4.5);
            //Console.WriteLine(noEs.EsLatice());
        }

        private void Elcanvitas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point Clickeo = e.GetPosition(elcanvitas);
            Punto p = new Punto(Clickeo.X,Clickeo.Y);
            p.Dibujate(elcanvitas);
        }
    }
}
