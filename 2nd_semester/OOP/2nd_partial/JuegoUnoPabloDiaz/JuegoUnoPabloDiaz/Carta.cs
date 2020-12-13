using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace JuegoUnoPabloDiaz
{
    class Carta
    {
        //public string ImageSource { get; }

        public int Valor { get; set; }
        public string Color { get; set; }
        public bool MostrarONo { get; set; }

        public Carta(string Color, int valor) //int valor, string Color
        {
            //this.ImageSource = ImageSource;
            this.Valor = Valor;
            this.Color = Color;
            MostrarONo = true;
        }
        //public void Dibujate(Canvas c, int posX, int posY)
        //{
        //    Image i = new Image();
        //    if (MostrarONo == true)
        //    {
        //        i.Source = new BitmapImage(new Uri(ImageSource, UriKind.Relative));
        //    }
        //    else
        //    {
        //        i.Source = new BitmapImage(new Uri(@"Imagenes\Oculta.jpg"));
        //    }
        //    c.Children.Add(i);
        //    i.Width = 150;
        //    i.Height = 250;
        //    Canvas.SetLeft(i, posX);
        //    Canvas.SetTop(i, posY);
        //}
    }
}
