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
using System.Windows.Shapes;

namespace final
{
    /// <summary>
    /// Interaction logic for hotOrNot.xaml
    /// </summary>
    public partial class hotOrNot : Window
    {
        bool verify = true;
        public hotOrNot()
        {
            InitializeComponent();
        }

        // UI Fixes
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (verify) this.Owner.Show();
        }

        private void Imgranking_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { 
            verify = false;
            Utils.Rankingwin(HotOrNotwindow);
        }

        private void Imgupload_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verify = false;
            Utils.Uploadwin(HotOrNotwindow);
        }
    }
}
