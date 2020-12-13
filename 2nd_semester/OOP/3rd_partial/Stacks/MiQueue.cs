using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class MiQueue<T> where T : IComparable
    {
        public int Tamaño { get; set; }
        public Nodo<T> Ultimo { get; private set; }

        public void PushJerry(Nodo<T> nuevo)
        {
           nuevo.siguiente = Ultimo;
           Ultimo = nuevo;
           Tamaño++;
        }
        public void PushJerry(T valor)
        {
            Nodo<T> nuevo = new Nodo<T>(valor);

            this.PushJerry(nuevo);
        }

        public T Pop()
        {
            Nodo<T> temp = Ultimo;
            for (int i = 0; i < Tamaño-1; i++)
            {
                temp = temp.siguiente;
            }
            T valor = temp.siguiente.valor;
            temp.siguiente = null;
            Tamaño--;
            return valor;
        }

    }
}
