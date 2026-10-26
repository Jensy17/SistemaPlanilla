namespace SistemaPlanilla.UI.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panel1 = new Panel();
            panel3 = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnConfiguracion = new FontAwesome.Sharp.IconButton();
            btnColaboradores = new FontAwesome.Sharp.IconButton();
            btnEmpresa = new FontAwesome.Sharp.IconButton();
            btnDashboard = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            panelContenedor = new Panel();
            btnNomina = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnRoles = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnRoles);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnNomina);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnConfiguracion);
            panel1.Controls.Add(btnColaboradores);
            panel1.Controls.Add(btnEmpresa);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 978);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSalir);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 894);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 84);
            panel3.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 35;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 0);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(11, 0, 0, 0);
            btnSalir.Size = new Size(273, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "   Cerrar Sesión";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.BuildingColumns;
            btnConfiguracion.IconColor = Color.White;
            btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguracion.IconSize = 30;
            btnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.Location = new Point(3, 615);
            btnConfiguracion.Margin = new Padding(3, 4, 3, 4);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(11, 0, 0, 0);
            btnConfiguracion.Size = new Size(255, 67);
            btnConfiguracion.TabIndex = 6;
            btnConfiguracion.Text = "  Configuración Legal";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleRight;
            btnConfiguracion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnColaboradores
            // 
            btnColaboradores.Cursor = Cursors.Hand;
            btnColaboradores.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnColaboradores.FlatAppearance.BorderSize = 0;
            btnColaboradores.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnColaboradores.FlatStyle = FlatStyle.Flat;
            btnColaboradores.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColaboradores.ForeColor = Color.White;
            btnColaboradores.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnColaboradores.IconColor = Color.White;
            btnColaboradores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnColaboradores.IconSize = 30;
            btnColaboradores.ImageAlign = ContentAlignment.MiddleLeft;
            btnColaboradores.Location = new Point(3, 390);
            btnColaboradores.Margin = new Padding(3, 4, 3, 4);
            btnColaboradores.Name = "btnColaboradores";
            btnColaboradores.Padding = new Padding(11, 0, 0, 0);
            btnColaboradores.Size = new Size(223, 67);
            btnColaboradores.TabIndex = 6;
            btnColaboradores.Text = "   Colaboradores";
            btnColaboradores.TextAlign = ContentAlignment.MiddleRight;
            btnColaboradores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnColaboradores.UseVisualStyleBackColor = true;
            btnColaboradores.Click += btnColaboradores_Click;
            // 
            // btnEmpresa
            // 
            btnEmpresa.Cursor = Cursors.Hand;
            btnEmpresa.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnEmpresa.FlatAppearance.BorderSize = 0;
            btnEmpresa.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnEmpresa.FlatStyle = FlatStyle.Flat;
            btnEmpresa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpresa.ForeColor = Color.White;
            btnEmpresa.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            btnEmpresa.IconColor = Color.White;
            btnEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmpresa.IconSize = 30;
            btnEmpresa.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpresa.Location = new Point(3, 315);
            btnEmpresa.Margin = new Padding(3, 4, 3, 4);
            btnEmpresa.Name = "btnEmpresa";
            btnEmpresa.Padding = new Padding(11, 0, 0, 0);
            btnEmpresa.Size = new Size(223, 67);
            btnEmpresa.TabIndex = 6;
            btnEmpresa.Text = "   Empresa";
            btnEmpresa.TextAlign = ContentAlignment.MiddleRight;
            btnEmpresa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpresa.UseVisualStyleBackColor = true;
            btnEmpresa.Click += btnEmpresa_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            btnDashboard.IconColor = Color.White;
            btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDashboard.IconSize = 30;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 240);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(11, 0, 0, 0);
            btnDashboard.Size = new Size(223, 67);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 223);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 170);
            label2.Name = "label2";
            label2.Size = new Size(210, 31);
            label2.TabIndex = 5;
            label2.Text = "Sistema de Planilla";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 119);
            label1.Name = "label1";
            label1.Size = new Size(210, 51);
            label1.TabIndex = 4;
            label1.Text = "HelpPlan";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Teal;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.BackColor = Color.FromArgb(229, 231, 225);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(273, 938);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1076, 40);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(273, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1076, 938);
            panelContenedor.TabIndex = 3;
            // 
            // btnNomina
            // 
            btnNomina.Cursor = Cursors.Hand;
            btnNomina.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnNomina.FlatAppearance.BorderSize = 0;
            btnNomina.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnNomina.FlatStyle = FlatStyle.Flat;
            btnNomina.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNomina.ForeColor = Color.White;
            btnNomina.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnNomina.IconColor = Color.White;
            btnNomina.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNomina.IconSize = 30;
            btnNomina.ImageAlign = ContentAlignment.MiddleLeft;
            btnNomina.Location = new Point(3, 465);
            btnNomina.Margin = new Padding(3, 4, 3, 4);
            btnNomina.Name = "btnNomina";
            btnNomina.Padding = new Padding(11, 0, 0, 0);
            btnNomina.Size = new Size(223, 67);
            btnNomina.TabIndex = 7;
            btnNomina.Text = "   Nómina";
            btnNomina.TextAlign = ContentAlignment.MiddleRight;
            btnNomina.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNomina.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Cursor = Cursors.Hand;
            btnReportes.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            btnReportes.IconColor = Color.White;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 30;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(3, 540);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Padding = new Padding(11, 0, 0, 0);
            btnReportes.Size = new Size(264, 67);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "  Historial y Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleRight;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Cursor = Cursors.Hand;
            btnUsuarios.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.ForeColor = Color.White;
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnUsuarios.IconColor = Color.White;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(3, 681);
            btnUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Padding = new Padding(11, 0, 0, 0);
            btnUsuarios.Size = new Size(255, 67);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.Text = "  Listado Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleRight;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            btnRoles.Cursor = Cursors.Hand;
            btnRoles.FlatAppearance.BorderColor = Color.FromArgb(179, 179, 179);
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 99, 235);
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoles.ForeColor = Color.White;
            btnRoles.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            btnRoles.IconColor = Color.White;
            btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRoles.IconSize = 30;
            btnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoles.Location = new Point(3, 756);
            btnRoles.Margin = new Padding(3, 4, 3, 4);
            btnRoles.Name = "btnRoles";
            btnRoles.Padding = new Padding(11, 0, 0, 0);
            btnRoles.Size = new Size(267, 67);
            btnRoles.TabIndex = 10;
            btnRoles.Text = "  Listado Roles";
            btnRoles.TextAlign = ContentAlignment.MiddleRight;
            btnRoles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoles.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 978);
            Controls.Add(panelContenedor);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            MinimumSize = new Size(1280, 720);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmPrincipal_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private FontAwesome.Sharp.IconButton btnNomina;
        private FontAwesome.Sharp.IconButton btnEmpresa;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnColaboradores;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnSalir;
        private StatusStrip statusStrip1;
        private Panel panelContenedor;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnUsuarios;
    }
}