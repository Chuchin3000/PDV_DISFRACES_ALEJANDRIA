namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmAuditoriaProducto
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
            panelSuperior = new Panel();
            lblTitulo = new Label();
            groupBoxFiltros = new GroupBox();
            btnBuscarProducto = new Button();
            btnFiltrarFecha = new Button();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            btnFiltrarAccion = new Button();
            cboAccion = new ComboBox();
            label1 = new Label();
            btnMostrarTodo = new Button();
            dgvAuditoria = new DataGridView();
            panelInferior = new Panel();
            lblContador = new Label();
            txtIDProducto = new TextBox();
            label4 = new Label();
            panelSuperior.SuspendLayout();
            groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(52, 73, 94);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1257, 93);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(34, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(449, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🔍 Auditoría de Productos";
            // 
            // groupBoxFiltros
            // 
            groupBoxFiltros.Controls.Add(label4);
            groupBoxFiltros.Controls.Add(txtIDProducto);
            groupBoxFiltros.Controls.Add(btnBuscarProducto);
            groupBoxFiltros.Controls.Add(btnFiltrarFecha);
            groupBoxFiltros.Controls.Add(dtpFechaFin);
            groupBoxFiltros.Controls.Add(dtpFechaInicio);
            groupBoxFiltros.Controls.Add(label3);
            groupBoxFiltros.Controls.Add(label2);
            groupBoxFiltros.Controls.Add(btnFiltrarAccion);
            groupBoxFiltros.Controls.Add(cboAccion);
            groupBoxFiltros.Controls.Add(label1);
            groupBoxFiltros.Controls.Add(btnMostrarTodo);
            groupBoxFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxFiltros.Location = new Point(34, 120);
            groupBoxFiltros.Margin = new Padding(3, 4, 3, 4);
            groupBoxFiltros.Name = "groupBoxFiltros";
            groupBoxFiltros.Padding = new Padding(3, 4, 3, 4);
            groupBoxFiltros.Size = new Size(1189, 200);
            groupBoxFiltros.TabIndex = 1;
            groupBoxFiltros.TabStop = false;
            groupBoxFiltros.Text = "Filtros de Búsqueda";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.FromArgb(155, 89, 182);
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.Location = new Point(1051, 127);
            btnBuscarProducto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(114, 40);
            btnBuscarProducto.TabIndex = 11;
            btnBuscarProducto.Text = "🔍 Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnFiltrarFecha
            // 
            btnFiltrarFecha.BackColor = Color.FromArgb(41, 128, 185);
            btnFiltrarFecha.FlatAppearance.BorderSize = 0;
            btnFiltrarFecha.FlatStyle = FlatStyle.Flat;
            btnFiltrarFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFiltrarFecha.ForeColor = Color.White;
            btnFiltrarFecha.Location = new Point(583, 127);
            btnFiltrarFecha.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarFecha.Name = "btnFiltrarFecha";
            btnFiltrarFecha.Size = new Size(114, 40);
            btnFiltrarFecha.TabIndex = 8;
            btnFiltrarFecha.Text = "📅 Filtrar";
            btnFiltrarFecha.UseVisualStyleBackColor = false;
            btnFiltrarFecha.Click += btnFiltrarFecha_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 9F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(400, 129);
            dtpFechaFin.Margin = new Padding(3, 4, 3, 4);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(159, 27);
            dtpFechaFin.TabIndex = 7;
            dtpFechaFin.ValueChanged += dtpFechaFin_ValueChanged;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 9F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(149, 129);
            dtpFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(159, 27);
            dtpFechaInicio.TabIndex = 6;
            dtpFechaInicio.ValueChanged += dtpFechaInicio_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(331, 133);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 5;
            label3.Text = "Hasta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(23, 133);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 4;
            label2.Text = "Desde (Fecha):";
            // 
            // btnFiltrarAccion
            // 
            btnFiltrarAccion.BackColor = Color.FromArgb(241, 196, 15);
            btnFiltrarAccion.FlatAppearance.BorderSize = 0;
            btnFiltrarAccion.FlatStyle = FlatStyle.Flat;
            btnFiltrarAccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFiltrarAccion.ForeColor = Color.White;
            btnFiltrarAccion.Location = new Point(331, 53);
            btnFiltrarAccion.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarAccion.Name = "btnFiltrarAccion";
            btnFiltrarAccion.Size = new Size(114, 40);
            btnFiltrarAccion.TabIndex = 3;
            btnFiltrarAccion.Text = "🔎 Filtrar";
            btnFiltrarAccion.UseVisualStyleBackColor = false;
            btnFiltrarAccion.Click += btnFiltrarAccion_Click;
            // 
            // cboAccion
            // 
            cboAccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAccion.Font = new Font("Segoe UI", 10F);
            cboAccion.FormattingEnabled = true;
            cboAccion.Location = new Point(149, 56);
            cboAccion.Margin = new Padding(3, 4, 3, 4);
            cboAccion.Name = "cboAccion";
            cboAccion.Size = new Size(159, 31);
            cboAccion.TabIndex = 2;
            cboAccion.SelectedIndexChanged += cboAccion_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 60);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 1;
            label1.Text = "Tipo de acción:";
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.BackColor = Color.FromArgb(46, 204, 113);
            btnMostrarTodo.FlatAppearance.BorderSize = 0;
            btnMostrarTodo.FlatStyle = FlatStyle.Flat;
            btnMostrarTodo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMostrarTodo.ForeColor = Color.White;
            btnMostrarTodo.Location = new Point(1006, 47);
            btnMostrarTodo.Margin = new Padding(3, 4, 3, 4);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(160, 53);
            btnMostrarTodo.TabIndex = 0;
            btnMostrarTodo.Text = "📋 Mostrar Todos";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.BackgroundColor = Color.White;
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(40, 307);
            dgvAuditoria.Margin = new Padding(3, 4, 3, 4);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowHeadersWidth = 51;
            dgvAuditoria.RowTemplate.Height = 25;
            dgvAuditoria.Size = new Size(1189, 493);
            dgvAuditoria.TabIndex = 2;
            dgvAuditoria.CellContentClick += dgvAuditoria_CellContentClick;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(236, 240, 241);
            panelInferior.Controls.Add(lblContador);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 866);
            panelInferior.Margin = new Padding(3, 4, 3, 4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1257, 67);
            panelInferior.TabIndex = 3;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContador.Location = new Point(34, 20);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(169, 23);
            lblContador.TabIndex = 0;
            lblContador.Text = "Total de registros: 0";
            // 
            // txtIDProducto
            // 
            txtIDProducto.Location = new Point(850, 133);
            txtIDProducto.Name = "txtIDProducto";
            txtIDProducto.Size = new Size(125, 30);
            txtIDProducto.TabIndex = 12;
            txtIDProducto.TextChanged += txtIDProducto_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(730, 131);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 13;
            label4.Text = "ID Producto:";
            // 
            // FrmAuditoriaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 933);
            Controls.Add(panelInferior);
            Controls.Add(dgvAuditoria);
            Controls.Add(groupBoxFiltros);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmAuditoriaProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auditoría de Productos";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            groupBoxFiltros.ResumeLayout(false);
            groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrarAccion;
        private System.Windows.Forms.ComboBox cboAccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblContador;
        private TextBox txtIDProducto;
        private Label label4;
    }
}
