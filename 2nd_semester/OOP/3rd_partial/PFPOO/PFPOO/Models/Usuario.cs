using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFPOO.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string NombreCompleto, string NombreUsuario, string Contrasena)
        {
            this.NombreCompleto = NombreCompleto;
            this.NombreUsuario = NombreUsuario;
            this.Contrasena = Contrasena;
        }
    }
}
