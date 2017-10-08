using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using SRM.Entidades;
using SRM.Conexiones;

namespace SRM.Formularios
{
    public partial class AgregarEditarMatricula : MetroForm
    {
        string modo, codigoUsuario;
        private void CargarDataGridViews()
        {
            mgCodigoalumno.AllowUserToAddRows = false;
            mgCodigoalumno.AllowUserToDeleteRows = false;
            mgCodigoalumno.AllowUserToResizeRows = false;
            mgCodigoalumno.MultiSelect = false;
            mgCodigoalumno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgCodigoalumno.ReadOnly = true;
            mgCodigoseccion.AllowUserToAddRows = false;
            mgCodigoseccion.AllowUserToDeleteRows = false;
            mgCodigoseccion.AllowUserToResizeRows = false;
            mgCodigoseccion.MultiSelect = false;
            mgCodigoseccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgCodigoseccion.ReadOnly = true;
        }

        private void ActualizarDataGridViews()
        {
            AlumnoCon conAlumnos = new AlumnoCon();
            SeccionCon conSecciones = new SeccionCon();
            mgCodigoalumno.DataSource = conAlumnos.ObtenerAlumnos();
            mgCodigoseccion.DataSource = conSecciones.ObtenerSecciones();
        }

        public AgregarEditarMatricula(string modo, Matricula obj, string codigoUsuario)
        {
            InitializeComponent();
            this.modo = modo;
            this.codigoUsuario = codigoUsuario;
            CargarDataGridViews();
            ActualizarDataGridViews();
            if (modo == "agregar")
            {
                Text = "Agregar nueva matricula";
                MatriculaCon con = new MatriculaCon();
                mtCodigo.Text = con.ObtenerCodigo().ToString();
                mtCodigousuario.Text = codigoUsuario;
            }
            else if (modo == "editar")
            {
                Text = "Editar matricula";
                mtCodigo.Text = obj.Codigo.ToString();
                mtCodigousuario.Text = obj.CodigoUsuario;
                foreach (DataGridViewRow i in mgCodigoalumno.Rows)
                {
                    if (i.Cells[0].Value.ToString() == obj.CodigoAlumno) mgCodigoalumno.CurrentCell = i.Cells[0];
                }
                foreach (DataGridViewRow i in mgCodigoseccion.Rows)
                {
                    if (i.Cells[0].Value.ToString() == obj.CodigoSeccion) mgCodigoseccion.CurrentCell = i.Cells[0];
                }
            }
            mtAccion.Click += mtAccionClick;
        }

        private void mtAccionClick(object sender, EventArgs e)
        {
            MatriculaCon con = new MatriculaCon();
            Matricula obj = new Matricula(int.Parse(mtCodigo.Text), mgCodigoalumno.SelectedRows[0].Cells[0].Value.ToString(), mgCodigoseccion.SelectedRows[0].Cells[0].Value.ToString(), codigoUsuario);
            if (modo == "agregar")
            {
                con.AgregarMatricula(obj);
                MetroMessageBox.Show(this, "Matricula agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else if (modo == "editar")
            {
                con.EditarMatricula(obj);
                MetroMessageBox.Show(this, "Matricula editada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
