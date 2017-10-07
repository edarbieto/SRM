using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using SRM.Conexiones;
using SRM.Entidades;

namespace SRM.Formularios
{
    public partial class Inicio : MetroForm
    {
        public Inicio()
        {
            InitializeComponent();
            Load += FormLoad;
            mtAlumnosAgregar.Click += mtAlumnosAgregarClick;
            mgAlumnos.MouseDoubleClick += mgAlumnosDoubleClick;
            
        }

        private void mgAlumnosDoubleClick(object sender, MouseEventArgs e)
        {
            if (mgAlumnos.SelectedRows.Count > 0)
            {
                string codigo = mgAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                AlumnoCon con = new AlumnoCon();
                Alumno temp = con.ObtenerAlumno(codigo);
                AgregarEditarAlumno obj = new AgregarEditarAlumno("editar", temp);
                obj.ShowDialog();
            }
        }

        private void mtAlumnosAgregarClick(object sender, EventArgs e)
        {
            AgregarEditarAlumno obj = new AgregarEditarAlumno("agregar", null);
            obj.ShowDialog();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            AlumnoCon conAlumnos = new AlumnoCon();
            CursoCon conCursos = new CursoCon();
            DocenteCon conDocentes = new DocenteCon();
            MatriculaCon conMatriculas = new MatriculaCon();
            SeccionCon conSecciones = new SeccionCon();
            mgAlumnos.DataSource = conAlumnos.ObtenerAlumnos();
            mgCursos.DataSource = conCursos.ObtenerCursos();
            mgDocentes.DataSource = conDocentes.ObtenerDocentes();
            mgMatriculas.DataSource = conMatriculas.ObtenerMatriculas();
            mgSecciones.DataSource = conSecciones.ObtenerSecciones();
        }
    }
}
