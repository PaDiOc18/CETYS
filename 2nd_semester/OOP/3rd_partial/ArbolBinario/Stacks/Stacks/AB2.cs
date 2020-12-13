using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Stacks
{
    class AB2
    {
        public Nodo2 raiz { get; set; }
        public void AddNode(Nodo2 Nuevo)
        {
            if (raiz is null)
            {
                raiz = Nuevo;
            }
            else
            {
                raiz.AgregaHijo(Nuevo);
            }

        }

        public bool Busqueda(int valor)
        {
            Nodo2 actual = raiz;

            while (!(actual is null))
            {
                if (valor == actual.Value)
                {
                    return true;
                }
                if (valor > actual.Value)
                {
                    actual = actual.Right;
                }
                else
                {
                    actual = actual.Left;
                }
            }
            return false;

        }

        public void AddNode(int value)
        {
            AddNode(new Nodo2(value));
        }

        string Cadenilla = "";
        public string EnOrden()
        {
            Cadenilla = "";
            if (raiz != null)
            {
                EnOrden2(raiz);
            }
            return Cadenilla;
        }

        public void EnOrden2(Nodo2 Nodito)
        {
            //Izquierda, Nodo, Derecha
            if (Nodito != null)
            {
                EnOrden2(Nodito.Left);
                Cadenilla = Cadenilla + Nodito.Value + ",";
                EnOrden2(Nodito.Right);
            }
        }

        string Cadenilla2 = "";
        public string PreOrden()
        {
            Cadenilla2 = "";
            if (raiz != null)
            {
                PreOrden2(raiz);
            }
            return Cadenilla2;
        }

        public void PreOrden2(Nodo2 Padre)
        {
            //Nodo,Izquierda,Derecha
            if (Padre != null)
            {
                Cadenilla2 = Cadenilla2 + Padre.Value + ",";
                PreOrden2(Padre.Left);
                PreOrden2(Padre.Right);
            }
        }

        string Cadenilla3 = "";
        public string PostOrden()
        {
            Cadenilla3 = "";
            if (raiz != null)
            {
                PostOrden2(raiz);
            }
            return Cadenilla3;
        }

        public void PostOrden2(Nodo2 Padre)
        {
            //Izquierda, Derecha, Nodo
            if (Padre != null)
            {
                PostOrden2(Padre.Left);
                PostOrden2(Padre.Right);
                Cadenilla3 = Cadenilla3 + Padre.Value + ",";
            }
        }

        string Cadenilla4 = "";
        public string ValoresHojas()
        {
            Cadenilla4 = "";
            if (raiz != null)
            {
                Hojas(raiz);
            }
            return Cadenilla4;
        }

        public void Hojas(Nodo2 Nodito)
        {
            if (Nodito != null)
            {
                Hojas(Nodito.Left);
                Hojas(Nodito.Right);
                Console.WriteLine("Nodo Actual: " + Nodito.Value);
                if (Nodito.Left != null)
                {
                    Console.WriteLine("Nodo Hijo Izquierda: " + Nodito.Left.Value);
                }
                if (Nodito.Right != null)
                {
                    Console.WriteLine("Nodo Hijo Derecha: " + Nodito.Right.Value);
                }
                Console.WriteLine("_____________________________________________");
                if (Nodito.Left == null & Nodito.Right == null)
                {
                    Cadenilla4 = Cadenilla4 + Nodito.Value + ",";
                }
            }
        }

        public void Trans(Nodo2 Nodo, ref string printed, string type)
        {
            if (!(Nodo is null))
            {
                if (type == "pre")
                {
                    printed += Nodo.Value.ToString() + " ";
                }
                Trans(Nodo.Left, ref printed, type);
                if (type == "orden")
                {
                    printed += Nodo.Value.ToString() + " ";
                }
                Trans(Nodo.Right,ref printed, type);
                if (type == "post")
                {
                    printed += Nodo.Value.ToString() + " ";
                }
                if (type=="Hojas" && Nodo.Left is null && Nodo.Right is null)
                {
                    printed += Nodo.Value.ToString() + " ";
                }
            }
        }

        public string PreOrder()
        {
            string result = string.Empty;
            Trans(this.raiz, ref result, "pre");
            return result;
        }

        public string Order()
        {
            string result = string.Empty;
            Trans(this.raiz, ref result, "orden");
            return result;
        }

        public string Post()
        {
            string result = string.Empty;
            Trans(this.raiz, ref result, "post");
            return result;
        }

        public string HojasJerry()
        {
            string result = string.Empty;
            Trans(this.raiz, ref result, "Hojas");
            return result;
        }


        public void DibujaArbol(Canvas elCanvas)
        {
            int y = 0;
            int x = 960 / 2;
            int distancia = 220;
            if (this.raiz != null)
            {
                DibujatePreOrden(elCanvas, this.raiz, ref x, ref y, distancia);
                DibujaLineas(elCanvas, this.raiz);
            }
        }

        int conta = 0;
        public void DibujatePreOrden(Canvas elCanvas, Nodo2 Padre, ref int lax, ref int lay, int distancia)
        {

            if (!(Padre is null))
            {
                //if (Padre.Left != null || Padre.Right !=null)
                //{
                //    niveles++;
                //    lax = lax + 120;
                //}
                Padre.posX = lax;
                Padre.posY = lay;
                Padre.Dibujate(elCanvas);
                conta++;
                //Console.WriteLine("El nodo " + conta + " con valor: " + Padre.Value );
                //Console.WriteLine("Tiene una posicion en x de: " + lax);
                //Console.WriteLine("Tiene una posicion en y de : " + lay);
                if (Padre.Left != null)
                {
                    lay = Padre.posY + 80;
                    lax = Padre.posX - distancia;
                    Padre.Left.posX = lax;
                    Padre.Left.posY = lay;
                    
                    //Linea l = new Linea(Padre.posX, Padre.Left.posX, Padre.posY, Padre.Left.posY);
                    //l.DibujaLinea(elCanvas);
                    DibujatePreOrden(elCanvas, Padre.Left, ref lax, ref lay, distancia/2);
                }
                if (Padre.Right != null)
                {
                    //Console.WriteLine("Valor de Padre:  x = " + Padre.posX + " en y = " + Padre.posY);
                    //Console.WriteLine("Valor de Padre. right:  x = " + Padre.Right.posX + " en y = " + Padre.Left.posY);
                    lay = Padre.posY + 80;
                    lax = Padre.posX + distancia;
                    Padre.Right.posX = lax;
                    Padre.Right.posY = lay;
                    //Linea l = new Linea(Padre.posX, Padre.Right.posX, Padre.posY, Padre.Right.posY);
                    //l.DibujaLinea(elCanvas);
                    DibujatePreOrden(elCanvas, Padre.Right, ref lax, ref lay,distancia/2);
                }
            }
        }


        public void DibujaLineas(Canvas elCanvas, Nodo2 Padre)
        {
            if (!(Padre is null))
            {
                Padre.Dibujate(elCanvas);
                //conta++;
                //Console.WriteLine("El nodo " + conta + " con valor: " + Padre.Value );
                //Console.WriteLine("Tiene una posicion en x de: " + lax);
                //Console.WriteLine("Tiene una posicion en y de : " + lay);
                if (Padre.Left != null)
                {
                    Linea l = new Linea(Padre.posX+15, Padre.Left.posX+15, Padre.posY+15, Padre.Left.posY+15);
                    l.DibujaLinea(elCanvas);
                    DibujaLineas(elCanvas, Padre.Left);
                }
                if (Padre.Right != null)
                {
                    Linea l = new Linea(Padre.posX+15, Padre.Right.posX+15, Padre.posY+15, Padre.Right.posY+15);
                    l.DibujaLinea(elCanvas);
                    DibujaLineas(elCanvas, Padre.Right);
                }
            }
        }

    }
}
