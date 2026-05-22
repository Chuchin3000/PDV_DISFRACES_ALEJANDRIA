namespace PVD_DISFRACES_ALEJANDRIA.Forms
{
    partial class FrmReportes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblEstadoProductos = new Label();
            dgvProductos = new DataGridView();
            btnGenerarReporteProductos = new Button();
            dtpFinProductos = new DateTimePicker();
            dtpInicioProductos = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lblEstadoEmpleados = new Label();
            dgvEmpleados = new DataGridView();
            btnGenerarReporteEmpleados = new Button();
            dtpFinEmpleado = new DateTimePicker();
            dtpInicioEmpleado = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1257, 867);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(lblEstadoProductos);
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Controls.Add(btnGenerarReporteProductos);
            tabPage1.Controls.Add(dtpFinProductos);
            tabPage1.Controls.Add(dtpInicioProductos);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1249, 831);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "📦 Reporte de Productos";
            // 
            // label1 — título pestaña productos
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.TabIndex = 0;
            label1.Text = "Reporte de Ventas de Productos";
            // 
            // label2 — Fecha de inicio
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio:";
            // 
            // dtpInicioProductos
            // 
            dtpInicioProductos.Font = new Font("Segoe UI", 10F);
            dtpInicioProductos.Format = DateTimePickerFormat.Short;
            dtpInicioProductos.Location = new Point(166, 83);
            dtpInicioProductos.Name = "dtpInicioProductos";
            dtpInicioProductos.Size = new Size(171, 30);
            dtpInicioProductos.TabIndex = 3;
            dtpInicioProductos.ValueChanged += dtpInicioProductos_ValueChanged;
            // 
            // label3 — Fecha de fin
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(366, 87);
            label3.Name = "label3";
            label3.TabIndex = 2;
            label3.Text = "Fecha de fin:";
            // 
            // dtpFinProductos
            // 
            dtpFinProductos.Font = new Font("Segoe UI", 10F);
            dtpFinProductos.Format = DateTimePickerFormat.Short;
            dtpFinProductos.Location = new Point(486, 83);
            dtpFinProductos.Name = "dtpFinProductos";
            dtpFinProductos.Size = new Size(171, 30);
            dtpFinProductos.TabIndex = 4;
            dtpFinProductos.ValueChanged += dtpFinProductos_ValueChanged;
            // 
            // btnGenerarReporteProductos
            // 
            btnGenerarReporteProductos.BackColor = Color.FromArgb(46, 204, 113);
            btnGenerarReporteProductos.FlatAppearance.BorderSize = 0;
            btnGenerarReporteProductos.FlatStyle = FlatStyle.Flat;
            btnGenerarReporteProductos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarReporteProductos.ForeColor = Color.White;
            btnGenerarReporteProductos.Location = new Point(680, 76);
            btnGenerarReporteProductos.Name = "btnGenerarReporteProductos";
            btnGenerarReporteProductos.Size = new Size(183, 47);
            btnGenerarReporteProductos.TabIndex = 5;
            btnGenerarReporteProductos.Text = "📊 Generar reporte";
            btnGenerarReporteProductos.UseVisualStyleBackColor = false;
            btnGenerarReporteProductos.Click += btnGenerarReporteProductos_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 140);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(1200, 613);
            dgvProductos.TabIndex = 6;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // lblEstadoProductos
            // 
            lblEstadoProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstadoProductos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoProductos.ForeColor = Color.FromArgb(52, 73, 94);
            lblEstadoProductos.Location = new Point(23, 767);
            lblEstadoProductos.Name = "lblEstadoProductos";
            lblEstadoProductos.Size = new Size(1200, 33);
            lblEstadoProductos.TabIndex = 7;
            lblEstadoProductos.Text = "Seleccione un rango de fechas y genere el reporte";
            lblEstadoProductos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(lblEstadoEmpleados);
            tabPage2.Controls.Add(dgvEmpleados);
            tabPage2.Controls.Add(btnGenerarReporteEmpleados);
            tabPage2.Controls.Add(dtpFinEmpleado);
            tabPage2.Controls.Add(dtpInicioEmpleado);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1249, 831);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "👥 Reporte por Empleado";
            // 
            // label4 — título pestaña empleados
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(142, 68, 173);
            label4.Location = new Point(23, 20);
            label4.Name = "label4";
            label4.TabIndex = 0;
            label4.Text = "Reporte de Ventas por Empleado";
            // 
            // label5 — Fecha de inicio empleados
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(23, 87);
            label5.Name = "label5";
            label5.TabIndex = 1;
            label5.Text = "Fecha de inicio:";
            // 
            // dtpInicioEmpleado
            // 
            dtpInicioEmpleado.Font = new Font("Segoe UI", 10F);
            dtpInicioEmpleado.Format = DateTimePickerFormat.Short;
            dtpInicioEmpleado.Location = new Point(166, 83);
            dtpInicioEmpleado.Name = "dtpInicioEmpleado";
            dtpInicioEmpleado.Size = new Size(171, 30);
            dtpInicioEmpleado.TabIndex = 3;
            dtpInicioEmpleado.ValueChanged += dtpInicioEmpleado_ValueChanged;
            // 
            // label6 — Fecha de fin empleados
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(366, 87);
            label6.Name = "label6";
            label6.TabIndex = 2;
            label6.Text = "Fecha de fin:";
            // 
            // dtpFinEmpleado
            // 
            dtpFinEmpleado.Font = new Font("Segoe UI", 10F);
            dtpFinEmpleado.Format = DateTimePickerFormat.Short;
            dtpFinEmpleado.Location = new Point(486, 83);
            dtpFinEmpleado.Name = "dtpFinEmpleado";
            dtpFinEmpleado.Size = new Size(171, 30);
            dtpFinEmpleado.TabIndex = 4;
            dtpFinEmpleado.ValueChanged += dtpFinEmpleado_ValueChanged;
            // 
            // btnGenerarReporteEmpleados
            // 
            btnGenerarReporteEmpleados.BackColor = Color.FromArgb(155, 89, 182);
            btnGenerarReporteEmpleados.FlatAppearance.BorderSize = 0;
            btnGenerarReporteEmpleados.FlatStyle = FlatStyle.Flat;
            btnGenerarReporteEmpleados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarReporteEmpleados.ForeColor = Color.White;
            btnGenerarReporteEmpleados.Location = new Point(680, 76);
            btnGenerarReporteEmpleados.Name = "btnGenerarReporteEmpleados";
            btnGenerarReporteEmpleados.Size = new Size(183, 47);
            btnGenerarReporteEmpleados.TabIndex = 5;
            btnGenerarReporteEmpleados.Text = "📊 Generar reporte";
            btnGenerarReporteEmpleados.UseVisualStyleBackColor = false;
            btnGenerarReporteEmpleados.Click += btnGenerarReporteEmpleados_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(23, 140);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(1200, 613);
            dgvEmpleados.TabIndex = 6;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // lblEstadoEmpleados
            // 
            lblEstadoEmpleados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstadoEmpleados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoEmpleados.ForeColor = Color.FromArgb(52, 73, 94);
            lblEstadoEmpleados.Location = new Point(23, 767);
            lblEstadoEmpleados.Name = "lblEstadoEmpleados";
            lblEstadoEmpleados.Size = new Size(1200, 33);
            lblEstadoEmpleados.TabIndex = 7;
            lblEstadoEmpleados.Text = "Seleccione un rango de fechas y genere el reporte";
            lblEstadoEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 867);
            Controls.Add(tabControl1);
            MinimumSize = new Size(1273, 903);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes de Ventas - Disfraces Alejandría";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblEstadoProductos;
        private DataGridView dgvProductos;
        private Button btnGenerarReporteProductos;
        private DateTimePicker dtpFinProductos;
        private DateTimePicker dtpInicioProductos;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Label lblEstadoEmpleados;
        private DataGridView dgvEmpleados;
        private Button btnGenerarReporteEmpleados;
        private DateTimePicker dtpFinEmpleado;
        private DateTimePicker dtpInicioEmpleado;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}