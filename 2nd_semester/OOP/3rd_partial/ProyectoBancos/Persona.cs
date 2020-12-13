using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBancos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Persona(string Nombre, string ApellidoP, string ApellidoM, int Edad, string Genero)
        {
            this.Nombre = Nombre;
            this.ApellidoP = ApellidoP;
            this.ApellidoM = ApellidoM;
            this.Edad = Edad;
            this.Genero = Genero;
        }
    }
}
