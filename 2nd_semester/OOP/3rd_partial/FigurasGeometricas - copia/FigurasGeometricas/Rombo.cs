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
    class Rombo : FiguraGeometrica
    {
        public double DMayor { get; set; }
        public double DMenor { get; set; }
        private Polygon r;

        public Rombo(double DMayor, double DMenor) :
            base("Rombo", 4)
        {
            this.DMayor = DMayor;
            this.DMenor = DMenor;
            r = new Polygon();
        }

        public override double Area()
        {
            return (DMayor * DMenor) / 2;
        }

        //public override void Animate(Canvas elCanvas)
        //{
        //    base.Animate(elCanvas);
        //    Random randis = new Random(Guid.NewGuid().GetHashCode());
        //    posX += DeltaX;
        //    posY += DeltaY;
        //    if (posX - DMenor/2 <= 0 || posX + DMayor / 2>= elCanvas.ActualWidth)
        //    {
        //        DeltaX = DeltaX * -1;
        //        relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
        //    }
        //    else if (posY <= 0 || posY + DMayor >= elCanvas.ActualHeight)
        //    {
        //        DeltaY = DeltaY * -1;
        //        relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
        //    }

        //}

        public override void Dibujate(Canvas miCanvas)
        {
            Random randis = new Random(Guid.NewGuid().GetHashCode());
            r.Points.Add(new Point(0, 0));
            r.Points.Add(new Point((DMenor / 2), (DMayor / 2)));
            r.Points.Add(new Point(0, DMayor));
            r.Points.Add(new Point(-(DMenor / 2), (DMayor / 2)));

            //int posX = randis.Next((int)DMenor, 772-(int)DMenor);
            //int posY = randis.Next(0, 399-(int)DMayor);
            if (!miCanvas.Children.Contains(r))
            {
                miCanvas.Children.Add(r);
            }
            Canvas.SetTop(r, posY);
            Canvas.SetLeft(r,posX);
            r.Fill = relleno;
            r.Opacity = 0.4;
            r.Stroke = Brushes.Black;
        }

        public override double Perimetro()
        {
            double aux = DMayor / 2;
            double aux2 = DMenor / 2;
            double perimetro = Math.Pow(aux, 2) + Math.Pow(aux2, 2);
            perimetro = Math.Sqrt(perimetro);
            return perimetro;
        }

        public override double PosizaoXTotal()
        {
            return DMenor;
        }

        public override double PosizaoYTotal()
        {
            return DMayor;
        }
    }
}
