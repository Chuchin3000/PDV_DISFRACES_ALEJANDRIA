namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmVentas
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
            groupBoxProducto = new GroupBox();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            txtCodigo = new TextBox();
            lblCantidad = new Label();
            lblCodigo = new Label();
            dgvCarrito = new DataGridView();
            panelInferior = new Panel();
            btnCancelar = new Button();
            btnPagar = new Button();
            lblTotal = new Label();
            lblTotalLabel = new Label();
            panelSuperior.SuspendLayout();
            groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(230, 126, 34);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1143, 93);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(34, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 Punto de Venta";
            // 
            // groupBoxProducto
            // 
            groupBoxProducto.Controls.Add(btnAgregar);
            groupBoxProducto.Controls.Add(txtCantidad);
            groupBoxProducto.Controls.Add(txtCodigo);
            groupBoxProducto.Controls.Add(lblCantidad);
            groupBoxProducto.Controls.Add(lblCodigo);
            groupBoxProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProducto.Location = new Point(34, 110);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Padding = new Padding(3, 4, 3, 4);
            groupBoxProducto.Size = new Size(1074, 133);
            groupBoxProducto.TabIndex = 1;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = "Agregar Producto";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 11F);
            lblCodigo.Location = new Point(34, 64);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(171, 60);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(285, 34);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 11F);
            lblCantidad.Location = new Point(514, 64);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(640, 60);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(171, 34);
            txtCantidad.TabIndex = 3;
            txtCantidad.Text = "1";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(857, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(183, 60);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(34, 270);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(1074, 467);
            dgvCarrito.TabIndex = 2;
            dgvCarrito.CellContentClick += dgvCarrito_CellContentClick;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(44, 62, 80);
            panelInferior.Controls.Add(btnCancelar);
            panelInferior.Controls.Add(btnPagar);
            panelInferior.Controls.Add(lblTotal);
            panelInferior.Controls.Add(lblTotalLabel);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 774);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1143, 133);
            panelInferior.TabIndex = 3;
            // 
            // lblTotalLabel
            // 
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.White;
            lblTotalLabel.Location = new Point(34, 47);
            lblTotalLabel.Name = "lblTotalLabel";
            lblTotalLabel.TabIndex = 0;
            lblTotalLabel.Text = "TOTAL A PAGAR:";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotal.Location = new Point(229, 27);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(343, 80);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "$0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(743, 33);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 67);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "🗑️ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(46, 204, 113);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(926, 20);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(183, 93);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "💳 PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 907);
            Controls.Add(panelInferior);
            Controls.Add(dgvCarrito);
            Controls.Add(groupBoxProducto);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto de Venta - Disfraces Alejandría";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            groupBoxProducto.ResumeLayout(false);
            groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label lblTitulo;
        private GroupBox groupBoxProducto;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private TextBox txtCodigo;
        private Label lblCantidad;
        private Label lblCodigo;
        private DataGridView dgvCarrito;
        private Panel panelInferior;
        private Button btnCancelar;
        private Button btnPagar;
        private Label lblTotal;
        private Label lblTotalLabel;
    }
}