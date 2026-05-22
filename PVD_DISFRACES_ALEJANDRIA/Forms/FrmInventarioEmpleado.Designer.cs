namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmInventarioEmpleado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSuperior = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            dgvInventario = new DataGridView();
            panelInferior = new Panel();
            lblTotalProductos = new Label();
            lblProductosBajoStock = new Label();
            lblValorTotal = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(52, 152, 219);
            panelSuperior.Controls.Add(lblSubtitulo);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1000, 100);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🎭 Inventario de Disfraces";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.FromArgb(236, 240, 241);
            lblSubtitulo.Location = new Point(30, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consulta de disfraces disponibles";
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(30, 130);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowTemplate.Height = 25;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(940, 420);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(236, 240, 241);
            panelInferior.Controls.Add(lblValorTotal);
            panelInferior.Controls.Add(lblProductosBajoStock);
            panelInferior.Controls.Add(lblTotalProductos);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 570);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1000, 80);
            panelInferior.TabIndex = 2;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalProductos.Location = new Point(30, 20);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.TabIndex = 0;
            lblTotalProductos.Text = "Total de disfraces: 0";
            // 
            // lblProductosBajoStock
            // 
            lblProductosBajoStock.AutoSize = true;
            lblProductosBajoStock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProductosBajoStock.ForeColor = Color.FromArgb(231, 76, 60);
            lblProductosBajoStock.Location = new Point(30, 45);
            lblProductosBajoStock.Name = "lblProductosBajoStock";
            lblProductosBajoStock.TabIndex = 1;
            lblProductosBajoStock.Text = "⚠️ Disfraces bajo stock: 0";
            // 
            // lblValorTotal
            // 
            lblValorTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblValorTotal.ForeColor = Color.FromArgb(46, 204, 113);
            lblValorTotal.Location = new Point(700, 20);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(270, 40);
            lblValorTotal.TabIndex = 2;
            lblValorTotal.Text = "Valor total: $0.00";
            lblValorTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmInventarioEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(panelInferior);
            Controls.Add(dgvInventario);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmInventarioEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario de Disfraces - Alejandría";
            Load += FrmInventarioEmpleado_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private DataGridView dgvInventario;
        private Panel panelInferior;
        private Label lblValorTotal;
        private Label lblProductosBajoStock;
        private Label lblTotalProductos;
    }
}