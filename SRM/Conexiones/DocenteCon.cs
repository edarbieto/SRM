using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRM.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SRM.Conexiones
{
    public class DocenteCon
    {
        public Docente ObtenerDocente(string codigo)
        {
            Docente obj = null;
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM docente WHERE codigo='{0}'", codigo), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        obj = new Docente(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8));
                        break;
                    }
                }
            }
            return obj;
        }
        public DataTable ObtenerDocentes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM docente", con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
