using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace Tower
{
    class Disco
    {
        public int Posicion { get; set; }
        public int Tamaño { get; set;  }
        private Brush Colorcito { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        private Rectangle r;

        public Disco(int posX, int posY, int Tamaño, Brush Colorcito)
        {
            r = new Rectangle();
            this.posX = posX;
            this.posY = posY;
            this.Tamaño = Tamaño;
            this.Colorcito = Colorcito;
            
        }

        public void Quitar()
        {

        }

        public void Apilar()
        {

        }

        public void DibujaDisco(Canvas canvitas)
        {
            r.Fill = Colorcito;
            r.Width = Tamaño;
            r.Height = 20;
            Canvas.SetTop(r,posY);
            Canvas.SetLeft(r,posX);
            canvitas.Children.Add(r);
            r.Stroke = Brushes.Black;
            
        }

    }
}
