using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AAAAAAA.Models
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

        public Usuario()
        { }
    }
    public class UsuarioDBContext : DbContext
    {
        public DbSet<Usuario> Movies { get; set; }
    }
}