using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Biblioteca
{
    class Conexion
    {
        public SqlConnection getConexion()
        {

            try
            {
                string cadena = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=C:\Users\pdiaz\Desktop\AAAAAAA\AAAAAAA\App_Data\Usuario.mdf;Initial Catalog=aspnet-AAAAAAA;Integrated Security=True";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                return con;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
