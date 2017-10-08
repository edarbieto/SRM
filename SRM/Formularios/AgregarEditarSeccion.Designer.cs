namespace SRM.Formularios
{
    partial class AgregarEditarSeccion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mcSede = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mcModalidad = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtPeriodo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mgCodigocurso = new MetroFramework.Controls.MetroGrid();
            this.mgCodigodocente = new MetroFramework.Controls.MetroGrid();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mcDia = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtHorainicio = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.mtNumerohoras = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mtAula = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.mtAccion = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mgCodigocurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgCodigodocente)).BeginInit();
            this.SuspendLayout();
            // 
            // mtCodigo
            // 
            // 
            // 
            // 
            this.mtCodigo.CustomButton.Image = null;
            this.mtCodigo.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.mtCodigo.CustomButton.Name = "";
            this.mtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtCodigo.CustomButton.TabIndex = 1;
            this.mtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtCodigo.CustomButton.UseSelectable = true;
            this.mtCodigo.CustomButton.Visible = false;
            this.mtCodigo.Lines = new string[0];
            this.mtCodigo.Location = new System.Drawing.Point(145, 64);
            this.mtCodigo.MaxLength = 32767;
            this.mtCodigo.Name = "mtCodigo";
            this.mtCodigo.PasswordChar = '\0';
            this.mtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtCodigo.SelectedText = "";
            this.mtCodigo.SelectionLength = 0;
            this.mtCodigo.SelectionStart = 0;
            this.mtCodigo.ShortcutsEnabled = true;
            this.mtCodigo.Size = new System.Drawing.Size(127, 23);
            this.mtCodigo.TabIndex = 34;
            this.mtCodigo.UseSelectable = true;
            this.mtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Código:";
            // 
            // mcSede
            // 
            this.mcSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcSede.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcSede.FormattingEnabled = true;
            this.mcSede.ItemHeight = 23;
            this.mcSede.Items.AddRange(new object[] {
            "Monterrico",
            "San Isidro",
            "San Miguel",
            "Villa"});
            this.mcSede.Location = new System.Drawing.Point(145, 93);
            this.mcSede.MaxDropDownItems = 4;
            this.mcSede.Name = "mcSede";
            this.mcSede.Size = new System.Drawing.Size(189, 29);
            this.mcSede.TabIndex = 40;
            this.mcSede.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(98, 97);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Sede:";
            // 
            // mcModalidad
            // 
            this.mcModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcModalidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcModalidad.FormattingEnabled = true;
            this.mcModalidad.ItemHeight = 23;
            this.mcModalidad.Items.AddRange(new object[] {
            "EPE",
            "Pregrado"});
            this.mcModalidad.Location = new System.Drawing.Point(145, 128);
            this.mcModalidad.MaxDropDownItems = 4;
            this.mcModalidad.Name = "mcModalidad";
            this.mcModalidad.Size = new System.Drawing.Size(189, 29);
            this.mcModalidad.TabIndex = 42;
            this.mcModalidad.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(63, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 41;
            this.metroLabel2.Text = "Modalidad:";
            // 
            // mtPeriodo
            // 
            // 
            // 
            // 
            this.mtPeriodo.CustomButton.Image = null;
            this.mtPeriodo.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.mtPeriodo.CustomButton.Name = "";
            this.mtPeriodo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtPeriodo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtPeriodo.CustomButton.TabIndex = 1;
            this.mtPeriodo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtPeriodo.CustomButton.UseSelectable = true;
            this.mtPeriodo.CustomButton.Visible = false;
            this.mtPeriodo.Lines = new string[0];
            this.mtPeriodo.Location = new System.Drawing.Point(145, 163);
            this.mtPeriodo.MaxLength = 32767;
            this.mtPeriodo.Name = "mtPeriodo";
            this.mtPeriodo.PasswordChar = '\0';
            this.mtPeriodo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtPeriodo.SelectedText = "";
            this.mtPeriodo.SelectionLength = 0;
            this.mtPeriodo.SelectionStart = 0;
            this.mtPeriodo.ShortcutsEnabled = true;
            this.mtPeriodo.Size = new System.Drawing.Size(112, 23);
            this.mtPeriodo.TabIndex = 44;
            this.mtPeriodo.UseSelectable = true;
            this.mtPeriodo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtPeriodo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(81, 164);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 43;
            this.metroLabel5.Text = "Periodo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(377, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Seleccionar curso:";
            // 
            // mgCodigocurso
            // 
            this.mgCodigocurso.AllowUserToResizeRows = false;
            this.mgCodigocurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCodigocurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgCodigocurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgCodigocurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCodigocurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgCodigocurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgCodigocurso.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgCodigocurso.EnableHeadersVisualStyles = false;
            this.mgCodigocurso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgCodigocurso.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCodigocurso.Location = new System.Drawing.Point(496, 65);
            this.mgCodigocurso.Name = "mgCodigocurso";
            this.mgCodigocurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCodigocurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgCodigocurso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgCodigocurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgCodigocurso.Size = new System.Drawing.Size(295, 150);
            this.mgCodigocurso.Style = MetroFramework.MetroColorStyle.Green;
            this.mgCodigocurso.TabIndex = 46;
            // 
            // mgCodigodocente
            // 
            this.mgCodigodocente.AllowUserToResizeRows = false;
            this.mgCodigodocente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCodigodocente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgCodigodocente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgCodigodocente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCodigodocente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgCodigodocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgCodigodocente.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgCodigodocente.EnableHeadersVisualStyles = false;
            this.mgCodigodocente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgCodigodocente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgCodigodocente.Location = new System.Drawing.Point(496, 221);
            this.mgCodigodocente.Name = "mgCodigodocente";
            this.mgCodigodocente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgCodigodocente.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mgCodigodocente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgCodigodocente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgCodigodocente.Size = new System.Drawing.Size(295, 150);
            this.mgCodigodocente.Style = MetroFramework.MetroColorStyle.Green;
            this.mgCodigodocente.TabIndex = 48;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(361, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(129, 19);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = "Seleccionar docente:";
            // 
            // mcDia
            // 
            this.mcDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mcDia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcDia.FormattingEnabled = true;
            this.mcDia.ItemHeight = 23;
            this.mcDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.mcDia.Location = new System.Drawing.Point(145, 192);
            this.mcDia.MaxDropDownItems = 4;
            this.mcDia.Name = "mcDia";
            this.mcDia.Size = new System.Drawing.Size(189, 29);
            this.mcDia.TabIndex = 50;
            this.mcDia.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(108, 197);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.TabIndex = 49;
            this.metroLabel6.Text = "Dia:";
            // 
            // mtHorainicio
            // 
            // 
            // 
            // 
            this.mtHorainicio.CustomButton.Image = null;
            this.mtHorainicio.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.mtHorainicio.CustomButton.Name = "";
            this.mtHorainicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtHorainicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtHorainicio.CustomButton.TabIndex = 1;
            this.mtHorainicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtHorainicio.CustomButton.UseSelectable = true;
            this.mtHorainicio.CustomButton.Visible = false;
            this.mtHorainicio.Lines = new string[0];
            this.mtHorainicio.Location = new System.Drawing.Point(145, 227);
            this.mtHorainicio.MaxLength = 32767;
            this.mtHorainicio.Name = "mtHorainicio";
            this.mtHorainicio.PasswordChar = '\0';
            this.mtHorainicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtHorainicio.SelectedText = "";
            this.mtHorainicio.SelectionLength = 0;
            this.mtHorainicio.SelectionStart = 0;
            this.mtHorainicio.ShortcutsEnabled = true;
            this.mtHorainicio.Size = new System.Drawing.Size(52, 23);
            this.mtHorainicio.TabIndex = 52;
            this.mtHorainicio.UseSelectable = true;
            this.mtHorainicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtHorainicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(45, 229);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(94, 19);
            this.metroLabel11.TabIndex = 51;
            this.metroLabel11.Text = "Hora de inicio:";
            // 
            // mtNumerohoras
            // 
            // 
            // 
            // 
            this.mtNumerohoras.CustomButton.Image = null;
            this.mtNumerohoras.CustomButton.Location = new System.Drawing.Point(30, 1);
            this.mtNumerohoras.CustomButton.Name = "";
            this.mtNumerohoras.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtNumerohoras.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtNumerohoras.CustomButton.TabIndex = 1;
            this.mtNumerohoras.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtNumerohoras.CustomButton.UseSelectable = true;
            this.mtNumerohoras.CustomButton.Visible = false;
            this.mtNumerohoras.Lines = new string[0];
            this.mtNumerohoras.Location = new System.Drawing.Point(145, 256);
            this.mtNumerohoras.MaxLength = 32767;
            this.mtNumerohoras.Name = "mtNumerohoras";
            this.mtNumerohoras.PasswordChar = '\0';
            this.mtNumerohoras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtNumerohoras.SelectedText = "";
            this.mtNumerohoras.SelectionLength = 0;
            this.mtNumerohoras.SelectionStart = 0;
            this.mtNumerohoras.ShortcutsEnabled = true;
            this.mtNumerohoras.Size = new System.Drawing.Size(52, 23);
            this.mtNumerohoras.TabIndex = 54;
            this.mtNumerohoras.UseSelectable = true;
            this.mtNumerohoras.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtNumerohoras.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 258);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 53;
            this.metroLabel8.Text = "Numero de horas:";
            // 
            // mtAula
            // 
            // 
            // 
            // 
            this.mtAula.CustomButton.Image = null;
            this.mtAula.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.mtAula.CustomButton.Name = "";
            this.mtAula.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtAula.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtAula.CustomButton.TabIndex = 1;
            this.mtAula.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtAula.CustomButton.UseSelectable = true;
            this.mtAula.CustomButton.Visible = false;
            this.mtAula.Lines = new string[0];
            this.mtAula.Location = new System.Drawing.Point(145, 285);
            this.mtAula.MaxLength = 32767;
            this.mtAula.Name = "mtAula";
            this.mtAula.PasswordChar = '\0';
            this.mtAula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtAula.SelectedText = "";
            this.mtAula.SelectionLength = 0;
            this.mtAula.SelectionStart = 0;
            this.mtAula.ShortcutsEnabled = true;
            this.mtAula.Size = new System.Drawing.Size(112, 23);
            this.mtAula.TabIndex = 56;
            this.mtAula.UseSelectable = true;
            this.mtAula.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtAula.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(101, 287);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(38, 19);
            this.metroLabel9.TabIndex = 55;
            this.metroLabel9.Text = "Aula:";
            // 
            // mtAccion
            // 
            this.mtAccion.ActiveControl = null;
            this.mtAccion.Location = new System.Drawing.Point(145, 329);
            this.mtAccion.Name = "mtAccion";
            this.mtAccion.Size = new System.Drawing.Size(75, 42);
            this.mtAccion.TabIndex = 57;
            this.mtAccion.Text = "Guardar";
            this.mtAccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAccion.UseSelectable = true;
            // 
            // AgregarEditarSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 397);
            this.Controls.Add(this.mtAccion);
            this.Controls.Add(this.mtAula);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.mtNumerohoras);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.mtHorainicio);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.mcDia);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.mgCodigodocente);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mgCodigocurso);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtPeriodo);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mcModalidad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mcSede);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mtCodigo);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarEditarSeccion";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Titulo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.mgCodigocurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgCodigodocente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtCodigo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox mcSede;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox mcModalidad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtPeriodo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid mgCodigocurso;
        private MetroFramework.Controls.MetroGrid mgCodigodocente;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox mcDia;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox mtHorainicio;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox mtNumerohoras;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox mtAula;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTile mtAccion;
    }
}