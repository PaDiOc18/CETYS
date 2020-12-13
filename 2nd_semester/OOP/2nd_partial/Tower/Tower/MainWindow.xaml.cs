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


namespace Tower
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Disco> Discos;
        Random randis = new Random();


        public MainWindow()
        {
            InitializeComponent();
            Discos = new List<Disco>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //int TamañoRandom = randex.Next(120, 150);
            //Disco d1 = new Disco((int)elCanvitas.ActualWidth / 7 - TamañoRandom/2, (int)elCanvitas.ActualHeight / 4 + (int)Uno.Alto - 37, TamañoRandom);
            //d1.DibujaDisco(elCanvitas);
            Torre Uno = new Torre((int)elCanvitas.ActualWidth / 7, (int)elCanvitas.ActualHeight / 4);
            Torre Dos = new Torre((int)elCanvitas.ActualWidth / 2, (int)elCanvitas.ActualHeight / 4);
            Torre Tres = new Torre((int)elCanvitas.ActualWidth - 140, (int)elCanvitas.ActualHeight / 4);

            Uno.Dibuja(elCanvitas);
            Dos.Dibuja(elCanvitas);
            Tres.Dibuja(elCanvitas);

            int aux = 37;
            Brush relleno;
            int TamañoRandom = 170;
            for (int i = 0; i < 8; i++)
            {
                relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
                Disco d1 = new Disco((int)elCanvitas.ActualWidth / 7 + 10 - TamañoRandom / 2, (int)elCanvitas.ActualHeight / 4 + (int)Uno.Alto - aux, TamañoRandom, relleno);
                Discos.Add(d1);
                aux += 20;
                TamañoRandom -= 20;
            }
            for (int i = 0; i < Discos.Count; i++)
            {
                Discos[i].DibujaDisco(elCanvitas);
            }

        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Cbdisk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
