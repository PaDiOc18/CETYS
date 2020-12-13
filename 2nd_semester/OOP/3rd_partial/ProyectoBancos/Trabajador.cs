using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancos
{
    public class Trabajador : Persona
    {
        public string ID_Trabajador { get; set; }
        public static int conta = 0;
        public Trabajador(string Nombre, string ApellidoP, string ApellidoM, int Edad, string Genero) : 
            base(Nombre, ApellidoP, ApellidoM, Edad, Genero)
        {
            conta++;
            this.ID_Trabajador = "T" + conta.ToString();
        }
    }
}
