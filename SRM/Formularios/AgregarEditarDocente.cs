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

namespace SRM.Formularios
{
    public partial class AgregarEditarDocente : MetroForm
    {
        string modo;
        public AgregarEditarDocente(string modo, Docente obj)
        {
            InitializeComponent();
            this.modo = modo;
            if (modo == "agregar")
            {
                mcCarrera.SelectedIndex = 0;
                mcContrato.SelectedIndex = 0;
                Text = "Agregar nuevo docente";
                DocenteCon con = new DocenteCon();
                mtCodigo.Text = con.GenerarCodigo();
            }
            else if (modo == "editar")
            {
                Text = "Editar docente";
                mtCodigo.Text = obj.Codigo;
                mtNombre.Text = obj.Nombre;
                mtApellido.Text = obj.Apellido;
                mtDni.Text = obj.DNI;
                mdtFechanacimiento.Text = obj.FechaNacimiento;
                mtDescripcion.Text = obj.Descripcion;
                mtDireccion.Text = obj.Direccion;
                mcCarrera.Text = obj.Carrera;
                mcContrato.Text = obj.Contrato;
            }
            mtAccion.Click += mtAccionClick;
        }

        private void mtAccionClick(object sender, EventArgs e)
        {
            if (EstanCamposOK())
            {
                DocenteCon con = new DocenteCon();
                Docente obj = new Docente(mtCodigo.Text, mtNombre.Text, mtApellido.Text, mtDni.Text, mdtFechanacimiento.Text, mtDescripcion.Text, mtDireccion.Text, mcCarrera.Text, mcContrato.Text);
                if (modo == "agregar")
                {
                    con.AgregarDocente(obj);
                    MetroMessageBox.Show(this, "Docente agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (modo == "editar")
                {
                    con.EditarDocente(obj);
                    MetroMessageBox.Show(this, "Docente editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private bool EstanCamposOK()
        {
            string log = "";
            if (mtNombre.Text == "") log += "Falta indicar el nombre\r\n";
            if (mtApellido.Text == "") log += "Falta indicar el apellido\r\n";
            if (mtDescripcion.Text == "") log += "Falta indicar la descripcion\r\n";
            if (mtDireccion.Text == "") log += "Falta indicar la direccion\r\n";
            if (mtNombre.Text.Length > 30) log += "El nombre no puede tener más de 30 carateres\r\n";
            if (mtApellido.Text.Length > 30) log += "El apellido no puede tener más de 30 carateres\r\n";
            if (mtDni.Text == "") log += "Falta indicar el DNI\r\n";
            else
            {
                if (mtDni.Text.Length != 8) log += "El dni debe tener 8 caracteres exactamente\r\n";
                if (!int.TryParse(mtDni.Text, out int temp)) log += "El dni debe ser un numero\r\n";
            }
            if (mtDescripcion.Text.Length > 200) log += "La descripcion no puede tener más de 200 carateres\r\n";
            if (mtDireccion.Text.Length > 50) log += "La direccion no puede tener más de 50 carateres";
            if (log != "")
            {
                MetroMessageBox.Show(this, log, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
