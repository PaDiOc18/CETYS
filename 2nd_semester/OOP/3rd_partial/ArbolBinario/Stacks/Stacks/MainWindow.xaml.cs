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

namespace Stacks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AB2 bt;
        int v = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            bt = new AB2();

            //int v = 0;
            Random r = new Random(Guid.NewGuid().GetHashCode());
            //bt.AddNode(5);
            //bt.AddNode(3);
            //bt.AddNode(12);
            //bt.AddNode(2);
            //bt.AddNode(4);
            //bt.AddNode(10);
            //bt.AddNode(14);
            //bt.AddNode(1);
            //bt.AddNode(9);
            //bt.AddNode(11);

            bt.AddNode(20);
            bt.AddNode(10);
            bt.AddNode(30);
            bt.AddNode(5);
            bt.AddNode(15);
            bt.AddNode(25);
            bt.AddNode(40);
            bt.AddNode(2);
            bt.AddNode(9);
            bt.AddNode(14);
            bt.AddNode(17);
            bt.AddNode(24);
            bt.AddNode(28);
            bt.AddNode(35);
            bt.AddNode(50);


            //lblArbolInicial.Content = "5,3,12,2,4,10,14,1,9,11";

            //for (int i = 0; i < 10; i++)
            //{
            //    v = r.Next(1, 20);
            //    bt.AddNode(v);
            //    lblArbolInicial.Content = lblArbolInicial.Content + (v + ", ");
            //}



            //List<Nodo2> losnodoswe = new List<Nodo2>();
            //Nodo2 n1 = new Nodo2(5);
            //losnodoswe.Add(n1);
            //Nodo2 n2 = new Nodo2(3);
            //losnodoswe.Add(n2);
            //Nodo2 n3 = new Nodo2(12);
            //losnodoswe.Add(n3);
            //Nodo2 n4 = new Nodo2(2);
            //losnodoswe.Add(n4);
            //Nodo2 n5 = new Nodo2(4);
            //losnodoswe.Add(n5);
            //Nodo2 n6 = new Nodo2(10);
            //losnodoswe.Add(n6);
            //Nodo2 n7 = new Nodo2(14);
            //losnodoswe.Add(n7);
            //Nodo2 n8 = new Nodo2(1);
            //losnodoswe.Add(n8);
            //Nodo2 n9 = new Nodo2(9);
            //losnodoswe.Add(n9);
            //Nodo2 n10 = new Nodo2(11);
            //losnodoswe.Add(n10);

            bt.DibujaArbol(elCanvas);
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            int num;
            int.TryParse(txtBuscar1.Text, out num);
            lblXD.Content = bt.Busqueda(num) ? "Si esta" : "No esta"; // es un if :))))))
            txtBuscar1.Clear();
        }

        private void btnOrden_Click(object sender, RoutedEventArgs e)
        {
            //Orden (Izq, Nodo, Derecha)
            Nodo2 Padre = bt.raiz;
            Nodo2 Temporal = bt.raiz;
            while (!(Padre.Left is null))
            {
                Padre = Padre.Left;
                //CadenaInOrder = CadenaInOrder + Padre;
            }
            //MessageBox.Show(Padre.Value.ToString());
            //EnOrden(Padre);
            //bt.EnOrden();


            MessageBox.Show(bt.EnOrden());
            //MessageBox.Show(bt.Order());
        }

        private void Pre_Orden_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(bt.PreOrden());
            MessageBox.Show(bt.PreOrden());
        }

        private void Post_Orden_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(bt.PostOrden());
            MessageBox.Show(bt.Post());
        }

        private void Hojas_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(bt.ValoresHojas());
            MessageBox.Show(bt.HojasJerry());
            ///Nodo2 n = new Nodo2(8);
            //n.Dibujate(elCanvas, y, x);
            //x = x + 50; y = y + 50;
            

        }
    }
}
 