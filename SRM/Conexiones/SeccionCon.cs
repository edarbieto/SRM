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
                        obj = new Seccion(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetInt32(7).ToString(), dr.GetInt32(8).ToString(), dr.GetString(9));
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
        public void AgregarSeccion(Seccion seccion)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO seccion(codigo, sede, modalidad, periodo, codigocurso, codigodocente, dia, horainicio, numerohoras, aula) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, '{9}')", seccion.Codigo, seccion.Sede, seccion.Modalidad, seccion.Periodo, seccion.CodigoCurso, seccion.CodigoDocente, seccion.Dia, seccion.HoraInicio, seccion.NumeroHoras, seccion.Aula);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarSeccion(Seccion seccion, string antiguoCodigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("UPDATE seccion SET codigo='{1}', sede='{2}', modalidad='{3}', periodo='{4}', codigocurso='{5}', codigodocente='{6}', dia='{7}', horainicio={8}, numerohoras={9}, aula='{10}' WHERE codigo='{0}'", antiguoCodigo, seccion.Codigo, seccion.Sede, seccion.Modalidad, seccion.Periodo, seccion.CodigoCurso, seccion.CodigoDocente, seccion.Dia, seccion.HoraInicio, seccion.NumeroHoras, seccion.Aula);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarSeccion(string codigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("DELETE FROM seccion WHERE codigo='{0}'", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool ExisteCodigo(string codigo)
        {
            DataTable dt = ObtenerSecciones();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                if (codigo == dt.Rows[i]["codigo"].ToString()) return true;
            }
            return false;
        }
    }
}
