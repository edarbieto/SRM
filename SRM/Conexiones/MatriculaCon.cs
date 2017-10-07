using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SRM.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SRM.Conexiones
{
    public class MatriculaCon
    {
        public Matricula ObtenerMatricula(string codigo)
        {
            Matricula obj = null;
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM matricula WHERE codigo='{0}'", codigo), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        AlumnoCon tempAlumno = new AlumnoCon();
                        SeccionCon tempSeccion = new SeccionCon();
                        obj = new Matricula(dr.GetInt32(0), tempAlumno.ObtenerAlumno(dr.GetString(1)), tempSeccion.ObtenerSeccion(dr.GetString(2)), dr.GetString(3));
                        break;
                    }
                }
            }
            return obj;
        }
        public DataTable ObtenerMatriculas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM matricula", con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
