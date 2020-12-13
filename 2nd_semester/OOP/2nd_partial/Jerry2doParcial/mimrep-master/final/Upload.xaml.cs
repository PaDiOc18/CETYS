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
        bool verify = true;
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

        // UI Fixes
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (verify) this.Owner.Show();
        }

        private void Imgranking_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verify = false;
            Utils.Rankingwin(uploadwindow);
        }

        private void Imghotornot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verify = false;
            Utils.HORN(uploadwindow);
        }
    }
}
