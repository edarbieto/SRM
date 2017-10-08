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
                        obj = new Matricula(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
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
        public void AgregarMatricula(Matricula matricula)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO matricula(codigo, codigoalumno, codigoseccion, codigousuario) VALUES({0}, '{1}', '{2}', '{3}')", matricula.Codigo, matricula.CodigoAlumno, matricula.CodigoSeccion, matricula.CodigoUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarMatricula(Matricula matricula)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("UPDATE matricula SET codigoalumno='{1}', codigoseccion='{2}', codigousuario='{3}' WHERE codigo={0}", matricula.Codigo, matricula.CodigoAlumno, matricula.CodigoSeccion, matricula.CodigoUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarMatricula(int codigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("DELETE FROM matricula WHERE codigo={0}", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int ObtenerCodigo()
        {
            int codigo = -1;
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM matricula ORDER BY codigo DESC", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        codigo = dr.GetInt32(0);
                        break;
                    }
                }
            }
            return codigo + 1;
        }
    }
}
