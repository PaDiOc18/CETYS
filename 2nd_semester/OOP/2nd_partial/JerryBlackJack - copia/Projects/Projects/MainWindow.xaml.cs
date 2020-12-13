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

namespace Projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Baraja b;
        Mano m;
        Partida j;
        int posX = 200;
        int posY = 1;
       
        public void Grid_Loaded(object sender, RoutedEventArgs e)
        {
        }
        private void PideApuetas()
        {
            lblDineroApostado.Visibility = Visibility.Visible;
            txtDineroApostado.Visibility = Visibility.Visible;
            int numeroJ = 1;
            foreach (Jugador jugador in j.Jugadores)
            {
                
            }
        }

        private void IniciaJuego()
        {
            Partida j = new Partida();
            j.AddPlayer("Big Chungus", 1000);
            j.ReparteCartasIniciales();
            int indiceJ = 0;

            foreach (Jugador jugador in j.Jugadores)
            {
                int indiceC = 0;
                foreach (Carta carta in jugador.Mano.mano)
                {
                    carta.Dibujate(this.miCanvas, posX + (indiceC * 60), posY + (indiceJ * 120));
                    indiceC++;
                }
                indiceJ = indiceJ + 2;
            }
            lbldealer.Content = j.Jugadores[0].Mano.SumaMano();
            lblPuntos.Content = j.Jugadores[1].Mano.SumaMano();
            lblDineroApostado.Content = @"hola";
            PideApuetas();
        }



        public void BtnQuedarse_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void BtnApostar_Click(object sender, RoutedEventArgs e)
        {
            lblDineroApostado.Visibility = Visibility.Visible;
            txtDineroApostado.Visibility = Visibility.Visible;
            lblDineroApostado.Content = $"Apuesta del jugador { numeroJ}:";
            int apuesta = 0;
            while (true)
            {
                int.TryParse(txtDineroApostado.Text, out apuesta);
                if (apuesta > 0 && jugador.Apostar(apuesta))
                {
                    break;
                }
            }
            numeroJ++;
        }
        private void BtnAgarrar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IniciaJuego();
        }
    }
}
