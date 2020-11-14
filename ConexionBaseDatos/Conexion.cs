using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConexionBaseDatos
{
    class Conexion
    {
        private SqlConnection conexion;
        public void conectar()
        {
            conexion = new SqlConnection("Server=DESKTOP-26GA0I1\\SQLEXPRESS;Database=proyecto1;Trusted_Connection=True;");
            conexion.Open();


        }

        public bool login(string user, string pass)
        {
            SqlCommand cmd = new SqlCommand("loginUser", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", user));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));

            var result = cmd.ExecuteScalar();
            
            if(result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
