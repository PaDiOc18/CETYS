using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private string EncryptClave()
        {
            string clave = txtpassword.Password;
            clave += "smallchungus";
            SHA512 sha = SHA512.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(clave));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            sha.Dispose();
            return sb.ToString();
        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            if (txtpassword.Password == txtpassword1.Password && txtpassword.Password != string.Empty && txtpassword1.Password != string.Empty)
            {
                var temp = (Owner as MainWindow).users;
                for (int i = 0; i < temp.Count; i++)
                {
                    if(temp[i].username == txtusername.Text)
                    {
                        MessageBox.Show("Username already exists");
                        return;
                    }
                }

                User u = new User(txtusername.Text, EncryptClave());
                temp.Add(u);
                string data = JsonConvert.SerializeObject(temp);
                File.WriteAllText("data.json", data);
                this.Close();
            }
            else
            {
                MessageBox.Show("User can not be created");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
