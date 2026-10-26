namespace SistemaPlanilla.UI.Formularios.Empresa
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            disenoTablelayoutpanel1 = new TableLayoutPanel();
            disenoPanel2 = new Panel();
            pictureBox2 = new PictureBox();
            lblTitulo = new Label();
            label2 = new Label();
            disenoFlowlayoutpanel3 = new FlowLayoutPanel();
            panelBuscar = new Panel();
            iconBuscar = new FontAwesome.Sharp.IconPictureBox();
            txtBuscar = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            dgvListadoEmpresa = new DataGridView();
            disenoFlowlayoutpanel4 = new FlowLayoutPanel();
            lblTotalRegistros = new Label();
            lblPagina = new Label();
            disenoButton8 = new Button();
            disenoButton9 = new Button();
            disenoLabel5 = new Label();
            panel1.SuspendLayout();
            disenoTablelayoutpanel1.SuspendLayout();
            disenoPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            disenoFlowlayoutpanel3.SuspendLayout();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListadoEmpresa).BeginInit();
            disenoFlowlayoutpanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(disenoTablelayoutpanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 617);
            panel1.TabIndex = 0;
            // 
            // disenoTablelayoutpanel1
            // 
            disenoTablelayoutpanel1.BackColor = Color.FromArgb(230, 236, 243);
            disenoTablelayoutpanel1.ColumnCount = 1;
            disenoTablelayoutpanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            disenoTablelayoutpanel1.Controls.Add(disenoPanel2, 0, 0);
            disenoTablelayoutpanel1.Controls.Add(disenoFlowlayoutpanel3, 0, 1);
            disenoTablelayoutpanel1.Controls.Add(dgvListadoEmpresa, 0, 2);
            disenoTablelayoutpanel1.Controls.Add(disenoFlowlayoutpanel4, 0, 3);
            disenoTablelayoutpanel1.Controls.Add(disenoLabel5, 0, 4);
            disenoTablelayoutpanel1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoTablelayoutpanel1.ForeColor = Color.FromArgb(0, 0, 0);
            disenoTablelayoutpanel1.Location = new Point(32, 54);
            disenoTablelayoutpanel1.Margin = new Padding(4);
            disenoTablelayoutpanel1.Name = "disenoTablelayoutpanel1";
            disenoTablelayoutpanel1.RowCount = 5;
            disenoTablelayoutpanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            disenoTablelayoutpanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            disenoTablelayoutpanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            disenoTablelayoutpanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            disenoTablelayoutpanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            disenoTablelayoutpanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            disenoTablelayoutpanel1.Size = new Size(1051, 522);
            disenoTablelayoutpanel1.TabIndex = 34;
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
            disenoPanel2.Size = new Size(1043, 82);
            disenoPanel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(230, 236, 243);
            pictureBox2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            pictureBox2.ForeColor = Color.FromArgb(0, 0, 0);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 8);
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
            lblTitulo.Size = new Size(135, 41);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Empresa";
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
            label2.Text = "Consulte, administre y gestione el registro de la empresa.";
            // 
            // disenoFlowlayoutpanel3
            // 
            disenoFlowlayoutpanel3.BackColor = Color.FromArgb(230, 236, 243);
            disenoFlowlayoutpanel3.Controls.Add(panelBuscar);
            disenoFlowlayoutpanel3.Controls.Add(tableLayoutPanel1);
            disenoFlowlayoutpanel3.Dock = DockStyle.Fill;
            disenoFlowlayoutpanel3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoFlowlayoutpanel3.ForeColor = Color.FromArgb(0, 0, 0);
            disenoFlowlayoutpanel3.Location = new Point(4, 94);
            disenoFlowlayoutpanel3.Margin = new Padding(4);
            disenoFlowlayoutpanel3.Name = "disenoFlowlayoutpanel3";
            disenoFlowlayoutpanel3.Size = new Size(1043, 64);
            disenoFlowlayoutpanel3.TabIndex = 1;
            disenoFlowlayoutpanel3.Paint += disenoFlowlayoutpanel3_Paint;
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
            panelBuscar.Size = new Size(543, 50);
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
            txtBuscar.Size = new Size(477, 25);
            txtBuscar.TabIndex = 44;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnEditar, 1, 0);
            tableLayoutPanel1.Location = new Point(564, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(466, 62);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(248, 250, 252);
            btnAdd.Dock = DockStyle.Fill;
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
            btnAdd.Size = new Size(143, 50);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Agregar";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(248, 250, 252);
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.ForeColor = Color.FromArgb(0, 0, 0);
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.FromArgb(255, 0, 0);
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 30;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(310, 6);
            btnEliminar.Margin = new Padding(0, 6, 12, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 50);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Desactivar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = false;
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
            btnEditar.Location = new Point(155, 6);
            btnEditar.Margin = new Padding(0, 6, 12, 6);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(143, 50);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvListadoEmpresa
            // 
            dgvListadoEmpresa.AllowUserToAddRows = false;
            dgvListadoEmpresa.AllowUserToDeleteRows = false;
            dgvListadoEmpresa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvListadoEmpresa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListadoEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListadoEmpresa.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvListadoEmpresa.BorderStyle = BorderStyle.None;
            dgvListadoEmpresa.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListadoEmpresa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListadoEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListadoEmpresa.ColumnHeadersHeight = 44;
            dgvListadoEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 8, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListadoEmpresa.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListadoEmpresa.Dock = DockStyle.Fill;
            dgvListadoEmpresa.EnableHeadersVisualStyles = false;
            dgvListadoEmpresa.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dgvListadoEmpresa.GridColor = Color.FromArgb(226, 232, 240);
            dgvListadoEmpresa.Location = new Point(4, 164);
            dgvListadoEmpresa.Margin = new Padding(4, 2, 4, 2);
            dgvListadoEmpresa.MultiSelect = false;
            dgvListadoEmpresa.Name = "dgvListadoEmpresa";
            dgvListadoEmpresa.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListadoEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListadoEmpresa.RowHeadersVisible = false;
            dgvListadoEmpresa.RowHeadersWidth = 51;
            dgvListadoEmpresa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoEmpresa.Size = new Size(1043, 248);
            dgvListadoEmpresa.TabIndex = 39;
            // 
            // disenoFlowlayoutpanel4
            // 
            disenoFlowlayoutpanel4.BackColor = Color.FromArgb(255, 255, 255);
            disenoFlowlayoutpanel4.Controls.Add(lblTotalRegistros);
            disenoFlowlayoutpanel4.Controls.Add(lblPagina);
            disenoFlowlayoutpanel4.Controls.Add(disenoButton8);
            disenoFlowlayoutpanel4.Controls.Add(disenoButton9);
            disenoFlowlayoutpanel4.Dock = DockStyle.Fill;
            disenoFlowlayoutpanel4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoFlowlayoutpanel4.ForeColor = Color.FromArgb(0, 0, 0);
            disenoFlowlayoutpanel4.Location = new Point(4, 418);
            disenoFlowlayoutpanel4.Margin = new Padding(4);
            disenoFlowlayoutpanel4.Name = "disenoFlowlayoutpanel4";
            disenoFlowlayoutpanel4.Size = new Size(1043, 62);
            disenoFlowlayoutpanel4.TabIndex = 40;
            disenoFlowlayoutpanel4.WrapContents = false;
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
            // disenoButton8
            // 
            disenoButton8.AutoSize = true;
            disenoButton8.BackColor = Color.FromArgb(255, 255, 255);
            disenoButton8.Enabled = false;
            disenoButton8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoButton8.ForeColor = Color.FromArgb(0, 0, 0);
            disenoButton8.Location = new Point(337, 12);
            disenoButton8.Margin = new Padding(10, 12, 0, 0);
            disenoButton8.Name = "disenoButton8";
            disenoButton8.Size = new Size(130, 44);
            disenoButton8.TabIndex = 17;
            disenoButton8.Text = "‹ Anterior";
            disenoButton8.UseVisualStyleBackColor = false;
            disenoButton8.Click += disenoButton8_Click;
            // 
            // disenoButton9
            // 
            disenoButton9.AutoSize = true;
            disenoButton9.BackColor = Color.FromArgb(255, 255, 255);
            disenoButton9.Enabled = false;
            disenoButton9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoButton9.ForeColor = Color.FromArgb(0, 0, 0);
            disenoButton9.Location = new Point(477, 12);
            disenoButton9.Margin = new Padding(10, 12, 0, 0);
            disenoButton9.Name = "disenoButton9";
            disenoButton9.Size = new Size(141, 44);
            disenoButton9.TabIndex = 18;
            disenoButton9.Text = "Siguiente ›";
            disenoButton9.UseVisualStyleBackColor = false;
            // 
            // disenoLabel5
            // 
            disenoLabel5.BackColor = Color.FromArgb(230, 236, 243);
            disenoLabel5.Dock = DockStyle.Fill;
            disenoLabel5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            disenoLabel5.ForeColor = Color.FromArgb(160, 45, 45);
            disenoLabel5.Location = new Point(4, 484);
            disenoLabel5.Margin = new Padding(4, 0, 4, 0);
            disenoLabel5.Name = "disenoLabel5";
            disenoLabel5.Size = new Size(1043, 38);
            disenoLabel5.TabIndex = 41;
            disenoLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmEmpresa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 617);
            Controls.Add(panel1);
            Name = "FrmEmpresa";
            Text = "FrmEmpresa";
            panel1.ResumeLayout(false);
            disenoTablelayoutpanel1.ResumeLayout(false);
            disenoPanel2.ResumeLayout(false);
            disenoPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            disenoFlowlayoutpanel3.ResumeLayout(false);
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconBuscar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListadoEmpresa).EndInit();
            disenoFlowlayoutpanel4.ResumeLayout(false);
            disenoFlowlayoutpanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel disenoTablelayoutpanel1;
        private Panel disenoPanel2;
        private PictureBox pictureBox2;
        public Label lblTitulo;
        protected Label label2;
        private FlowLayoutPanel disenoFlowlayoutpanel3;
        private Panel panelBuscar;
        private FontAwesome.Sharp.IconPictureBox iconBuscar;
        public TextBox txtBuscar;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private DataGridView dgvListadoEmpresa;
        private FlowLayoutPanel disenoFlowlayoutpanel4;
        public Label lblTotalRegistros;
        public Label lblPagina;
        private Button disenoButton8;
        private Button disenoButton9;
        private Label disenoLabel5;
        private TableLayoutPanel tableLayoutPanel1;
    }
}