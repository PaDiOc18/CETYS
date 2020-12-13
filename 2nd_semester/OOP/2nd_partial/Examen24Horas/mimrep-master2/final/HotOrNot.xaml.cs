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
        public hotOrNot()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void ImageRanking_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Ranking rk = new Ranking();
            rk.Owner = (Owner as MainWindow);
            rk.Show();
        }

        private void ImageUpload_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Upload up = new Upload();
            up.Owner = (Owner as MainWindow);
            up.Show();
        }
    }
}
