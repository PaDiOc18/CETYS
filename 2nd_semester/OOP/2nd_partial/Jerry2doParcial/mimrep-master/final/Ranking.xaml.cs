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
    /// Interaction logic for Ranking.xaml
    /// </summary>
    public partial class Ranking : Window
    {
        public bool verify = true;
        public List<Post> ListBestPosts;
        public List<User> ListBestUsers;
        public User CurrentUser;
        private List<User> AllUsers; //Lista temporal para recorrerla y encontrar 

        public Ranking()
        {
            InitializeComponent();
            AllUsers = new List<User>();//Debemos deserializar el archivo y meter la lista de todos los usuarios aquí
            //La lista de los mejores Post
            ListBestPosts = new List<Post>();//Las mejores 
            //this.CurrentUser = CurrentUser; //Igualamos para recuperar el usuario
        }

        public void SortPosts()
        {
            foreach (var User in AllUsers)
            {
                for (int i = 0; i < User.getPosts().Count; i++)
                {
                    if (User.getPosts()[i].score >= 10)
                    {
                        ListBestPosts.Add(User.getPosts()[i]);
                        ListBestUsers.Add(User); //Agregar Usuario
                    }
                }
            }
            foreach (var Post in ListBestPosts)
            {
                ListBoxPosts.Items.Add(Post);
            }
        }


        // UI Fixes
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (verify == true) this.Owner.Show();
        }

        private void Imghotnot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verify = false;
            Utils.HORN(rankingwindow);   
        }

        private void Lblupload_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verify = false;
            Utils.Uploadwin(rankingwindow);
        }

        private void ListBoxPosts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //int Index = 0;
            if (ListBoxPosts.SelectedIndex != -1)
            {
                //Index = ListBoxPosts.SelectedIndex;
                //MessageBox.Show("El índice es: " + Index);
                ShowPost sp = new ShowPost(ListBestUsers[ListBoxPosts.SelectedIndex], ListBestPosts[ListBoxPosts.SelectedIndex]);
                sp.Show();
                sp.Owner = this;
                this.Hide();
            }
            ListBoxPosts.SelectedIndex = -1;
        }
    }
}
