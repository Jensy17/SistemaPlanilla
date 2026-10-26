namespace SistemaPlanilla.UI.Formularios.Colaboradores
{
    partial class FrmColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColaboradores));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panelContenido = new TableLayoutPanel();
            disenoPanel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblTitulo = new Label();
            label2 = new Label();
            disenoFlowlayoutpanel3 = new FlowLayoutPanel();
            panelBuscar = new Panel();
            iconBuscar = new FontAwesome.Sharp.IconPictureBox();
            txtBuscar = new TextBox();
            cmbEmpresa = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnBaja = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            dgvListadoColaboradores = new DataGridView();
            panelPaginacion = new FlowLayoutPanel();
            lblTotalRegistros = new Label();
            lblPagina = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            disenoLabel5 = new Label();
            panel1.SuspendLayout();
            panelContenido.SuspendLayout();
            disenoPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            disenoFlowlayoutpanel3.SuspendLayout();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoColaboradores).BeginInit();
            panelPaginacion.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelContenido);
            panel1.Location = new Point(63, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 496);
            panel1.TabIndex = 0;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(230, 236, 243);
            panelContenido.ColumnCount = 1;
            panelContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelContenido.Controls.Add(disenoPanel2, 0, 0);
            panelContenido.Controls.Add(disenoFlowlayoutpanel3, 0, 1);
            panelContenido.Controls.Add(dgvListadoColaboradores, 0, 2);
            panelContenido.Controls.Add(panelPaginacion, 0, 3);
            panelContenido.Controls.Add(disenoLabel5, 0, 4);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            panelContenido.ForeColor = Color.FromArgb(0, 0, 0);
            panelContenido.Location = new Point(0, 0);
            panelContenido.Margin = new Padding(4);
            panelContenido.Name = "panelContenido";
            panelContenido.RowCount = 5;
            panelContenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            panelContenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            panelContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelContenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            panelContenido.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            panelContenido.Size = new Size(989, 496);
            panelContenido.TabIndex = 34;
            // 
            // disenoPanel2
            // 
            disenoPanel2.BackColor = Color.FromArgb(230, 236, 243);
            disenoPanel2.Controls.Add(pictureBox2);
            disenoPanel2.Controls.Add(lblTitulo);
            disenoPanel2.Controls.Add(label2);
            disenoPanel2.Dock = DockStyle.Fill;
            disenoPanel2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoPanel2.ForeColor = Color.FromArgb(0, 0, 0);
            disenoPanel2.Location = new Point(4, 4);
            disenoPanel2.Margin = new Padding(4);
            disenoPanel2.Name = "disenoPanel2";
            disenoPanel2.Size = new Size(981, 82);
            disenoPanel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(230, 236, 243);
            pictureBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            pictureBox2.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(230, 236, 243);
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 0, 0);
            lblTitulo.Location = new Point(85, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 41);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Colaboradores";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.BackColor = Color.FromArgb(230, 236, 243);
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(105, 105, 105);
            label2.Location = new Point(85, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1075, 35);
            label2.TabIndex = 22;
            label2.Text = "Consulte, administre y gestione el registro de los colaboradores.";
            // 
            // disenoFlowlayoutpanel3
            // 
            disenoFlowlayoutpanel3.BackColor = Color.FromArgb(230, 236, 243);
            disenoFlowlayoutpanel3.Controls.Add(panelBuscar);
            disenoFlowlayoutpanel3.Controls.Add(cmbEmpresa);
            disenoFlowlayoutpanel3.Controls.Add(tableLayoutPanel1);
            disenoFlowlayoutpanel3.Dock = DockStyle.Fill;
            disenoFlowlayoutpanel3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoFlowlayoutpanel3.ForeColor = Color.FromArgb(0, 0, 0);
            disenoFlowlayoutpanel3.Location = new Point(4, 94);
            disenoFlowlayoutpanel3.Margin = new Padding(4);
            disenoFlowlayoutpanel3.Name = "disenoFlowlayoutpanel3";
            disenoFlowlayoutpanel3.Size = new Size(981, 64);
            disenoFlowlayoutpanel3.TabIndex = 1;
            // 
            // panelBuscar
            // 
            panelBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBuscar.BackColor = Color.FromArgb(255, 255, 255);
            panelBuscar.Controls.Add(iconBuscar);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            panelBuscar.ForeColor = Color.FromArgb(0, 0, 0);
            panelBuscar.Location = new Point(0, 6);
            panelBuscar.Margin = new Padding(0, 6, 18, 6);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(333, 50);
            panelBuscar.TabIndex = 24;
            // 
            // iconBuscar
            // 
            iconBuscar.BackColor = Color.FromArgb(255, 255, 255);
            iconBuscar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            iconBuscar.ForeColor = Color.FromArgb(105, 105, 105);
            iconBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconBuscar.IconColor = Color.FromArgb(105, 105, 105);
            iconBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBuscar.IconSize = 30;
            iconBuscar.Location = new Point(11, 10);
            iconBuscar.Margin = new Padding(4, 2, 4, 2);
            iconBuscar.Name = "iconBuscar";
            iconBuscar.Size = new Size(30, 30);
            iconBuscar.TabIndex = 31;
            iconBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.BackColor = Color.FromArgb(255, 255, 255);
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtBuscar.ForeColor = Color.FromArgb(0, 0, 0);
            txtBuscar.Location = new Point(56, 12);
            txtBuscar.Margin = new Padding(4);
            txtBuscar.MaxLength = 150;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar…";
            txtBuscar.Size = new Size(273, 25);
            txtBuscar.TabIndex = 44;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.BackColor = Color.FromArgb(255, 255, 255);
            cmbEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpresa.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cmbEmpresa.ForeColor = Color.FromArgb(0, 0, 0);
            cmbEmpresa.Location = new Point(351, 15);
            cmbEmpresa.Margin = new Padding(0, 15, 15, 0);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(154, 33);
            cmbEmpresa.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.24635F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.5123138F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.24134F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBaja, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEditar, 1, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(523, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(447, 53);
            tableLayoutPanel1.TabIndex = 26;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(248, 250, 252);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Enabled = false;
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.ForeColor = Color.FromArgb(0, 0, 0);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
            btnAdd.IconColor = Color.FromArgb(37, 99, 235);
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.IconSize = 30;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(0, 6);
            btnAdd.Margin = new Padding(0, 6, 12, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 41);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Agregar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.FromArgb(248, 250, 252);
            btnBaja.Dock = DockStyle.Fill;
            btnBaja.Enabled = false;
            btnBaja.Font = new Font("Segoe UI", 10F);
            btnBaja.ForeColor = Color.FromArgb(0, 0, 0);
            btnBaja.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnBaja.IconColor = Color.FromArgb(255, 0, 0);
            btnBaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBaja.IconSize = 30;
            btnBaja.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaja.Location = new Point(297, 6);
            btnBaja.Margin = new Padding(0, 6, 12, 6);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(138, 41);
            btnBaja.TabIndex = 36;
            btnBaja.Text = "Dar de baja";
            btnBaja.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaja.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(248, 250, 252);
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.ForeColor = Color.FromArgb(0, 0, 0);
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            btnEditar.IconColor = Color.FromArgb(22, 163, 74);
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 30;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(148, 6);
            btnEditar.Margin = new Padding(0, 6, 12, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 41);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvListadoColaboradores
            // 
            dgvListadoColaboradores.AllowUserToAddRows = false;
            dgvListadoColaboradores.AllowUserToDeleteRows = false;
            dgvListadoColaboradores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvListadoColaboradores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoColaboradores.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvListadoColaboradores.BorderStyle = BorderStyle.None;
            dgvListadoColaboradores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListadoColaboradores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListadoColaboradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoColaboradores.ColumnHeadersHeight = 44;
            dgvListadoColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListadoColaboradores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoColaboradores.Dock = DockStyle.Fill;
            dgvListadoColaboradores.EnableHeadersVisualStyles = false;
            dgvListadoColaboradores.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dgvListadoColaboradores.GridColor = Color.FromArgb(226, 232, 240);
            dgvListadoColaboradores.Location = new Point(4, 166);
            dgvListadoColaboradores.Margin = new Padding(4);
            dgvListadoColaboradores.MultiSelect = false;
            dgvListadoColaboradores.Name = "dgvListadoColaboradores";
            dgvListadoColaboradores.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListadoColaboradores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListadoColaboradores.RowHeadersVisible = false;
            dgvListadoColaboradores.RowHeadersWidth = 51;
            dgvListadoColaboradores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoColaboradores.Size = new Size(981, 218);
            dgvListadoColaboradores.TabIndex = 2;
            dgvListadoColaboradores.CellFormatting += dgvListadoColaboradores_CellFormatting;
            // 
            // panelPaginacion
            // 
            panelPaginacion.BackColor = Color.FromArgb(255, 255, 255);
            panelPaginacion.Controls.Add(lblTotalRegistros);
            panelPaginacion.Controls.Add(lblPagina);
            panelPaginacion.Controls.Add(btnAnterior);
            panelPaginacion.Controls.Add(btnSiguiente);
            panelPaginacion.Dock = DockStyle.Fill;
            panelPaginacion.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            panelPaginacion.ForeColor = Color.FromArgb(0, 0, 0);
            panelPaginacion.Location = new Point(4, 392);
            panelPaginacion.Margin = new Padding(4);
            panelPaginacion.Name = "panelPaginacion";
            panelPaginacion.Size = new Size(981, 62);
            panelPaginacion.TabIndex = 3;
            panelPaginacion.WrapContents = false;
            panelPaginacion.Paint += disenoFlowlayoutpanel4_Paint;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.Anchor = AnchorStyles.Left;
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.BackColor = Color.FromArgb(255, 255, 255);
            lblTotalRegistros.Font = new Font("Segoe UI", 10F);
            lblTotalRegistros.ForeColor = Color.FromArgb(0, 0, 0);
            lblTotalRegistros.Location = new Point(15, 27);
            lblTotalRegistros.Margin = new Padding(15, 22, 25, 0);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(134, 23);
            lblTotalRegistros.TabIndex = 16;
            lblTotalRegistros.Text = "Total registros: 0";
            lblTotalRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPagina
            // 
            lblPagina.Anchor = AnchorStyles.None;
            lblPagina.AutoSize = true;
            lblPagina.BackColor = Color.FromArgb(255, 255, 255);
            lblPagina.Font = new Font("Segoe UI", 10F);
            lblPagina.ForeColor = Color.FromArgb(0, 0, 0);
            lblPagina.Location = new Point(189, 27);
            lblPagina.Margin = new Padding(15, 22, 25, 0);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(113, 23);
            lblPagina.TabIndex = 14;
            lblPagina.Text = "Página 0 de 0";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnterior
            // 
            btnAnterior.AutoSize = true;
            btnAnterior.BackColor = Color.FromArgb(255, 255, 255);
            btnAnterior.Enabled = false;
            btnAnterior.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAnterior.ForeColor = Color.FromArgb(0, 0, 0);
            btnAnterior.Location = new Point(337, 12);
            btnAnterior.Margin = new Padding(10, 12, 0, 0);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(130, 44);
            btnAnterior.TabIndex = 17;
            btnAnterior.Text = "‹ Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoSize = true;
            btnSiguiente.BackColor = Color.FromArgb(255, 255, 255);
            btnSiguiente.Enabled = false;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.FromArgb(0, 0, 0);
            btnSiguiente.Location = new Point(477, 12);
            btnSiguiente.Margin = new Padding(10, 12, 0, 0);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(141, 44);
            btnSiguiente.TabIndex = 18;
            btnSiguiente.Text = "Siguiente ›";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // disenoLabel5
            // 
            disenoLabel5.BackColor = Color.FromArgb(230, 236, 243);
            disenoLabel5.Dock = DockStyle.Fill;
            disenoLabel5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoLabel5.ForeColor = Color.FromArgb(160, 45, 45);
            disenoLabel5.Location = new Point(4, 458);
            disenoLabel5.Margin = new Padding(4, 0, 4, 0);
            disenoLabel5.Name = "disenoLabel5";
            disenoLabel5.Size = new Size(981, 38);
            disenoLabel5.TabIndex = 4;
            disenoLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmColaboradores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 617);
            Controls.Add(panel1);
            Name = "FrmColaboradores";
            Text = "FrmColaboradores";
            Load += FrmColaboradores_Load;
            Shown += FrmColaboradores_Shown;
            panel1.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            disenoPanel2.ResumeLayout(false);
            disenoPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            disenoFlowlayoutpanel3.ResumeLayout(false);
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoColaboradores).EndInit();
            panelPaginacion.ResumeLayout(false);
            panelPaginacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel panelContenido;
        private Panel disenoPanel2;
        private PictureBox pictureBox2;
        public Label lblTitulo;
        protected Label label2;
        private FlowLayoutPanel disenoFlowlayoutpanel3;
        private Panel panelBuscar;
        private FontAwesome.Sharp.IconPictureBox iconBuscar;
        public TextBox txtBuscar;
        private ComboBox cmbEmpresa;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgvListadoColaboradores;
        private FlowLayoutPanel panelPaginacion;
        public Label lblTotalRegistros;
        public Label lblPagina;
        private Button btnAnterior;
        private Button btnSiguiente;
        private Label disenoLabel5;
        public TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnBaja;
    }
}