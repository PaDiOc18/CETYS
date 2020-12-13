using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Biblioteca
{
    class Operacion
    {
        public bool InsertPersona(string rut, string Nombre, string Contra, string Usuario)
        {
            Conexion cn = new Conexion();
            try
            {
                //string sql = "insert into ;
                //SqlCommand cnd = new SqlCommand(sql, cn.getConexion());
                //int n = cnd.ExecuteNonQuery();
                //return n > 0;
            }
            catch(Exception)
            {
                throw;

            }
        }
    }
}
