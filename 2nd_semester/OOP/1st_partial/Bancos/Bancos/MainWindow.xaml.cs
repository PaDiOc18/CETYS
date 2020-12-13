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

namespace Bancos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnMiBoton_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
            string leyo = txtContenido.Text;
            lblContenido.Content = leyo;
            txtContenido.Text = string.Empty;
            bool resultado = Problema9(leyo);
            //lblContenido.Content = resultado;
            if (resultado)
            {
                lblContenido.Content = "Esta en orden";
            }
            else
            {
                lblContenido.Content = "No esta en orden";
            }
        }
        private bool Problema9(string palabra)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                if ((int)palabra[i] >(int)palabra[i+1])
                {
                    return false;

                }
            }
            return true;
        }
    }
}
