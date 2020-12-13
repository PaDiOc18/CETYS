using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Tower
{
    class Torre
    {
        public int posX { get; }
        public int posY { get; }
        public int Discos { get; set; }
        public double alto { get;  set; }
           
        public Torre(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public double Alto
        {
            get
            {
                return alto;
            }
        }

        public void Dibuja(Canvas elCanvas)
        {
            //Vertical
            Rectangle r = new Rectangle();
            r.Fill = Brushes.Brown;
            r.Height = elCanvas.ActualHeight / 2;
            r.Width = elCanvas.ActualWidth / 40;

            //Horizontal
            Rectangle r2 = new Rectangle();
            r2.Fill = Brushes.Brown;
            r2.Height = elCanvas.ActualHeight / 20;
            r2.Width = elCanvas.ActualWidth / 4;

            alto = r.Height;

            r.Stroke = Brushes.Black;
            r2.Stroke = Brushes.Black;
            Canvas.SetLeft(r, posX);
            Canvas.SetTop(r, posY);
            Canvas.SetLeft(r2, posX - (r2.Width/2 - r.Width/2));
            Canvas.SetTop(r2, posY + (r.Height - r2.Height));
            elCanvas.Children.Add(r);
            elCanvas.Children.Add(r2);
        }
    }
}
