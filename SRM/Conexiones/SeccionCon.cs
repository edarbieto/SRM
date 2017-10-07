using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRM.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SRM.Conexiones
{
    public class SeccionCon
    {
        public Seccion ObtenerSeccion(string codigo)
        {
            Seccion obj = null;
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM seccion WHERE codigo='{0}'", codigo), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DocenteCon tempDocente = new DocenteCon();
                        CursoCon tempCurso = new CursoCon();
                        obj = new Seccion(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), tempCurso.ObtenerCurso(dr.GetString(4)), tempDocente.ObtenerDocente(dr.GetString(5)), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetString(9));
                        break;
                    }
                }
            }
            return obj;
        }
        public DataTable ObtenerSecciones()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM seccion", con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
