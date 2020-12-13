using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Stacks
{
    class Nodo2
    {
        public int Value { get; set; }
        public Nodo2 Left {get;set;}
        public Nodo2 Right { get; set; }
        //Modificado
        public int posX { get; set; }
        public int posY { get; set; }


        private Nodin n;


        public Nodo2 (int Value, Nodo2 Left, Nodo2 Right) : this (Value)
        {
            this.Value = Value;
            this.Left = Left;
            this.Right = Right;
        }

        public Nodo2 (int Value)
        {
            this.Value = Value;
            n = new Nodin();
        }

        public void AgregaHijo (Nodo2 nuevo)
        {
            if (nuevo.Value > this.Value)
            {
                if (this.Right is null)
                {
                    this.Right = nuevo;
                }
                else
                {
                    this.Right.AgregaHijo(nuevo);
                }
            }
            else
            {
                if (this.Left is null )
                {
                    this.Left = nuevo;
                }
                else
                {
                    this.Left.AgregaHijo(nuevo);
                }
            }
        }

        public void Dibujate(Canvas elCanvas)
        { 
            n.Numerito.Content = this.Value;
            if (!elCanvas.Children.Contains(n))
            {
                elCanvas.Children.Add(n);
            }
            Canvas.SetLeft(n, this.posX);
            Canvas.SetTop(n, this.posY);
            //n.Opacity = 0.5;
        }
    }

}
