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
    class TrianguloEquilatero : FiguraGeometrica
    {
        public double lado { get; set; }
        private Polygon p;
        private int angulo;
        public TrianguloEquilatero(double lado) :
            base("Triángulo Equilatero",3)
        {
            this.lado = lado;
            p = new Polygon();
            p.Points.Add(new Point(lado / 2, 0));
            p.Points.Add(new Point(0, Altura));
            p.Points.Add(new Point(lado, Altura));
            angulo = 0;
        }

        public override double Area()
        {
            //throw new NotImplementedException();
           
            return (lado * Altura) / 2;
        }

        public double Altura
        {
            get{
                double lado2 = lado / 2;
                double Suma = Math.Pow(lado, 2) + Math.Pow(lado2, 2);
                double altura = Math.Sqrt(Suma);
                return altura;
            }         
        }

        public override double Perimetro()
        {
            //throw new NotImplementedException();
            return lado * 3;
        }

        public override void Animate(Canvas elCanvas)
        {
            base.Animate(elCanvas);
            angulo = (angulo - 1) % 360;
            p.RenderTransform = new RotateTransform(angulo, lado / 2, Altura / 2);
        }

        public override void Dibujate(Canvas miCanvas)
        {
            //Random randis = new Random(Guid.NewGuid().GetHashCode());
            ////posX = randis.Next(0, 772-(int)lado);
            ////posY = randis.Next(0, 399-(int)Altura);
            if (!miCanvas.Children.Contains(p))
            {
                miCanvas.Children.Add(p);
            }
            Canvas.SetTop(p, posY);
            Canvas.SetLeft(p, posX);
            p.Fill = relleno;
            p.Opacity = 0.4;
            p.Stroke= Brushes.Black;

        }

        public override double PosizaoXTotal()
        {
            return lado;
        }

        public override double PosizaoYTotal()
        {
            return Altura;
        }
    }
}
