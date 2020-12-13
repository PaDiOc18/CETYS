using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Arbol_Binario
    {
        public Nodo<int> NodoInicial { get; set; }
       
        public Arbol_Binario()
        {
            
        }

        public void AB(Nodo<int> NodoNuevo)
        {

            if (NodoInicial is null)
            {
                NodoInicial= NodoNuevo;
            }
            else
            {
                Nodo<int> Temp = NodoInicial;
                Nodo<int> Arriba;
                while (true)
                {
                    Arriba = Temp;
                    if(NodoNuevo.valor>Temp.NodoIzquierdo.valor)
                    {
                        Temp = Temp.NodoIzquierdo;
                        if (Temp == null)
                        {
                            Arriba.NodoIzquierdo = NodoNuevo;
                            break;
                        }
                    }
                    else
                    {
                        Temp = Temp.NodoDerecho;
                        if(Temp == null)
                        {
                            Arriba.NodoDerecho = NodoNuevo;
                            break;
                        }
                    }
                }
            }
         
        }

    }
}
