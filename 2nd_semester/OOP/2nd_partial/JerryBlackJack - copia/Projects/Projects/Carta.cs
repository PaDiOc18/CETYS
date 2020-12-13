using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Projects
{
    class Carta
    {
        public string ImageSource { get; }
        public int Valor { get; set; }
        public bool Mostrar { get; set; }

        public Carta(string ImageSource, int valor)
        {
            this.ImageSource = ImageSource;
            this.Valor = valor;
            Mostrar = true;
        }
        public void Dibujate(Canvas c, int posX, int posY)
        {
           Image i = new Image();
            if (Mostrar)
            {
                i.Source = new BitmapImage(new Uri(ImageSource, UriKind.Relative));
            }
            else
            {
                i.Source = new BitmapImage(new Uri(@"C:\Users\pdiaz\Desktop\JerryBlackJack - copia\Projects\Projects\Imagenes\secreta.jpg"));
            }          
           c.Children.Add(i);
           i.Width = 150;
           i.Height = 250;
           Canvas.SetLeft(i, posX);
           Canvas.SetTop(i,posY);
        }
    }
}
