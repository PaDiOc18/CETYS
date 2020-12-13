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

namespace CalculadoraPabloLola
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double Numero1;
        public double Numero2;
        public string operacion;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "0";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "1";
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "2";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "3";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "4";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "5";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "6";
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "7";
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "8";
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + "9";
        }

        private void BtnPunto_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = txtCuenta.Text + ".";
        }

        private void BtnMas_Click(object sender, RoutedEventArgs e)
        {
            Numero1 = GeneraNumero();
            operacion = "sumar";
        }

        private void BtnMenos_Click(object sender, RoutedEventArgs e)
        {
            Numero1 = GeneraNumero();
            operacion = "restar";
        }

        private void BtnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            Numero1 = GeneraNumero();
            operacion = "multiplicar";
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            Numero1 = GeneraNumero();
            operacion = "dividir";
        }

        private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtCuenta.Text = null;
            Numero1 = 0;
            Numero2 = 0;
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public double GeneraNumero()
        {
            string Cadena = null;
            if (!(txtCuenta.Text == null))
            {
                Cadena = txtCuenta.Text;
                double numero;
                double regresa = 0;
                if (double.TryParse(Cadena, out numero))
                {
                    regresa = double.Parse(Cadena);
                    txtCuenta.Text = null;
                    return regresa;
                }
                else
                {
                    MessageBox.Show("No es númerico");
                }
            }
            else
            {
                MessageBox.Show("Está Vacío");
            }
            txtCuenta.Text = null;
            return 0;
        }

        private void BtnIgual_Click(object sender, RoutedEventArgs e)
        {
            double resultado = 0;
            Numero2 = GeneraNumero();
            if (operacion=="sumar")
            {
                resultado = Numero1 + Numero2;
            }
            else if (operacion =="restar")
            {
                resultado = Numero1 - Numero2;
            }
            else if (operacion == "multiplicar")
            {
                resultado = Numero1 * Numero2;
            }
            else if (operacion == "dividir")
            {
                resultado = Numero1 / Numero2;
            }
            txtCuenta.Text = resultado.ToString();
            resultado = 0;
            operacion = "";
        }
    }
}
