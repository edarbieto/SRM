using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
using SRM.Entidades;

namespace SRM.Conexiones
{
    public class AlumnoCon
    {
        public Alumno ObtenerAlumno(string codigo)
        {
            Alumno obj = null;
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM alumno WHERE codigo='{0}'", codigo), con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        obj = new Alumno(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5), dr.GetString(6), dr.GetString(7), dr.GetString(8), dr.GetInt32(9), dr.GetInt32(10));
                        break;
                    }
                }
            }
            return obj;
        }
        public DataTable ObtenerAlumnos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM alumno", con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public void AgregarAlumno(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO alumno(codigo, nombre, apellido, sexo, periodoingreso, dni, carrera, fechanacimiento, direccion, creditostotales, creditosmatriculados) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10})", alumno.Codigo, alumno.Nombre, alumno.Apellido, alumno.Sexo, alumno.PeriodoIngreso, alumno.DNI, alumno.Carrera, alumno.FechaNacimiento, alumno.Direccion, alumno.CreditosTotales, alumno.CreditosMatriculados);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EditarAlumno(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("UPDATE alumno SET nombre='{1}', apellido='{2}', sexo='{3}', periodoingreso='{4}', dni='{5}', carrera='{6}', fechanacimiento='{7}', direccion='{8}', creditostotales={9}, creditosmatriculados={10} WHERE codigo='{0}'", alumno.Codigo, alumno.Nombre, alumno.Apellido, alumno.Sexo, alumno.PeriodoIngreso, alumno.DNI, alumno.Carrera, alumno.FechaNacimiento, alumno.Direccion, alumno.CreditosTotales, alumno.CreditosMatriculados);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarAlumno(string codigo)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=dbSRM; Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("DELETE FROM alumno WHERE codigo='{0}'", codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public string GenerarCodigo()
        {
            string codigo = "u" + DateTime.Now.Year;
            bool cmp;
            Random gen = new Random();
            int id = gen.Next(10000, 99999);
            DataTable dt = ObtenerAlumnos();
            do
            {
                cmp = true;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    if (codigo + id == dt.Rows[i]["codigo"])
                    {
                        id = gen.Next(10000, 99999);
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
