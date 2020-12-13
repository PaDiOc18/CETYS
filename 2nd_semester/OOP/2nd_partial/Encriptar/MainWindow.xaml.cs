using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography; //Para enecriptar
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
using System.Xml.Serialization;

namespace Encriptar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEncriptar_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = EncriptaClave();

            XmlSerializer xs = new XmlSerializer(typeof(User));
            FileStream fs = new FileStream("Users.xml", FileMode.OpenOrCreate);
            User nuevousuario = new User();
            nuevousuario.Nickname = txtUser.Text;
            nuevousuario.Passwordhash = sb.ToString();
            xs.Serialize(fs, nuevousuario);
            fs.Close();
        }

        private StringBuilder EncriptaClave()
        {
            string clave = txtPassword.Password;
            clave += "Big Chungus Reconoce Arreglos.";
            SHA512 sha = SHA512.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(clave));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            lblEncriptado.Content = sb.ToString();
            sha.Dispose();
            return sb;
        }

        private void BtnValida_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = EncriptaClave();
            XmlSerializer xs = new XmlSerializer(typeof(User));
            FileStream fs = new FileStream("Users.xml", FileMode.Open);
            User u = (User)xs.Deserialize(fs);
            fs.Close();
            if (u.Passwordhash == sb.ToString())
            {
                lblEncriptado.Content = "Si entras compa";
            }
            else
            {
                lblEncriptado.Content = "No jala tu contra compa";
            }
        }
    }
}
