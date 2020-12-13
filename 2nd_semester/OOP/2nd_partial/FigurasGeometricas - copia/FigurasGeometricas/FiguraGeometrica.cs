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
    abstract class FiguraGeometrica
    {
        public string Nombre { get; set; }
        public int Lados { get; set; }
        public double posX { get; set; }
        public double posY { get; set; }

        public double DeltaX { get; set; }
        public double DeltaY { get; set; }
        public Brush relleno { get; set; }

        public FiguraGeometrica(string Nombre, int Lados)
        {
            this.Lados = Lados;
            this.Nombre = Nombre;
            this.DeltaX = 0;
            this.DeltaY = 0;
        }

        public FiguraGeometrica(string Nombre, int Lados, double posX, double posY) :
            this(Nombre, Lados)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public virtual void Animate(Canvas elCanvas)
        {
            Random randis = new Random(Guid.NewGuid().GetHashCode());
            if (posX + DeltaX <= 0 || posX + DeltaX >= elCanvas.ActualWidth - PosizaoXTotal())
            {
                DeltaX = DeltaX * -1;
                relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
            }
            else if (posY +  DeltaY <= 0 || posY + DeltaY >= elCanvas.ActualHeight - PosizaoYTotal())
            {
                DeltaY = DeltaY * -1;
                relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
            }
            posX += DeltaX;
            posY += DeltaY;
            Dibujate(elCanvas);
        } 

        public abstract double Perimetro();
        public abstract double Area();

        public abstract void Dibujate(Canvas miCanvas);

        public abstract double PosizaoXTotal();

        public abstract double PosizaoYTotal();
    }
}
