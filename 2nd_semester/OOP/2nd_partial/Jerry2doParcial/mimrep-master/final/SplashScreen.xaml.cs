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
using System.Windows.Threading;

namespace final
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();
        int cont = 0;
        public SplashScreen()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;
            progressbar.Maximum = 3;
            Timer.Interval = new TimeSpan(5000000);
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressbar.Value += cont;
            cont++;
            if (cont == 4)
            {
                MainWindow mw = new MainWindow();
                mw.Show();

                Timer.Stop();
                this.Close();
            }
          
        }
    }
}
