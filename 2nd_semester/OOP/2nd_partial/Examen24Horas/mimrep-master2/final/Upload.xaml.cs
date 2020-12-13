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
using System.IO;
using Path = System.IO.Path;

namespace final
{
    /// <summary>
    /// Interaction logic for Upload.xaml
    /// </summary>
    public partial class Upload : Window
    {
        public Upload()
        {
            InitializeComponent();
        }
        public int i = 0;
        private void btnImage_Click(object sender, RoutedEventArgs e)
        {
            i++;
            //TEST USER DELETE LATER
            User U = new User("Jack", "Jackinson");

            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            
            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
             
            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document  

                //Filename = SourcePath

                string Target = @"..\..\MemeBase";
                string filename = dlg.FileName;

                //Testing Pushing.
                int j = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0);

                File.Copy(filename, Path.Combine(Target,j.ToString()+".png" ));
                
                U.createPost(txtDescription.Text, filename);
                ImageSourceConverter imgs = new ImageSourceConverter();
                imgMem.SetValue(Image.SourceProperty, imgs.ConvertFromString(filename));
            }
        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            (Owner as MainWindow).Show();
        }

        private void ImageRanking_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            Ranking rk = new Ranking();
            rk.Owner = (Owner as MainWindow);
            rk.Show();
        }

        private void ImageHotOrNot_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            hotOrNot rk = new hotOrNot();
            rk.Owner = (Owner as MainWindow);
            rk.Show();
        }
    }
}
