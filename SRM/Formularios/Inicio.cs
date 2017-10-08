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
        string codigoUsuario, nombreUsuario;
        public Inicio(string codigoUsuario, string nombreUsuario)
        {
            InitializeComponent();
            this.codigoUsuario = codigoUsuario;
            this.nombreUsuario = nombreUsuario;
            Load += FormLoad;
            mtAlumnosAgregar.Click += mtAlumnosAgregarClick;
            mtAlumnosEliminar.Click += mtAlumnosEliminarClick;
            mgAlumnos.MouseDoubleClick += mgAlumnosDoubleClick;
            mgAlumnos.SelectionChanged += mgAlumnosSelectionChanged;
            mtDocentesAgregar.Click += mtDocentesAgregarClick;
            mtDocentesEliminar.Click += mtDocentesEliminarClick;
            mgDocentes.MouseDoubleClick += mgDocentesDoubleClick;
            mgDocentes.SelectionChanged += mgDocentesSelectionChanged;
            mtCursosAgregar.Click += mtCursosAgregarClick;
            mtCursosEliminar.Click += mtCursosEliminarClick;
            mgCursos.MouseDoubleClick += mgCursosDoubleClick;
            mgCursos.SelectionChanged += mgCursosSelectionChanged;
            mtSeccionesAgregar.Click += mtSeccionesAgregarClick;
            mtSeccionesEliminar.Click += mtSeccionesEliminarClick;
            mgSecciones.MouseDoubleClick += mgSeccionesDoubleClick;
            mgSecciones.SelectionChanged += mgSeccionesSelectionChanged;
            mtMatriculasAgregar.Click += mtMatriculasAgregarClick;
            mtMatriculasEliminar.Click += mtMatriculasEliminarClick;
            mgMatriculas.MouseDoubleClick += mgMatriculasDoubleClick;
            mgMatriculas.SelectionChanged += mgMatriculasSelectionChanged;
        }

        private void mgMatriculasSelectionChanged(object sender, EventArgs e)
        {
            if (mgMatriculas.SelectedRows.Count > 0)
            {
                string prevista = "";
                prevista += "Codigo: " + mgMatriculas.SelectedRows[0].Cells[0].Value.ToString() + "\r\n";
                prevista += "Codigo alumno: " + mgMatriculas.SelectedRows[0].Cells[1].Value.ToString() + "\r\n";
                prevista += "Codigo seccion: " + mgMatriculas.SelectedRows[0].Cells[2].Value.ToString() + "\r\n";
                prevista += "Codigo usuario: " + mgMatriculas.SelectedRows[0].Cells[3].Value.ToString();
                mlMatriculasPrevista.Text = prevista;
            }
        }

        private void mgMatriculasDoubleClick(object sender, MouseEventArgs e)
        {
            if (mgMatriculas.SelectedRows.Count > 0)
            {
                string codigo = mgMatriculas.SelectedRows[0].Cells[0].Value.ToString();
                MatriculaCon con = new MatriculaCon();
                Matricula temp = con.ObtenerMatricula(codigo);
                AgregarEditarMatricula obj = new AgregarEditarMatricula("editar", temp, codigoUsuario);
                obj.ShowInTaskbar = false;
                obj.ShowDialog();
                ActualizarDataGridViews();
            }
        }

        private void mtMatriculasEliminarClick(object sender, EventArgs e)
        {
            if (mgMatriculas.SelectedRows.Count > 0)
            {
                DialogResult resultado = MetroMessageBox.Show(this, "¿Esta seguro de eliminar esta matricula? Se eliminara toda informacion de ella", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    string codigo = mgMatriculas.SelectedRows[0].Cells[0].Value.ToString();
                    MatriculaCon con = new MatriculaCon();
                    con.EliminarMatricula(int.Parse(codigo));
                    MetroMessageBox.Show(this, "Matricula elimada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridViews();
                }
            }
        }

        private void mtMatriculasAgregarClick(object sender, EventArgs e)
        {
            AgregarEditarMatricula obj = new AgregarEditarMatricula("agregar", null, codigoUsuario);
            obj.ShowInTaskbar = false;
            obj.ShowDialog();
            ActualizarDataGridViews();
        }

        private void mgSeccionesSelectionChanged(object sender, EventArgs e)
        {
            if (mgSecciones.SelectedRows.Count > 0)
            {
                string prevista = "";
                prevista += "Codigo: " + mgSecciones.SelectedRows[0].Cells[0].Value.ToString() + "\r\n";
                prevista += "Sede: " + mgSecciones.SelectedRows[0].Cells[1].Value.ToString() + "\r\n";
                prevista += "Modalidad: " + mgSecciones.SelectedRows[0].Cells[2].Value.ToString() + "\r\n";
                prevista += "Periodo: " + mgSecciones.SelectedRows[0].Cells[3].Value.ToString();
                mlSeccionesPrevista.Text = prevista;
            }
        }

        private void mgSeccionesDoubleClick(object sender, MouseEventArgs e)
        {
            if (mgSecciones.SelectedRows.Count > 0)
            {
                string codigo = mgSecciones.SelectedRows[0].Cells[0].Value.ToString();
                SeccionCon con = new SeccionCon();
                Seccion temp = con.ObtenerSeccion(codigo);
                AgregarEditarSeccion obj = new AgregarEditarSeccion("editar", temp);
                obj.ShowInTaskbar = false;
                obj.ShowDialog();
                ActualizarDataGridViews();
            }
        }

        private void mtSeccionesEliminarClick(object sender, EventArgs e)
        {
            if (mgSecciones.SelectedRows.Count > 0)
            {
                DialogResult resultado = MetroMessageBox.Show(this, "¿Esta seguro de eliminar esta seccion? Se eliminara toda informacion de ella", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    string codigo = mgSecciones.SelectedRows[0].Cells[0].Value.ToString();
                    SeccionCon con = new SeccionCon();
                    con.EliminarSeccion(codigo);
                    MetroMessageBox.Show(this, "Seccion elimada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridViews();
                }
            }
        }

        private void mtSeccionesAgregarClick(object sender, EventArgs e)
        {
            AgregarEditarSeccion obj = new AgregarEditarSeccion("agregar", null);
            obj.ShowInTaskbar = false;
            obj.ShowDialog();
            ActualizarDataGridViews();
        }

        private void mgCursosSelectionChanged(object sender, EventArgs e)
        {
            if (mgCursos.SelectedRows.Count > 0)
            {
                string prevista = "";
                prevista += "Codigo: " + mgCursos.SelectedRows[0].Cells[0].Value.ToString() + "\r\n";
                prevista += "Nombre: " + mgCursos.SelectedRows[0].Cells[1].Value.ToString() + "\r\n";
                prevista += "Descripcion: " + mgCursos.SelectedRows[0].Cells[2].Value.ToString() + "\r\n";
                prevista += "Carrera: " + mgCursos.SelectedRows[0].Cells[3].Value.ToString() + "\r\n";
                prevista += "Creditaje: " + mgCursos.SelectedRows[0].Cells[4].Value.ToString();
                mlCursosPrevista.Text = prevista;
            }
        }

        private void mgCursosDoubleClick(object sender, MouseEventArgs e)
        {
            if (mgCursos.SelectedRows.Count > 0)
            {
                string codigo = mgCursos.SelectedRows[0].Cells[0].Value.ToString();
                CursoCon con = new CursoCon();
                Curso temp = con.ObtenerCurso(codigo);
                AgregarEditarCurso obj = new AgregarEditarCurso("editar", temp);
                obj.ShowInTaskbar = false;
                obj.ShowDialog();
                ActualizarDataGridViews();
            }
        }

        private void mtCursosEliminarClick(object sender, EventArgs e)
        {
            if (mgCursos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MetroMessageBox.Show(this, "¿Esta seguro de eliminar este curso? Se eliminara toda informacion de el", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.OK)
                {
                    string codigo = mgCursos.SelectedRows[0].Cells[0].Value.ToString();
                    CursoCon con = new CursoCon();
                    con.EliminarCurso(codigo);
                    MetroMessageBox.Show(this, "Curso elimado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridViews();
                }
            }
        }

        private void mtCursosAgregarClick(object sender, EventArgs e)
        {
            AgregarEditarCurso obj = new AgregarEditarCurso("agregar", null);
            obj.ShowInTaskbar = false;
            obj.ShowDialog();
            ActualizarDataGridViews();
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
                obj.ShowInTaskbar = false;
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
            obj.ShowInTaskbar = false;
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
                obj.ShowInTaskbar = false;
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
            obj.ShowInTaskbar = false;
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
