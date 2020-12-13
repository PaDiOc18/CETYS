using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class Lista<T> where T : IComparable
    {
        public Nodo<T> raíz { get; set; }
        public int Tamaño { get; private set; } = 0;

        public void AgregarNodo(Nodo<T> nuevoNodo)
        {
            if (raíz is null)
            {
                raíz = nuevoNodo;
            }
            else
            {
                Nodo<T> temp = raíz;
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

        public void AgregarNodoConIndex(T Valor, int index)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(Valor);
            if (index <= 0)
            {
                Nodo<T> NodoAntes = raíz;
                raíz = nuevoNodo;
                nuevoNodo.siguiente = NodoAntes;
                Tamaño++;
            }
            else
            {
                Nodo<T> NodoAntes = ExtraerNodo(index);
                Nodo<T> NodoDespues = ExtraerNodo(index+1);              
                Nodo<T> Auxiliar2 = raíz;
                while (Auxiliar2 != NodoAntes)
                {
                    Auxiliar2 = Auxiliar2.siguiente;
                }
                Auxiliar2.siguiente = nuevoNodo;
                nuevoNodo.siguiente = NodoDespues;
                Tamaño++;
            }
        }

        public Nodo<T> ExtraerNodo(int index)
        {
            Nodo<T> Auxiliar1 = raíz;
            for (int i = 1; i < index ; i++)
            {
                Auxiliar1 = Auxiliar1.siguiente;
            }
            return Auxiliar1;
        }

        public void PopIndex(int Index)
        {
            Nodo<T> NodoAEliminar = ExtraerNodo(Index + 1);
            Console.WriteLine("Nodo a eliminar: " + NodoAEliminar.valor);
            Nodo<T> NodoRecorre = raíz;
            if (Tamaño <= 2)
            {
                if (Tamaño == 1)
                {
                    NodoAEliminar = null;
                    raíz = null;
                    Tamaño--;
                }
                else
                {
                    if (Index == 0)
                    {
                        NodoAEliminar = null;
                        raíz = ExtraerNodo(Index + 2);
                        Tamaño--;
                    }
                    else //Aqui el index es 1
                    {
                        Console.WriteLine("Soy Index 1 y voy a eliminar: " + NodoAEliminar.valor); 
                        NodoAEliminar = null;
                        raíz.siguiente = null;
                        Tamaño--;
                    }
                }
            }
            else 
            {
                if (Index == 0)
                {
                    NodoAEliminar = ExtraerNodo(Index);
                    Console.WriteLine("Soy Index 0 y soy el nodo:" + NodoAEliminar.valor);
                    NodoAEliminar = null;
                    raíz = ExtraerNodo(Index + 2);
                    Tamaño--;
                }
                else
                {
                    Nodo<T> NodoAtras = ExtraerNodo(Index);
                    Console.WriteLine("Nodo de atras: " + NodoAtras.valor);
                    Nodo<T> NodoDelante = ExtraerNodo(Index + 2);
                    Console.WriteLine("Nodo de enfrente: " + NodoDelante.valor);
                    NodoAEliminar = null;
                    NodoAtras.siguiente = NodoDelante;
                    Tamaño--;
                }
            }
        }

        public void Remover(T valor)
        {
            Nodo<T> RemoverNodo = new Nodo<T>(valor);
            Console.WriteLine("Vamos a remover el valor de " + RemoverNodo.valor);
            Nodo<T> actual = raíz;
            Nodo<T> antes = null;
            for (int i = 0; i < Tamaño; i++)
            {
                if (actual.valor.Equals(valor))
                {
                    if (i== 0)
                    {
                        if (Tamaño == 1)
                        {
                            raíz = null;
                        }
                        else
                        {
                            Console.WriteLine("ES EL PRIMERO: " + actual.valor + " Y es tamaño 2");
                            actual = null;
                            raíz = ExtraerNodo(i + 2);
                        }
                    }
                    else
                    {
                        Console.WriteLine("SI ES IGUAL");
                        Nodo<T> auxilio = actual;
                        antes = ExtraerNodo(i - 1);
                        actual = null;
                        actual = antes;
                        actual.siguiente = auxilio.siguiente;
                    }
                    break;
                }
                actual = actual.siguiente;
            }
            Tamaño--;
        }

        public bool EstaEmpty()
        {
            if (Tamaño <= 0)
            {
                return true;
            }
            return false;
        }

        public bool Contains(T valor)
        {
            Nodo<T> NodoElegido = new Nodo<T>(valor);
            Nodo<T> actual = raíz;
            for (int i = 0; i < Tamaño; i++)
            {
                if (actual.valor.Equals(valor))
                {
                    return true;
                }
                actual = actual.siguiente;
            }
            return false;
        }

        public int Contar(T valor)
        {
            Nodo<T> EseNodazo = new Nodo<T>(valor);
            Nodo<T> actual = raíz;
            int acum = 0;
            for (int i = 0; i < Tamaño; i++)
            {
                if (actual.valor.Equals(EseNodazo.valor))
                {
                    acum += 1;
                }
                actual = actual.siguiente;
            }
            return acum;
        }

        public void Extender(T[] valor) 
        {
            for (int i = 0; i < valor.Length; i++)
            {
                AgregarNodo(valor[i]);
            }
        }

        public void Reverse()
        {
            int auxiliar = Tamaño;
            Nodo<T> actual = raíz;
            for (int i = 0; i < Tamaño; i++)
            {
                actual = actual.siguiente;
            }
            //Lista<T> listaNuevecita = new Lista<T>();
            //raíz = ExtraerNodo(0);
            //Nodo<T> Ultimo = ExtraerNodo(Tamaño - 1);
            //raíz.siguiente = null;

            //Nodo<T> Recorrer = raíz;
            //for (int i = Tamaño; i > 0; i--)
            //{
            //    Recorrer.siguiente = ExtraerNodo(i - 1);
            //    if (i == 1)
            //    {
            //        raíz.siguiente = null;
            //    }
            //}
        }

        public T PopJerry(int index)
        {
            if (index >= Tamaño)
            {
                throw new IndexOutOfRangeException("Indice fuera del rango");
            }
            Nodo<T> actual = raíz;
            T valor = raíz.siguiente.valor;
            if (index == 0)
            {
                removeNodeJerry(actual,true);
                return actual.valor;
            }
            for (int i = 0; i < index; i++)
            {
                actual = actual.siguiente;
                valor = actual.siguiente.valor;
            }
            removeNodeJerry(actual,false);
            return valor;
        }

        private void removeNodeJerry(Nodo<T> anterior, bool esRaiz)
        {
            if (anterior == raíz)
            {
                Nodo<T> temp = raíz.siguiente;
                raíz.siguiente = null;
                raíz = temp;
            }
            else
            {
                Nodo<T> temp = anterior.siguiente.siguiente;
                anterior.siguiente.siguiente = null;
                anterior.siguiente = temp;
            }
            Tamaño--;
        }

        public void Insertameequisde(int index, Nodo<T> nuevonodo)
        {
            if (index > Tamaño||index <0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                nuevonodo.siguiente = null;
                raíz = nuevonodo;
            }
            Nodo<T> actual = raíz;
            for (int i = 0; i < index; i++)
            {
                actual = actual.siguiente;
            }
            nuevonodo.siguiente = actual.siguiente;
            actual.siguiente = nuevonodo;
            Tamaño++;
        }

        public void Insertameequisde(int Index, T valor)
        {
            Insertameequisde(Index, new Nodo<T>(valor));
        }



        public override string ToString()
        {
            string resultado = "";
            Nodo<T> actual = raíz;
            for (int i = 0; i < Tamaño; i++)
            {
                resultado += actual.valor + " ";
                actual = actual.siguiente;
            }           
            return resultado;
        }
    }
}
