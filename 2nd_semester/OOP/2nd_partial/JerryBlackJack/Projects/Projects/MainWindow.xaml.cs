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
        Mano m; //Mano del jugador
        Mano Del; //Mano del Dealer
        int x = 200;
        Dealer D;
        Jugador J;
       
        public void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //Invalidamos los botones
            btnAgarrar.IsEnabled = false;
            btnQuedarse.IsEnabled = false;
            //Inicializamos al jugador
            J = new Jugador();
            lblBancoJugador.Content = "$" + J.dinero;
            //Inicializamos Baraja
            b = new Baraja();
            //Mano de Jugador
            m = new Mano();
            //Mano del dealer
            Del = new Mano();
            Carta l = b.ReparteCarta();
            Carta t = b.ReparteCarta();//Segunda Carta del Valor del dealer 
            //Recibeme dos cartas
            Del.RecibiriCarta(l);
            Del.RecibiriCarta(t);
            //Imprimimos datos en el label
            int SumaPuntosDelDealer = Del.SumaMano();
            D = new Dealer(l, t, SumaPuntosDelDealer, Del, b);
            //Ocultamos la segunda carta
            Carta ocultita = new Carta(@"Imagenes\oculto.png", 0);
            //t.Dibujate(miCanvas, 500, 10);
            //Dibujamos las dos cartas
            l.Dibujate(miCanvas, 450, 10);
            //ocultita.Dibujate(miCanvas, 550, 10);
            ocultita.Dibujate(miCanvas, 550, 10);
        }

        public void BtnQuedarse_Click(object sender, RoutedEventArgs e)
        {
            D.VoltearCarta().Dibujate(miCanvas, 550, 10);
            if (D.SaberSiImprime3eraCarta() == true)
            {
                D.CartitaExtra().Dibujate(miCanvas, 650, 10);
            }
            lbldealer.Content = D.SumaTotalDealer();
            //DECISION DEL JUEGO
            Partida p = new Partida(D.SumaTotalDealer(), m.SumaMano());
            MessageBox.Show(p.Ganador(), "RESULTADO: ");
            if (p.Ganador() == "Ganaste")
            {
                J.dinero = J.dinero + (J.apuesta * 2);
            }
            else if (p.Ganador() == "Perdiste")
            {
            }
            else
            {
                J.dinero = J.dinero + J.apuesta;
            }
            lblBancoJugador.Content = "$" + J.dinero;
            lblDineroApostado.Content = "$0";
            //Limpiar Canvas
            miCanvas.Children.Clear();
            //Volvemos a inicializar la mano del jugador<-------------------------
            m = new Mano();
            x = 200;
            //Volvemos a inicializar la mano del dealer<---------------
            Del = new Mano();
            Carta l = b.ReparteCarta();
            Carta t = b.ReparteCarta();//Segunda Carta del Valor del dealer 
            //Recibeme dos cartas
            Del.RecibiriCarta(l);
            Del.RecibiriCarta(t);
            //Imprimimos datos en el label
            lbldealer.Content = "";
            int SumaPuntosDelDealer = Del.SumaMano();
            D = new Dealer(l, t, SumaPuntosDelDealer, Del, b);
            //Ocultamos la segunda carta
            Carta ocultita = new Carta(@"Imagenes\oculto.png", 0);
            //t.Dibujate(miCanvas, 500, 10);
            //Dibujamos las dos cartas
            l.Dibujate(miCanvas, 450, 10);
            //ocultita.Dibujate(miCanvas, 550, 10);
            ocultita.Dibujate(miCanvas, 550, 10);
            btnApostar.IsEnabled = true;
            btnAgarrar.IsEnabled = false;
            btnQuedarse.IsEnabled = false;
        }
        private void BtnApostar_Click(object sender, RoutedEventArgs e)
        {
            int Apuesta = int.Parse(txtDineroApostado.Text);
            J.apuesta = Apuesta;
            int Resta = 0;
            Resta = J.dinero - J.apuesta;
            if(Resta < 0)
            {
                MessageBox.Show("Estás apostando más de lo que tienes en tu banco, piensa chavotl");
            }
            else if (J.dinero <= 0)
            {
                btnAgarrar.IsEnabled = false;
                btnApostar.IsEnabled = false;
                btnQuedarse.IsEnabled = false;
                MessageBox.Show("JUEGO TERMINADO");
            }
            else
            {
                J.dinero = J.dinero - J.apuesta;
                btnApostar.IsEnabled = false;
                lblDineroApostado.Content = "$" + J.apuesta;
                lblBancoJugador.Content = "$" + J.dinero;
            }
            btnAgarrar.IsEnabled = true;
            btnQuedarse.IsEnabled = true;
            txtDineroApostado.Text = "";
        }

        private void BtnAgarrar_Click(object sender, RoutedEventArgs e)
        {
            //Mano Tuya    
            Carta c = b.ReparteCarta();
            c.Dibujate(miCanvas, x, 250);
            m.RecibiriCarta(c);
            lblPuntos.Content = m.SumaMano();
            x += 50;
        }
    }
}
