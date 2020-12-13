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

namespace JuegoUnoPabloDiaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Baraja b;
        Mano m;
        Partida j;
        int posX = 200;
        int posY = 1;

        public MainWindow()
        {       
            InitializeComponent();
            Image i = new Image();
            i.Source = new BitmapImage(new Uri(@"Imagenes\reverse.png", UriKind.Relative));
            Canvas1.Children.Add(i);
            i.Width = 150;
            i.Height = 250;
            Canvas.SetLeft(i, 20);
            Canvas.SetTop(i, 20);
        }

        private void BtnHola_Click(object sender, RoutedEventArgs e)
        {
            b = new Baraja();
        }
    }
}
