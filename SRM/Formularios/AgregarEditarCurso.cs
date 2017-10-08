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
    public partial class AgregarEditarCurso : MetroForm
    {
        string modo, antiguoCodigo;
        public AgregarEditarCurso(string modo, Curso obj)
        {
            InitializeComponent();
            this.modo = modo;
            if (modo == "agregar")
            {
                mcCarrera.SelectedIndex = 0;
                Text = "Agregar nuevo curso";
            }
            else if (modo == "editar")
            {
                Text = "Editar curso";
                mtCodigo.Text = antiguoCodigo = obj.Codigo;
                mtNombre.Text = obj.Nombre;
                mtDescripcion.Text = obj.Descripcion;
                mcCarrera.Text = obj.Carrera;
                mtCreditaje.Text = obj.Creditaje.ToString();
            }
            mtAccion.Click += mtAccionClick;
        }

        private void mtAccionClick(object sender, EventArgs e)
        {
            if (EstanCamposOK())
            {
                CursoCon con = new CursoCon();
                Curso obj = new Curso(mtCodigo.Text, mtNombre.Text, mtDescripcion.Text, mcCarrera.Text, int.Parse(mtCreditaje.Text));
                if (modo == "agregar")
                {
                    con.AgregarCurso(obj);
                    MetroMessageBox.Show(this, "Curso agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (modo == "editar")
                {
                    con.EditarCurso(obj, antiguoCodigo);
                    MetroMessageBox.Show(this, "Curso editado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private bool EstanCamposOK()
        {
            Regex reg = new Regex("^[A-Z]{2}\\d{3}$");
            CursoCon con = new CursoCon();
            string log = "";
            if (mtCodigo.Text == "") log += "Falta indicar el codigo\r\n";
            if (mtNombre.Text == "") log += "Falta indicar el nombre\r\n";
            if (mtDescripcion.Text == "") log += "Falta indicar la descripcion\r\n";
            if (mtCreditaje.Text == "") log += "Falta indicar el creditaje\r\n";
            if (con.ExisteCodigo(mtCodigo.Text)) log += "Este codigo ya existe\r\n";
            else if (mtCodigo.Text.Length != 5 || !reg.IsMatch(mtCodigo.Text)) log += "El formato del codigo es AA### (dos letras mayusculas y tres digitos)\r\n";
            if (mtNombre.Text.Length > 30) log += "El nombre no puede tener más de 30 carateres\r\n";
            if (mtDescripcion.Text.Length > 200) log += "La descripcion no puede tener más de 200 carateres\r\n";
            if (!int.TryParse(mtCreditaje.Text, out int temp)) log += "El creditaje debe ser un numero";
            if (log != "")
            {
                MetroMessageBox.Show(this, log, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
