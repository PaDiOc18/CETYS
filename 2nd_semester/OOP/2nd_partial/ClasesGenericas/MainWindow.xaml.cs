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

namespace ClasesGenericas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lista<int> lista;

        public MainWindow()
        {
            InitializeComponent();
            lista = new Lista<int>();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregaNodo();
        }

        private void AgregaNodo()
        {
            lista.AgregarNodo(int.Parse(txtInput.Text));
            lblOutput.Content = lista.ToString();
            txtInput.Clear();
            txtInput.Focus();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AgregaNodo();
                Console.WriteLine(lista.ToString());
            }
        }

        private void TxtAgregarNodoIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //lista.AgregarNodoConIndex(int.Parse(txtAgregarNodoIndex.Text), int.Parse(txtIndice.Text));
                lista.Insertameequisde(int.Parse(txtIndice.Text), int.Parse(txtAgregarNodoIndex.Text));
                lblOutput.Content = lista.ToString();
            }
        }

        private void TxtPop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //lista.PopIndex(int.Parse(txtPop.Text));
                lista.PopJerry(int.Parse(txtPop.Text));
                lblOutput.Content = lista.ToString();
            }
        }

        private void TxtRemover_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lista.Remover(int.Parse(txtRemover.Text));
                lblOutput.Content = lista.ToString();
            }
        }

        private void BtnEmpty_Click(object sender, RoutedEventArgs e)
        {
            lista.EstaEmpty();
            if (lista.EstaEmpty() == true)
            {
                MessageBox.Show("ESTA VACÍA");
            }
            else
            {
                MessageBox.Show("SI TIENE NODOS");
            }
        }

        private void TxtContiene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (lista.Contains(int.Parse(txtContiene.Text)) == true)
                {
                    MessageBox.Show("Si lo contiene amigo :)");
                }
                else
                {
                    MessageBox.Show("No lo contiene amigo :(");
                }
            }
        }

        private void TxtCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                lista.Contar(int.Parse(txtCount.Text));
                string hola = lista.Contar(int.Parse(txtCount.Text)).ToString();
                MessageBox.Show("En total hay: " + hola + " veces en los nodos");
            }
        }

        private void TxtArreglo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string[] arreglo = txtArreglo.Text.Split(',');
                int[] ArregloNumeros = new int[arreglo.Length];
                for (int i = 0; i < ArregloNumeros.Length; i++)
                {
                    ArregloNumeros[i] = int.Parse(arreglo[i]);
                    Console.WriteLine(ArregloNumeros[i]);
                }
                lista.Extender(ArregloNumeros);
                lblOutput.Content = lista.ToString();
            }
        }

        private void BtnReverse_Click(object sender, RoutedEventArgs e)
        {
            lista.Reverse();
            lblOutput.Content = lista.ToString();
        }
    }
}
