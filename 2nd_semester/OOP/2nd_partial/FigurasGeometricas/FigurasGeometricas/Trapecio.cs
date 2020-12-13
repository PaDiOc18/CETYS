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
    class Trapecio : FiguraGeometrica
    {
        public double Altura { get; set; }
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        private Polygon p;

        public Trapecio(double Altura, double BaseMayor, double BaseMenor) :
            base("Trapecio", 4)
        {
            this.Altura = Altura;
            this.BaseMayor = BaseMayor;
            this.BaseMenor = BaseMenor;
            p = new Polygon();
        }
        public double lado
        {
            get
            {
                double ladiux = 0;
                ladiux = Math.Pow(Altura, 2) + Math.Pow((BaseMayor - BaseMenor), 2);
                ladiux = Math.Sqrt(ladiux);
                return ladiux;
            }
        }
        public override double Area()
        {
            return ((BaseMayor + BaseMenor) * Altura) / 2;
        }

        public override void Animate(Canvas elCanvas)
        {
            base.Animate(elCanvas);

            base.Animate(elCanvas);
            posX += DeltaX;
            posY += DeltaY;
            if (posX -(BaseMayor - BaseMenor) <= 0 || posX + BaseMayor >= elCanvas.ActualWidth)
            {
                DeltaX = DeltaX * -1;
                relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
            }
            else if (posY <= 0 || posY + Altura >= elCanvas.ActualHeight)
            {
                DeltaY = DeltaY * -1;
                relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
            }

        }

        public override void Dibujate(Canvas miCanvas)
        {
            int diferencia = int.Parse((BaseMayor - BaseMenor).ToString());          
            p.Points.Add(new Point(0, 0));
            p.Points.Add(new Point(BaseMenor, 0));
            p.Points.Add(new Point(BaseMenor+diferencia, Altura));
            p.Points.Add(new Point(-diferencia,Altura));

            Random randis = new Random(Guid.NewGuid().GetHashCode());
            //int posX = randis.Next(diferencia, 772 - (int)BaseMayor);
            //int posY = randis.Next((int)Altura, 399 - (int)Altura);
            if (!miCanvas.Children.Contains(p))
            {
                miCanvas.Children.Add(p);
            }
            Canvas.SetTop(p, posY);
            Canvas.SetLeft(p, posX);
            p.Fill = relleno;
            p.Stroke = Brushes.Black;
            p.Opacity = 0.4;
        }

        public override double Perimetro()
        {
            return (BaseMenor + BaseMenor + (2 * lado));
        }
    }
}
