using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Nodo<T>
    {
        public T valor { get; set; }

        public Nodo<T> NodoIzquierdo {get;set;}
        public Nodo<T> NodoDerecho { get; set; }
        public Nodo<T> siguiente { get; set; }

        public Nodo(T valor)
        {
            this.valor = valor;
        }

        public Nodo(T valor, Nodo<T> siguiente)
        {
            this.valor = valor;
            this.siguiente = siguiente;
        }
    }
}
