using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancos
{
    public class Cliente : Persona
    {
        public string ID_Cliente { get; set; }
        public static int conta = 0;
        public Cliente(string Nombre, string ApellidoP, string ApellidoM, int Edad, string Genero) : 
            base(Nombre, ApellidoP, ApellidoM, Edad, Genero)
        {
            conta++;
            this.ID_Cliente = "C" + conta.ToString();
        }
    }
}
