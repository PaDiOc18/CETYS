using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class MiStack<T> where T : IComparable
    {
        public int Tamaño { get; set; }
        public Nodo<T> Raiz { get; set; }

        public MiStack()
        {

        }

        public void PushJerry(Nodo <T> nuevo)
        {
            nuevo.siguiente = Top;
            Top = nuevo;
            Tamaño++;
        }

        public T Pop()
        {
            if (Top is null)
            {
                throw new NullReferenceException("Empty stack");
            }
            Nodo<T> exit = Top;
            Top = exit.next;
            exit.next = null;
            Tamaño--;

        }






        public void AgregarNodo(Nodo<T> nuevoNodo)
        {
            if (Raiz is null)
            {
                Raiz = nuevoNodo;
            }
            else
            {
                Nodo<T> temp = Raiz;
                while (!(temp.siguiente is null))
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevoNodo;
            }
            Tamaño++;
        }

        public void AgregarNodo(T valor)
        {
            AgregarNodo(new Nodo<T>(valor));
        }

        public Nodo<T> Pop()
        {
            Nodo<T> temp = Raiz;
            for (int i = 0; i < Tamaño-1; i++)
            {
                temp = temp.siguiente;
            }
            temp = null;
            Tamaño--;
            return temp;
        }

        public int Cuantos()
        {
            return Tamaño;
        }
    }
}
