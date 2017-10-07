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

namespace SRM.Formularios
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            metroTile1.Click += MetroTile1_Click;
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
