using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class queue <T>
    {
        public Nodo<T> Last { get; set; }
        public int Size { get; set; }

        public void Push (Nodo<T>nodo)
        {
            Nodo<T> temp;
            if(Size == 0)
            {
                Last = nodo;
                Size++;
            }
            else
            {
                temp = Last;
                Last = nodo;
                Last.siguiente = temp;
                Size++;
            }
        }

        public void Push (T valor)
        {
            Nodo<T> nodo = new Nodo<T>(valor);
            this.Push(nodo);
        }

        public T Pop()
        {
            Nodo<T> temp = Last;
            for (int i = 0; i < Size -1 ; i++)
            {
                temp = temp.siguiente;
           
            }
            T valor = temp.siguiente.valor;
            temp.siguiente = null;
            Size--;
            return valor;
        }
        public int Count()
        {
            return Size;
        }
    }
}
//hacer lo de arreglar el arbolito de acomodar numeritos
