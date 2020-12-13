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

        public Random randis = new Random(Guid.NewGuid().GetHashCode());

        public FiguraGeometrica(string Nombre, int Lados)
        {
            this.Lados = Lados;
            this.Nombre = Nombre;
            this.DeltaX = 1;
            this.DeltaY = 2;
        }

        public FiguraGeometrica(string Nombre, int Lados, double posX, double posY) :
            this(Nombre, Lados)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public virtual void Animate(Canvas elCanvas)
        {
            this.posX += DeltaX;
            this.posY += DeltaY;
            if (this.posX <= 0 || this.posX >= elCanvas.ActualWidth)
            {
                this.DeltaX = DeltaX * -1;
                this.relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
            }
            else if (this.posY <= 0 || this.posY >= elCanvas.ActualHeight)
            {
                this.DeltaY = DeltaY * -1;
                this.relleno = new SolidColorBrush(Color.FromRgb((byte)randis.Next(256), (byte)randis.Next(256), (byte)randis.Next(256)));
            }
            Dibujate(elCanvas);
        } 

        public abstract double Perimetro();
        public abstract double Area();

        public abstract void Dibujate(Canvas miCanvas);
    }
}
