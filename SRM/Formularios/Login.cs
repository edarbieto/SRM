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

namespace SRM.Formularios
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            mtIngresar.Click += mtIngresarClick;
        }

        private void mtIngresarClick(object sender, EventArgs e)
        {
            if (mtUsuario.Text != "" && mtUsuario.Text != "")
            {
                UsuarioCon con = new UsuarioCon();
                string[] data = con.Ingresar(mtUsuario.Text, mtPassword.Text);
                if (data[0] == "OK")
                {
                    Hide();
                    ShowInTaskbar = false;
                    Inicio obj = new Inicio(data[1], data[2]);
                    obj.FormClosed += (s, args) => Close();
                    obj.ShowDialog();
                }
                else if (data[0] == "NO")
                {
                    MetroMessageBox.Show(this, "El usuario y contraseña no coinciden", "Credenciales invalidas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Por favor rellenar todos los campos", "Usuario o contraseña faltantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
