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
using MetroFramework;

namespace SRM.Formularios
{
    public partial class Inicio : MetroForm
    {
        public Inicio()
        {
            InitializeComponent();
            Load += FormLoad;
            mtAlumnosAgregar.Click += mtAlumnosAgregarClick;
            mtAlumnosEliminar.Click += mtAlumnosEliminarClick;
            mgAlumnos.MouseDoubleClick += mgAlumnosDoubleClick;
            mgAlumnos.SelectionChanged += mgAlumnosSelectionChanged;
            mtDocentesAgregar.Click += mtDocentesAgregarClick;
            mtDocentesEliminar.Click += mtDocentesEliminarClick;
            mgDocentes.MouseDoubleClick += mgDocentesDoubleClick;
            mgDocentes.SelectionChanged += mgDocentesSelectionChanged;
        }

        private void mgDocentesSelectionChanged(object sender, EventArgs e)
        {
            if (mgDocentes.SelectedRows.Count > 0)
            {
                string prevista = "";
                prevista += "Codigo: " + mgDocentes.SelectedRows[0].Cells[0].Value.ToString() + "\r\n";
                prevista += "Nombre: " + mgDocentes.SelectedRows[0].Cells[1].Value.ToString() + "\r\n";
                prevista += "Apellido: " + mgDocentes.SelectedRows[0].Cells[2].Value.ToString() + "\r\n";
                prevista += "Descripcion: " + mgDocentes.SelectedRows[0].Cells[5].Value.ToString() + "\r\n";
                prevista += "Carrera: " + mgDocentes.SelectedRows[0].Cells[7].Value.ToString();
                mlDocentesPrevista.Text = prevista;
            }
        }

        private void mgDocentesDoubleClick(object sender, MouseEventArgs e)
        {
            if (mgDocentes.SelectedRows.Count > 0)
            {
                string codigo = mgDocentes.SelectedRows[0].Cells[0].Value.ToString();
                DocenteCon con = new DocenteCon();
                Docente temp = con.ObtenerDocente(codigo);
                AgregarEditarDocente obj = new AgregarEditarDocente("editar", temp);
                obj.ShowDialog();
                ActualizarDataGridViews();
            }
        }

        private void mtDocentesEliminarClick(object sender, EventArgs e)
        {
            if (mgDocentes.SelectedRows.Count > 0)
            {
                DialogResult resultado = MetroMessageBox.Show(this, "¿Esta seguro de eliminar a este docente? Se eliminara toda informacion de el", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    string codigo = mgDocentes.SelectedRows[0].Cells[0].Value.ToString();
                    DocenteCon con = new DocenteCon();
                    con.EliminarDocente(codigo);
                    MetroMessageBox.Show(this, "Docente elimado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridViews();
                }
            }
        }

        private void mtDocentesAgregarClick(object sender, EventArgs e)
        {
            AgregarEditarDocente obj = new AgregarEditarDocente("agregar", null);
            obj.ShowDialog();
            ActualizarDataGridViews();
        }

        private void mgAlumnosSelectionChanged(object sender, EventArgs e)
        {
            if (mgAlumnos.SelectedRows.Count > 0)
            {
                string prevista = "";
                prevista += "Codigo: " + mgAlumnos.SelectedRows[0].Cells[0].Value.ToString() + "\r\n";
                prevista += "Nombre: " + mgAlumnos.SelectedRows[0].Cells[1].Value.ToString() + "\r\n";
                prevista += "Apellido: " + mgAlumnos.SelectedRows[0].Cells[2].Value.ToString() + "\r\n";
                prevista += "Carrera: " + mgAlumnos.SelectedRows[0].Cells[6].Value.ToString();
                mlAlumnosPrevista.Text = prevista;
            }
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
                ActualizarDataGridViews();
            }
        }

        private void mtAlumnosEliminarClick(object sender, EventArgs e)
        {
            if (mgAlumnos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MetroMessageBox.Show(this, "¿Esta seguro de eliminar a este alumno? Se eliminara toda informacion de el", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    string codigo = mgAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                    AlumnoCon con = new AlumnoCon();
                    con.EliminarAlumno(codigo);
                    MetroMessageBox.Show(this, "Alumno elimado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridViews();
                }
            }
        }

        private void mtAlumnosAgregarClick(object sender, EventArgs e)
        {
            AgregarEditarAlumno obj = new AgregarEditarAlumno("agregar", null);
            obj.ShowDialog();
            ActualizarDataGridViews();
        }

        private void CargarDataGridViews()
        {
            mgAlumnos.AllowUserToAddRows = false;
            mgAlumnos.AllowUserToDeleteRows = false;
            mgAlumnos.AllowUserToResizeRows = false;
            mgAlumnos.MultiSelect = false;
            mgAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgAlumnos.ReadOnly = true;
            mgCursos.AllowUserToAddRows = false;
            mgCursos.AllowUserToDeleteRows = false;
            mgCursos.AllowUserToResizeRows = false;
            mgCursos.MultiSelect = false;
            mgCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgCursos.ReadOnly = true;
            mgDocentes.AllowUserToAddRows = false;
            mgDocentes.AllowUserToDeleteRows = false;
            mgDocentes.AllowUserToResizeRows = false;
            mgDocentes.MultiSelect = false;
            mgDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgDocentes.ReadOnly = true;
            mgMatriculas.AllowUserToAddRows = false;
            mgMatriculas.AllowUserToDeleteRows = false;
            mgMatriculas.AllowUserToResizeRows = false;
            mgMatriculas.MultiSelect = false;
            mgMatriculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgMatriculas.ReadOnly = true;
            mgSecciones.AllowUserToAddRows = false;
            mgSecciones.AllowUserToDeleteRows = false;
            mgSecciones.AllowUserToResizeRows = false;
            mgSecciones.MultiSelect = false;
            mgSecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgSecciones.ReadOnly = true;
        }

        private void ActualizarDataGridViews()
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

        private void FormLoad(object sender, EventArgs e)
        {
            CargarDataGridViews();
            ActualizarDataGridViews();
        }
    }
}
