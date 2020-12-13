using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Clases_Estaticas
{
    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double X, double Y)
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
            Canvas.SetBottom(e, Y); //Desde abajo empieza a contar con bottom Y con top es desde arriba
            Canvas.SetLeft(e, X);
            e.Stroke = Brushes.BlanchedAlmond;
        }

        public bool EsLatice()
        {
            if (X/ (int)X == 1 && Y/(int)Y == 1)
            {
                return true;
            }        
            return false;
        }

        private Brush TipoPunto()
        {
            if (X%2 == 0 && Y%2 == 0)
            {
                return Brushes.White;
            }
            else if (X % 2 == 0 && Y % 2 == 1)
            {
                return Brushes.Red;
            }
            else if (X % 2 == 1 && Y % 2 == 0)
            {
                return Brushes.Fuchsia;
            }
            else
            {
                return Brushes.Blue;
            }
        }


        public static Punto CreaPuntoRandom(double maxX, double maxY)
        {
            Random randy = new Random(Guid.NewGuid().GetHashCode());
            Punto p = new Punto(randy.Next(0, (int)maxX), randy.Next(0, (int)maxY));
            return p;
        }
    }
}
