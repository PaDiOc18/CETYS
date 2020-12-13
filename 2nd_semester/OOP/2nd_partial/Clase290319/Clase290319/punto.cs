using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Clase290319
{
    class punto
    {
        public double X { get; set; }

        public double Y { get; set; }

        public punto (double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Dibujate(Canvas elCanvas)
        {
            Ellipse e = new Ellipse();
            e.Height = 10;
            e.Width = 10;
            e.Fill = TipoPunto();
            elCanvas.Children.Add(e);
            Canvas.SetTop(e, Y);
            Canvas.SetLeft(e, X);
            e.Stroke = Brushes.BlanchedAlmond;
        }
        public bool EsLattice()
        {
            return X == (int)X && Y == (int)Y;
        }

        private Brush TipoPunto()
        {
            if (X%2 == 0 && Y%2==0)
            {
                return Brushes.Black;
            }
            else if (X % 2 == 0 && Y % 2==1)
            {
                return Brushes.RosyBrown;
            }
            else if (X % 2 == 1 && Y % 2 == 0)
            {
                return Brushes.Fuchsia;
            }
            else
            {
                return Brushes.Red;
            }
        }
        public static punto CreaPuntoRandom(double maxX, double maxY)
        {
            Random randy = new Random(Guid.NewGuid().GetHashCode());
            punto p = new punto(randy.Next(0, (int)maxX), randy.Next(0, (int)maxY));
            return p;
        }
    }
}
