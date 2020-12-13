using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class StaK <T>
    {
        public Nodo<T> raiz { get; set; }
        public int Tamanio { get; private set; }

        public void push (Nodo<T> nuevo)
        {
            Nodo<T> Temporal;
            if (Tamanio == 0)
            {
                raiz = nuevo;
                Tamanio++;
            }
            else
            {
                Temporal = raiz;
                raiz = nuevo;
                raiz.siguiente = Temporal;
                Tamanio++;
            }
           
        }

        public void Push( T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);
            this.push(nuevo);
        }

        public T Pop()
        {
            Nodo<T> Temporal = raiz;
            raiz = raiz.siguiente;
            Temporal.siguiente = null;
            Tamanio--;
            return Temporal.valor;
        }

        public int Count()
        {
            return Tamanio;
        }

    }
        

    
}
