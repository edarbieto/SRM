using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SRM.Conexiones
{
    public class UsuarioCon
    {
        public string[] Ingresar(string usuario, string password)
        {
            string[] data = new string[3];
            data[0] = "NO";
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT codigo, nombre FROM usuario WHERE username='{0}' AND password='{1}'", usuario, password), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        data[0] = "OK";
                        data[1] = dr.GetString(0);
                        data[2] = dr.GetString(1);
                    }
                }
            }
            return data;
        }
    }
}
