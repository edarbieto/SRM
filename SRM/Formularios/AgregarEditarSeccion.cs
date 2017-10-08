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
using SRM.Conexiones;
using SRM.Entidades;
using System.Text.RegularExpressions;

namespace SRM.Formularios
{
    public partial class AgregarEditarSeccion : MetroForm
    {
        string modo, antiguoCodigo;
        private void CargarDataGridViews()
        {
            mgCodigocurso.AllowUserToAddRows = false;
            mgCodigocurso.AllowUserToDeleteRows = false;
            mgCodigocurso.AllowUserToResizeRows = false;
            mgCodigocurso.MultiSelect = false;
            mgCodigocurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgCodigocurso.ReadOnly = true;
            mgCodigodocente.AllowUserToAddRows = false;
            mgCodigodocente.AllowUserToDeleteRows = false;
            mgCodigodocente.AllowUserToResizeRows = false;
            mgCodigodocente.MultiSelect = false;
            mgCodigodocente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            mgCodigodocente.ReadOnly = true;
        }

        private void ActualizarDataGridViews()
        {
            CursoCon conCursos = new CursoCon();
            DocenteCon conDocentes = new DocenteCon();
            mgCodigocurso.DataSource = conCursos.ObtenerCursos();
            mgCodigodocente.DataSource = conDocentes.ObtenerDocentes();
        }

        public AgregarEditarSeccion(string modo, Seccion obj)
        {
            InitializeComponent();
            this.modo = modo;
            CargarDataGridViews();
            ActualizarDataGridViews();
            if (modo == "agregar")
            {
                mcDia.SelectedIndex = 0;
                mcModalidad.SelectedIndex = 0;
                mcSede.SelectedIndex = 0;
                Text = "Agregar nueva seccion";
            }
            else if (modo == "editar")
            {
                Text = "Editar seccion";
                mtCodigo.Text = antiguoCodigo = obj.Codigo;
                mcSede.Text = obj.Sede;
                mcModalidad.Text = obj.Modalidad;
                mtPeriodo.Text = obj.Periodo;
                mcDia.Text = obj.Dia;
                mtHorainicio.Text = obj.HoraInicio;
                mtNumerohoras.Text = obj.NumeroHoras;
                mtAula.Text = obj.Aula;
                foreach (DataGridViewRow i in mgCodigocurso.Rows)
                {
                    if (i.Cells[0].Value.ToString() == obj.CodigoCurso) mgCodigocurso.CurrentCell = i.Cells[0];
                }
                foreach (DataGridViewRow i in mgCodigodocente.Rows)
                {
                    if (i.Cells[0].Value.ToString() == obj.CodigoDocente) mgCodigodocente.CurrentCell = i.Cells[0];
                }
            }
            mtAccion.Click += mtAccionClick;
        }

        private void mtAccionClick(object sender, EventArgs e)
        {
            if (EstanCamposOK())
            {
                SeccionCon con = new SeccionCon();
                Seccion obj = new Seccion(mtCodigo.Text, mcSede.Text, mcModalidad.Text, mtPeriodo.Text, mgCodigocurso.SelectedRows[0].Cells[0].Value.ToString(), mgCodigodocente.SelectedRows[0].Cells[0].Value.ToString(), mcDia.Text, mtHorainicio.Text, mtNumerohoras.Text, mtAula.Text);
                if (modo == "agregar")
                {
                    con.AgregarSeccion(obj);
                    MetroMessageBox.Show(this, "Seccion agregada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (modo == "editar")
                {
                    con.EditarSeccion(obj, antiguoCodigo);
                    MetroMessageBox.Show(this, "Seccion editada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private bool EstanCamposOK()
        {
            Regex regCodigo = new Regex("^[A-Z]{2}\\d{2}$");
            Regex regAula = new Regex("^[A-Z]{1}\\d{3}$");
            CursoCon con = new CursoCon();
            string log = "";
            if (mtCodigo.Text == "") log += "Falta indicar el codigo\r\n";
            if (mtPeriodo.Text == "") log += "Falta indicar el periodo\r\n";
            if (mtHorainicio.Text == "") log += "Falta indicar la hora de inicio\r\n";
            if (mtNumerohoras.Text == "") log += "Falta indicar el numero de horas\r\n";
            if (mtAula.Text == "") log += "Falta indicar el aula\r\n";
            if (con.ExisteCodigo(mtCodigo.Text)) log += "Este codigo ya existe\r\n";
            else if (mtCodigo.Text.Length != 4 || !regCodigo.IsMatch(mtCodigo.Text)) log += "El formato del codigo es AA## (dos letras mayusculas y dos digitos)\r\n";
            if (!int.TryParse(mtHorainicio.Text, out int temp1)) log += "La hora de inicio debe ser un numero\r\n";
            if (!int.TryParse(mtNumerohoras.Text, out int temp2)) log += "El numero de horas debe ser un numero\r\n";
            if (mtAula.Text.Length != 4 || !regAula.IsMatch(mtAula.Text)) log += "El formato del aula es A### (una letra mayuscula y tres digitos)";
            if (log != "")
            {
                MetroMessageBox.Show(this, log, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
