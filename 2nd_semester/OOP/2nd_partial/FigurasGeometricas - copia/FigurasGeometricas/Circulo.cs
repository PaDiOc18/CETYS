using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows;
using System.Windows.Media;

namespace FigurasGeometricas
{
    class Circulo : FiguraGeometrica
    {
        public double radio { get; set; }
        private Ellipse c;

        public Circulo(int radio) : 
            base("Circulo",1)
        {
            this.radio = radio;
            c = new Ellipse();
            c.Width = 2 * radio;
            c.Height = 2 * radio;
        }

        public override double Area()
        {
            //throw new NotImplementedException();
            return Math.PI * radio * radio;
        }

        public override double Perimetro()
        {
            //throw new NotImplementedException();
            return 2*Math.PI * radio;
        }

        //public override void Animate(Canvas elCanvas)
        //{
        //    base.Animate(elCanvas);
        //    Random randis = new Random(Guid.NewGuid().GetHashCode());
        //    base.Animate(elCanvas);
        //    posX += DeltaX;
        //    posY += DeltaY;
        //    if (posX <= 0 || posX + 2*radio >= elCanvas.ActualWidth)
        //    {
        //        DeltaX = DeltaX * -1;
        //        relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
        //    }
        //    else if (posY <= 0 || posY + 2*radio >= elCanvas.ActualHeight)
        //    {
        //        DeltaY = DeltaY * -1;
        //        relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
        //    }
        //}

        public override void Dibujate(Canvas miCanvas)
        {
            //Random randis = new Random(Guid.NewGuid().GetHashCode());
            //int posX = randis.Next(0, 772-(int)(2*radio));
            //int posY = randis.Next(0, 399 - (int)(2 * radio));

            if (!miCanvas.Children.Contains(c))
            {
                miCanvas.Children.Add(c);
            }
            Canvas.SetTop(c, posY);
            Canvas.SetLeft(c, posX);
            c.Opacity = 0.4;
            c.Stroke = Brushes.Black;
            c.Fill = relleno;
        }

        public override double PosizaoXTotal()
        {
            return 2 * radio;
        }

        public override double PosizaoYTotal()
        {
            return 2 * radio;
        }
    }
}
