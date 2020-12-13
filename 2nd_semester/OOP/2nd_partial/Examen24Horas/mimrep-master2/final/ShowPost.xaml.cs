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
    /// Lógica de interacción para ShowPost.xaml
    /// </summary>
    public partial class ShowPost : Window
    {

        private User CurrentUser;
        private Post BestPost;
        public ShowPost(User CurrentUser, Post BestPost)
        {
            this.CurrentUser = CurrentUser;
            this.BestPost = BestPost;
            InitializeComponent();
            ImagePost.Source = new BitmapImage(new Uri(BestPost.imageRoute, UriKind.Relative));
            lblUser.Content = CurrentUser.username;
            lblVotes.Content = BestPost.score;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
