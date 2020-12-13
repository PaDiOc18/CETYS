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
    /// Interaction logic for Nodin.xaml
    /// </summary>
    public partial class Nodin : UserControl
    {


        public Nodin()
        {
            InitializeComponent();

        }

        public string Text
        {
            get { return Numerito.Content.ToString(); }
            set { Numerito.Content = value; }
        }

        public SolidColorBrush Colore
        {
            get
            {
                return (SolidColorBrush)circulo.Fill;
            }
            set
            {
                circulo.Fill = value;
            }
        }

    }
}
