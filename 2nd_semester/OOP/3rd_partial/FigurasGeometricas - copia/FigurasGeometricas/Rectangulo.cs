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
    class Rectangulo : FiguraGeometrica
    {
        public double _base { get; set; }
        public double altura { get; set; }
        private Rectangle r;


        public Rectangulo(double _base, double altura) : 
            base("Rectangulo",4)
        {
            this.altura = altura;
            this._base = _base;
            r = new Rectangle();
            r.Height = altura;
            r.Width = _base;
        }

        public override double Perimetro()
        {
            //throw new NotImplementedException();
            return (2 * _base) + (2 * altura);
        }

        public override double Area()
        {
            //throw new NotImplementedException();
            return _base * altura;
        }

        //public override void Animate(Canvas elCanvas)
        //{
        //    Random randis = new Random(Guid.NewGuid().GetHashCode());
        //    base.Animate(elCanvas);
        //    posX += DeltaX;
        //    posY += DeltaY;
        //    if (posX <= 0 || posX + _base >= elCanvas.ActualWidth)
        //    {
        //        DeltaX = DeltaX * -1;
        //        relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
        //    }
        //    else if (posY <= 0 || posY + altura >= elCanvas.ActualHeight)
        //    {
        //        DeltaY = DeltaY * -1;
        //        relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
        //    }
        //}

        public override void Dibujate(Canvas miCanvas)
        {
            //throw new NotImplementedException();
            Random randis = new Random(Guid.NewGuid().GetHashCode());
            //posX = randis.Next(0, 772-(int)_base);
            //posY = randis.Next(0, 399-(int)altura);

            if (!miCanvas.Children.Contains(r))
            {
                miCanvas.Children.Add(r);
            }

            Canvas.SetTop(r, posY);
            Canvas.SetLeft(r, posX);
            r.Fill = relleno;
            r.Opacity = 0.4;
            r.Stroke = Brushes.Black;
        }

        public override double PosizaoXTotal()
        {
            return _base;
        }

        public override double PosizaoYTotal()
        {
            return altura;
        }
    }
}
