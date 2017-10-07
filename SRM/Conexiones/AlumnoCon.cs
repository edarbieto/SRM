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
            using (SqlConnection con = new SqlConnection("DataSource=dbSRM.mdf"))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = string.Format("INSERT INTO alumno(codigo,nombre,apellido,genero,peringreso,dni,carrera,fecnacimiento,direccion,credsdisponibles,credsmatriculados) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, {10})", alumno.Codigo, alumno.Nombre, alumno.Apellido, alumno.Sexo, alumno.PeriodoIngreso, alumno.DNI, alumno.Carrera, alumno.FechaNacimiento, alumno.Direccion, alumno.CreditosTotales, alumno.CreditosMatriculados);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
