using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SRM.Entidades;

namespace SRM.Conexiones
{
    public class CursoCon
    {
        public Curso ObtenerCurso(string codigo)
        {
            Curso obj = null;
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM curso WHERE codigo='{0}'", codigo), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        obj = new Curso(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetInt32(4));
                        break;
                    }
                }
            }
            return obj;
        }
        public DataTable ObtenerCursos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM curso", con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public void AgregarCurso(Curso curso)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO curso(codigo, nombre, descripcion, carrera, creditaje) VALUES('{0}', '{1}', '{2}', '{3}', {4})", curso.Codigo, curso.Nombre, curso.Descripcion, curso.Carrera, curso.Creditaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarCurso(Curso curso, string antiguoCodigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("UPDATE curso SET codigo='{1}', nombre='{2}', descripcion='{3}', carrera='{4}', creditaje={5} WHERE codigo='{0}'", antiguoCodigo, curso.Codigo, curso.Nombre, curso.Descripcion, curso.Carrera, curso.Creditaje);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarCurso(string codigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("DELETE FROM curso WHERE codigo='{0}'", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool ExisteCodigo(string codigo)
        {
            DataTable dt = ObtenerCursos();
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                if (codigo == dt.Rows[i]["codigo"].ToString()) return true;
            }
            return false;
        }
    }
}
