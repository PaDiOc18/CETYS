using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace Clase290319
{

    class Linea
    {
        public double longitud { get; set; }
        public int posX1 { get; set; }
        public int posX2 { get; set; }
        public int posY1 { get; set; }
        public int posY2 { get; set; }
        Line lain;

        public Linea(int posX1, int posX2, int posY1, int posY2)
        {
            this.longitud = longitud;
            this.posX1 = posX1;
            this.posX2 = posX2;
            this.posY1 = posY1;
            this.posY2 = posY2;
            lain = new Line();
            lain.Stroke = Brushes.Black;
            lain.X1 = posX1;
            lain.X2 = posX2;
            lain.Y1 = posY1;
            lain.Y2 = posY2;
        }

        public void DibujaLinea(Canvas canviux)
        {
            if (!canviux.Children.Contains(lain))
            {
                canviux.Children.Add(lain);
            }
            lain.StrokeThickness = 2;
        }

        public double CalculaLongitud()
        {
           double equiscuadrada = Math.Pow(lain.X2 - lain.X1, 2);
           double yiescuadrada = Math.Pow(lain.Y2 - lain.Y1, 2);
           longitud = Math.Sqrt(equiscuadrada + yiescuadrada);
           return longitud;
        }
    }
}
