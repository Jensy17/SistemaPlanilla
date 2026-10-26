namespace SistemaPlanilla.UI.Formularios.Seguridad
{
    partial class FrmConfiguracionConexion
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracionConexion));
            panel1 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnProbar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            pictureCerrar = new PictureBox();
            label5 = new Label();
            lblConexionServidor = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            panelDB = new Panel();
            txtBaseDatos = new TextBox();
            panelUser = new Panel();
            txtUsuarioSql = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panelServidor = new Panel();
            txtServidor = new TextBox();
            label1 = new Label();
            panelPass = new Panel();
            txtClave = new TextBox();
            errorIcon = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelDB.SuspendLayout();
            panelUser.SuspendLayout();
            panelServidor.SuspendLayout();
            panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 236, 243);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panelDB);
            panel1.Controls.Add(panelUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panelServidor);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panelPass);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 406);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 336);
            panel4.Name = "panel4";
            panel4.Size = new Size(532, 70);
            panel4.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnProbar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnGuardar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(532, 67);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnProbar
            // 
            btnProbar.Cursor = Cursors.Hand;
            btnProbar.Font = new Font("Segoe UI Symbol", 9.6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProbar.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnProbar.IconColor = Color.FromArgb(0, 192, 192);
            btnProbar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProbar.IconSize = 22;
            btnProbar.ImageAlign = ContentAlignment.MiddleLeft;
            btnProbar.Location = new Point(32, 3);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(194, 50);
            btnProbar.TabIndex = 0;
            btnProbar.Text = "Probar Conexión";
            btnProbar.TextAlign = ContentAlignment.MiddleRight;
            btnProbar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.FromArgb(0, 192, 192);
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 24;
            btnGuardar.Location = new Point(232, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 50);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnCancelar.IconColor = Color.FromArgb(192, 0, 0);
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 24;
            btnCancelar.Location = new Point(373, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(136, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureCerrar);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblConexionServidor);
            panel3.Controls.Add(iconPictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(532, 86);
            panel3.TabIndex = 4;
            // 
            // pictureCerrar
            // 
            pictureCerrar.Image = (Image)resources.GetObject("pictureCerrar.Image");
            pictureCerrar.Location = new Point(464, 12);
            pictureCerrar.Name = "pictureCerrar";
            pictureCerrar.Size = new Size(32, 32);
            pictureCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureCerrar.TabIndex = 3;
            pictureCerrar.TabStop = false;
            pictureCerrar.Click += pictureCerrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(73, 42);
            label5.Name = "label5";
            label5.Size = new Size(356, 25);
            label5.TabIndex = 2;
            label5.Text = "Complete la información de registro.";
            // 
            // lblConexionServidor
            // 
            lblConexionServidor.AutoSize = true;
            lblConexionServidor.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConexionServidor.Location = new Point(73, 12);
            lblConexionServidor.Name = "lblConexionServidor";
            lblConexionServidor.Size = new Size(213, 28);
            lblConexionServidor.TabIndex = 1;
            lblConexionServidor.Text = "Conexión al Servidor";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(230, 236, 243);
            iconPictureBox1.ForeColor = Color.Teal;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Server;
            iconPictureBox1.IconColor = Color.Teal;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(12, 12);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(58, 55);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold);
            label4.Location = new Point(22, 274);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 2;
            label4.Text = "Contraseña";
            // 
            // panelDB
            // 
            panelDB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDB.BackColor = Color.White;
            panelDB.Controls.Add(txtBaseDatos);
            panelDB.Location = new Point(149, 165);
            panelDB.Name = "panelDB";
            panelDB.Padding = new Padding(4, 0, 10, 0);
            panelDB.Size = new Size(370, 40);
            panelDB.TabIndex = 3;
            panelDB.Paint += panelDB_Paint;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaseDatos.BorderStyle = BorderStyle.None;
            txtBaseDatos.Location = new Point(10, 10);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(342, 25);
            txtBaseDatos.TabIndex = 1;
            // 
            // panelUser
            // 
            panelUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelUser.BackColor = Color.White;
            panelUser.Controls.Add(txtUsuarioSql);
            panelUser.Location = new Point(149, 221);
            panelUser.Name = "panelUser";
            panelUser.Padding = new Padding(4, 0, 10, 0);
            panelUser.Size = new Size(370, 40);
            panelUser.TabIndex = 1;
            // 
            // txtUsuarioSql
            // 
            txtUsuarioSql.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuarioSql.BorderStyle = BorderStyle.None;
            txtUsuarioSql.Location = new Point(7, 10);
            txtUsuarioSql.Name = "txtUsuarioSql";
            txtUsuarioSql.Size = new Size(342, 25);
            txtUsuarioSql.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold);
            label2.Location = new Point(22, 175);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 2;
            label2.Text = "Base de Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold);
            label3.Location = new Point(22, 221);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 0;
            label3.Text = "Usuario SQl";
            // 
            // panelServidor
            // 
            panelServidor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelServidor.BackColor = Color.White;
            panelServidor.Controls.Add(txtServidor);
            panelServidor.Location = new Point(149, 109);
            panelServidor.Name = "panelServidor";
            panelServidor.Padding = new Padding(4, 0, 10, 0);
            panelServidor.Size = new Size(370, 40);
            panelServidor.TabIndex = 1;
            // 
            // txtServidor
            // 
            txtServidor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtServidor.BorderStyle = BorderStyle.None;
            txtServidor.Location = new Point(7, 10);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(342, 25);
            txtServidor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold);
            label1.Location = new Point(22, 121);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // panelPass
            // 
            panelPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPass.BackColor = Color.White;
            panelPass.Controls.Add(txtClave);
            panelPass.Location = new Point(149, 274);
            panelPass.Name = "panelPass";
            panelPass.Padding = new Padding(4, 0, 10, 0);
            panelPass.Size = new Size(370, 40);
            panelPass.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Location = new Point(7, 12);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(342, 25);
            txtClave.TabIndex = 0;
            // 
            // errorIcon
            // 
            errorIcon.ContainerControl = this;
            // 
            // FrmConfiguracionConexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 406);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConfiguracionConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfiguracionConexion";
            Shown += FrmConfiguracionConexion_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelDB.ResumeLayout(false);
            panelDB.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            panelServidor.ResumeLayout(false);
            panelServidor.PerformLayout();
            panelPass.ResumeLayout(false);
            panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelPass;
        private Label label1;
        private TextBox txtServidor;
        private Panel panelServidor;
        private TextBox txtBaseDatos;
        private Label label4;
        private Panel panelDB;
        private TextBox txtUsuario;
        private Panel panelUser;
        private TextBox txtUsuarioSql;
        private Label label2;
        private Label label3;
        private TextBox txtClave;
        private Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label5;
        private Label lblConexionServidor;
        private PictureBox pictureCerrar;
        private Panel panel4;
        private ErrorProvider errorIcon;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnProbar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}