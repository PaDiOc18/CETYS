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

namespace clases1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        persona[] personas = new persona[10];
        int cuantas = 0;
        // es una variable de la clase 
        // el constructor indica las reglas de lo que es indispensable para crear una persona

        public MainWindow()
        {
            InitializeComponent();
            //j = new persona("Pablo", "Díaz", new DateTime(1999,09,27));
            //persona x = new persona("fofo", "Mauricio", "Romero", new DateTime(1999, 12, 01));
          


        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //etiqueta.Content = j.edad();
            string Nom = txtNombre.Text;
            string Apater = txtAP.Text;
            string Amater = txtAM.Text;
            DateTime fechita = (DateTime)DP.SelectedDate;
            persona p = new persona(Nom, Apater, Amater, fechita);
            personas[cuantas] = p;
            cuantas++;
            listwiewjeje.
        }
    }
}
