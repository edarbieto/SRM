using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using SRM.Entidades;
using SRM.Conexiones;

namespace SRM.Formularios
{
    public partial class AgregarEditarAlumno : MetroForm
    {
        string modo;
        public AgregarEditarAlumno(string modo, Alumno obj)
        {
            InitializeComponent();
            this.modo = modo;
            if (modo == "agregar")
            {
                mcCarrera.SelectedIndex = 0;
                mcSexo.SelectedIndex = 0;
                Text = "Agregar nuevo alumno";
                AlumnoCon con = new AlumnoCon();
                mtCodigo.Text = con.GenerarCodigo();
                mtPeriodo.Text = DateTime.Now.Year.ToString() + (DateTime.Now.Month < 6 ? "01" : "02");
            }
            else if (modo == "editar")
            {
                Text = "Editar alumno";
                mtCodigo.Text = obj.Codigo;
                mtNombre.Text = obj.Nombre;
                mtApellido.Text = obj.Apellido;
                mcSexo.Text = obj.Sexo;
                mtDni.Text = obj.DNI;
                mtPeriodo.Text = obj.PeriodoIngreso;
                mcCarrera.Text = obj.Carrera;
                mdtFechanacimiento.Text = obj.FechaNacimiento;
                mtDireccion.Text = obj.Direccion;
                mtCreditostotales.Text = obj.CreditosTotales.ToString();
                mtCreditosmatriculados.Text = obj.CreditosMatriculados.ToString();
            }
            mtAccion.Click += mtAccionClick;
            mtNombre.KeyPress += mtNombreApellido_KeyPress;
            mtApellido.KeyPress += mtNombreApellido_KeyPress;
            mtCreditostotales.KeyPress += mtCreditos_KeyPress;
            mtCreditosmatriculados.KeyPress += mtCreditos_KeyPress;
            mdtFechanacimiento.MaxDate = DateTime.Today;
        }

        private void mtAccionClick(object sender, EventArgs e)
        {
            if (EstanCamposOK())
            {
                AlumnoCon con = new AlumnoCon();
                Alumno obj = new Alumno(mtCodigo.Text, mtNombre.Text, mtApellido.Text, mcSexo.Text, mtPeriodo.Text, mtDni.Text, mcCarrera.Text, mdtFechanacimiento.Text, mtDireccion.Text, int.Parse(mtCreditostotales.Text), int.Parse(mtCreditosmatriculados.Text));
                if (modo == "agregar")
                {
                    con.AgregarAlumno(obj);
                    MetroMessageBox.Show(this, "Alumno agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (modo == "editar")
                {
                    con.EditarAlumno(obj);
                    MetroMessageBox.Show(this, "Alumno editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
        
        private bool EstanCamposOK()
        {
            string log = "";
            if (mtNombre.Text == "") log += "Falta indicar el nombre\r\n";
            if (mtApellido.Text == "") log += "Falta indicar el apellido\r\n";
            if (mtDireccion.Text == "") log += "Falta indicar la direccion\r\n";
            if (mtNombre.Text.Length > 30) log += "El nombre no puede tener más de 30 carateres\r\n";
            if (mtApellido.Text.Length > 30) log += "El apellido no puede tener más de 30 carateres\r\n";
            if (mtDni.Text == "") log += "Falta indicar el DNI\r\n";
            else
            {
                if (mtDni.Text.Length != 8) log += "El dni debe tener 8 caracteres exactamente\r\n";
                if (!int.TryParse(mtDni.Text, out int temp)) log += "El dni debe ser un numero\r\n";
                if (mtDni.Text != "00000000") log += "El dni no puede ser 00000000\r\n";
            }
            if (mtDireccion.Text.Length > 50) log += "La direccion no puede tener más de 50 carateres\r\n";
            if (mtCreditostotales.Text == "") log += "Faltan indicar los créditos totales\r\n";
            if (mtCreditosmatriculados.Text == "") log += "Faltan indicar los créditos matriculados\r\n";
            if (log != "")
            {
                MetroMessageBox.Show(this, log, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void mtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar)) e.Handled = true;
            if (char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)) e.Handled = false;
        }

        private void mtCreditos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) e.Handled = true;
            if (char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar)) e.Handled = false;
        }
    }
}
