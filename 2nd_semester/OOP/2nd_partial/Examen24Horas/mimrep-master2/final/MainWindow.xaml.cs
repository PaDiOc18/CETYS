using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<User> users { get; set; } = new List<User>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtusername_GotFocus(object sender, RoutedEventArgs e)
        {
            txtusername.Text = string.Empty;
        }

        private void lblregister_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Register r = new Register();
            r.Owner = this;
            r.Show();
            this.Hide();
        }


        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (txtusername.Text == users[i].username && Utils.EncryptClave(txtpassword.Password) == users[i].password)
                {
                    hotOrNot h = new hotOrNot();
                    h.Owner = this;
                    h.Show();                 
                    this.Hide();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            File.Create("data.json");
            if(new FileInfo("data.json").Length > 0)
            {
                users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("data.json"));
            }
        }
    }
}
