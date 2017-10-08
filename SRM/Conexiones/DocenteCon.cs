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
        public void AgregarDocente(Docente docente)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO docente(codigo, nombre, apellido, dni, fechanacimiento, descripcion, direccion, carrera, contrato) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", docente.Codigo, docente.Nombre, docente.Apellido, docente.DNI, docente.FechaNacimiento, docente.Descripcion, docente.Direccion, docente.Carrera, docente.Contrato);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarDocente(Docente docente)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("UPDATE docente SET nombre='{1}', apellido='{2}', dni='{3}', fechanacimiento='{4}', descripcion='{5}', direccion='{6}', carrera='{7}', contrato='{8}' WHERE codigo='{0}'", docente.Codigo, docente.Nombre, docente.Apellido, docente.DNI, docente.FechaNacimiento, docente.Descripcion, docente.Direccion, docente.Carrera, docente.Contrato);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarDocente(string codigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("DELETE FROM docente WHERE codigo='{0}'", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public string GenerarCodigo()
        {
            string codigo = "";
            bool cmp;
            Random gen = new Random();
            int id = gen.Next(1000000, 9999999);
            DataTable dt = ObtenerDocentes();
            do
            {
                cmp = true;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    if (codigo + id == dt.Rows[i]["codigo"])
                    {
                        id = gen.Next(1000000, 9999999);
                        break;
                    }
                    else if (i + 1 == dt.Rows.Count) cmp = false;
                }
            } while (cmp);
            codigo += id;
            return codigo;
        }
    }
}
