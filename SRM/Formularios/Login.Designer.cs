namespace SRM.Formularios
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.mtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtIngresar = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario:";
            // 
            // mtUsuario
            // 
            // 
            // 
            // 
            this.mtUsuario.CustomButton.Image = null;
            this.mtUsuario.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mtUsuario.CustomButton.Name = "";
            this.mtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtUsuario.CustomButton.TabIndex = 1;
            this.mtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtUsuario.CustomButton.UseSelectable = true;
            this.mtUsuario.CustomButton.Visible = false;
            this.mtUsuario.Lines = new string[0];
            this.mtUsuario.Location = new System.Drawing.Point(115, 97);
            this.mtUsuario.MaxLength = 32767;
            this.mtUsuario.Name = "mtUsuario";
            this.mtUsuario.PasswordChar = '\0';
            this.mtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtUsuario.SelectedText = "";
            this.mtUsuario.SelectionLength = 0;
            this.mtUsuario.SelectionStart = 0;
            this.mtUsuario.ShortcutsEnabled = true;
            this.mtUsuario.Size = new System.Drawing.Size(142, 23);
            this.mtUsuario.TabIndex = 1;
            this.mtUsuario.UseSelectable = true;
            this.mtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtPassword
            // 
            // 
            // 
            // 
            this.mtPassword.CustomButton.Image = null;
            this.mtPassword.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.mtPassword.CustomButton.Name = "";
            this.mtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPassword.CustomButton.TabIndex = 1;
            this.mtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPassword.CustomButton.UseSelectable = true;
            this.mtPassword.CustomButton.Visible = false;
            this.mtPassword.Lines = new string[0];
            this.mtPassword.Location = new System.Drawing.Point(115, 126);
            this.mtPassword.MaxLength = 32767;
            this.mtPassword.Name = "mtPassword";
            this.mtPassword.PasswordChar = '*';
            this.mtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPassword.SelectedText = "";
            this.mtPassword.SelectionLength = 0;
            this.mtPassword.SelectionStart = 0;
            this.mtPassword.ShortcutsEnabled = true;
            this.mtPassword.Size = new System.Drawing.Size(142, 23);
            this.mtPassword.TabIndex = 3;
            this.mtPassword.UseSelectable = true;
            this.mtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // mtIngresar
            // 
            this.mtIngresar.ActiveControl = null;
            this.mtIngresar.Location = new System.Drawing.Point(115, 184);
            this.mtIngresar.Name = "mtIngresar";
            this.mtIngresar.Size = new System.Drawing.Size(75, 51);
            this.mtIngresar.TabIndex = 4;
            this.mtIngresar.Text = "Ingresar";
            this.mtIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtIngresar.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(46, 261);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(211, 47);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Contacte con el administrador para obtener sus credenciales";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.WrapToLine = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 306);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtIngresar);
            this.Controls.Add(this.mtPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtUsuario;
        private MetroFramework.Controls.MetroTextBox mtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile mtIngresar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}