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
using System.Windows.Threading;

namespace FigurasGeometricas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FiguraGeometrica> Figuritas;
        DispatcherTimer Tiempos;
        Random randy;

        public MainWindow()
        {
            InitializeComponent();
            Figuritas = new List<FiguraGeometrica>();
            Tiempos = new DispatcherTimer();
            Tiempos.Interval = new TimeSpan(100000);
            Tiempos.Tick += Tiempos_Tick;
        }

        private void Tiempos_Tick(object sender, EventArgs e)
        {
            foreach (FiguraGeometrica figura in Figuritas)
            {
                figura.Animate(ElCanvas);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            randy = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < 20; i++)
            {
                //Trapecio tra = new Trapecio(randy.Next(10, 80), randy.Next(k, 250), k);
                //tra.posX = randy.Next((int)(tra.BaseMayor-tra.BaseMenor), (int)(ElCanvas.ActualWidth - tra.BaseMayor));
                //tra.posY = randy.Next(0, (int)(ElCanvas.ActualHeight - tra.Altura));
                //Figuritas.Add(tra);
                int salio = randy.Next(5);
                switch (salio)
                {
                    case 0:
                        Rectangulo R = new Rectangulo(randy.Next(10, 50), randy.Next(10, 50));
                        R.posX = randy.Next(0, (int)(ElCanvas.ActualWidth - R._base));
                        R.posY = randy.Next(0, (int)(ElCanvas.ActualHeight - R.altura));
                        Figuritas.Add(R);
                        break;
                    case 1:
                        Circulo c = new Circulo(randy.Next(10, 51));
                        c.posX = randy.Next(0, (int)(ElCanvas.ActualWidth - c.radio * 2));
                        c.posY = randy.Next(0, (int)(ElCanvas.ActualHeight - c.radio * 2));
                        Figuritas.Add(c);
                        break;
                    case 2:
                        TrianguloEquilatero te = new TrianguloEquilatero(randy.Next(10, 50));
                        te.posX = randy.Next(0, (int)(ElCanvas.ActualWidth - te.lado));
                        te.posY = randy.Next(0, (int)(ElCanvas.ActualHeight - te.Altura));
                        Figuritas.Add(te);
                        break;
                    case 3:
                        int k = randy.Next(10, 50);
                        Trapecio tra = new Trapecio(randy.Next(10, 30), randy.Next(k, 60), k);
                        tra.posX = randy.Next((int)(tra.BaseMayor - tra.BaseMenor), (int)(ElCanvas.ActualWidth - tra.BaseMayor));
                        tra.posY = randy.Next(0, (int)(ElCanvas.ActualHeight - tra.Altura));
                        Figuritas.Add(tra);
                        break;
                    case 4:
                        int w = randy.Next(10, 50);
                        Rombo rom = new Rombo(randy.Next(w, 60), w);
                        rom.posX = randy.Next(0, (int)(ElCanvas.ActualWidth - rom.DMenor));
                        rom.posY = randy.Next(0, (int)(ElCanvas.ActualHeight - rom.DMayor));
                        Figuritas.Add(rom);
                        break;
                    default:
                        break;
                }

                while (Figuritas[i].DeltaX == 0)
                {
                    Figuritas[i].DeltaX = randy.Next(-3, 4);
                }
                while (Figuritas[i].DeltaY == 0)
                {
                    Figuritas[i].DeltaY = randy.Next(-3, 4);
                }
                
            }
            DibujaTodas();
            Tiempos.Start();
        }

        public void DibujaTodas()
        {
            foreach (FiguraGeometrica figura in Figuritas)
            {
                figura.Dibujate(ElCanvas);
                figura.relleno = new SolidColorBrush(Color.FromRgb((byte)randy.Next(256), (byte)randy.Next(256), (byte)randy.Next(256)));
            }
        }

    }
}
